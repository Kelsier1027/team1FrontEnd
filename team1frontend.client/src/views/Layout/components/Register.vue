<script setup>
import { ref } from 'vue';
import { onMounted } from 'vue';
import { useMemberStore } from '@/stores/memberStore';

// 定義可被父組件監聽的事件
const emit = defineEmits(['register-success', 'switch-register']);
const memberStore = useMemberStore();

// 使用 ref 來創建表單數據和規則
const form = ref({
    email: 'ForTest31@gmail.com',
    password: 'ForTest31!',
    checkbox: false,
});
const loading = ref(false);
const visible = ref(false);
// 錯誤訊息
const errorMessage = ref('');

// 取得表單實例
const formRef = ref(null);
const register = async () => {
    const { email, password } = form.value;
    // 驗證表單 v-form 是否通過
    const valid = await formRef.value.validate();
    // console.log(valid.valid);
    if (valid.valid) {
        try {
            loading.value = true;
            // 如果表單驗證通過，執行註冊操作
            // console.log('註冊中...');
            await memberStore.register({ email, password });
            // console.log('註冊成功');
            loading.value = false;

            // 如果註冊成功，清空表單數據
            form.value.email = '';
            form.value.password = '';
            form.value.checkbox = false;
            // 觸發父組件監聽的事件
            emit('register-success');
        } catch (error) {
            console.log(error);
            if (error != null || undefined) {
                if (error.response != null || undefined) {
                    if (error.response.data != null || undefined) {
                        errorMessage.value = error.response.data;
                    }
                } else {
                    console.log(error.response);
                }
            } else {
                console.log(error);
            }
        }
    }
};

const siteKey = '6LcgoJkpAAAAADOg5FfAq7dnzphBVxFRIH-hFO8k';
const serverKey = '6LcgoJkpAAAAAH86f6Zu_ggiKcf0fPR6DGpX_IqL';

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

onMounted(() => {
    const script = document.createElement('script');
    script.src = 'https://www.google.com/recaptcha/api.js';
    script.async = true;
    script.defer = true;
    document.head.appendChild(script);
});

function showLogin() {
    emit('switch-register');
}
</script>
<template>
    <v-card-title class="justify-center text-center text-h5 mt-0 mb-1"
        >免費註冊</v-card-title
    >
    <v-card-subtitle class="justify-center text-center mb-9"
        >立即登入，隨時收到獨家優惠</v-card-subtitle
    >
    <v-form ref="formRef" @submit.prevent="register">
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
        <v-checkbox
            v-model="form.checkbox"
            :rules="[requiredWithNoMessage]"
            color="info"
            class="justify-start mt-0"
            style="margin-left: -11px"
            label="我已詳閱並同意"
        >
            <template v-slot:label>
                <div style="font-size: 14px">
                    我已詳閱並同意
                    <v-tooltip location="bottom">
                        <template v-slot:activator="{ props }">
                            <a
                                href="https://vuetifyjs.com"
                                target="_blank"
                                v-bind="props"
                                @click.stop
                                style="
                                    color: #5cbbc7;
                                    font-size: 14px;
                                    font-weight: 1000;
                                "
                            >
                                使用者條款
                            </a>
                            &
                            <a
                                href="https://vuetifyjs.com"
                                target="_blank"
                                v-bind="props"
                                @click.stop
                                style="
                                    color: #5cbbc7;
                                    font-size: 14px;
                                    font-weight: 1000;
                                "
                            >
                                隱私權保護政策
                            </a>
                            *
                        </template>
                        Opens in new window
                    </v-tooltip>
                </div>
            </template>
        </v-checkbox>
        <!-- ReCAPTCHA v2的容器 -->
        <div
            class="g-recaptcha recaptcha-container"
            :data-sitekey="siteKey"
        ></div>
        <br />
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
            註冊
        </v-btn>
    </v-form>
    <v-row class="justify-start">
        <div style="margin-left: 14px; font-size: 14px">
            <a
                class="text-decoration-none cursor-pointer"
                style="color: black"
                @click="showLogin"
                >已成為會員？立即登入</a
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
.recaptcha-container {
    display: flex;
    justify-content: center; /* 这行使得容器内的内容水平居中 */
}
.v-selection-control {
    height: 10px !important;
}
</style>

<script></script>
