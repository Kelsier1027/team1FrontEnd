<template>
    <v-main class="content">
        <div class="hotel-room-container">
            <div class="hotel-room">
                <h1>{{ hotel.hotelInfo.name }}</h1>

                <!-- 圖片輪播 -->
                <div class="image-gallery">
                    <img v-for="image in hotel.hotelInfo.images"
                         :src="image"
                         :alt="`酒店的圖片 ${hotel.hotelInfo.name}`"
                         :key="image"
                         class="hotel-image" />
                </div>
                <!-- 詳細信息和地圖的容器 -->
                <div class="details-map-container">
                    <!-- 信息容器 -->
                    <div class="info-container">
                        <p>{{ hotel.hotelInfo.description }}</p>
                        <ul class="facilities-list">
                            <li v-for="facility in hotel.hotelInfo.facilities"
                                :key="facility">
                                {{ facility }}
                            </li>
                        </ul>
                        <div class="check-in-out">
                            <p>入住時間: {{ hotel.hotelInfo.checkInTime }}</p>
                            <p>退房時間: {{ hotel.hotelInfo.checkOutTime }}</p>
                        </div>
                        <div class="rating">評分: {{ hotel.hotelInfo.rating }}</div>
                        <div class="price">價格: NT${{ hotel.hotelInfo.price }}</div>
                    </div>
                    <!-- 地圖容器 -->
                    <div class="map-container">
                        <iframe width="270"
                                height="250"
                                style="border:0"
                                loading="lazy"
                                allowfullscreen
                                referrerpolicy="no-referrer-when-downgrade"
                                :src="mapSrc"></iframe>
                    </div>
                </div>
                <!-- 房型列表 -->
                <div class="room-types">
                    <div class="room-type-card"
                         v-for="roomType in hotel.roomTypes"
                         :key="roomType.name">
                        <h3>{{ roomType.name }}</h3>
                        <img :src="roomType.image"
                             :alt="`房型圖片 ${roomType.name}`"
                             class="room-type-image" />
                        <p>尺寸: {{ roomType.size }}</p>
                        <p>價格: NT${{ roomType.price }}</p>
                        <!-- 其他房型信息 -->
                    </div>
                </div>
                <!-- 其他你需要展示的酒店信息 -->
            </div>
        </div>
    </v-main>
</template>


<script setup>
    import { ref, onMounted, computed } from 'vue';
    import { useRouter, useRoute } from 'vue-router';

    const router = useRouter();
    const route = useRoute();



    const hotel = ref({
        "hotelInfo": {
            "id": "1",
            "name": "阿里山英迪格酒店",
            "address": "阿里山景觀大道100號",
            rating: 8.8,
            price: 13500,
            "facilities": ["WiFi", "健身房", "游泳池", "Spa"],
            "checkInTime": "15:00",
            "checkOutTime": "11:00",
            "images": [
                "https://a.travel-assets.com/media/meso_cm/PAPI/Images/lodging/90000000/89340000/89338400/89338365/df25c0f1_b.jpg?impolicy=resizecrop&rw=455&ra=fit",
                "https://a.travel-assets.com/media/meso_cm/PAPI/Images/lodging/90000000/89340000/89338400/89338365/df25c0f1_b.jpg?impolicy=resizecrop&rw=455&ra=fit",
                "https://a.travel-assets.com/media/meso_cm/PAPI/Images/lodging/90000000/89340000/89338400/89338365/df25c0f1_b.jpg?impolicy=resizecrop&rw=455&ra=fit"
            ]
        },
        "roomTypes": [
            {
                "name": "豪華房",
                "size": "30坪",
                "facilities": ["大床", "山景", "獨立衛浴"],
                "image": "https://a.travel-assets.com/media/meso_cm/PAPI/Images/lodging/90000000/89340000/89338400/89338365/df25c0f1_b.jpg?impolicy=resizecrop&rw=455&ra=fithttps://a.travel-assets.com/media/meso_cm/PAPI/Images/lodging/90000000/89340000/89338400/89338365/df25c0f1_b.jpg?impolicy=resizecrop&rw=455&ra=fit",
                "price": 5000,
                "quantity": 10
            },
            {
                "name": "家庭套房",
                "size": "50坪",
                "facilities": ["兩張大床", "海景", "包含早餐"],
                "image": "https://a.travel-assets.com/media/meso_cm/PAPI/Images/lodging/90000000/89340000/89338400/89338365/df25c0f1_b.jpg?impolicy=resizecrop&rw=455&ra=fit",
                "price": 8000,
                "quantity": 5
            }
            // ...更多房型
        ]
    });

    // 静态地址数据
    const address = '阿里山英迪格酒店';
    // 您的 Google Maps API 密钥
    const apiKey = 'AIzaSyCHn4jLlc2mfHlmAcXBC0NkeBzOsZYrSUE';


    // 生成地图源地址
    const mapSrc = computed(() => {
        const query = encodeURIComponent(address);
        return `https://www.google.com/maps/embed/v1/place?key=${apiKey}&q=${query}`;
    });

    // 在組件掛載後，從後端獲取詳細資料
    onMounted(async () => {
        // 獲取路由參數中的酒店ID
        const hotelId = route.params.id;
        // 發送請求到後端獲取詳細資料
        // 這裡假設你有一個API端點是 `/api/hotels/{id}`
        // const response = await fetch(`/api/hotels/${hotelId}`);
        // hotel.value = await response.json();
    });


</script>

<style scoped>
    .hotel-room-container {
        display: flex;
        justify-content: center;
        padding-top: 40px;
    }

    .image-gallery {
        display: flex;
        overflow-x: auto;
        gap: 10px;
        margin-bottom: 20px; /* 為輪播圖下方添加間距 */
    }

    .hotel-image, .room-type-image {
        width: 200px;
        height: 150px;
        object-fit: cover;
        border-radius: 5px;
    }

    .details-map-container {
        display: flex;
        justify-content: center;
        align-items: flex-start;
        gap: 20px;
        margin-bottom: 20px; /* 為地圖和信息容器下方添加間距 */
    }

    .info-container {
        background: #f5f5f5;
        border-radius: 8px;
        box-shadow: 0 2px 4px rgba(0,0,0,0.1);
        padding: 20px;
        flex: 1;
        margin-right: 20px;
    }

    .facilities-list {
        list-style: none;
        padding: 0;
        margin-bottom: 10px;
    }

        .facilities-list li {
            margin-bottom: 5px;
        }

    .rating, .price {
        font-weight: bold;
        color: #333;
    }

    .room-types {
        display: flex;
        justify-content: center;
        flex-wrap: wrap;
        gap: 20px;
    }

    .room-type-card {
        flex: 1;
        min-width: 250px; /* 設置最小寬度 */
        margin-bottom: 20px;
    }

    .map-container {
        flex: 1;
        min-width: 250px; /* 根據實際情況設置適當的寬度 */
        height: 250px; /* 根據實際情況設置適當的高度 */
    }

    @media (max-width: 768px) {
        .details-map-container {
            flex-direction: column;
        }

        .info-container, .map-container {
            flex: 1;
            margin-right: 0;
            max-width: 100%;
        }
    }
</style>