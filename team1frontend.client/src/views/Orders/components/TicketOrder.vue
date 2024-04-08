<template>
    <v-list :items="ticketOrders" item-props>
        <v-list-item v-for="order in ticketOrders" :key="order.id">
            <v-list-item-content class="">
                <v-row>
                    <v-col cols="3" class="d-flex align-top justify-start">
                        <v-img :src="order.photo" height="72px"></v-img>
                    </v-col>
                    <v-col cols="7" class="d-flex justify-start flex-column">
                        <v-list-item-title class="mt-2 font-weight-bold">{{
                            order.name
                        }}</v-list-item-title>
                        <v-list-item-subtitle class="font-weight-medium">{{
                            order.detail
                        }}</v-list-item-subtitle>
                    </v-col>
                    <v-col cols="2">
                        <v-list-item-subtitle
                            class="fontFamily"
                            style="color: #5cbbc7; font-weight: 900"
                            ><span>TWD</span>{{ ' '
                            }}{{ order.total }}</v-list-item-subtitle
                        >
                    </v-col>
                </v-row>
            </v-list-item-content>
        </v-list-item>
    </v-list>
</template>

<script setup>
import { ref } from 'vue';

const ticketOrders = ref([
    {
        id: 1,
        photo: 'https://fakeimg.pl/300/',
        date: '2024-10-10',
        name: '劍湖山樂園',
        detail: '詳細資訊',
        ticket: '全票',
        quantity: 2,
        price: 2000,
        total: 4000,
        status: '已付款',
        action: '查看',
    },
    {
        id: 2,
        photo: 'https://fakeimg.pl/300/',
        date: '2024-10-10',
        name: '劍湖山樂園',
        detail: '詳細資訊',
        ticket: '全票',
        quantity: 2,
        price: 2000,
        total: 4000,
        status: '已付款',
        action: '查看',
    },
    {
        id: 3,
        photo: 'https://fakeimg.pl/300/',
        date: '2024-10-10',
        name: '劍湖山樂園',
        detail: '詳細資訊',
        ticket: '全票',
        quantity: 2,
        price: 2000,
        total: 4000,
        status: '已付款',
        action: '查看',
    },
]);
</script>

<style scoped></style>
