<template>
    <GoogleMap api-key="AIzaSyAJNn4sB8zDRMpbD1GrRzN6dsGfSPuFiSg" style="width: 100%; height: 500px" :center="center"
        :zoom="17">



        <Marker :options="{ position: center }" />
    </GoogleMap>
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

<style></style>


<!-- map-type-id="hybrid" load時預設地圖樣式-->