<template>
    <!-- 主要內容 -->
    <v-main class="content">
        <div class="wrapper">
            <!--左邊篩選直條-->
            <div class="facilities">
                <p><i class="fa-solid fa-house"></i>設施服務</p>
                <!--飯店設施-->
                <div class="facility-list">
                    <div class="facility-item"
                         v-for="(facility, index) in facilities"
                         :key="facility.id">
                        <input type="checkbox"
                               :id="facility.id"
                               :value="facility.id"
                               v-model="selectedFacilities" />
                        <!--:for 是 v-bind:for 的簡寫,將 facility.id 的值綁定到 label 元素的 for 屬性-->
                        <label :for="facility.id">{{ facility.jaon }}</label>
                    </div>
                </div>
                <!--金額搜尋-->
                <div class="search-price">
                    <p>價格篩選</p>
                    <div class="form-group">
                        <label for="searchMix">最高金額</label>
                        <input type="text"
                               id="searchName"
                               v-model="searchMix" />
                    </div>

                    <div class="form-group">
                        <label for="searchMin">最低金額</label>
                        <input type="text"
                               id="searchLocation"
                               v-model="searchMin" />
                    </div>
                </div>
                <!--旅客評分篩選-->
                <div class="rating-filter">
                    <p>旅客評分</p>
                    <label v-for="option in ratingOptions" :key="option.value">
                        <input type="radio"
                               name="rating"
                               :value="option.value"
                               v-model="selectedRating" />
                        {{ option.label }}
                    </label>
                </div>
                <div class="collect">
                    <button @click="goToCollect"><i class="fa-solid fa-heart"></i>我的收藏</button>
                </div>
            </div>
        </div>
        <div>
            <div class="main-content">
                <Search @search="handleSearch" />
                <div class="dropdown-selects">
                    <div class="dropdown-container">
                        <label for="sort" class="dropdown-label">排序方式 :</label>
                        <select v-model="selectedSort"
                                id="sort"
                                class="dropdown">
                            <option disabled value="">請選擇</option>
                            <option v-for="option in sortOptions"
                                    :key="option.value"
                                    :value="option.value">
                                {{ option.text }}
                            </option>
                        </select>
                    </div>

                    <div class="dropdown-container">
                        <label for="region" class="dropdown-label">地區 :</label>
                        <select v-model="selectedRegion"
                                id="region"
                                class="dropdown">
                            <option disabled value="">請選擇</option>
                            <option v-for="region in regionOptions"
                                    :key="region.value"
                                    :value="region.value">
                                {{ region.text }}
                            </option>
                        </select>
                    </div>

                    <div class="dropdown-container">
                        <label for="features" class="dropdown-label">住宿類型 :</label>
                        <select v-model="selectedFeature"
                                id="features"
                                class="dropdown">
                            <option disabled value="">請選擇</option>
                            <option v-for="feature in featureOptions"
                                    :key="feature.value"
                                    :value="feature.value">
                                {{ feature.text }}
                            </option>
                        </select>
                    </div>
                </div>
            </div>


            <div class="hotel-list">
                <!-- 搜索消息提示 -->
                <p v-if="searchMessage && (!hotels.value || hotels.value.length === 0)">{{ searchMessage }}</p>

                <!-- 酒店列表 -->
                <div v-else>
                    <div class="hotel-card"
                         v-for="hotel in hotels"
                         :key="hotel.id"
                         @click="goToHotelRoom(hotel.id)">
                        <img :src="getHotelImageUrl(hotel.mainImage)" alt="Hotel Image" class="hotel-image" />
                        <div class="hotel-info">
                            <h3>{{ hotel.name }}</h3>
                            <h5>{{ hotel.address }}</h5>
                            <div class="hotel-rating">
                                <span>{{ hotel.grade }}</span>
                            </div>
                            <div class="hotel-price">
                                <span v-if="hotel.hotelRooms.length">NT${{ hotel.hotelRooms[0].weekendPrice }}</span>
                            </div>
                            <div class="heart" @click.stop="toggleFavorite(hotel)">
                                <i :class="hotel.isFavorite ? 'fa-solid fa-heart' : 'fa-regular fa-heart'"></i>
                            </div>
                        </div>
                        <button class="booking-button">
                            立即訂購 
                        </button>
                       
                    </div>
                </div>
            </div>

        </div>




    </v-main>
    

    <div>
        <mediaIcon />
    </div>



</template>

<script setup>
    import Search from '../Layout/components/search.vue';
    import { ref, onMounted} from 'vue'
    import { useRoute, useRouter } from 'vue-router';
    import axios from 'axios';
    import { watch } from 'vue';
    import mediaIcon from '../Layout/components/mediaIcon.vue';
    import { useHotelStore } from '../../stores/hotel.js';
    

    const route = useRoute();
    const router = useRouter();

    const hotels = ref([]);
    const searchMessage = ref(""); 
    const store = useHotelStore();  // 使用 Pinia Store


    function goToCollect() {
        console.log('Navigating to Collect page');
        router.push({ name: 'Collect' })
    }

    // 記得在 setup 函數的返回值中包含 goToCollect
    //return {
    //    // ... 其他返回值
    //    goToCollect,
    //};
    
    function handleSearch(searchQuery) {
        //搜索時，清空現有的酒店數據和消息，並導航到新的 URL
        //查詢參數（地址和容納人數）發生變化時，重新加載酒店數據
        hotels.value = [];
        searchMessage.value = "";
        router.push({ path: '/hotel/list', query: { address: searchQuery.location ,capacity:searchQuery.adults + searchQuery.children} });
    }
    watch(() => [route.query.address, route.query.capacity], ([newAddress, newCapacity], [oldAddress, oldCapacity]) => {
    // 如果參數有變化重新載入
    if (newAddress !== oldAddress || newCapacity !== oldCapacity) {

        fetchHotelsAndRooms();
    }
    }, { deep: true }); // 監聽對象內部的所有屬性變化

 
    const facilities = ref([])
    const selectedFacilities = ref([]);
    //左欄設施列表
    async function fetchFacilities() {
        try {
            const response = await axios.get('https://localhost:7113/api/HotelCategories');
            facilities.value = response.data; // 假設API返回的數據直接是我們需要的設施列表
        } catch (error) {
            console.error('Failed to fetch facilities:', error);
        }
    }
    onMounted(fetchFacilities);

    

    //處理圖片
    const getHotelImageUrl = (imagePath) => {
        return `/assets/HotelImages/${imagePath}`;
    };

    //價格篩選
    const selectedPrice = ref([])
    const searchMix = ref('')
    const searchMin = ref('')

    //旅客評分篩選
    const selectedRating = ref('')
    const ratingOptions = [
        { label: '不限', value: 'all' },
        { label: '好評 9+', value: '9plus' },
        { label: '非常好 8+', value: '8plus' },
        { label: '不錯 7+', value: '7plus' }
    ]

    //三個select
    const selectedSort = ref('')
    const sortOptions = [
        { value: 'recommend', text: '推薦' },
        { value: 'popularity', text: '人氣' },
        
    ]

    const selectedRegion = ref('')
    const regionOptions = [
        { value: 'north', text: '北部' },
        { value: 'south', text: '南部' },
        
    ]

    const selectedFeature = ref('')
    const featureOptions = [
        { value: 'hotel', text: '飯店' },
        { value: 'motel', text: '汽車旅館' },
        
    ]

   
    // 跳轉去那個飯店
    const goToHotelRoom = (hotelId) => {
    
        router.push({ name: 'HotelRoom', params: { id: hotelId } });
        
    };

    //設施篩選
    watch(selectedFacilities, (newValue, oldValue) => {
        
        if (newValue !== oldValue) {
            searchMessage.value ="";
            fetchHotelsBasedOnFacilities(newValue);
        }
    });

    async function fetchHotelsBasedOnFacilities(selectedFacilities) {
        try {

            const facilities = selectedFacilities;
            const queryString = facilities.map(f => `facilities=${f}`).join('&');
            const url = `https://localhost:7113/api/Hotels/GetHotelsByFacilities?${queryString}`;
            const response = await axios.get(url);
            // 假設後端返回的是一個符合條件的飯店列表
            hotels.value = response.data;
            hotels.value = hotels.value.map(hotel => ({
                ...hotel,
                isFavorite: store.isFavorite(hotel.id)
            }));

        } catch (error) {
            searchMessage.value = "沒有找到匹配的酒店，請嘗試其他搜索條件。";
            hotels.value = []; // 清空之前的搜索结果
            console.error('Failed to fetch hotels based on facilities:', error);
        }
    }


    

   

    async function fetchHotelsAndRooms() {
        const address = route.query.address;
        const capacity = route.query.capacity; // 添加容納人數參數
        const name = route.query.name; //承接Carousel.vue裡面的name:itemname

        let url = 'https://localhost:7113/api/Hotels';

        // 根據查詢參數動態構建 URL
        if (address) {
            url += `/search?address=${encodeURIComponent(address)}`;
        }

        if (name) {
            url += `/search?address=${encodeURIComponent(name)}`;
        }
        
        // 如果有 capacity，將其添加到查詢參數中
        if (capacity) {
            url += `&capacity=${encodeURIComponent(capacity)}`;
        }

        try {
            const response = await axios.get(url);
            hotels.value = response.data;
            
            // 發送請求獲取每個酒店的房間信息
            const hotelRoomsRequests = hotels.value.map(hotel =>
                axios.get(`https://localhost:7113/api/HotelRooms/hotel/${hotel.id}`)
            );

            const hotelRoomsResponses = await Promise.allSettled(hotelRoomsRequests);

            hotelRoomsResponses.forEach((result, index) => {
                if (result.status === 'fulfilled' && result.value.data.length > 0) {
                    hotels.value[index].hotelRooms = result.value.data;
                } else {
                    hotels.value[index].hotelRooms = { weekendPrice: 'No data' };
                }
            });

            hotels.value = hotels.value.map(hotel => ({
                ...hotel,
                isFavorite: store.isFavorite(hotel.id)
            }));
        } catch (error) {
            searchMessage.value = "沒有找到匹配的酒店，請嘗試其他搜索條件。";
            hotels.value = []; // 清空之前的搜索結果
            console.error('Failed to fetch hotels:', error);
        }
    }

    function toggleFavorite(hotel) {
        store.toggleFavorite(hotel);
        hotel.isFavorite = store.isFavorite(hotel.id);
    }
    onMounted(fetchHotelsAndRooms);





</script>

<style scoped>


    .wrapper {
        display: grid;
        grid-template-columns: 300px auto; /* 300px為左側篩選欄寬度，剩餘空間給右側內容 */
        gap: 20px;
        height:60%;
    }

    .facilities {
        background-color: #eee;
        color: black;
        padding: 20px;
        border-right: 2px solid #ddd;
       
    }

    .content {
        
        display: flex;
        flex: 1; /* 讓 .content 佔滿剩餘空間 */
        max-width: 1500px; /* 設定最大寬度 */
        margin-left: auto; /* 水平居中 */
        margin-right: auto; /* 水平居中 */
    }

    .main-content {
        flex: 1; /* 讓 .main-content 佔滿剩餘空間 */
        padding-left: 20px; 
    }

    .search-panel {
        background-color: #D0AB7A; 
        padding: 15px;
        border-radius: 8px;
        max-width: 900px;
        margin: 0; 
    }
    /*飯店設施*/
    .facility-list {
        max-width: 300px;
        margin: 0;
        padding: 0;
    }

    .facility-item {
        margin: 10px 0;
        display: flex;
        align-items: center;
    }

        .facility-item input[type='checkbox'] {
            margin-right: 10px;
        }

        .facility-item label {
            margin: 0;
        }
        /*價格篩選*/
    .search-price {
        display: flex;
        flex-direction: column;
        width: 100%; 
    }

    .form-group {
        margin-bottom: 10px;
    }

        .form-group label {
            display: block;
            margin-bottom: 5px;
        }

        .form-group input[type='text'] {
            width: 100%;
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 4px;
            background-color:white;
        }

      /*  旅客評分篩選*/
    .rating-filter {
        margin-bottom: 20px;
    }

        .rating-filter label {
            display: block;
            margin: 5px 0;
        }
        
        /*三個select*/
    .dropdown-selects {
        display: flex;
        /*將子元素均勻地分布在容器內*/
        justify-content: space-around;
        align-items: center;
        margin-bottom: 20px;
        background-color: #f7f7f7;
        padding: 20px;
        border-radius: 8px;
        box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
    }

    .dropdown-select {
        display: flex;
        justify-content: center;
        align-items: center;
    }

    .dropdown-select label {
        margin-bottom: 5px;
        font-weight: bold;
    }

    .dropdown {
        background-color: white;
        margin-left: 1rem;
        border: 1px solid black;
        border-radius: 5px;
        padding:0 10px;
    }

    .dropdown label {
        display: block;
        margin-bottom: 5px;
    }

    .dropdown select {
        width: 100%;
        padding: 5px 10px;
        font-size: 16px;
    }


    /*飯店標題*/
    .hotel-list {
        display: flex;
        /*垂直方向排列*/
        flex-direction: column;
    }

    .hotel-card {
        border: 1px solid #e1e1e1;
        border-radius: 8px;
        overflow: hidden;
        margin-bottom: 10px;
        display: flex;
        height: 200px;
        box-sizing: border-box;
        position: relative;
    }
        .hotel-card:hover {
            background-color: #F0DBBF; 
        }

    .hotel-image {
        width: 200px;
        height: 200px;
        object-fit: cover;

    }

    .hotel-info {
        padding: 10px;
       
    }

    .hotel-rating {
        color: green;
    }

    .hotel-price {
        font-size: 16px;
    }


    .booking-button {
        width:130px;
        height:60px;
        padding: 5px 5px;
        background-color: #F3C364; 
        color: white; 
        border: none;
        border-radius: 4px;
        cursor: pointer;
        bottom: 13px;
        left: 450px;
        position: absolute;
    }


        .booking-button:hover {
            background-color: #FCC954;
        }

    .hotel-card {
        cursor: pointer;
        transition: box-shadow 0.3s;
        position:relative;
    }

    .hotel-card:hover {
        box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1); 
    }
    .pagination{
        display:flex;
        justify-content:center;
        margin:0 auto;
    }

    .pagination {
        display: flex;
        justify-content: center;
        margin: 0 auto;
    }

    .page-item.disabled .page-link {
        pointer-events: none;
        opacity: 0.5;
    }

    .page-item.active .page-link {
        background-color: #007bff;
        color: white;
    }
                            
    .heart{
        font-size:40px;
        display:flex;
        position:absolute;
        top:10px;
        right:10px;
    }
    .collect{
        width:100px;
        border:2px solid black;
        border-radius:20px;
        padding-left:5px;
    }

</style>
