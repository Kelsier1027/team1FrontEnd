<script setup>
import { ref } from 'vue';
import { onMounted } from 'vue';
import { useMemberStore } from '@/stores/memberStore';

const memberStore = useMemberStore();

// 使用 ref 來創建表單數據和規則
const form = ref({
    email: 'ForTest31@gmail.com',
    password: 'ForTest31!',
});
const visible = ref(false);
const loading = ref(false);

// 錯誤訊息
const errorMessage = ref('');

// 取得表單實例
const formRef = ref(null);
const doLogin = async () => {
    const { email, password } = form.value;
    // 驗證表單 v-form 是否通過
    const isValid = await formRef.value.validate();
    // console.log(valid.valid);
    if (isValid.valid) {
        try {
            loading.value = true;
            await memberStore.login({ email, password });
            loading.value = false;
            // console.log(memberStore.memberId);
            await memberStore.getMemberInfo();
            // 觸發父組件監聽的事件
            LoginSuccess();
            // 如果註冊成功，清空表單數據
            // 等待 2 秒後清空表單數據
            setTimeout(() => {
                form.value.email = '';
                form.value.password = '';
            }, 2000);
        } catch (error) {
            // 顯示帳號或密碼錯誤
            loading.value = false;
            errorMessage.value = '帳號或密碼錯誤';
        }
    }
};

// 定義可被父組件監聽的事件
const emit = defineEmits([
    'switch-register',
    'login-success',
    'forget-password-has-been-clicked',
]);

// 當某個動作發生時（例如按鈕點擊），觸發事件通知父組件
function ShowRegister() {
    emit('switch-register');
}
function LoginSuccess() {
    emit('login-success');
}
function ShowForgetPassword() {
    // console.log('forget-password-has-been-clicked');
    emit('forget-password-has-been-clicked');
}

// v-form 表單驗證規則
const required = (v) => !!v || '此欄位必填';
const requiredWithNoMessage = (v) => !!v || '';
const emailFormat = (v) => /.+@.+\..+/.test(v) || '錯誤的 email 格式';
const passwordLength = (v) =>
    (v.length >= 6 && v.length <= 20) || '密碼長度需在6-20位之間';
const passwordUpperCase = (v) =>
    /[A-Z]/.test(v) || '密碼需包含至少一個大寫字母';
const passwordLowerCase = (v) =>
    /[a-z]/.test(v) || '密碼需包含至少一個小寫字母';
const passwordNumber = (v) => /[0-9]/.test(v) || '密碼需包含至少一個數字';
const passwordSpecial = (v) =>
    /[^A-Za-z0-9]/.test(v) || '密碼需至少包含一個特殊字符';
</script>
<template>
    <v-card-title class="justify-center text-center text-h5 mt-0 mb-1"
        >登入 小白旅遊</v-card-title
    >

    <v-card-subtitle class="justify-center text-center mb-9"
        >立即登入，隨時收到獨家優惠</v-card-subtitle
    >

    <v-form ref="formRef" @submit.prevent="doLogin">
        <v-text-field
            color="#26bec9"
            v-model="form.email"
            :readonly="loading"
            :rules="[required, emailFormat]"
            class="mb-2"
            label="電子郵件"
            type="email"
            clearable
            density="compact"
            prepend-inner-icon="mdi-email-outline"
            variant="outlined"
        ></v-text-field>

        <v-text-field
            color="#26bec9"
            class="mb-0"
            v-model="form.password"
            :readonly="loading"
            :rules="[
                required,
                passwordLength,
                passwordUpperCase,
                passwordLowerCase,
                passwordNumber,
                passwordSpecial,
            ]"
            label="密碼"
            clearable
            :append-inner-icon="visible ? 'mdi-eye-off' : 'mdi-eye'"
            :type="visible ? 'text' : 'password'"
            density="compact"
            prepend-inner-icon="mdi-lock-outline"
            variant="outlined"
            @click:append-inner="visible = !visible"
        ></v-text-field>
        <div
            class="d-flex justify-space-between"
            style="margin-top: -18px; margin-bottom: 8px"
        >
            <div
                class="mb-3"
                style="color: red; font-size: 13px; margin-top: 0"
            >
                {{ errorMessage }}
            </div>
            <a
                class="forget-password"
                @click="ShowForgetPassword"
                style="font-size: 14px"
                >忘記密碼</a
            >
        </div>
        <!-- 錯誤訊息 -->
        <v-btn
            type="submit"
            class="mb-4 login-btn"
            size="large"
            variant="tonal"
            block
            style="margin-top: 0"
        >
            <!-- 使用v-if根据loading的状态来显示或隐藏加载指示器 -->
            <v-progress-circular
                v-if="loading"
                indeterminate
                size="24"
                width="3"
                style="
                    position: absolute;
                    left: 50%;
                    top: 50%;
                    transform: translate(-50%, -50%);
                "
            ></v-progress-circular>
            <!-- 当不在加载时显示按钮文字 -->
            <span class="fontFamily" v-if="!loading">登入</span>
        </v-btn>
    </v-form>
    <v-row class="justify-start">
        <div style="margin-left: 14px; font-size: 14px">
            <a
                class="text-decoration-none cursor-pointer"
                style="color: black"
                @click="ShowRegister"
                >還未加入 小白旅遊 嗎？立即註冊！</a
            >
        </div>
    </v-row>
    <br />
    <br />

    <!-- <v-card-text class="text-center"> </v-card-text> -->
</template>

<style scoped>
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}
:deep(.fontFamily) {
    font-family: 'Noto Sans TC', '微软雅黑', 'Microsoft YaHei', 'sans-serif';
    /* border-bottom: 1px solid #dfdfdf; */
}
:deep(.forget-password, .forget-password:visited) {
    font-weight: 900;
    color: gray;
    transition: color 0.3s, text-decoration-color 0.3s;
    text-decoration: none;
}

:deep(.forget-password:hover) {
    color: rgb(23, 23, 23);
    text-decoration: underline;
    text-decoration-color: var(--hover-text-color);
}
:deep(.login-btn) {
    font-weight: 500;
    font-size: 14px;
    color: white;
    border-radius: 5px;
    background-color: #5cbbc7;
    transition: background-color 0.3s;
}
:deep(.login-btn:hover) {
    background-color: #428c8c;
    font-size: 16px;
}
</style>

<script></script>
