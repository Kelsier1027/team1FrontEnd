<template>
    <v-card-title
        class="justify-center text-center text-h5 mb-8"
        style="margin-top: -4px"
        >忘記密碼</v-card-title
    >

    <v-form ref="formRef" @submit.prevent="SendForgetPasswordEmail">
        <v-text-field
            color="#26bec9"
            v-model="form.email"
            :readonly="loading"
            :rules="[required, emailFormat]"
            class="mb-4"
            label="電子郵件"
            type="email"
            clearable
            density="compact"
            prepend-inner-icon="mdi-email-outline"
            variant="outlined"
        ></v-text-field>

        <div
            class="d-flex justify-start"
            style="margin-top: -18px; margin-bottom: 0"
        >
            <div
                class="mb-3"
                style="color: red; font-size: 13px; margin-top: 0"
            >
                {{ errorMessage }}
            </div>
        </div>
        <!-- 錯誤訊息 -->
        <v-btn
            type="submit"
            class="mb-2 resetPassword-btn"
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
            <span class="fontFamily" v-if="!loading">重新設定密碼</span>
        </v-btn>
    </v-form>
    <v-row class="justify-start mt-1">
        <div style="margin-left: 14px; font-size: 14px; margin-bottom: -10px">
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
</template>

<script setup>
import { ref } from 'vue';
import { useMemberStore } from '@/stores/memberStore';
const memberStore = useMemberStore();
// 使用 ref 來創建表單數據和規則
const form = ref({
    email: 'w6886423e@gmail.com',
});
// 取得表單實例
const formRef = ref(null);
// 錯誤訊息
const errorMessage = ref('');

const loading = ref(false);

const required = (v) => !!v || '此欄位必填';
const emailFormat = (v) => /.+@.+\..+/.test(v) || '錯誤的 email 格式';

// 定義可被父組件監聽的事件
const emit = defineEmits(['show-register', 'show-send-email-success']);

// 當某個動作發生時（例如按鈕點擊），觸發事件通知父組件
function ShowRegister() {
    emit('show-register');
}
function SendEmailSuccess() {
    emit('show-send-email-success');
}
// 發送忘記密碼的郵件
const SendForgetPasswordEmail = async () => {
    // 確認表單數據是否符合規則
    const isValid = await formRef.value.validate();
    if (isValid.valid) {
        loading.value = true;
        try {
            // await new Promise((resolve) => setTimeout(resolve, 1000));
            const result = await memberStore.sendForgetPasswordEmail(
                form.value.email
            );
            loading.value = false;
            if (result) {
                form.value.email = '';
                SendEmailSuccess();
            } else {
                loading.value = false;
                errorMessage.value = '查無此帳號，請檢查是否有誤';
            }
        } catch (error) {
            loading.value = false;
            errorMessage.value = '查無此帳號，請檢查是否有誤';
        }
    }
};
</script>

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

:deep(.resetPassword-btn) {
    font-weight: 500;
    font-size: 14px;
    color: white;
    border-radius: 5px;
    background-color: #5cbbc7;
    transition: background-color 0.3s;
}
:deep(.resetPassword-btn:hover) {
    background-color: #428c8c;
    font-size: 16px;
}
</style>
