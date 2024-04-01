<template>
  <v-main>
    <Cart />

    <AttractionAttraction />


  </v-main>

</template>

<script setup>
import AttractionAttraction from './components/AttractionAttraction.vue';
import Cart from '../components/cart.vue'
import { useMemberStore } from '@/stores/memberStore';

const memberStore = useMemberStore();
console.log(memberStore);




</script>

<style scoped>
/* ul{
border:2px solid black;
  }
  li{
      width: 240px;
      height: 300px;
      margin-right: 10px;
      margin-bottom: 10px;
      border:2px solid black;

      &:nth-last-child(-n + 4) {
        margin-bottom: 0;
      }

      &:nth-child(4n) {
        margin-right: 0;
      }
    }
    .container{
      border: 2px solid black;
    } */
</style>