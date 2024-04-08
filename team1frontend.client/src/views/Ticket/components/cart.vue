<template>
  <el-affix :offset="120" class="affix-container">
    <img class="cartIcon" src="/src/assets/images/chih/shopping-cart.gif" @click="handleClick"
      v-if="memberStore.isLoggedIn == true">
  </el-affix>
  <el-drawer v-model="drawer" :direction="direction">
    <template #header>
      <h4>購物車</h4>
    </template>


    <template #default>

      <v-card>
        <v-tabs v-model="tab" bg-color="primary">
          <v-tab value="one">景點訂票</v-tab>
          <v-tab value="four">全台訂車</v-tab>
          <v-tab value="two">飯店訂房</v-tab>
          <v-tab value="three">套裝行程</v-tab>
        </v-tabs>

        <v-card-text>
          <v-window v-model="tab">
            <v-window-item value="one">
              <div class="cart-item row">
                <div class="item-name col-6">門票</div>
                <div class="item-price col-2">單價</div>
                <div class="item-qty col-2">數量</div>
                <div class="item-del col-2"></div>
              </div>
              <div class="cart-item row" v-for="item in cartList" :key="item.id">
                <div class="item-name col-6">{{ item.cartItem.name }}</div>
                <div class="item-price col-2">{{ item.cartItem.price }}</div>
                <div class="item-qty col-2">{{ item.quantity }}</div>
                <div class="item-del col-2"><button @click="removeItem(item.id)">
                    <svg xmlns="http://www.w3.org/2000/svg" width="20" height="22" fill="currentColor"
                      class="bi bi-trash" viewBox="0 0 16 18">
                      <path
                        d="M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5m2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5m3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0z" />
                      <path
                        d="M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4zM2.5 3h11V2h-11z" />
                    </svg>
                  </button></div>
                <div></div>
              </div>
            </v-window-item>

            <v-window-item value="two">
              <div class="cart-item row">
                <div class="item-name col-4">飯店</div>
                <div class="item-price col-3">房型</div>
                <div class="item-qty col-2">單價</div>
                <div class="item-qty col-1">量</div>
                <div class="item-del col-2"></div>
              </div>

              <div class="cart-item row" v-for="item in cleanItem" :key="item.id">
                <div class="item-name col-4">台南愛莎公寓旅宿</div>
                <div class="item-name col-3">{{ item.cartItem.name }}</div>
                <div class="item-price col-2">{{ item.cartItem.price }}</div>
                <div class="item-qty col-1">{{ item.quantity }}</div>
                <div class="item-del col-2"><button @click="removeItem(item.id)">
                    <svg xmlns="http://www.w3.org/2000/svg" width="20" height="22" fill="currentColor"
                      class="bi bi-trash" viewBox="0 0 16 18">
                      <path
                        d="M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5m2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5m3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0z" />
                      <path
                        d="M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4zM2.5 3h11V2h-11z" />
                    </svg>
                  </button></div>
                <div></div>
              </div>
            </v-window-item>

            <v-window-item value="three">
              <div class="cart-item row">
                <div class="item-name col-4">名稱</div>
                <div class="item-qty col-2">單價</div>
                <div class="col-2"></div>
                <div class="item-del col-2"></div>
              </div>
              <div class="cart-item row" v-for="item in cleanItem3" :key="item.id">
                <div class="item-name col-4">{{ item.cartItem.name }}</div>
                <div class="item-price col-2">{{ item.cartItem.price }}</div>
                <div class="col-2"></div>
                <div class="item-del col-2"><button @click="removeItem(item.id)">
                    <svg xmlns="http://www.w3.org/2000/svg" width="20" height="22" fill="currentColor"
                      class="bi bi-trash" viewBox="0 0 16 18">
                      <path
                        d="M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5m2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5m3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0z" />
                      <path
                        d="M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4zM2.5 3h11V2h-11z" />
                    </svg>
                  </button></div>
                <div></div>
              </div>
            </v-window-item>
            <v-window-item value="four">
              <div class="cart-item row">
                <div class="item-name col-3">車款</div>
                <div class="item-price col-2">總價</div>
                <div class="col-4">時間</div>
                <div class="item-del col-2"></div>
              </div>
              <div class="cart-item row" v-for="item in cleanItem2" :key="item.id">
                <div class="item-name col-3">{{ item.cartItem.name }}</div>
                <div class="item-price col-2">{{ item.cartItem.price }}</div>
                <div class="col-4">04/12-04/17</div>
                <div class="item-del col-2"><button @click="removeItem(item.id)">
                    <svg xmlns="http://www.w3.org/2000/svg" width="20" height="22" fill="currentColor"
                      class="bi bi-trash" viewBox="0 0 16 18">
                      <path
                        d="M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5m2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5m3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0z" />
                      <path
                        d="M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4zM2.5 3h11V2h-11z" />
                    </svg>
                  </button></div>
                <div></div>
              </div>
            </v-window-item>
          </v-window>
        </v-card-text>
      </v-card>
    </template>

    <template #footer>
      <div style="display: flex;" class="row">
        <div class="col-5">總計:NT${{ total }}</div>
        <div style="flex:auto" class="col-7">
          <el-button @click="cancelClick">繼續購買</el-button>
          <el-button type="primary" @click="toCartList">查看購物車</el-button>
        </div>
      </div>

    </template>
  </el-drawer>
</template>

<script setup>
import { ref, onMounted, computed } from 'vue'
import { ElMessageBox } from 'element-plus'
import { getCartByMemberAPI } from '@/apis/Chih/apis/get_cartByMember'
import { useMemberStore } from '@/stores/memberStore';
import { useRouter } from 'vue-router';

import { getcartitem } from '@/apis/Cart/getcartitem';
import { delitem } from '@/apis/Cart/delitem'


const memberStore = useMemberStore();
const router = useRouter();


const drawer = ref(false)
const direction = ref('rtl')
const cartList = ref({});
const cleanItem = ref({})
const cleanItem2 = ref({})
const cleanItem3 = ref({})

const tab = ref(null);

const total = computed(() => {
  let sum = 0
  if (cartList.value.length) {
    cartList.value.forEach(x => {
      sum += x.cartItem.price * x.quantity
    })
  }
  if (cleanItem.value.length) {
    cleanItem.value.forEach(x => {
      sum += x.cartItem.price * x.quantity
    })
  }
  if (cleanItem2.value.length) {
    cleanItem2.value.forEach(x => {
      sum += x.cartItem.price * x.quantity
    })
  }
  if (cleanItem3.value.length) {
    cleanItem3.value.forEach(x => {
      sum += x.cartItem.price * x.quantity
    })
  }

  return sum
})
console.log(total.value);


//get cart info
const useCart = async () => {
  const res = await getcartitem(1, 1);
  cartList.value = res;
  console.log(res);
};
const useCart2 = async () => {
  const res = await getcartitem(1, 2);
  cleanItem.value = res;
  console.log(res);
};
const useCart3 = async () => {
  const res = await getcartitem(1, 3);
  cleanItem3.value = res;
  console.log(res);
};
const useCart4 = async () => {
  const res = await getcartitem(1, 4);
  cleanItem2.value = res;
  console.log(res);
};
const removeItem = async (id) => {
  await delitem(id)
  await useCart();
  await useCart2();
  await useCart3();
  await useCart4();
}

function handleClick() {
  drawer.value = true;
  useCart();
  useCart2();
  useCart3();
  useCart4();
}
function cancelClick() {
  drawer.value = false;
}
function toCartList() {
  router.push('/cartList')
}

function confirmClick() {
  ElMessageBox.confirm(`確認結帳`)
    .then(() => {
      router.push('/attraction_order');
    })
    .catch(() => {
      // catch error
    })
}

onMounted(async () => useCart());
onMounted(async () => useCart2());
onMounted(async () => useCart4());
onMounted(async () => useCart3());


</script>


<style scoped>
/* .all-item{
    border: 2px solid pink;
    padding: 2px;  
} */
.item-name {

  text-align: left;
}

.item-price {

  text-align: left;
}

.item-qty {

  text-align: center;
}

.cartIcon {
  width: 100px;
  height: 100px;
}

.cartIcon:hover {
  cursor: pointer;
}

.affix-container {
  position: fixed;
  right: 20px;
  top: 120px;
  z-index: 1001
}
</style>