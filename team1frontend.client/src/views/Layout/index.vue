<script setup>
import LayoutNav from './components/LayoutNav.vue';
import LayoutHeader from './components/LayoutHeader.vue';
import { computed } from 'vue';
import { useRoute } from 'vue-router';
import Service from './Service/Service.vue';
import Dialogflow from './Service/Dialogflow.vue';
import test from './Service/test.vue';
import Cart from './Service/Cart.vue';

const route = useRoute();

const links = ['熱門目的地', '住宿', '景點門票', '套裝行程', '全台租車'];

// 透過 computed 來判斷是否顯示 Header
const showHeader = computed(() => !route.meta.hideHeader);
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
