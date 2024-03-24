<script setup>
import { ref } from 'vue';
import Login from './Login.vue';
import Register from './Register.vue';

const emit = defineEmits(['close-dialog']);

const showRegister = ref(false); // 控制顯示哪個組件

// 定義一個方法來切換顯示的組件
function toggleRegister() {
    showRegister.value = !showRegister.value;
}
// 定義一個方法告知父組件關閉對話框
function informParentToCloseDialog() {
    emit('close-dialog');
}
</script>
<template>
    <!-- 根據 showRegister 的值決定顯示哪個組件 -->
    <Login
        v-if="!showRegister"
        @switch-register="toggleRegister"
        @login-success="informParentToCloseDialog"
    />
    <Register
        v-else
        @switch-register="toggleRegister"
        @register-success="informParentToCloseDialog"
    />
</template>
