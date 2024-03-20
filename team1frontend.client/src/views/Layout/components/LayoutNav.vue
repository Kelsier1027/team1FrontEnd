<script setup>
import { ref } from 'vue';

import Options from './Options.vue';
import LoginOrRegister from './LoginOrRegister.vue';
const showLogin = ref(false); // 控制顯示哪個組件
const isLogin = ref(false); //  控制顯示登入或註冊

// 確認是否登入
function checkLogin() {
    // 如果為尚未登入狀態，則顯示 Options 組件， 將 showLogin 設為 false
    if (!isLogin.value) {
        showLogin.value = false;
    }
    dialog.value = true;
}

// 定義一個方法來切換顯示的組件
function toggleShowLogin() {
    showLogin.value = !showLogin.value;
}

const drawer = ref(false);
const dialog = ref(false);
const items = ref([
    { title: 'Foo', value: 'foo' },
    { title: 'Bar', value: 'bar' },
    { title: 'Fizz', value: 'fizz' },
    { title: 'Buzz', value: 'buzz' },
]);
</script>

<template>
    <v-app-bar :elevation="1" class="app-bar-flex">
        <!-- 將標題放在最左邊 -->
        <v-app-bar-title>
            <div
                class="font-weight-bold text-h4"
                style="color: RGB(38, 190, 201)"
            >
                小白旅遊
            </div></v-app-bar-title
        >

        <!-- 使用flex容器包裹右邊的兩個元件，並利用CSS控制排列 -->
        <div class="flex-right">
            <v-icon icon="mdi-cart-outline" class="pe-6" />
            <v-btn @click="checkLogin">
                <div class="font-weight-bold" style="color: gray">
                    登入/註冊
                </div>
            </v-btn>

            <!-- 只在大螢幕上顯示v-avatar，並在小螢幕上隱藏v-app-bar-nav-icon -->
            <!-- <v-avatar
                class="hidden-sm-and-down"
                color="grey-darken-1"
                size="32"
            ></v-avatar> -->
            <v-app-bar-nav-icon
                class="hidden-md-and-up"
                @click.stop="drawer = !drawer"
            ></v-app-bar-nav-icon>
        </div>
    </v-app-bar>

    <v-navigation-drawer v-model="drawer" location="right" temporary>
        <v-list :items="items"></v-list>
    </v-navigation-drawer>

    <!-- 註冊及登入彈出窗口 -->
    <v-dialog
        v-model="dialog"
        transition="dialog-top-transition"
        class="dialog-vertical-top overflow-y-auto"
        max-width="450px"
    >
        <template v-slot:default="{ isActive }">
            <v-card class="d-flex overflow-hidden rounded-2" elevation="8">
                <template v-slot:append>
                    <div
                        style="
                            background-color: RGB(38, 190, 201);
                            width: 450px;
                            position: absolute;
                            top: 0;
                            left: 0;
                            z-index: 1000;
                            height: 10px;
                        "
                    ></div>
                    <div class="">
                        <v-btn
                            icon="$close"
                            size="large"
                            variant="text"
                            @click="isActive.value = false"
                        ></v-btn>
                    </div>
                </template>
                <div class="overflow-y-auto mt-0">
                    <v-container class="w-75 h-100 pa-0 align-center">
                        <!-- 根據 showLogin 的值決定顯示哪個組件 -->
                        <Options
                            v-if="!showLogin"
                            @show-login="toggleShowLogin"
                        />
                        <LoginOrRegister v-else />
                    </v-container>
                </div>
            </v-card>
        </template>
    </v-dialog>
</template>

<script></script>

<style scoped>
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

.dialog-vertical-top {
    display: flex;
    align-items: flex-start;
    justify-content: center;
}
.app-bar-flex {
    /* height: 64px; */
    padding-left: 350px; /* 起始點設置較大的間距 */
    display: flex;
    justify-content: space-between;
    align-items: center;
    justify-content: center; /* 保留一個justify-content設定 */
}

.flex-right {
    padding-right: 380px; /* 起始點設置較大的間距 */
    display: flex;
    align-items: center;
}

/* 根據螢幕大小動態調整間距 */
@media (max-width: 1800px) {
    .app-bar-flex,
    .flex-right {
        padding-left: 260px;
        padding-right: 290px;
    }
}
@media (max-width: 1600px) {
    .app-bar-flex,
    .flex-right {
        padding-left: 165px;
        padding-right: 190px;
    }
}
@media (max-width: 1300px) {
    .app-bar-flex,
    .flex-right {
        padding-left: 105px;
        padding-right: 140px;
    }
}
@media (max-width: 1200px) {
    .app-bar-flex,
    .flex-right {
        padding-left: 40px;
        padding-right: 75px;
    }
}

@media (max-width: 992px) {
    .app-bar-flex,
    .flex-right {
        padding-left: 80px;
        padding-right: 100px;
    }
}

@media (max-width: 768px) {
    .app-bar-flex,
    .flex-right {
        padding-left: 50px;
        padding-right: 60px;
    }
}

@media (max-width: 678px) {
    .app-bar-flex,
    .flex-right {
        padding-left: 0px;
        padding-right: 0px;
    }
}
</style>
