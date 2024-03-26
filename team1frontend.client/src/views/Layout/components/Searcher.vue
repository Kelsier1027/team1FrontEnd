<template>
    <v-text-field
        class=""
        clearable
        clear-icon="mdi-close"
        placeholder="搜尋景點、地區或城市"
        variant="solo"
        flat
        bg-color="#f5f5f5"
        rounded="2"
        density="compact"
        append-inner-icon="mdi-magnify"
        width="1140px"
    ></v-text-field>
</template>

<script setup></script>

<style scoped>
:deep(.v-field__input) {
    font-size: 14px !important;
    font-family: 'Noto Sans TC', 微软雅黑, 'Microsoft YaHei', sans-serif !important;
    font-weight: 400 !important;
    color: rgb(51, 51, 51) !important;
}
</style>
