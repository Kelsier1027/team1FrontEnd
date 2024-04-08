<template>
    <v-table theme="">
        <thead>
            <tr class="">
                <th class="text-center font-weight-black">飯店名稱</th>
                <th class="text-center font-weight-black">入住時間</th>
                <th class="text-center font-weight-black">退房時間</th>
                <th class="text-center font-weight-black">房型</th>
                <th class="text-center font-weight-black">入住人數</th>
                <th class="text-center font-weight-black">數量</th>
                <th class="text-center font-weight-black">單價</th>
                <th class="text-center font-weight-black">總價</th>
                <th class="text-center font-weight-black">狀態</th>
                <!-- <th class="text-left">操作</th> -->
            </tr>
        </thead>
        <tbody>
            <tr v-for="item in hotelOrders" :key="item.name">
                <td class="text-center" :style="{ minWidth: '100px' }">
                    {{ item.name }}
                </td>
                <td class="text-center">{{ item.checkin }}</td>
                <td class="text-center">{{ item.checkout }}</td>
                <!-- <td>{{ item.detail }}</td> -->
                <td class="text-center">{{ item.type }}</td>
                <td class="text-center">{{ item.member }}</td>
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

const hotelOrders = ref([
    {
        name: '台北君悅酒店',
        checkin: '2024-02-01',
        checkout: '2024-02-03',
        type: '豪華房',
        member: 2,
        quantity: 1,
        price: 8000,
        total: 8000,
        status: '已付款',
        color: 'green',
    },
    {
        name: '台中日勝生酒店',
        checkin: '2024-05-15',
        checkout: '2024-05-17',
        type: '商務房',
        member: 4,
        quantity: 2,
        price: 5000,
        total: 10000,
        status: '已付款',
        color: 'green',
    },
    {
        name: '高雄國賓大飯店',
        checkin: '2024-08-20',
        checkout: '2024-08-22',
        type: '家庭房',
        member: 4,
        quantity: 1,
        price: 6000,
        total: 6000,
        status: '未付款',
        color: 'red',
    },
    {
        name: '台南晶英酒店',
        checkin: '2024-09-01',
        checkout: '2024-09-03',
        type: '家庭房',
        member: 3,
        quantity: 1,
        price: 7000,
        total: 7000,
        status: '未付款',
        color: 'red',
    },
]);
</script>

<style scoped>
:deep(.v-row) {
    width: 800px !important;
}
</style>
