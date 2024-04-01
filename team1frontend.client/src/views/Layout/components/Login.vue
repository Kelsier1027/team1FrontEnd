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
    loading.value = true;
    const { email, password } = form.value;
    // 驗證表單 v-form 是否通過
    const valid = await formRef.value.validate();
    // console.log(valid.valid);
    if (valid.valid) {
        try {
            await memberStore.login({ email, password });
            // console.log(memberStore.memberId);
            loading.value = false;
            await memberStore.getMemberInfo();
            // 如果註冊成功，清空表單數據
            form.value.email = '';
            form.value.password = '';
            // 觸發父組件監聽的事件
            emit('login-success');
        } catch (error) {
            // console.log(error);
            // if (error != null || undefined) {
            //     if (error.response != null || undefined) {
            //         if (error.response.data != null || undefined) {
            //             errorMessage.value = error.response.data;
            //         }
            //     } else {
            //         console.log(error.response);
            //     }
            // } else {
            //     console.log(error);
            // }
        }
    }
};

// 定義可被父組件監聽的事件
const emit = defineEmits(['switch-register', 'login-success']);

// 當某個動作發生時（例如按鈕點擊），觸發事件通知父組件
function ShowRegister() {
    emit('switch-register');
}
function ShowLogin() {
    emit('login-success');
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

        <!-- 錯誤訊息 -->
        <div class="mb-3" style="color: red; font-size: 13px">
            {{ errorMessage }}
        </div>
        <v-btn
            type="submit"
            class="mb-4"
            color="white"
            size="large"
            variant="tonal"
            block
            style="background-color: #5cbbc7"
        >
            登入
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
</style>

<script></script>
