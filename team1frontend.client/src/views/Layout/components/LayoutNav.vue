<script setup>
// import { onMounted } from 'vue';
// import test from '/public/assets/js/test';
// onMounted(() => test(window.jQuery));
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
            </div>
        </v-app-bar-title>

        <!-- 使用flex容器包裹右邊的兩個元件，並利用CSS控制排列 -->
        <div class="flex-right">
            <!-- 只在大螢幕上顯示v-avatar，並在小螢幕上隱藏v-app-bar-nav-icon -->
            <v-avatar
                class="hidden-sm-and-down"
                color="grey-darken-1"
                size="32"
            ></v-avatar>
            <v-app-bar-nav-icon
                class="hidden-md-and-up"
                @click.stop="drawer = !drawer"
            ></v-app-bar-nav-icon>
        </div>
    </v-app-bar>

    <v-navigation-drawer v-model="drawer" location="right" temporary>
        <v-list :items="items"></v-list>
    </v-navigation-drawer>
</template>

<script>
export default {
    data: () => ({
        drawer: false,
        items: [
            { title: 'Foo', value: 'foo' },
            { title: 'Bar', value: 'bar' },
            { title: 'Fizz', value: 'fizz' },
            { title: 'Buzz', value: 'buzz' },
        ],
    }),
};
</script>

<style scoped>
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
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
