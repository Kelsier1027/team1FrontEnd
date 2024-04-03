<template>
  <v-main>
    <div>
      <h2>商品列表</h2>
      <input type="checkbox" v-model="selectAll" @change="toggleSelectAll"> 全選
      <ul>
        <li style="list-style-type: none;" v-for="(item, index) in items" :key="index">
          <div style=" margin-bottom: 10px; display: flex; align-items: center;">
            <v-card style=" margin-right: 10px;width: 1200px;" variant="outlined">
              <v-row align="center">
                <v-col cols="auto">
                  <!-- <input type="checkbox" v-model="isChecked" class="checkBoxInput" @change="updateSelectAll"> -->
                  <input type="checkbox" v-model="item.selected" class="checkBoxInput" @change="updateSelectAll">
                </v-col>
                <v-col cols="auto">
                  <img src="../../images/noImage.jpg" alt="Your Image" style="width: 120px; height: 80px;">
                </v-col>
                <v-col cols="auto">
                  <v-card-title style="width: 200px; height: 48px;">
                    {{ item.title }}
                  </v-card-title>
                </v-col>
                <v-col cols="auto">
                  <v-card-text style="width: 250px; max-width: 250px;word-wrap: break-word;">
                    {{ ` ${item.name} ` }}
                  </v-card-text>
                </v-col>
                <v-col>
                  <v-card-text style="font-size: 16px;">
                    數量: {{ `${item.qty}` }}
                  </v-card-text>
                </v-col>
                <v-col>
                  <v-card-text style="font-size: 16px;">
                    價錢: {{ `${item.price}` }}
                  </v-card-text>
                </v-col>
              </v-row>
            </v-card>
            <button @click="removeItem(index)">
              <svg xmlns="http://www.w3.org/2000/svg" width="20" height="22" fill="currentColor" class="bi bi-trash"
                viewBox="0 0 16 18">
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
    </div>
  </v-main>
</template>

<script setup>
import { ref, computed } from 'vue';
import { getcartitem } from '@/apis/Cart/getcartitem';
import { delitem } from '@/apis/Cart/delitem'
const isChecked = ref(false);

const items = ref([
  { id: 1, title: '標題1', name: '商品1', qty: 1, price: 10, selected: false },
  { id: 2, title: '標題2', name: '商品2', qty: 2, price: 20, selected: false },
  { id: 3, title: '標題3', name: '商品3', qty: 3, price: 30, selected: false },
]);
// console.log(items.value.length);
const selectedItems = ref(new Array(items.value.length).fill(false));
// console.log(selectedItems);

const removeItem = (index) => {

  items.value.splice(index, 1);
  selectedItems.value.splice(index, 1);
};

const removeSelectedItems = () => {
  for (let i = items.value.length - 1; i >= 0; i--) {
    // 如果项目被选中，则从数组中删除它
    if (items.value[i].selected) {
      console.log(items.value.splice(i, 1)); 
    }
  }
};

const hasSelectedItems = computed(() => {
  return items.value.some(item => item.selected);
});

const selectAll = ref(false);

const toggleSelectAll = () => {
  // console.log(items.value);
  // selectedItems.value.fill(selectAll.value);


  if (selectAll.value) {
    items.value.forEach((item, index) => {
      item.selected = true;
    })
  }
  else {
    items.value.forEach((item, index) => {
      item.selected = false;
    })
  };

};

const updateSelectAll = () => {
  selectAll.value = items.value.every(item => item.selected);
};
</script>