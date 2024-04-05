<script setup>
import { ref } from 'vue';
import { onMounted } from 'vue';

// 定義可被父組件監聽的事件
const emit = defineEmits(['show-login']);

// 當某個動作發生時（例如按鈕點擊），觸發事件通知父組件
function ShowLogin() {
    emit('show-login');
}

const loginURI = 'https://localhost:7113/api/Members/valid-google-login';

onMounted(() => {
    loadGoogleSignInSDK().then(() => {
        google.accounts.id.initialize({
            client_id:
                '841135279083-38u2rs985d6jl5ki7v7sa2tf4o0nuojb.apps.googleusercontent.com',
            callback: handleCredentialResponse,
            auto_select: false,
            context: 'signin',
            ux_mode: 'popup',
            login_uri: loginURI,
        });
        // 根據需要顯示登入提示或渲染登入按鈕
    });
});

function handleCredentialResponse(response) {
    console.log('Encoded JWT ID token:', response.credential);

    // 處理登入成功後的邏輯，例如將 token 發送到後端
}

function loadGoogleSignInSDK() {
    return new Promise((resolve, reject) => {
        const script = document.createElement('script');
        script.src = 'https://accounts.google.com/gsi/client';
        script.async = true;
        script.defer = true;
        script.onload = resolve;
        script.onerror = reject;
        document.head.appendChild(script);
    });
}
// function handleSignIn() {
//     // 確保 Google Accounts SDK 已經初始化
//     if (google && google.accounts && google.accounts.id) {
//         google.accounts.id.prompt((notification) => {
//             // 這裡處理登入提示的狀態
//             if (
//                 notification.isNotDisplayed() ||
//                 notification.isSkippedMoment()
//             ) {
//                 console.log('Login prompt is not displayed or was skipped.');
//             }
//         });
//     } else {
//         console.error('Google Accounts SDK is not initialized.');
//     }
// }
</script>
<template>
    <v-card-title class="justify-center text-center text-h5 mt-0 mb-1"
        >登入註冊 小白旅遊</v-card-title
    >
    <v-card-subtitle class="justify-center text-center mb-9"
        >立即登入，隨時收到獨家優惠</v-card-subtitle
    >
    <div class="login-channel-list">
        <v-btn class="btn-custom" variant="text" style="width: 100%">
            <div
                id="g_id_onload"
                data-client_id="841135279083-38u2rs985d6jl5ki7v7sa2tf4o0nuojb.apps.googleusercontent.com"
                data-login_uri="https://localhost:7113/api/Members/valid-google-login"
                data-auto_prompt="false"
            ></div>
            <div
                class="g_id_signin"
                data-type="standard"
                data-size="large"
                data-theme="outline"
                data-text="使用Google繼續"
                data-shape="circle"
                data-logo_alignment="left"
                style="width: 100%"
            ></div>
        </v-btn>
        <v-btn class="btn-custom" variant="text" style="width: 100%">
            <img
                class="btn-icon"
                src="https://cdn.kkday.com/pc-web/assets/img/sns/facebook.svg"
                alt="Facebook"
            />
            <span class="btn-text"> 使用 Facebook 繼續 </span>
        </v-btn>

        <!-- <v-btn class="btn-custom" variant="text" style="width: 100%">
            <img
                class="btn-icon"
                src="https://cdn.kkday.com/pc-web/assets/img/sns/google.svg"
                alt="Google"
            />
            <span class="btn-text">使用 Google 繼續</span>
        </v-btn> -->

        <v-btn class="btn-custom" variant="text" style="width: 100%">
            <img
                class="btn-icon"
                src="https://cdn.kkday.com/pc-web/assets/img/sns/line.svg"
                alt="Line"
            />
            <span class="btn-text">使用 Line 繼續</span>
        </v-btn>

        <v-btn class="btn-custom" variant="text" style="width: 100%">
            <img
                class="btn-icon"
                src="https://cdn.kkday.com/pc-web/assets/img/sns/wechat.svg"
                alt="Wechat"
            />
            <span class="btn-text">使用 Wechat 繼續</span>
        </v-btn>

        <v-btn class="btn-custom" variant="text" style="width: 100%">
            <img
                class="btn-icon"
                src="https://cdn.kkday.com/pc-web/assets/img/sns/kakao.svg"
                alt="Kakao"
            />
            <span class="btn-text">使用 Kakao 繼續</span>
        </v-btn>

        <v-btn class="btn-custom" variant="text" style="width: 100%">
            <img
                class="btn-icon"
                src="https://cdn.kkday.com/pc-web/assets/img/sns/naver.svg"
                alt="Naver"
            />
            <span class="btn-text">使用 Naver 繼續</span>
        </v-btn>

        <v-btn class="btn-custom" variant="text" style="width: 100%">
            <img
                class="btn-icon"
                src="https://cdn.kkday.com/pc-web/assets/img/sns/yahoo_japan.svg"
                alt="Yahoo! JAPAN ID"
            />
            <span class="btn-text">使用 Yahoo! JAPAN ID 繼續</span>
        </v-btn>

        <v-btn
            class="btn-custom"
            variant="text"
            style="width: 100%"
            @click="ShowLogin"
        >
            <v-icon icon="mdi-email-outline" class="btn-icon"></v-icon>
            <span class="btn-text">使用 電子郵件 繼續</span>
        </v-btn>
    </div>
</template>

<style scoped>
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}
/* :deep(.nsm7Bb-HzV7m-LgbsSe) {
    border-width: 0px;
} */
element.style {
    --text-color: #222;
    --border-color: #ddd;
    --background-color: transparent;
}
.v-btn {
    text-transform: none;
}
.login-channel-list {
    display: grid;
    gap: 16px;
    margin-bottom: 35px;
}

.btn-custom {
    display: flex;
    justify-content: center;
    align-items: center;
    width: 350px !important;
    font-weight: 500;
    font-size: 16px;
    border: 1px solid #ddd;
    border-radius: 22px;
    padding: 0 20px;

    display: grid;
    width: 100%;
    grid-template-columns: 20px auto 20px;
    gap: 16px;
    -webkit-box-align: center;
    -ms-flex-align: center;

    color: #222;
    height: 50px !important;
}
.btn-custom:hover {
    border-color: black;
}
.btn-icon {
    position: absolute;
    left: 16px; /* 根据需要调整，这是按钮内边距的标准值 */
}

.btn-text {
    flex: 1;
    text-align: center;
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
