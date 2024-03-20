<script setup>
import { ref } from 'vue';
import { onMounted } from 'vue';

// 定義可被父組件監聽的事件
const emit = defineEmits(['show-register']);

// 當某個動作發生時（例如按鈕點擊），觸發事件通知父組件
function ShowRegister() {
    emit('show-register');
}
</script>
<template>
    <v-card-title class="justify-center text-center text-h5 mb-2"
        >登入 小白旅遊</v-card-title
    >

    <v-card-subtitle class="justify-center text-center"
        >立即登入，隨時收到獨家優惠</v-card-subtitle
    >
    <div class="text-subtitle-1 text-medium-emphasis"></div>
    <br />
    <br />

    <v-text-field
        v-model="email"
        :readonly="loading"
        :rules="[required]"
        class="mb-2"
        label="電子郵件"
        clearable
        density="compact"
        prepend-inner-icon="mdi-email-outline"
        variant="outlined"
    ></v-text-field>

    <v-text-field
        v-model="password"
        :readonly="loading"
        :rules="[required]"
        label="密碼"
        clearable
        :append-inner-icon="visible ? 'mdi-eye-off' : 'mdi-eye'"
        :type="visible ? 'text' : 'password'"
        density="compact"
        prepend-inner-icon="mdi-lock-outline"
        variant="outlined"
        @click:append-inner="visible = !visible"
    ></v-text-field>

    <br />

    <v-btn
        :loading="loading"
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
.recaptcha-container {
    display: flex;
    justify-content: center; /* 这行使得容器内的内容水平居中 */
}
</style>

<script>
export default {
    data: () => ({
        visible: false,
        checkbox: false,
        form: false,
        email: null,
        password: null,
        loading: false,
    }),
    methods: {
        onSubmit() {
            if (!this.form) return;

            this.loading = true;

            setTimeout(() => (this.loading = false), 2000);
        },
        required(v) {
            return !!v || '此欄位必填';
        },
    },
};
</script>
