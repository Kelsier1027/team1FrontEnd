<script setup>
import { ref } from 'vue';
import Login from './Login.vue';
import Register from './Register.vue';

const showRegister = ref(false); // 控制顯示哪個組件

// 定義一個方法來切換顯示的組件
function toggleShowRegister() {
    showRegister.value = !showRegister.value;
}
</script>
<template>
    <!-- 根據 showRegister 的值決定顯示哪個組件 -->
    <Login v-if="!showRegister" @show-register="toggleShowRegister" />
    <Register v-else @show-register="toggleShowRegister" />
</template>
