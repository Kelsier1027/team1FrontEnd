<script setup>
import { ref, computed } from 'vue';
import Information from './Information.vue';

const tab = ref(null);
</script>

<template>
    <v-card
        height="807.5"
        variant="flat"
        style="background-color: rgb(255, 255, 255)"
    >
        <v-card-item style="padding: 0">
            <v-card-title
                class="fontFamily"
                style="
                    font-weight: 700;
                    font-size: 24px;
                    padding: 32px 20px 20px 20px;
                "
            >
                帳號設定
            </v-card-title>
        </v-card-item>
        <v-tabs
            class="tabs"
            v-model="tab"
            bg-color=""
            color="#398b8f"
            hide-slider
            style="border-bottom: 1px solid #dfdfdf"
        >
            <v-tab
                value="basicInformation"
                class="fontFamily tabTitle"
                style="margin-left: 20px"
                >基本資料</v-tab
            >
            <v-tab value="frequentTravelers" class="fontFamily tabTitle"
                >常用旅客</v-tab
            >
            <v-tab value="accountSafety" class="fontFamily tabTitle"
                >帳號安全</v-tab
            >
        </v-tabs>
        <v-card-text style="padding-top: 0">
            <v-window v-model="tab">
                <v-window-item value="basicInformation">
                    <Information />
                </v-window-item>

                <v-window-item value="frequentTravelers">
                    常用旅客
                </v-window-item>

                <v-window-item value="accountSafety"> 帳號安全 </v-window-item>
            </v-window>
        </v-card-text>
    </v-card>
</template>

<style scoped>
:deep(.fontFamily) {
    font-family: 'Noto Sans TC', '微软雅黑', 'Microsoft YaHei', 'sans-serif';
    /* border-bottom: 1px solid #dfdfdf; */
}
:deep(.tabTitle) {
    font-weight: 900;
    font-size: 14px;
    color: gray;
}
</style>

<script></script>
