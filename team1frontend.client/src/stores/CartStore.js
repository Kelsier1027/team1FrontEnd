import { defineStore } from 'pinia';
import { ref } from 'vue';

export const useCartStore = defineStore('cartStore', () => {
    const showCartContent = ref(false)

    return {
        showCartContent
    };
})