<template>
    <v-table theme="">
        <thead>
            <tr class="">
                <th class="text-center font-weight-black">門票名稱</th>
                <th class="text-center font-weight-black">有效期限</th>
                <!-- <th class="text-left">詳細資訊</th> -->
                <th class="text-center font-weight-black">票種</th>
                <th class="text-center font-weight-black">數量</th>
                <th class="text-center font-weight-black">單價</th>
                <th class="text-center font-weight-black">總價</th>
                <th class="text-center font-weight-black">狀態</th>
                <!-- <th class="text-left">操作</th> -->
            </tr>
        </thead>
        <tbody>
            <tr v-for="item in ticketOrders" :key="item.name">
                <td class="text-center">{{ item.name }}</td>
                <td class="text-center">{{ item.date }}</td>
                <!-- <td>{{ item.detail }}</td> -->
                <td class="text-center">{{ item.ticket }}</td>
                <td class="text-center">{{ item.quantity }}</td>
                <td class="text-center">{{ item.price }}</td>
                <td class="text-center">{{ item.total }}</td>
                <td
                    class="text-center font-weight-black"
                    style="font-size: 18px"
                    :style="{ color: item.color }"
                >
                    {{ item.status }}
                </td>
                <!-- <td>{{ item.action }}</td> -->
            </tr>
        </tbody>
    </v-table>
</template>
<script setup>
import { computed, ref } from 'vue';

const ticketOrders = ref([
    {
        id: 0,
        photo: 'https://fakeimg.pl/300/',
        date: '2024-02-01',
        name: '義大遊樂世界',
        detail: '詳細資訊',
        ticket: '全票',
        quantity: 3,
        price: 800,
        total: 2400,
        status: '已過期',
        color: 'red',
        action: '查看',
    },
    {
        id: 1,
        photo: 'https://fakeimg.pl/300/',
        date: '2024-05-15',
        name: '劍湖山樂園',
        detail: '詳細資訊',
        ticket: '全票',
        quantity: 2,
        price: 600,
        total: 1200,
        status: '已使用',
        color: 'gray',
        action: '查看',
    },
    {
        id: 2,
        photo: 'https://fakeimg.pl/300/',
        date: '2024-08-01',
        name: '台北101觀景台',
        detail: '詳細資訊',
        ticket: '全票',
        quantity: 4,
        price: 400,
        total: 1600,
        status: '已付款',
        color: 'green',
        action: '查看',
    },
    // {
    //     id: 3,
    //     photo: 'https://fakeimg.pl/300/',
    //     date: '2024-12-13',
    //     name: 'Xpark水生公園',
    //     detail: '詳細資訊',
    //     ticket: '全票',
    //     quantity: 1,
    //     price: 300,
    //     total: 300,
    //     status: '已付款',
    //     color: 'green',
    //     action: '查看',
    // },
]);
</script>

<style scoped>
:deep(.v-row) {
    width: 800px !important;
}
</style>
