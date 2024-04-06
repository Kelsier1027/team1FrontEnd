<script setup>
import { ref } from 'vue';
import { useMemberStore } from '@/stores/memberStore';
const memberStore = useMemberStore();

// 建立一個名為 links 的物件
const titles = ref([
    { name: '景點門票', url: '/' },
    { name: '全台租車', url: '/rentCar' },
    { name: '套裝行程', url: '/tour' },
    { name: '住宿', url: '/hotel' },
]);
const titlesWhenLogin = ref([
    { name: '景點門票', url: '/' },
    { name: '全台租車', url: '/rentCar' },
    { name: '套裝行程', url: '/tour' },
    { name: '住宿', url: '/hotel' },
    { name: '訂單管理', url: '/orders' },
]);
</script>

<template>
    <v-app-bar :elevation="7" class="" density="compact" flat>
        <v-spacer></v-spacer>
        <v-tabs color="grey-darken-2" centered v-if="!memberStore.isLoggedIn">
            <v-tab
                v-for="title in titles"
                :key="title.name"
                :text="title.name"
                :to="title.url"
                :value="title.name"
            ></v-tab>
        </v-tabs>
        <v-tabs color="grey-darken-2" centered v-if="memberStore.isLoggedIn">
            <v-tab
                v-for="title in titlesWhenLogin"
                :key="title.name"
                :text="title.name"
                :to="title.url"
                :value="title.name"
            ></v-tab>
        </v-tabs>
        <v-spacer></v-spacer>
    </v-app-bar>
</template>

<style scoped>
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

.demo-tabs > .el-tabs__content {
    padding: 32px;
    color: #6b778c;
    font-size: 32px;
    font-weight: 600;
}

:deep(.v-toolbar__content) {
    border-top: 1px solid #e6e6e6 !important;
}
</style>
