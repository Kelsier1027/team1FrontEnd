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
                        <p >{{ hotel.hotelInfo.describe }}</p>
                        <div class="check-in-out">
                            <p>入住時間: {{ hotel.hotelInfo.checkInTime }}</p>
                            <p>退房時間: {{ hotel.hotelInfo.checkOutTime }}</p>
                        </div>
                        <div class="rating">評分: {{ hotel.hotelInfo.rating }}</div>
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
                        <button class="add-to-cart-button">添加到購物車</button>
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
    import axios from 'axios';

    const router = useRouter();
    const route = useRoute();



    onMounted(async () => {
        // 獲取路由參數中的飯店ID
        const hotelId = route.params.id;
        try {
            const response = await axios.get(`https://localhost:7113/api/Hotels/${hotelId}`);
            const hotelData = response.data;

            // 如果飯店的ID為3，則加上假資料的描述
            if (hotelData.id === 3) {
                hotelData.describe = "艾莎公寓位於台南市中西區大智街與保安路口，地處四通八達的地理中心位置，交通便捷，徒步3分鐘保安路、夏林路小吃，5分鐘海安路藝術商圈，6分鐘國華街和友愛街商圈，8分鐘新光三越台南新天地及藍曬圖文創園區，享有文創流行及美食小吃等多元的深度之旅。 艾莎公寓是全新的電梯別墅，外觀日系內斂灰白外牆，入口搭配上綠意盎然的重植花園造景，讓您在熱鬧的市區裡感受到大自然的活力，公寓內備有多種不同風格的主題套房讓您選擇，不論您是喜愛簡潔沉靜的高雅、喜歡粉色溫馨的浪漫、異國風味的空間表現或是針對兒童設計的親子館，都能滿足您的需求，尤其適合親子一同來體驗移居台南的生活步調，把「艾莎公寓」當作是您台南第二個家。";
            }

            // 現在hotel.value將包含修改後的飯店資料
            hotel.value.hotelInfo = { ...hotelData };

        } catch (error) {
            console.error('Failed to fetch hotel details:', error);
        }
    });



    const hotel = ref({
        "hotelInfo": {},
        "roomTypes": []
    });
    // 使用计算属性动态获取酒店地址
    const address = computed(() => hotel.value.hotelInfo.name || '默认地址');
    // 生成地图源地址的计算属性
    const mapSrc = computed(() => {
        const query = encodeURIComponent(address.value); // 注意这里使用 address.value 来获取计算属性的值
        const apiKey = 'AIzaSyCHn4jLlc2mfHlmAcXBC0NkeBzOsZYrSUE';
        return `https://www.google.com/maps/embed/v1/place?key=${apiKey}&q=${query}`;
    });

    async function fetchFacilityNamesByIds(ids) {
        const facilityNames = [];

        for (const id of ids) {
            try {
                // Replace this URL with the actual API endpoint for fetching facility by ID
                const response = await axios.get(`https://localhost:7113/api/HotelCategories/${id}`);
                facilityNames.push(response.data.jaon); // Assume 'jaon' contains the facility name
            } catch (error) {
                console.error(`Failed to fetch facility with id ${id}:`, error);
                facilityNames.push(`Unknown facility ${id}`);
            }
        }

        return facilityNames;
    }

    // 在組件掛載後，從後端獲取詳細資料
    onMounted(async () => {
        // 獲取路由參數中的酒店ID
        const hotelId = route.params.id;
        // 發送請求到後端獲取詳細資料
        // 這裡假設你有一個API端點是 `/api/hotels/{id}`
        // const response = await fetch(`/api/hotels/${hotelId}`);
        // hotel.value = await response.json();
        try {
            const hotelResponse = await axios.get(`https://localhost:7113/api/Hotels/${hotelId}`);
            const hotelData = hotelResponse.data;
            const roomsResponse = await axios.get(`https://localhost:7113/api/HotelRooms/hotel/${hotelId}`);
            const roomTypesData = roomsResponse.data;

            // Parse the hotelFacilities JSON string to get the array of facility IDs
            const facilityIds = JSON.parse(hotelData.hotelFacilities).FacilityIds;

            // Fetch the facility names for the given IDs
            const facilityNames = await fetchFacilityNamesByIds(facilityIds);


            // 设置酒店信息
            hotel.value.hotelInfo = {
                id: hotelData.id,
                name: hotelData.name,
                address: hotelData.address,
                rating: hotelData.grade, // 假设评分字段为 grade
                facilities: facilityNames, // 假设这些信息需要另外处理
                checkInTime: hotelData.checkinStart.split(':').slice(0, 2).join(':'),
                checkOutTime: hotelData.checkoutEnd.split(':').slice(0, 2).join(':')
                ,
                images: [
                    // 假设使用 mainImage 作为展示图
                    `/assets/HotelImages/${hotelData.mainImage}`
                ]
            };

            // 设置酒店房型信息，这里假设每个房型信息中包含了设施描述
            hotel.value.roomTypes = roomTypesData.map(room => ({
                name: room.name,
                size: room.size,
                price: room.weekdayPrice, // 或者 room.weekendPrice
                facilities: room.roomFacilities.split(',').map(id => // 假设 roomFacilities 是逗号分隔的设施 ID
                    // 这里需要根据实际情况将 ID 转换为设施的描述
                    // 可能需要额外的 API 调用或在前端处理映射
                    `设施${id}`
                ),

                image: `/assets/HotelImages/${room.mainImage}`
            }));
            console.log(hotelData);
            console.log(roomTypesData);
        } catch (error) {
            console.error('Failed to fetch hotel details:', error);
        }

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

    .add-to-cart-button {
        padding: 10px 20px;
        margin-top: 10px;
        background-color: #4CAF50;
        color: white;
        border: none;
        border-radius: 4px;
        cursor: pointer;
    }

        .add-to-cart-button:hover {
            background-color: #45a049;
        }

    @media (max-width: 768px) {
        /* 移动设备或小屏幕的特定样式 */
        /* ... */
    }
</style> 