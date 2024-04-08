<template>
    <v-main>
        <div class="d-flex justify-content-center">
            <div>
                <h2 class="mt-12">商品列表</h2>
                <v-divider></v-divider>
                <input class="mb-5" type="checkbox" v-model="selectAll" @change="toggleSelectAll"> 全選
                <ul>
                    <li style="list-style-type: none;" v-for="item in cartList" :key="item.id">
                        <div style=" margin-bottom: 10px; display: flex; align-items: center;">
                            <v-card style="margin-right: 10px;width: 1200px;" variant="outlined">
                                <v-row class="mt-5" align="center">
                                    <v-col cols="auto">
                                        <!-- <input type="checkbox" v-model="isChecked" class="checkBoxInput" @change="updateSelectAll"> -->
                                        <input type="checkbox" v-model="item.selected" class="checkBoxInput"
                                            :id="`${item.id}`" @change="updateSelectAll">
                                    </v-col>
                                    <v-col cols="">
                                        <img :src="`src/assets/images/huang/${item.cartItem.fileName}`" alt="Your Image"
                                            style="width: 200px;">
                                    </v-col>
                                    <v-col cols="4">
                                        <v-card-title>
                                            {{ item.cartItem.name }}
                                        </v-card-title>
                                    </v-col>
                                    <v-col cols="5">
                                        <v-card-text v-if="item.categoryId === 4">
                                            費用不包含燃油費、停車費、高速公路過路費與甲租乙還費用。高速公路過路費(ETC)：收費規定將依照取車店家現場說明指示如需攜帶寵物，請事先洽詢客服;未事先告知，店家將保留出租權益。
                                        </v-card-text>
                                        <v-card-text v-if="item.categoryId === 2">
                                            這是一家位於城市中心的時尚飯店，擁有舒適的客房和豪華的設施。飯店提供各種房型，包括單人間、雙人間和套房，以滿足不同客人的需求。每個房間都配備了現代化的設施，如空調、免費無線網絡、迷你冰箱和平板電視。飯店還設有一間風格獨特的餐廳，供應精緻美食和飲料。此外，飯店還擁有健身中心、室內游泳池和會議設施，為客人提供一站式服務。
                                        </v-card-text>
                                        <v-card-text v-if="item.categoryId === 3">
                                            響應環保~客房浴室不提供拋棄式備品喔! (牙膏/牙刷/梳子/刮鬍
                                            刀/浴帽/棉花棒等)，旅客請自行攜帶!!! 讓我們一起為地球盡一
                                            份心力吧~<br />
                                            海景風呂溫泉RF樓，需從10F走樓梯上樓，電梯無法到達，敬
                                            請知悉！
                                            <br />
                                            早餐：敬請自理
                                            午餐：頭城老街自理午餐
                                            晚餐：頭城農場晚餐
                                        </v-card-text>
                                        <v-card-text v-if="item.categoryId === 1">
                                            {{ item.cartItem.detail }}
                                        </v-card-text>
                                    </v-col>
                                    <v-col cols="2">
                                        <v-card-text style="font-size: 16px;">
                                            數量: {{ `${item.quantity}` }}
                                        </v-card-text>
                                    </v-col>
                                    <v-col cols="2">
                                        <v-card-text style="font-size: 16px;">
                                            單價: {{ `${item.cartItem.price}` }}
                                        </v-card-text>
                                    </v-col>
                                </v-row>
                            </v-card>
                            <button @click="removeItem(item.id)">
                                <svg xmlns="http://www.w3.org/2000/svg" width="20" height="22" fill="currentColor"
                                    class="bi bi-trash" viewBox="0 0 16 18">
                                    <path
                                        d="M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5m2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5m3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0z" />
                                    <path
                                        d="M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4zM2.5 3h11V2h-11z" />
                                </svg>
                            </button>
                        </div>
                    </li>
                </ul>
                <button v-if="hasSelectedItems" @click="removeSelectedItems">删除選擇的商品</button>

                <div class="action border rounded">
                    <div class="batch">
                        <span class="red">總計:NT${{ total }}</span>
                    </div>
                    <div class="total">
                        <el-button size="large" type="primary" @click="checkOut">下單結算</el-button>
                    </div>
                </div>
                <v-divider></v-divider>
            </div>
        </div>
    </v-main>
</template>

<script setup>
import { ref, computed, onMounted } from 'vue';
import { createOrder } from '@/apis/Cart/createOrder'
import { getcartitem } from '@/apis/Cart/getcartitem';
import { delitem } from '@/apis/Cart/delitem'
import { GetOrderAPI } from '@/apis/CarModel/Order'
import { useRouter } from 'vue-router';
const router = useRouter()
const isChecked = ref(false);
let cartList = ref([]);

const checkOut = async () => {
    const ids = cartList.value.map(x => x.id)
    const res = await createOrder(ids)
    console.log(res)
    const response = await GetOrderAPI(res)
    console.log(response);
    router.push({
        path: '/toecpay',
        name: 'toecpay',
        params: {
            str: JSON.stringify(response)
        }
    })
}
const useCart = async () => {
    const res = await getcartitem(1, 0);
    cartList.value = res;
    console.log(cartList.value);
};
onMounted(() => useCart());

const removeItem = async (id) => {
    await delitem(id)
    await useCart();
}

const total = computed(() => {
    let sum = 0
    if (cartList.value.length) {
        cartList.value.forEach(x => {
            sum += x.cartItem.price * x.quantity
        })
    }
    return sum
})

const removeSelectedItems = () => {
    for (let i = items.value.length - 1; i >= 0; i--) {
        // 如果项目被选中，则从数组中删除它
        if (items.value[i].selected) {
            console.log(items.value.splice(i, 1));
        }
    }
};

const hasSelectedItems = computed(() => {
    return cartList.value.some(item => item.selected);
});

const selectAll = ref(false);

const toggleSelectAll = () => {
    if (selectAll.value) {
        cartList.value.forEach((cartList) => {
            cartList.selected = true;
        })
    }
    else {
        cartList.value.forEach((cartList) => {
            cartList.selected = false;
        })
    };

};

const updateSelectAll = () => {
    selectAll.value = cartList.value.every(item => item.selected);
};
</script>

<style scope>
.action {
    display: flex;
    margin-top: 20px;
    margin-left: 36px;
    height: 80px;
    align-items: center;
    font-size: 16px;
    justify-content: space-between;
    padding: 0 30px;
    width: 1200px;
    border-color: black;


    .batch {
        a {
            margin-left: 20px;
        }
    }

    .red {
        font-size: 18px;
        margin-right: 20px;
        font-weight: bold;
    }
}
</style>