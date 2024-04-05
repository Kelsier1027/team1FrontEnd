<script setup>
import { ref } from 'vue';
import Login from './Login.vue';
import Register from './Register.vue';
import ForgetPassword from './ForgetPassword.vue';
import SendEmailSuccessed from './SendEmailSuccessed.vue';

const emit = defineEmits(['close-dialog']);

const showRegister = ref(false); // 控制顯示哪個組件
const showLogin = ref(true); // 控制顯示哪個組件
const ShowForgetPassword = ref(false); // 控制顯示哪個組件
const ShowSendEmailSuccessed = ref(false); // 控制顯示哪個組件

// 定義一個方法來切換顯示的組件
function toggleRegister() {
    showRegister.value = !showRegister.value;
    showLogin.value = !showLogin.value;
}
// 定義一個方法告知父組件關閉對話框
function informParentToCloseDialog() {
    emit('close-dialog');
}
function switchToForgetPassword() {
    showRegister.value = false;
    showLogin.value = false;
    ShowForgetPassword.value = true;
}
function switchToRegister() {
    showRegister.value = true;
    showLogin.value = false;
    ShowForgetPassword.value = false;
}
function switchToSendEmailSuccessed() {
    showRegister.value = false;
    showLogin.value = false;
    ShowForgetPassword.value = false;
    ShowSendEmailSuccessed.value = true;
}
</script>
<template>
    <!-- 根據 showRegister 的值決定顯示哪個組件 -->
    <Login
        v-if="showLogin"
        @switch-register="toggleRegister"
        @login-success="informParentToCloseDialog"
        @forget-password-has-been-clicked="switchToForgetPassword"
    />
    <Register
        v-if="showRegister"
        @switch-register="toggleRegister"
        @register-success="informParentToCloseDialog"
    />
    <ForgetPassword
        v-if="ShowForgetPassword"
        @show-register="switchToRegister"
        @show-send-email-success="switchToSendEmailSuccessed"
    >
    </ForgetPassword>
    <SendEmailSuccessed
        v-if="ShowSendEmailSuccessed"
        @notify-close-dialog="informParentToCloseDialog"
    />
</template>
