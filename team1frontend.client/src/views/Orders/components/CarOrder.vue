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
const text = ref();
const desserts = ref([]);
desserts.value = [
    {
        name: 'Frozen Yogurt',
        calories: 159,
    },
    {
        name: 'Ice cream sandwich',
        calories: 237,
    },
    {
        name: 'Eclair',
        calories: 262,
    },
    {
        name: 'Cupcake',
        calories: 305,
    },
    {
        name: 'Gingerbread',
        calories: 356,
    },
    {
        name: 'Jelly bean',
        calories: 375,
    },
    {
        name: 'Lollipop',
        calories: 392,
    },
    {
        name: 'Honeycomb',
        calories: 408,
    },
    {
        name: 'Donut',
        calories: 452,
    },
    {
        name: 'KitKat',
        calories: 518,
    },
];
</script>

<template>
    <div class="row">
        <div class="col-0"></div>
        <div class="col-12">
            <!-- <h1 class="font-weight-black ma-6">訂單管理</h1> -->
            <div class="d-flex justify-center mt-3" style="">
                <v-btn-toggle
                    v-model="text"
                    color="blue-accent-3"
                    rounded="0"
                    group
                    style=""
                >
                    <v-btn
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
                    </v-btn>
                </v-btn-toggle>
            </div>
            <div class="mt-5">
                <v-table>
                    <thead>
                        <tr style="background-color: #e7e7e7f1; height: 70px">
                            <th class="text-left text-h6">租車單號</th>
                            <th class="text-left text-h6">下訂日期</th>
                            <th class="text-left text-h6">租賃車輛</th>
                            <th class="text-left text-h6">取車時間</th>
                            <th class="text-left text-h6">還車時間</th>
                            <th class="text-left text-h6">租車費用</th>
                            <th class="text-left text-h6">訂單處理</th>
                        </tr>
                    </thead>
                    <tbody>
                        <!-- <tr
                                v-for="item in desserts"
                                :key="item.name"
                            >
                                <td>{{ item.name }}</td>
                                <td>{{ item.calories }}</td>
                            </tr> -->
                    </tbody>
                </v-table>
            </div>
        </div>
        <div class="col-2"></div>
    </div>
</template>

<style scoped></style>
