<template lang="">
    <el-affix :offset="120" class="affix-container">
    <img class="cartIcon" src="/src/assets/images/chih/shopping-cart.gif" @click="drawer=true">
  </el-affix>
    <el-drawer v-model="drawer" :direction="direction">
    <template #header>
      <h4>你媽的購物車</h4>
    </template>

<template #default>

      <!-- v-for 購物清單  cart-item 預設樣式?-->
      <div class="cart-item row">
        <div class="item-name col-6">門票</div>
        <div class="item-price col-3">單價</div>
        <div class="item-qty col-3">數量</div>
      </div>
      <div class="cart-item row" v-for="item in cleanItem" :key="item.id">
        
        <div class="item-name col-6">{{item.ticketName}}</div>
        <div class="item-price col-3">{{item.price}}</div>
        <div class="item-qty col-3">{{item.qty}}</div>
        <div></div>
        
      </div>
      <div>{{cleanItem}}</div>
     
    
    </template>

<template #footer>
      <div style="flex: auto">
        <el-button @click="cancelClick">繼續</el-button>
        <el-button type="primary" @click="confirmClick">結帳</el-button>
      </div>
    </template>
</el-drawer>
</template>

<script setup>
import { ref, onMounted } from 'vue'
import { ElMessageBox } from 'element-plus'
import { getCartByMemberAPI } from '@/apis/Chih/apis/get_cartByMember'


const drawer = ref(false)
const direction = ref('rtl')
const cartList = ref({});
const id = 2;
const cleanItem = ref({})

//get cart info
const useCart = async () => {
  const res = await getCartByMemberAPI(id);
  cartList.value = res;
  console.log(res);
  cleanItem.value = res[0].cartItems.map(item => ({
    id: item.id,
    ticketName: item.ticketName.trim(), // 清理 ticketName 字段
    qty: item.qty,
    price: item.price,
  }))
  console.log(cleanItem.value);

};



function cancelClick() {
  drawer.value = false;
}

function confirmClick() {
  ElMessageBox.confirm(`Are you confirm to chose ${radio1.value} ?`)
    .then(() => {
      drawer2.value = false
    })
    .catch(() => {
      // catch error
    })
}

onMounted(() => useCart())

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
}
</style>
