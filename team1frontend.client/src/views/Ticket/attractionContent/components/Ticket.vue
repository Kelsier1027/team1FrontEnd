<template>
  <el-collapse-item :name="ticket.id" @click.stop.prevent="toggleTitle" :class=foldStatus>
    <template #title>
      <div class="titleBox">
        <div>{{ ticket.ticketTitle }}</div>

        <div v-if="showTitle">NT${{ ticket.price }}</div>
      </div>

    </template>


    <div @click.stop.prevent>
      <div>{{ ticket.ticketDetail }}</div>
      <div class="d-flex">
        <div class="price">NT${{ ticketTotalPrice }}</div>
        <el-button type="warning" plain @click.stop.prevent>Warning</el-button>
      </div>
      <el-input-number v-model="num" :min="1" :max="10" @change="handleChange" @click.stop.prevent />
    </div>
  </el-collapse-item>

</template>

<script setup>
import { computed, ref } from 'vue'

const showTitle = ref(true);




function toggleTitle() {
  showTitle.value = !showTitle.value
}



const props = defineProps({
  ticket: {
    type: Object,
    default: () => { }
  },

});




const num = ref(1)

const handleChange = (num) => {
  console.log(num);
  console.log(totalPrice);
  console.log(props.ticket.price);
}

const ticketTotalPrice = computed(()=>props.ticket.price*num.value);




</script>

<style>
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
  --el-collapse-border-color: red;
}

.el-button {
  margin: auto;
}

.price {
  margin-right: 7px;
  font-size: 20px;
}

.el-collapse-item__content {}

button {
  margin-top: 20px;
}
</style>