<template>
    <v-main class="content">
        <Cart></Cart>
        <div class="hotel-room-container">
            <div class="hotel-room">
                <h1>{{ hotel.hotelInfo.name }}</h1>
                <!-- 圖片輪播 -->
                <div class="image-gallery">
                    <img v-for="image in hotel.hotelInfo.images" :src="image" :alt="`酒店的圖片 ${hotel.hotelInfo.name}`"
                         :key="image" class="hotel-image" />
                    <img class="hotel-image"
                         src="https://cf.bstatic.com/xdata/images/hotel/max1280x900/455303717.jpg?k=893177d70da78b62c660f448535210c9eff942f8041d6499f3e33749ec46bfd6&o=&hp=1" />
                    <img class="hotel-image"
                         src="https://cf.bstatic.com/xdata/images/hotel/max1024x768/289814503.jpg?k=719e27f1e5d5b829eeb203c8ac97f99c41e3347cbd5e85f1e94008f7e3dd2599&o=&hp=1" />
                    <img class="hotel-image"
                         src="https://cf.bstatic.com/xdata/images/hotel/max1280x900/451933103.jpg?k=e43041cffa50667defb2381ef065273b6add7a81d217c5adf9eaf234d011ba83&o=&hp=1" />
                    <img class="hotel-image"
                         src="https://cf.bstatic.com/xdata/images/hotel/max1280x900/205758730.jpg?k=2a114ab9c212f1b81a3c2a99a1edb8b9dea6cbff0148d18ae2ce8ed4207446ad&o=&hp=1" />
                    <img class="hotel-image"
                         src="https://cf.bstatic.com/xdata/images/hotel/max1280x900/279604713.jpg?k=0c7463a31098c262b6e4e4949f35678a7c44472ae4048bf534fcc829af5dc7bb&o=&hp=1" />

                </div>

                <p v-html="hotel.hotelInfo.describe"></p>
                <!--<p>{{ hotel.hotelInfo.describe }}</p>-->
                <!-- 詳細信息和地圖的容器 -->
                <div class="details-map-container">
                    <!-- 信息容器 -->
                    <div class="info-container">
                        <p>{{ hotel.hotelInfo.description }}</p>
                        <ul class="facilities-list">
                            <h style="font-size:23px"><i class="fa-solid fa-house"></i>設施列表:</h>
                            <li v-for="facility in hotel.hotelInfo.facilities" :key="facility">
                                {{ facility }}
                            </li>
                        </ul>
                        <div class="check-in-out">
                            <p><i class="fa-solid fa-person-walking-luggage"></i>入住時間: {{ hotel.hotelInfo.checkInTime }}</p>
                            <p><i class="fa-solid fa-person-walking-luggage"></i>退房時間: {{ hotel.hotelInfo.checkOutTime }}</p>
                        </div>
                        <div class="rating">評分: {{ hotel.hotelInfo.rating }}</div>
                    </div>
                    <!-- 地圖容器 -->
                    <div class="map-container">
                        <iframe width="500" height="330" style="border:0" loading="lazy" allowfullscreen
                                referrerpolicy="no-referrer-when-downgrade" :src="mapSrc"></iframe>
                    </div>
                </div>
                <!-- 房型列表 -->
                <div class="room-types">
                    <div class="room-type-card" v-for="(roomType, index) in hotel.roomTypes" :key="roomType.name">
                        <h3>{{ roomType.name }}</h3>

                        <img :src="roomType.image" :alt="`房型圖片 ${roomType.name}`" class="room-type-image" />
                        <p>尺寸: {{ roomType.size }}</p>
                        <p>價格: NT${{ roomType.price }}</p>
                        <!-- 數量選擇器 -->
                        <div class="quantity-selector">
                            <button class="quantity-btn decrease" @click="decreaseQuantity(index)"
                                    :disabled="roomType.quantity === 0">
                                -
                            </button>
                            <span class="quantity-display">{{ roomType.quantity }}</span>
                            <button class="quantity-btn increase" @click="increaseQuantity(index)"
                                    :disabled="roomType.quantity >= roomType.count">
                                +
                            </button>
                        </div>
                        <p class="error">剩餘{{ roomType.count - roomType.quantity }}間房間！</p>

                        <button @click="addCartItem(roomType.id, roomType.quantity)"
                                class="add-to-cart-button">
                            添加到購物車
                        </button>

                    </div>
                </div>

            </div>
        </div>
        <div>
            <mediaIcon />
        </div>
    </v-main>
</template>

<script setup>
import { ref, onMounted, computed } from 'vue';
import Cart from '@/views/Ticket/components/cart.vue'
import { useRouter, useRoute } from 'vue-router';
import axios from 'axios';
import { AddItemToCart } from '@/apis/Cart/additem';
import mediaIcon from '../Layout/components/mediaIcon.vue';

const router = useRouter();
const route = useRoute();

const addCartItem = async (id, count) => {
    await AddItemToCart(55, id, 2, count)
}
// 增加数量
function increaseQuantity(index) {
    let room = hotel.value.roomTypes[index];
    if (room.quantity < room.count) {
        room.quantity++;
    }
}

// 减少数量
function decreaseQuantity(index) {
    let room = hotel.value.roomTypes[index];
    if (room.quantity > 0) {
        room.quantity--;
    }
}


onMounted(async () => {
    // 獲取路由參數中的飯店ID
    const hotelId = route.params.id;
    try {
        const response = await axios.get(`https://localhost:7113/api/Hotels/${hotelId}`);
        const hotelData = response.data;

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

const address = computed(() => hotel.value.hotelInfo.name || '默認地址');

const mapSrc = computed(() => {
    const query = encodeURIComponent(address.value); 
    const apiKey = 'AIzaSyCHn4jLlc2mfHlmAcXBC0NkeBzOsZYrSUE';//Google Maps API 密鑰，用於授權訪問 Google Maps 服務。
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


onMounted(async () => {
    
    const hotelId = route.params.id;
    //設施
    try {
        const hotelResponse = await axios.get(`https://localhost:7113/api/Hotels/${hotelId}`);
        const hotelData = hotelResponse.data;
        const roomsResponse = await axios.get(`https://localhost:7113/api/HotelRooms/hotel/${hotelId}`);
        const roomTypesData = roomsResponse.data;

        const facilityIds = JSON.parse(hotelData.hotelFacilities).FacilityIds;

        const facilityNames = await fetchFacilityNamesByIds(facilityIds);

        // 設置飯店訊息
        hotel.value.hotelInfo = {
            id: hotelData.id,
            name: hotelData.name,
            address: hotelData.address,
            rating: hotelData.grade, 
            facilities: facilityNames, 
            //統一時間格式
            checkInTime: hotelData.checkinStart.split(':').slice(0, 2).join(':'),
            checkOutTime: hotelData.checkoutEnd.split(':').slice(0, 2).join(':'),
            describe: "",

        };

        // 房型
        hotel.value.roomTypes = roomTypesData.map(room => ({
            id: room.id,
            name: room.name,
            size: room.size,
            price: room.weekdayPrice, 
            count: room.count,
            quantity: 0, 
            image: `/assets/HotelImages/${room.mainImage}`
        }));
        // 如果飯店的ID為3，則加上假資料的描述
         if (hotelData.id === 3) {
                hotel.value.hotelInfo.describe = "艾莎公寓位於台南市中西區大智街與保安路口，地處四通八達的地理中心位置，交通便捷，徒步3分鐘保安路、夏林路小吃，5分鐘海安路藝術商圈，6分鐘國華街和友愛街商圈，8分鐘新光三越台南新天地及藍曬圖文創園區，享有文創流行及美食小吃等多元的深度之旅。<br>" +
                    "艾莎公寓是全新的電梯別墅，外觀日系內斂灰白外牆，入口搭配上綠意盎然的重植花園造景，讓您在熱鬧的市區裡感受到大自然的活力，公寓內備有多種不同風格的主題套房讓您選擇，不論您是喜愛簡潔沉靜的高雅、喜歡粉色溫馨的浪漫、異國風味的空間表現或是針對兒童設計的親子館，都能滿足您的需求，尤其適合親子一同來體驗移居台南的生活步調，把「艾莎公寓」當作是您台南第二個家。";

                // 更新 HTML 中的描述
                document.getElementById("hotel-description").innerHTML = hotel.value.hotelInfo.describe;
            }

    } catch (error) {
        console.error('Failed to fetch hotel details:', error);
    }

});


</script>

<style scoped>
.hotel-room-container {
    display: flex;
    align-items: center;
    justify-content: center;
    padding-top: 40px;
}

.hotel-room {
    width: 80%;
}

.image-gallery {
    display: flex;
    overflow-x: auto;
    gap: 10px;
    margin-bottom: 20px;
    /* 為輪播圖下方添加間距 */
}

.hotel-image,
.room-type-image {
    width: 300px;
    height: 300px;
    object-fit: cover;
    border-radius: 5px;
}

.details-map-container {
    display: flex;
    justify-content: center;
    align-items: flex-start;
    gap: 20px;
    margin-bottom: 20px;
    /* 為地圖和信息容器下方添加間距 */
}

.info-container {
    background: #f5f5f5;
    border-radius: 8px;
    box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
    padding-left: 20px;
    flex: 1;
    margin-right: 20px;
    border:2px solid black;
}

.facilities-list {
    
    padding-left: 10px;
    margin-bottom: 10px;
}

.facilities-list li {
    margin-bottom: 5px;
   margin-left:20px;
}

    .rating,
    .price {
        font-weight: bold;
        color: #333;
        font-size: 25px;
        color: #DC6722;
        margin-left:20px;
    }

.room-types {
    display: flex;
    justify-content: center;
    flex-wrap: wrap;
}

    .room-type-card {
        flex: 1;
        min-width: 250px;
        /* 設置最小寬度 */
        margin-bottom: 20px;

    }


.map-container {
    flex: 1;
    min-width: 250px;
    /* 根據實際情況設置適當的寬度 */
    height: 250px;
    /* 根據實際情況設置適當的高度 */
}
/* 手機 小型平板大小*/
@media (max-width: 768px) {
    .details-map-container {
        flex-direction: column;
    }

    .info-container,
    .map-container {
        flex: 1;
        margin-right: 0;
        max-width: 100%;
    }
}

    .add-to-cart-button {
        padding: 10px 20px;
        margin-top: 10px;
        background-color: #F3C364;
        color: white;
        border: none;
        border-radius: 4px;
        cursor: pointer;
    }

        .add-to-cart-button:hover {
            background-color: #FCC954;
        }


.quantity-selector {
    display: flex;
    align-items: center;
    gap: 10px;
    margin-top: 10px;
 
}

.quantity-btn {
    padding: 5px 10px;
    font-size: 16px;
    color: #fff;
    background-color: #007bff;
    border: none;
    border-radius: 4px;
    cursor: pointer;
    transition: background-color 0.3s;
}

.quantity-btn:disabled {
    background-color: #cccccc;
    cursor: not-allowed;
}

.quantity-btn.decrease:hover,
.quantity-btn.increase:hover {
    background-color: #0056b3;
}

.quantity-display {
    font-size: 16px;
    color: #333;
    min-width: 30px;
    text-align: center;

}

.error {
    color: #dc3545;
    /* 錯誤訊息的顏色 */
    font-size: 14px;
    margin-top: 5px;
}
    .check-in-out{
        margin-left:20px;

    }



</style>