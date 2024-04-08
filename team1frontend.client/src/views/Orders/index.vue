<template>
    <v-card
        height="auto"
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
                訂單管理
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
                value="ticketOrder"
                class="fontFamily tabTitle"
                style="margin-left: 20px"
                >門票</v-tab
            >
            <v-tab value="carOrder" class="fontFamily tabTitle">租車</v-tab>
            <v-tab value="hotelOrder" class="fontFamily tabTitle">住宿</v-tab>
        </v-tabs>
        <v-card-text style="padding-top: 0">
            <v-window v-model="tab">
                <v-window-item value="ticketOrder">
                    <TicketOrder />
                </v-window-item>

                <v-window-item value="carOrder">
                    <CarOrder />
                </v-window-item>

                <v-window-item value="hotelOrder">
                    <HotelOrder />
                </v-window-item>
            </v-window>
        </v-card-text>
    </v-card>
</template>

<script setup>
import { ref, computed } from 'vue';
import TicketOrder from './components/TicketOrder.vue';
import CarOrder from './components/CarOrder.vue';
import HotelOrder from './components/HotelOrder.vue';

const tab = ref(null);
</script>

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
:deep(.v-slide-group-item--active) {
    border-bottom: 4px solid #398b8f;
}
</style>
