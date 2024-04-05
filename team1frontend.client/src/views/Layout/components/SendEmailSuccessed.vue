<template>
    <v-card-title
        class="justify-center text-center text-h5 mb-8 fontFamily"
        style="margin-top: -4px"
        >已發送密碼重置信件
    </v-card-title>
    <v-btn
        type="button"
        class="mb-11 check-btn"
        size="large"
        variant="tonal"
        block
        @click="closeDialog"
        style="margin-top: 0"
    >
        <span class="fontFamily">了解</span>
    </v-btn>
</template>

<script setup>
const emit = defineEmits(['notify-close-dialog']);
function closeDialog() {
    emit('notify-close-dialog');
}
</script>

<style scoped>
:deep(.fontFamily) {
    font-family: 'Noto Sans TC', '微软雅黑', 'Microsoft YaHei', 'sans-serif';
    /* border-bottom: 1px solid #dfdfdf; */
}
.check-btn {
    font-weight: 500;
    font-size: 14px;
    color: white;
    border-radius: 5px;
    background-color: #5cbbc7;
    transition: background-color 0.3s;
    margin-bottom: 100px;
}
.check-btn:hover {
    background-color: #428c8c;
    font-size: 16px;
}
</style>
