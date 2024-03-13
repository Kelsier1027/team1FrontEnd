<script setup>
import { ref } from 'vue';
// 建立一個名為 links 的物件
const titles = ref([
    { name: '熱門目的地', url: '/home' },
    { name: '住宿', url: '/hotel' },
    { name: '景點門票', url: '/ticket' },
    { name: '套裝行程', url: '/tour' },
    { name: '全台租車', url: '/rentCar' },
]);
</script>

<script>
export default {
    // data: () => ({
    //     names: ['熱門目的地', '住宿', '景點門票', '套裝行程', '全台租車'],
    // }),
};
</script>

<template>
    <v-app-bar class="px-3" density="compact" flat>
        <v-spacer></v-spacer>

        <v-tabs color="grey-darken-2" centered>
            <v-tab
                v-for="title in titles"
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
</style>
