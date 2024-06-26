import { defineStore } from 'pinia';

export const useHotelStore = defineStore('hotel', {
    state: () => ({
        favorites: []
    }),
    actions: {
        toggleFavorite(hotel) {
            const index = this.favorites.findIndex(fav => fav.id === hotel.id);
            if (index === -1) {
                this.favorites.push(hotel);
            } else {
                this.favorites.splice(index, 1);
            }
        },
        isFavorite(hotelId) {
            return this.favorites.some(fav => fav.id === hotelId);
        },
        removeFavorite(hotel) {
            const index = this.favorites.findIndex(fav => fav.id === hotel.id);
            if (index !== -1) {
                this.favorites.splice(index, 1);
            }
        }






    }

});
