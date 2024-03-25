    <template>
        <v-main class="content">
            <div class="hotel-room-container">
                <div class="hotel-room">
                    <h1>{{ hotel.hotelInfo.name }}</h1>
                    <div class="image-gallery">
                        <img v-for="image in hotel.hotelInfo.images"
                             :src="image"
                             :alt="`Image of ${hotel.hotelInfo.name}`"
                             :key="image"
                             class="hotel-image" />
                    </div>
                    <p>{{ hotel.hotelInfo.description }}</p>
                    <ul class="facilities-list">
                        <li v-for="facility in hotel.hotelInfo.facilities"
                            :key="facility">{{ facility }}</li>
                    </ul>
                    <div class="check-in-out">
                        <p>入住時間: {{ hotel.hotelInfo.checkInTime }}</p>
                        <p>退房時間: {{ hotel.hotelInfo.checkOutTime }}</p>
                    </div>
                    <div class="rating">評分：{{ hotel.hotelInfo.rating }}</div>
                    <div class="price">價格：NT${{ hotel.hotelInfo.price }}</div>
                    <div class="room-types">
                        <div class="room-type-card" v-for="roomType in hotel.roomTypes" :key="roomType.name">
                            <h3>{{ roomType.name }}</h3>
                            <img :src="roomType.image" :alt="`Image of ${roomType.name}`" class="room-type-image" />
                            <p>尺寸：{{ roomType.size }}</p>
                            <p>價格：NT${{ roomType.price }}</p>
                            <!-- 其他房型信息 -->
                        </div>
                    </div>
                    <!-- 其他你需要展示的酒店信息 -->
                </div>
            </div>
        </v-main>
    </template>


    <script setup>
        import { ref, onMounted } from 'vue';
        import { useRouter, useRoute } from 'vue-router';

        const router = useRouter();
        const route = useRoute();

        // 假定這裡是後端提供的酒店資料
        //const hotel = ref({
        //  // 預設資料，實際上你會從後端獲取這些資料
        //  name: '阿里山英迪格酒店 - IHG 旗下飯店頁面',
        //  imageUrl: 'hotel-room-image-url.jpg',
        //  description: '這裡是酒店描述...',
        //  rating: 8.8,
        //  price: 13500
        //});

        const hotel = ref({
            "hotelInfo": {
                "id": "1",
                "name": "阿里山英迪格酒店",
                "address": "阿里山景觀大道100號",
                description: '這裡是酒店描述...',
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
    <style scoped>
    
        .hotel-room-container {
            padding-top: 80px; /* 留出足够空间以避免内容被顶部导航栏遮挡 */
        }

        .image-gallery {
            display: flex;
            overflow-x: auto; /* 图片过多时可以横向滚动 */
            gap: 10px;
        }

        .hotel-image, .room-type-image {
            width: 200px;
            height: 150px;
            object-fit: cover;
            border-radius: 5px;
        }

        .facilities-list {
            list-style: none;
            padding: 0;
        }

            .facilities-list li {
                margin-bottom: 5px;
            }

        .check-in-out p, .rating, .price {
            margin: 10px 0;
        }

        .room-types {
            display: flex;
            flex-wrap: wrap;
            gap: 20px;
        }

        .room-type-card {
            border: 1px solid #ccc;
            padding: 10px;
            border-radius: 5px;
            width: calc(33.333% - 20px); /* 三列布局 */
        }

        @media (max-width: 768px) {
            .room-type-card {
                width: calc(50% - 20px); /* 在较小屏幕上改为两列布局 */
            }
        }

        @media (max-width: 480px) {
            .room-type-card {
                width: 100%; /* 在最小屏幕上改为单列布局 */
            }
        }
    </style>

