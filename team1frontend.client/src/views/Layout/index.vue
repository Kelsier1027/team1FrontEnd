<script setup>
import { ref, onMounted } from 'vue';
import LayoutNav from './components/LayoutNav.vue';
import LayoutHeader from './components/LayoutHeader.vue';
import { computed } from 'vue';
import Dialogflow from './Service/Dialogflow.vue';

import { useRoute, useRouter } from 'vue-router';
import { useMemberStore } from '@/stores/memberStore';
const memberStore = useMemberStore();
const router = useRouter();
const route = useRoute();
//import test from './Service/test.vue';
//import Cart from './Service/Cart.vue';

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
        // 如果沒有值，並且在 /member 之下的路由，則導回首頁
        console.log('目前為未登入狀態');
        if (route.path.includes('/member')) {
            router.push('/');
        }
    }
});
</script>

<template>
    <LayoutNav />
    <LayoutHeader v-if="showHeader" />
    <RouterView />
</template>

<script></script>
