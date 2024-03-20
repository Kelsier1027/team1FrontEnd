<script setup>
import { ref } from 'vue';
import { onMounted } from 'vue';

// 定義可被父組件監聽的事件
const emit = defineEmits(['show-register']);

// 當某個動作發生時（例如按鈕點擊），觸發事件通知父組件
function ShowRegister() {
    emit('show-register');
}

const siteKey = '6LcgoJkpAAAAADOg5FfAq7dnzphBVxFRIH-hFO8k';
const serverKey = '6LcgoJkpAAAAAH86f6Zu_ggiKcf0fPR6DGpX_IqL';

onMounted(() => {
    const script = document.createElement('script');
    script.src = 'https://www.google.com/recaptcha/api.js';
    script.async = true;
    script.defer = true;
    document.head.appendChild(script);
});
</script>
<template>
    <v-card-title class="justify-center text-center text-h5 mt-0 mb-1"
        >免費註冊</v-card-title
    >
    <v-card-subtitle class="justify-center text-center mb-9"
        >立即登入，隨時收到獨家優惠</v-card-subtitle
    >
    <v-text-field
        density="compact"
        placeholder="電子郵件"
        prepend-inner-icon="mdi-email-outline"
        variant="outlined"
    ></v-text-field>

    <v-text-field
        class="mb-0"
        :append-inner-icon="visible ? 'mdi-eye-off' : 'mdi-eye'"
        :type="visible ? 'text' : 'password'"
        density="compact"
        placeholder="密碼"
        prepend-inner-icon="mdi-lock-outline"
        variant="outlined"
        @click:append-inner="visible = !visible"
    ></v-text-field>
    <v-checkbox
        v-model="checkbox"
        color="info"
        class="justify-start mt-0"
        style="margin-left: -11px"
    >
        <template v-slot:label>
            <div>
                <span style="color: black; font-size: 14px"
                    >我已詳閱並同意</span
                >

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
                <!-- is awesome -->
            </div>
        </template>
    </v-checkbox>
    <!-- ReCAPTCHA v2的容器 -->
    <div class="g-recaptcha recaptcha-container" :data-sitekey="siteKey"></div>
    <br />

    <v-btn
        class="mb-4"
        color="white"
        size="large"
        variant="tonal"
        block
        style="background-color: #5cbbc7"
    >
        註冊
    </v-btn>
    <v-row class="justify-start">
        <div style="margin-left: 14px; font-size: 14px">
            <a
                class="text-decoration-none cursor-pointer"
                style="color: black"
                @click="ShowRegister"
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
</style>

<script>
export default {
    data: () => ({
        visible: false,
        checkbox: false,
    }),
};
</script>
