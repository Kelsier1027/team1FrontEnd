<template>
    <!-- 主要內容 -->
    <v-main class="content">
        <div class="wrapper">
            <!--左邊篩選直條-->
            <div class="facilities">
                <p>設施服務</p> <!-- 確保文字是實際的 HTML 元素 -->
                <!--飯店設施-->
                <div class="facility-list">
                    <div class="facility-item"
                         v-for="(facility, index) in facilities"
                         :key="facility.id">
                        <!-- 使用 facility.id 作為 key -->
                        <!-- 修正為模板字符串，正確繫結 id -->
                        <!-- 用 facility.id 作為 value -->
                        <!-- 確保 selectedFacilities 是一個陣列 -->
                        <input type="checkbox"
                               :id="facility.id"
                               :value="facility.id"
                               v-model="selectedFacilities" />
                        <label :for="facility.id">{{ facility.jaon }}</label>
                    </div>
                </div>
                <!--金額搜尋-->
                <div class="search-price">
                    <p>價格篩選</p>
                    <div class="form-group">
                        <label for="searchMix">最高金額</label>
                        <input type="text" id="searchName" v-model="searchMix" />
                    </div>

                    <div class="form-group">
                        <label for="searchMin">最低金額</label>
                        <input type="text" id="searchLocation" v-model="searchMin" />
                    </div>
                </div>
                <!--旅客評分篩選-->
                <div class="rating-filter">
                    <p>旅客評分</p>
                    <label v-for="option in ratingOptions" :key="option.value">
                        <input type="radio" name="rating" :value="option.value" v-model="selectedRating" />
                        {{ option.label }}
                    </label>
                </div>
            </div>


        </div>
        <div>
            <div class="main-content">
                <h1>Hotel飯店</h1>
                <Search @search="handleSearch" />
                <div class="dropdown-selects">
                    <div class="dropdown-container">
                        <label for="sort" class="dropdown-label">排序方式 :</label>
                        <select v-model="selectedSort" id="sort" class="dropdown">
                            <option disabled value="">請選擇</option>
                            <option v-for="option in sortOptions" :key="option.value" :value="option.value">
                                {{ option.text }}
                            </option>
                        </select>
                    </div>

                    <div class="dropdown-container">
                        <label for="region" class="dropdown-label">地區 :</label>
                        <select v-model="selectedRegion" id="region" class="dropdown">
                            <option disabled value="">請選擇</option>
                            <option v-for="region in regionOptions" :key="region.value" :value="region.value">
                                {{ region.text }}
                            </option>
                        </select>
                    </div>

                    <div class="dropdown-container">
                        <label for="features" class="dropdown-label">住宿類型 :</label>
                        <select v-model="selectedFeature" id="features" class="dropdown">
                            <option disabled value="">請選擇</option>
                            <option v-for="feature in featureOptions" :key="feature.value" :value="feature.value">
                                {{ feature.text }}
                            </option>
                        </select>
                    </div>
                </div>
            </div>

            <!-- list 页面的 template 部分 -->
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
                            <h2>{{ hotel.name }}</h2>
                            <p>{{ hotel.address }}</p>
                            <div class="hotel-rating">
                                <span>{{ hotel.grade }}</span>
                            </div>
                            <div class="hotel-price">
                                <span v-if="hotel.hotelRooms.length">NT${{ hotel.hotelRooms[0].weekendPrice }}</span>
                            </div>
                            <button class="booking-button">
                                立即訂購
                            </button>
                        </div>
                    </div>
                </div>
            </div>  

        </div>
    </v-main>
</template>

<script setup>
    import Search from '../Layout/components/search.vue';
    import { ref, onMounted} from 'vue'
    import { useRoute, useRouter } from 'vue-router';
    import axios from 'axios';
    import { watch } from 'vue';


    const route = useRoute();
    const router = useRouter();

    const hotels = ref([]);
    const searchMessage = ref(""); // 用于存储搜索消息或错误消息

    // list 页面的 script 部分，添加 handleSearch 函数处理搜索事件
    function handleSearch(searchQuery) {
        // Reset state before new search
        hotels.value = [];
        searchMessage.value = "";
        // 根据新的 searchQuery 更新页面展示的数据
        router.push({ path: '/hotel/list', query: { address: searchQuery.location } });
    }
    watch(() => route.query.address, (newAddress) => {
        // 当地址查询参数变化时，重新加载数据
        if (newAddress) {
            // 调用获取酒店数据的函数
            fetchHotelsAndRooms();
        }
    });
 
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

    // 使用 onMounted 生命週期鉤子來在組件掛載時獲取數據
    onMounted(fetchFacilities);

    const selectedPrice = ref([])

    //處理圖片
    const getHotelImageUrl = (imagePath) => {
        return `/assets/HotelImages/${imagePath}`;
    };

    //價格篩選
    const searchMix = ref('')
    const searchMin = ref('')

    //旅客評分篩選
    const selectedRating = ref('')
    const ratingOptions = [
        { label: '不限', value: 'all' },
        { label: '好评 9+', value: '9plus' },
        { label: '非常好 8+', value: '8plus' },
        { label: '不錯 7+', value: '7plus' }
    ]

    //三個select
    const selectedSort = ref('')
    const sortOptions = [
        { value: 'recommend', text: '推薦' },
        { value: 'popularity', text: '人氣' },
        // ...更多排序選項
    ]

    const selectedRegion = ref('')
    const regionOptions = [
        { value: 'north', text: '北部' },
        { value: 'south', text: '南部' },
        // ...更多地區選項
    ]

    const selectedFeature = ref('')
    const featureOptions = [
        { value: 'hotel', text: '飯店' },
        { value: 'motel', text: '汽車旅館' },
        // ...更多住宿類型選項
    ]

   
    // 跳转到酒店详细页面的函数
    const goToHotelRoom = (hotelId) => {
        // 这里可以使用Vue Router或者window.location来导航
        router.push({ name: 'HotelRoom', params: { id: hotelId } });
        console.log('Go to hotel:');
    };

    
    watch(selectedFacilities, (newValue, oldValue) => {
        // 只在實際有變化時發送請求
        if (newValue !== oldValue) {
            searchMessage.value ="";
            fetchHotelsBasedOnFacilities(newValue);
        }
    });

    async function fetchHotelsBasedOnFacilities(selectedFacilities) {
        try {
            // 構造請求 URL，這裡假設你的後端支持通過查詢參數來篩選設施
            // 注意：這裡的 URL 和參數需要根據你的實際後端接口進行調整
            const facilities = selectedFacilities;
            const queryString = facilities.map(f => `facilities=${f}`).join('&');
            const url = `https://localhost:7113/api/Hotels/GetHotelsByFacilities?${queryString}`;
            const response = await axios.get(url);
            // 假設後端返回的是一個符合條件的飯店列表
            hotels.value = response.data;
            console.log("77777");
            console.log(selectedFacilities.join(','));
            console.log(response.data);
            console.log(hotels.value);
            console.log("88888");
        } catch (error) {
            searchMessage.value = "沒有找到匹配的酒店，請嘗試其他搜索條件。";
            hotels.value = []; // 清空之前的搜索结果
            console.error('Failed to fetch hotels based on facilities:', error);
        }
    }

   

    async function fetchHotelsAndRooms() {
        const address = route.query.address;
        const name = route.query.name;
        let url = 'https://localhost:7113/api/Hotels';

        if (address) {
            url += `/search?address=${encodeURIComponent(address)}`;
        } else if (name) {
            // 如果你有一个基于name搜索酒店的API端点，你可以在这里构建URL
            url += `/search?address=${encodeURIComponent(name)}`;
            // 注意: 这里的'/searchByName'和查询参数'name'需要你根据实际API进行调整
        }
        try {
            const response = await axios.get(url);
            hotels.value = response.data;
            
            console.log('1212');
            // 為所有酒店同時發起請求，用 Promise.allSettled 等待所有請求完成或失敗
            const hotelRoomsRequests = hotels.value.map(hotel =>
                axios.get(`https://localhost:7113/api/HotelRooms/hotel/${hotel.id}`)
            );

            const hotelRoomsResponses = await Promise.allSettled(hotelRoomsRequests);

            hotelRoomsResponses.forEach((result, index) => {
                if (result.status === 'fulfilled' && result.value.data.length > 0) {
                    // 這裡我們只考慮至少有一個房間數據的情況
                    hotels.value[index].hotelRooms = result.value.data;
                } else {
                    // 如果請求失敗或沒有房間數據，可以根據您的業務需求做相應處理
                    hotels.value[index].hotelRooms = { weekendPrice: 'No data' };
                }

            });
            console.log(hotels.value);
        } catch (error) {
            // 当返回的数据为空数组时，设置提示信息
            searchMessage.value = "沒有找到匹配的酒店，請嘗試其他搜索條件。";
            hotels.value = []; // 清空之前的搜索结果
            console.error('Failed to fetch hotels:', error);
        }
    }

    onMounted(fetchHotelsAndRooms);




</script>

<style scoped>
    .wrapper {
        display: grid;
        grid-template-columns: 300px auto; /* 300px為左側篩選欄寬度，剩餘空間給右側內容 */
        gap: 20px;
    }

    .facilities {
        background-color: #eee;
        color: black;
        padding: 20px;
        border-right: 2px solid #ddd;
        overflow-y: auto;
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
        padding-left: 20px; /* 加點左邊距讓內容不會太擠 */
    }

    .search-panel {
        background-color: #ffd54f; /* 您喜歡的顏色 */
        padding: 15px;
        border-radius: 8px;
        max-width: 900px; /* 或者根據您的設計需求調整 */
        margin: 0; /* 讓搜索面板在頁面中間顯示 */
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
        width: 100%; /* 或者根据您的布局需求调整 */
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
        flex-direction: column;
    }

    .hotel-card {
        border: 1px solid #e1e1e1;
        border-radius: 8px;
        overflow: hidden;
        margin-bottom: 10px;
        display: flex;
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

    .original-price {
        text-decoration: line-through;
        color: grey;
        margin-left: 10px;
    }

    .booking-button {
        padding: 10px 20px;
        background-color: #4CAF50; /* 按钮背景颜色 */
        color: white; /* 按钮文字颜色 */
        border: none;
        border-radius: 4px;
        cursor: pointer;
        margin-top: 10px;
    }

    /* 增加 :hover 状态以改善用户体验 */
    .booking-button:hover {
        background-color: #45a049;
    }

    .hotel-card {
        cursor: pointer; /* 当鼠标悬停时显示指针手势 */
        transition: box-shadow 0.3s; /* 添加过渡效果使点击有动画感 */
    }

    .hotel-card:hover {
        box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1); /* 悬停时添加阴影 */
    }

</style>

