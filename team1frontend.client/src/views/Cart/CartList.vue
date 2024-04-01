<template>
    <v-main>
        <div>
            <h2>商品列表</h2>
            <input type="checkbox" v-model="selectAll" @change="toggleSelectAll"> 全选
            <ul>
                <li v-for="(item, index) in items" :key="index">
                    <input type="checkbox" v-model="selectedItems[index]" @change="updateSelectAll"> {{ item.name }} - {{ item.price }}
                    <button @click="removeItem(index)">删除</button>
                </li>
            </ul>
            <button v-if="hasSelectedItems" @click="removeSelectedItems">删除已选商品</button>
        </div>
    </v-main>
</template>

<script setup>
import { ref, computed } from 'vue';

const items = [
  { id: 1, name: '商品1', price: 10 },
  { id: 2, name: '商品2', price: 20 },
  { id: 3, name: '商品3', price: 30 }
];

const selectedItems = ref(new Array(items.length).fill(false));

const removeItem = (index) => {
  items.splice(index, 1);
  selectedItems.value.splice(index, 1);
};

const removeSelectedItems = () => {
  for (let i = selectedItems.value.length - 1; i >= 0; i--) {
    if (selectedItems.value[i]) {
      items.splice(i, 1);
      selectedItems.value.splice(i, 1);
    }
  }
};

const hasSelectedItems = computed(() => {
  return selectedItems.value.some(item => item);
});

const selectAll = ref(false);

const toggleSelectAll = () => {
selectedItems.value.fill(selectAll.value);
};
const updateSelectAll = () => {
  selectAll.value = selectedItems.value.every(item => item);
};
</script>