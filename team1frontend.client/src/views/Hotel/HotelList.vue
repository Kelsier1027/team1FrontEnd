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
                         :key="index">
                        <input type="checkbox"
                               :id="`facility-${index}`"
                               :value="facility.name"
                               v-model="selectedFacilities" />
                        <label :for="`facility-${index}`">{{ facility.name }}</label>
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

            <div class="hotel-list">
                <div class="hotel-card"
                     v-for="hotel in hotels"
                     :key="hotel.id"
                     @click="goToHotelRoom(hotel.id)">
                    <img :src="hotel.imageUrl" alt="Hotel Image" class="hotel-image" />
                    <div class="hotel-info">
                        <h2>{{ hotel.name }}</h2>
                        <p>{{ hotel.description }}</p>
                        <div class="hotel-rating">
                            <span>{{ hotel.rating }}</span>
                        </div>
                        <div class="hotel-price">
                            <span>NT${{ hotel.price }}</span>
                            <span class="original-price">原價 NT${{ hotel.originalPrice }}</span>
                        </div>
                        <button class="booking-button"
                               @click="goToHotelRoom(hotel.id)">
                            立即訂購
                        </button>
                    </div>
                </div>
            </div>

        </div>
    </v-main>
</template>

<script setup>
    import Search from '../Layout/components/search.vue';
    import { ref } from 'vue'
    import { useRoute, useRouter } from 'vue-router';

    const route = useRoute();
    const router = useRouter();
    const hotelId = route.params.id;

    function navigateToHotelRoom(hotelId) {
        console.log(hotelId);
        router.push({ name: 'HotelRoom', params: { id: hotelId } });
    }

    function handleSearch(searchQuery) {
        // 處理搜索邏輯
    }
    //飯店設施
    const facilities = ref([
        { name: '健身房' },
        { name: '游泳池' },
        { name: '免費早餐' },
        { name: '免费早餐' },
        { name: '免费早餐' },
        // 更多设施...
    ])

    const selectedPrice = ref([])

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

    //飯店標題
    const hotels = ref([
        {
            id: 1,
            name: '阿里山英迪格酒店 - IHG 旗下飯店頁面',
            description: '最佳視野景觀，輕度假首選的五星國際品牌酒店。',
            rating: '8.8',
            imageUrl: 'https://a.travel-assets.com/media/meso_cm/PAPI/Images/lodging/90000000/89340000/89338400/89338365/df25c0f1_b.jpg?impolicy=resizecrop&rw=455&ra=fit',
            price: 13500,
            originalPrice: 31185
        },
        {
            id: 2,
            name: '台北景觀101 -小木屋飯店',
            description: '台北頂級小木屋，有清新的空氣，還看的到101。',
            rating: '7.8',
            imageUrl: 'https://images.trvl-media.com/lodging/1000000/20000/14200/14153/f370d8eb.jpg?impolicy=resizecrop&rw=455&ra=fit',
            price: 12250,
            originalPrice: 44485
        },
        // ...其他酒店數據
    ]);
    // 跳转到酒店详细页面的函数
    const goToHotelRoom = (hotelId) => {
        // 这里可以使用Vue Router或者window.location来导航
        router.push({ name: 'HotelRoom', params: { id: hotelId } });
        console.log('Go to hotel:');
    };

    // 处理酒店预订的函数
    const bookHotel = (hotelId) => {
        console.log('Book hotel:', hotelId);
        // 这里可以添加预订逻辑或跳转到预订页面
    };

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

