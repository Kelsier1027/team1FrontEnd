<script setup>
import LayoutNav from './components/LayoutNav.vue';
import LayoutHeader from './components/LayoutHeader.vue';
import Service from './components/Service.vue';

const links = ['熱門目的地', '住宿', '景點門票', '套裝行程', '全台租車'];
</script>

<template>
    <LayoutNav />
    <LayoutHeader />    
    <RouterView />
    <Service/>
</template>

<script></script>
