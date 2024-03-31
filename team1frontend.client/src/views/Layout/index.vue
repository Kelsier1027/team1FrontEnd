<script setup>
import { ref, onMounted } from 'vue';
import LayoutNav from './components/LayoutNav.vue';
import LayoutHeader from './components/LayoutHeader.vue';
import { computed } from 'vue';
import Dialogflow from './Service/Dialogflow.vue';

import { useRoute, useRouter } from 'vue-router';
import Service from './Service/Service.vue';
import { useMemberStore } from '@/stores/memberStore';
const memberStore = useMemberStore();
const router = useRouter();
const route = useRoute();
import test from './Service/test.vue';
import Cart from './Service/Cart.vue';


const links = ['熱門目的地', '住宿', '景點門票', '套裝行程', '全台租車'];

// 透過 computed 來判斷是否顯示 Header
const showHeader = computed(() => !route.meta.hideHeader);

// 在 mounted 時執行
onMounted(async () => {
    // 叫用 getMemberInfo 方法
    await memberStore.getMemberInfo();

    // 檢查 memberStore 中的 account 是否有值
    if (memberStore.account) {
        console.log('目前為登入狀態');
    } else {
        // 如果沒有值，則導回首頁
        router.push('/'); // router 這個方法是 vue-router 提供的
    }
});
</script>

<template>
    <LayoutNav />
    <LayoutHeader v-if="showHeader" />
    <RouterView />
    <!-- <Service/> -->
    <Dialogflow/>
    <Cart/>
    <test/>
    
</template>

<script></script>
