<template>
  <el-collapse-item :name="ticket.id" @click.stop.prevent="toggleTitle" :class=foldStatus class="collapseDiv"> 
    <template #title>
      
        <div class="tickettitle">{{ ticket.ticketTitle }}</div>

        <div v-if="showTitle" class="outprice">NT${{ ticket.price }}</div>
      

    </template>


    <div @click.stop.prevent>
      <div class="ticketdetail">{{ ticket.ticketDetail }}</div>
      <div class="row">
        <div class="col-md-6 offset-md-6 buyblock">
        <div class="innerprice">NT${{ ticketTotalPrice }}</div>
        <div class="cal"><el-input-number v-model="num" :min="1" :max="77" @change="handleChange" @click.stop.prevent /></div>
        <div class="addbtn"><el-button type="primary" @click.stop.prevent="addItem" style="color:white"><el-icon size="25px"><ShoppingCart/></el-icon>加入購物車</el-button></div>
      </div>
    </div>
    </div>
  </el-collapse-item>

</template>

<script setup>
import { computed, ref, watch } from 'vue'
import { AddCartItemAPI } from '@/apis/Chih/apis/post_addItem';
import { getCartByMemberAPI } from '@/apis/Chih/apis/get_cartByMember'
import { useMemberStore } from '@/stores/memberStore';
import { useCartStore } from '@/stores/attractionStore'
import { ElMessage } from 'element-plus'

const memberStore = useMemberStore();
const cartStore = useCartStore();


const showTitle = ref(true);


function toggleTitle() {
  showTitle.value = !showTitle.value
}

const addMessage = ref()



const props = defineProps({
  ticket: {
    type: Object,
    default: () => { }
  },
  cartId: {
    type: Number,
  }

});




const num = ref(1)

const handleChange = (num) => {
  console.log(num);
  console.log(props.ticket.price);
}

const ticketTotalPrice = computed(() => props.ticket.price * num.value);





const addItem = async () => {
  if (memberStore.isLoggedIn == false) {
    ElMessage({
    message:'請先登入',
    type: 'warning'
  }
    );
      
    return;
  }

  const addItemDTO = {
    CartId: cartStore.cartId,
    ItemId: props.ticket.id,
    Quantity: num.value,
  };
  try {
    const res = await AddCartItemAPI(addItemDTO);
    addMessage.value = res;
    console.log(res);
    console.log(addItemDTO);
    ElMessage({
      message:`${props.ticket.ticketTitle}加入成功`,
      type:'success'
    });
  } catch (error) {
    ElMessage({
      message:error,
      type: 'error'
    });

  }



}





watch(() => memberStore.memberId, (newId, oldId) => {
  if (newId !== oldId && newId) {//避免0 !== 1 && 0
    (async () => {
      await cartStore.getCart();
      console.log(cartStore.cartId);
    })();

  }
}, { immediate: false })

</script>

<style>
@import url('/src/assets/font/font.css');
*{
  font-family:MSJHBD ;
}


.outprice{
  font-family: MATRIX;
  margin-left:400px;
  text-align: left;
  width: 200px;
}

.ticketdetail{
  margin-bottom: 30px;
  font-size: 20px;
	place-items: center;
	min-height: 100px;
	border: 3px solid;	
 
  border-image: linear-gradient(to left, turquoise, greenyellow) 1 0;
}

.innerprice{
  margin-right:36px;
  font-size: 25px;
  font-family: MATRIX;
  
}

.cal{
  margin-right:5px;

}

.buyblock{
  display: flex;
  justify-content: center;
  align-items: center;
}

.d-flex{
  margin-top:30px;
  
}

.el-breadcrumb {
  margin: 10px;
  font-size: 20px;
}

.el-collapse-item__header {
  display: flex;
  height: auto;
  font-size: 20px;

}

.el-tag {
  margin: 5px;
  width: 80px;
  height: 30px;
}

.el-collapse {
  --el-collapse-border-color: lightgreen;
  --el-collapse-border:10px;
}

.el-button {
  margin: auto;

}

.price {
  margin-left: 60px;
  font-size: 20px;
}

.el-collapse-item__content {}

button {
  margin-top: 20px;
}

.titleBox{
  display: block;
}

.tickettitle{
  width: 300px;
  text-align: left;
  font-size: 21px;
}

</style>