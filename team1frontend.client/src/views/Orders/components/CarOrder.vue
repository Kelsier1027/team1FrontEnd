<script setup>
import { ref } from 'vue';
// 導入監聽響應式變數的函數
import { watch } from 'vue';
import { useMemberStore } from '@/stores/memberStore';
import { useRoute, useRouter } from 'vue-router';
// 使用 useRoute 函數來獲取當前路由實例
const route = useRoute();
// 使用 useRouter 函數來獲取 router 實例
const router = useRouter();
// 使用 useMemberStore 函數來獲取 memberStore 實例
const memberStore = useMemberStore();
// 使用 watch 監聽 memberStore 的 isLoggedIn 變數 是否變化為 false
watch(
    () => memberStore.isLoggedIn,
    (isLoggedIn) => {
        // 如果 isLoggedIn 變為 false，則跳轉到登入頁面
        if (!isLoggedIn) {
            // 使用 router.push 方法跳轉到登入頁面
            router.push({ name: 'Home' });
        }
    }
);
const text = ref(0);
const carOrders = ref([]);
carOrders.value = [
    {
        orderId: 13244231,
        orderDate: '2024-02-01',
        carName: 'BMW-X5',
        pickUpTime: '2024-02-01',
        returnTime: '2024-02-03',
        price: 8000,
        status: '已付款',
        color: 'green',
    },
    {
        orderId: 43235452,
        orderDate: '2024-05-15',
        carName: 'Benz-SL500',
        pickUpTime: '2024-05-15',
        returnTime: '2024-05-17',
        price: 5000,
        status: '已付款',
        color: 'green',
    },
    {
        orderId: 33243212,
        orderDate: '2024-08-20',
        carName: 'Audi-A8',
        pickUpTime: '2024-08-20',
        returnTime: '2024-08-22',
        price: 6000,
        status: '未付款',
        color: 'red',
    },
    {
        orderId: 45223414,
        orderDate: '2024-09-01',
        carName: 'Toyota-Camry',
        pickUpTime: '2024-09-01',
        returnTime: '2024-09-03',
        price: 7000,
        status: '未付款',
        color: 'red',
    },
];
</script>

<template>
    <div class="row">
        <div class="col-0"></div>
        <div class="col-12">
            <!-- <h1 class="font-weight-black ma-6">訂單管理</h1> -->
            <div class="d-flex justify-center mt-4" style="">
                <!-- <v-btn-toggle
                    v-model="text"
                    color="blue-accent-3"
                    rounded="0"
                    group
                    style=""
                > -->
                <v-btn-toggle
                    v-model="text"
                    group
                    style=""
                    color="#00b9c6"
                    class="v-btn-toggle"
                >
                    <!-- <v-btn
                        border
                        value="left"
                        rounded="lg"
                        style="
                            margin-right: 20px;
                            font-size: 20px;
                            background-color: #e7e7e7f1;
                        "
                    >
                        未取車
                    </v-btn>

                    <v-btn
                        border
                        value="center"
                        rounded="lg"
                        style="
                            margin-right: 20px;
                            font-size: 20px;
                            background-color: #e7e7e7f1;
                        "
                    >
                        已取車
                    </v-btn>

                    <v-btn
                        border
                        value="right"
                        rounded="lg"
                        style="
                            margin-right: 20px;
                            font-size: 20px;
                            background-color: #e7e7e7f1;
                        "
                    >
                        已還車
                    </v-btn>

                    <v-btn
                        border
                        value="justify"
                        rounded="lg"
                        style="
                            margin-right: 20px;
                            font-size: 20px;
                            background-color: #e7e7e7f1;
                        "
                    >
                        未付款
                    </v-btn> -->
                    <v-btn
                        variant="text"
                        class="font-weight-black"
                        style="font-size: 20px; border-right: 1px solid white"
                    >
                        所有訂單
                    </v-btn>
                    <v-btn
                        variant="text"
                        class="font-weight-black"
                        style="font-size: 20px; border-right: 1px solid white"
                    >
                        未取車
                    </v-btn>

                    <v-btn
                        variant="text"
                        class="font-weight-black"
                        style="font-size: 20px; border-right: 1px solid white"
                    >
                        已取車
                    </v-btn>

                    <v-btn
                        variant="text"
                        value="right"
                        class="font-weight-black"
                        style="font-size: 20px; border-right: 1px solid white"
                    >
                        已還車
                    </v-btn>

                    <v-btn
                        variant="text"
                        class="font-weight-black"
                        style="font-size: 20px"
                    >
                        未付款
                    </v-btn>
                </v-btn-toggle>
            </div>
            <div class="mt-1">
                <v-table>
                    <thead>
                        <!-- <tr style="background-color: #e7e7e7f1; height: 70px"> -->
                        <tr style="background-color: white; height: 70px">
                            <th class="text-center font-weight-black text-h6">
                                租車單號
                            </th>
                            <th class="text-center font-weight-black text-h6">
                                下訂日期
                            </th>
                            <th class="text-center font-weight-black text-h6">
                                租賃車輛
                            </th>
                            <th class="text-center font-weight-black text-h6">
                                取車時間
                            </th>
                            <th class="text-center font-weight-black text-h6">
                                還車時間
                            </th>
                            <th class="text-center font-weight-black text-h6">
                                租車費用
                            </th>
                            <th class="text-center font-weight-black text-h6">
                                訂單處理
                            </th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr v-for="item in carOrders" :key="item.name">
                            <td class="text-center">{{ item.orderId }}</td>
                            <td class="text-center">{{ item.orderDate }}</td>
                            <td class="text-center">{{ item.carName }}</td>
                            <td class="text-center">{{ item.pickUpTime }}</td>
                            <td class="text-center">{{ item.returnTime }}</td>
                            <td class="text-center">{{ item.price }}</td>
                            <td
                                class="text-center font-weight-black"
                                style="font-size: 18px"
                                :style="{ color: item.color }"
                            >
                                {{ item.status }}
                            </td>
                        </tr>
                    </tbody>
                </v-table>
            </div>
        </div>
        <div class="col-2"></div>
    </div>
</template>

<style scoped>
.v-btn-toggle {
    background-color: #f1f1f1f1;
    /* color: #398b8f; */
    color: #8d8d8d;
}
</style>
