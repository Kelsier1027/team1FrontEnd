import { ref } from 'vue';
import { defineStore } from 'pinia';

export const useCartStore = defineStore('cartStore', () => {
    const cartItems = ref([
        {
            id: 1,
            photo: 'https://fakeimg.pl/300/',
            name: '劍湖山世界',
            detail: '成人門票',
            price: 600,
            quantity: 1,
        },
        {
            id: 2,
            photo: 'https://fakeimg.pl/300/',
            name: '九族文化村',
            detail: '成人門票',
            price: 700,
            quantity: 1,
        },
        {
            id: 3,
            photo: 'https://fakeimg.pl/300/',
            name: '麗寶樂園',
            detail: '成人門票',
            price: 900,
            quantity: 1,
        },
    ]);

    return {
        cartItems,
    };
});
