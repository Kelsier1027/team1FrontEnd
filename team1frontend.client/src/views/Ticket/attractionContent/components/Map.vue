<template>
  <div class="gmap">
  <GoogleMap api-key="AIzaSyAJNn4sB8zDRMpbD1GrRzN6dsGfSPuFiSg" style="width: 100%; height: 500px" :center="center"
    :zoom="17">



    <Marker :options="{ position: center }" />
    
  </GoogleMap>
</div>
</template>


<script setup>
import { computed } from 'vue'
import { GoogleMap, Marker } from 'vue3-google-map'
const props = defineProps({
  lat: {
    type: Number
  },
  lng: {
    type: Number
  }
})

const center = computed(() => ({
  lat: parseFloat(props.lat),
  lng: parseFloat(props.lng)
}))

console.log(center);



</script>

<style scoped>
.gmap {
  text-align: center;
  font-family: cursive;
  font-size: 24px;
  border: 7px solid black;
  min-height: 3em;
  width: 100%;
  resize: both;
  background: linear-gradient(to top, rgba(#cffffe, 0.3), rgba(#f9f7d9, 0.3), rgba(#fce2ce, 0.3), rgba(#ffc1f3, 0.3));
  border-image: url("data:image/svg+xml;charset=utf-8,%3Csvg width='100' height='100' viewBox='0 0 100 100' fill='none' xmlns='http://www.w3.org/2000/svg'%3E %3ClinearGradient id='g' x1='0%25' y1='0%25' x2='0%25' y2='100%25'%3E%3Cstop offset='0%25' stop-color='%23cffffe' /%3E%3Cstop offset='25%25' stop-color='%23f9f7d9' /%3E%3Cstop offset='50%25' stop-color='%23fce2ce' /%3E%3Cstop offset='100%25' stop-color='%23ffc1f3' /%3E%3C/linearGradient%3E %3Cpath d='M1.5 1.5 l97 0l0 97l-97 0 l0 -97' stroke-linecap='square' stroke='url(%23g)' stroke-width='3'/%3E %3C/svg%3E") 1;
}
</style>


<!-- map-type-id="hybrid" load時預設地圖樣式-->