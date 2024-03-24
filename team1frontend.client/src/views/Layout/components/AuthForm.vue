<template>
    <v-card-title>
        <span v-if="isRegister">免費註冊</span>
        <span v-else>登入小白旅遊</span>
    </v-card-title>
    <v-card-subtitle>立即登入，隨時收到獨家優惠</v-card-subtitle>
    <v-card-text>
        <v-form ref="form" @submit.prevent="handleSubmit">
            <v-text-field
                v-model="email"
                :rules="[rules.required, rules.emailFormat]"
                label="電子郵件"
                type="email"
                clearable
            ></v-text-field>
            <v-text-field
                v-model="password"
                :rules="[rules.required]"
                label="密碼"
                type="password"
                clearable
                :append-inner-icon="showPassword ? 'mdi-eye' : 'mdi-eye-off'"
                @click:append-inner="showPassword = !showPassword"
                :type="showPassword ? 'text' : 'password'"
            ></v-text-field>
            <v-checkbox
                v-model="agreedToTerms"
                v-if="isRegister"
                :rules="[rules.requiredCheckbox]"
                label="我已詳閱並同意使用者條款與隱私權政策"
            ></v-checkbox>
            <div
                v-if="isRegister"
                class="g-recaptcha"
                :data-sitekey="siteKey"
            ></div>
            <v-btn :disabled="loading" color="primary" block type="submit">
                {{ isRegister ? '註冊' : '登入' }}
            </v-btn>
            <v-btn text color="primary" @click="toggleMode">
                {{ isRegister ? '已有帳號？立即登入' : '沒有帳號？立即註冊' }}
            </v-btn>
        </v-form>
    </v-card-text>
</template>

<script setup>
import { ref } from 'vue';
import { useMemberStore } from '@/stores/memberStore';
import { useRouter } from 'vue-router';

const form = ref(null);
const email = ref('');
const password = ref('');
const agreedToTerms = ref(false);
const showPassword = ref(false);
const isRegister = ref(false);
const loading = ref(false);
const siteKey = '你的siteKey';
const router = useRouter();
const memberStore = useMemberStore();

const rules = {
    required: (value) => !!value || '此欄位必填',
    emailFormat: (value) => /.+@.+\..+/.test(value) || '錯誤的電子郵件格式',
    requiredCheckbox: (value) => !!value || '必須同意條款',
};

const handleSubmit = async () => {
    loading.value = true;
    try {
        if (isRegister.value) {
            await memberStore.register({
                email: email.value,
                password: password.value,
            });
            // 進一步處理註冊成功的情況，如導航到登入頁或主頁
        } else {
            await memberStore.login({
                email: email.value,
                password: password.value,
            });
            // 登入成功後的處理，如導航到主頁
            router.push('/');
        }
    } catch (error) {
        // 處理錯誤情況
        console.error(error);
    } finally {
        loading.value = false;
    }
};

const toggleMode = () => {
    isRegister.value = !isRegister.value;
};
</script>
