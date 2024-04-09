<template>
    <v-card width="400px" class="d-flex flex-column floatingCard">
        <v-list v-if="cartItems.length > 0" class="m-1">
            <v-list-item v-for="item in cartItems" :key="item.id">
                <div class="">
                    <v-row>
                        <v-col cols="3" class="d-flex align-top justify-start">
                            <v-img :src="item.photo" height="72px"></v-img>
                        </v-col>
                        <v-col
                            cols="7"
                            class="d-flex justify-start flex-column"
                        >
                            <v-list-item-title class="mt-2 font-weight-bold">{{
                                item.name
                            }}</v-list-item-title>
                            <v-list-item-subtitle class="font-weight-medium">{{
                                item.detail
                            }}</v-list-item-subtitle>
                            <v-list-item-subtitle
                                class="fontFamily"
                                style="color: #5cbbc7; font-weight: 900"
                                >TWD{{ ' '
                                }}{{ item.price }}</v-list-item-subtitle
                            >
                        </v-col>
                        <v-col
                            cols="2"
                            class="d-flex justify-end align-top mt-1"
                        >
                            <v-btn
                                variant="text"
                                size="small"
                                icon="mdi-trash-can-outline"
                            ></v-btn>
                        </v-col>
                    </v-row>
                </div>
            </v-list-item>
        </v-list>

        <v-spacer></v-spacer>
        <v-card-item
            v-if="cartItems.length === 0"
            class="d-flex justify-center"
        >
            <v-img
                :src="cartIcon"
                width="132px"
                class="d-flex justify-center"
            ></v-img>
            <div class="text-center fontFamily cartEmptyMessasge">
                您的購物車是空的
            </div>
        </v-card-item>

        <v-spacer></v-spacer>
        <v-divider class="m-0"></v-divider>
        <div class="m-3">
            <v-row class="d-flex justify-space-between align-center">
                <v-col class="d-flex justify-start" col="auto"
                    >共 3 件商品</v-col
                >
                <v-col class="d-flex justify-end" col="auto"
                    ><v-btn class="btn fontFamily">查看購物車</v-btn></v-col
                >
            </v-row>
        </div>
    </v-card>
</template>

<script setup>
import { ref } from 'vue';
import cartIcon from '@/assets/Icons/shopping_cart.svg';

const cartItems = ref([
    {
        id: 1,
        photo: 'https://fakeimg.pl/300/',
        name: '劍湖山世界',
        detail: '成人門票',
        price: 600,
        quantity: 1,
    },
    {
        id: 2,
        photo: 'https://fakeimg.pl/300/',
        name: '九族文化村',
        detail: '成人門票',
        price: 700,
        quantity: 1,
    },
    {
        id: 3,
        photo: 'https://fakeimg.pl/300/',
        name: '麗寶樂園',
        detail: '成人門票',
        price: 900,
        quantity: 1,
    },
]);
</script>

<style scoped>
:deep(.cartEmptyMessasge) {
    font-weight: 900;
    color: #b2b2b2;
}
:deep(.btn) {
    font-weight: 500;
    font-size: 14px;
    color: white;
    border-radius: 5px;
    background-color: #5cbbc7;
    transition: background-color 0.3s;
}
:deep(.btn:hover) {
    background-color: #428c8c;
    color: white;
    font-size: 16px;
}
:deep(.fontFamily) {
    font-family: 'Noto Sans TC', '微软雅黑', 'Microsoft YaHei', 'sans-serif';
    /* border-bottom: 1px solid #dfdfdf; */
}
</style>
