<template>
    <div
        class="cart"
        @mouseover="showCartContent = true"
        @mouseleave="showCartContent = false"
    >
        <div class="cart-icon">通知跟購物車</div>
        <div v-if="showCartContent" class="cart-content">
            <div
                v-for="(item, index) in cartItems"
                :key="index"
                class="cart-item"
            >
                <span>{{ item.name }}</span>
                <span>{{ item.price }}</span>
            </div>
            <div>錢: {{ total }}</div>
        </div>
    </div>
</template>

<script setup>
import { ref, computed } from 'vue';

const cartItems = ref([
    { id: 1, name: '測試 1 price ', price: 10 },
    { id: 2, name: '測試 2 price ', price: 20 },
]);

const total = computed(() => {
    return cartItems.value.reduce((total, item) => total + item.price, 0);
});

const showCartContent = ref(false);
</script>

<style scoped>
/* 样式可以自定义 */
.cart {
    position: relative;
    display: inline-block;
}

.cart-content {
    position: absolute;
    top: 100%;
    left: 0;
    background-color: white;
    border: 1px solid gray;
    padding: 5px;
}

.cart-content .cart-item {
    display: flex;
    justify-content: space-between;
}

.cart-icon {
    cursor: pointer;
}
</style>
