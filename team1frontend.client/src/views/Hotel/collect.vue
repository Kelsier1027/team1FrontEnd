<template>
    <v-main class="content">
        <div class="collect-page">
            <h1>我的收藏</h1>
            <div v-if="favorites.length === 0" class="no-favorites">
                您還沒有收藏任何飯店。
            </div>
            <div v-else class="favorites-list">
                <div v-for="hotel in favorites" :key="hotel.id" class="hotel-card">
                    <img :src="getHotelImageUrl(hotel.mainImage)" alt="Hotel Image" class="hotel-image" />
                    <div class="hotel-info">
                        <h3>{{ hotel.name }}</h3>
                        <h5>{{ hotel.address }}</h5>
                        <div class="hotel-rating">
                            <span>{{ hotel.grade }}</span>
                        </div>
                        <div class="hotel-price" v-if="hotel.hotelRooms && hotel.hotelRooms.length">
                            <span>NT${{ hotel.hotelRooms[0].weekendPrice }}</span>
                        </div>
                    </div>
                    <button class="remove-favorite" @click="removeFavorite(hotel)">
                        移除收藏
                    </button>
                </div>
            </div>
        </div>
    </v-main>
</template>

<script setup>
    import { useHotelStore } from '../../stores/hotel.js';
    import { storeToRefs } from 'pinia';
    import { computed } from 'vue';

    const store = useHotelStore();
    const { favorites } = storeToRefs(store);

    const getHotelImageUrl = (imagePath) => {
        return `/assets/HotelImages/${imagePath}`;
    };

    const removeFavorite = (hotel) => {
        store.toggleFavorite(hotel);
    };
</script>

<style scoped>
    .collect-page {
        max-width: 1200px;
        margin: 0 auto;
        padding: 20px;
    }

    h1 {
        text-align: center;
        margin-bottom: 30px;
        color: #333;
    }

    .no-favorites {
        text-align: center;
        font-size: 18px;
        color: #666;
        margin-top: 50px;
    }

    .favorites-list {
        display: grid;
        grid-template-columns: repeat(auto-fill, minmax(300px, 1fr));
        gap: 20px;
    }

    .hotel-card {
        border: 1px solid #e0e0e0;
        border-radius: 8px;
        overflow: hidden;
        box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
        transition: transform 0.3s ease;
    }

        .hotel-card:hover {
            transform: translateY(-5px);
        }

    .hotel-image {
        width: 100%;
        height: 200px;
        object-fit: cover;
    }

    .hotel-info {
        padding: 15px;
    }

        .hotel-info h3 {
            margin: 0 0 10px;
            font-size: 18px;
            color: #333;
        }

        .hotel-info h5 {
            margin: 0 0 10px;
            font-size: 14px;
            color: #666;
        }

    .hotel-rating {
        font-size: 14px;
        color: #4caf50;
        margin-bottom: 5px;
    }

    .hotel-price {
        font-size: 16px;
        font-weight: bold;
        color: #e91e63;
    }

    .remove-favorite {
        width: 100%;
        padding: 10px;
        background-color: #f44336;
        color: white;
        border: none;
        cursor: pointer;
        transition: background-color 0.3s ease;
    }

        .remove-favorite:hover {
            background-color: #d32f2f;
        }
</style>