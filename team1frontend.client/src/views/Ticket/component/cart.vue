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
      <div class="cart-item">123</div>
      <div class="cart-item">123</div>
      <div class="cart-item">123</div>
      <div class="cart-item">123</div>
     
    
    </template>
    
    <template #footer>
      <div style="flex: auto">
        <el-button @click="cancelClick">繼續買</el-button>
        <el-button type="primary" @click="confirmClick">結帳</el-button>
      </div>
    </template>
  </el-drawer>
</template>

<script setup>
import { ref } from 'vue'
import { ElMessageBox } from 'element-plus'


const drawer = ref(false)
const direction = ref('rtl')


function cancelClick(){
    drawer.value=false;
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
</script>


<style scoped>
/* .all-item{
    border: 2px solid pink;
    padding: 2px;  
} */

.cartIcon{
  width:100px;
  height: 100px;
}
.cartIcon:hover{
    cursor:pointer;
}

.affix-container{
  position: fixed;
  right: 20px; 
  top: 120px; 
}
</style>
