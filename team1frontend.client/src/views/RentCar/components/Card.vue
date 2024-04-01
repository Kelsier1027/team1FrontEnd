<script setup>
import { useRouter } from 'vue-router';
const router = useRouter()
defineProps({
    carModel: {
        type: Object,
        default: () => { }
    }
})

const click = (carModel) => {
    router.push({
        path: '/order',
        name: 'order',
        params: {
            str: JSON.stringify(carModel)
        }
    })
}
</script>


<template>
    <v-card class="mx-auto" width="500" elevation="16">
        <v-img class="align-end text-white" height="300" :src="`../src/assets/${carModel.mainImage}`" cover>
        </v-img>
        <v-card-title class="pt-4 text-h5">
            {{ carModel.name }} {{ carModel.carBrand.name }}
        </v-card-title>
        <v-divider></v-divider>
        <v-card-text>
            <font-awesome-icon class="fa-2x" icon="car" /><span class="text-h6 mx-3">{{ carModel.seats }}人座</span>
            <font-awesome-icon class="fa-2x" icon="gear" /><span class="text-h6 mx-3">{{
            carModel.carTransmission.name }}</span>
            <font-awesome-icon class="fa-2x" icon="gas-pump" /><span class="text-h6 mx-3">{{ carModel.carEnergyType.name
                }}</span>
        </v-card-text>
        <v-card-actions>
            <div class=" d-flex align-items-end">
                <span class="text-h3 mt-3 me-2">TWD {{ carModel.feePerDay }}</span><span class="text-h5">總金額</span>
            </div>
            <button @click="click(carModel)" class="btn btnbgc rounded-pill text-white ms-auto"
                style="height:50px;width: 150px;font-size: 1.25rem;">了解詳情</button>
        </v-card-actions>
    </v-card>
</template>

<style scoped>
.btnbgc {
    background-color: rgb(12, 62, 119)
}
</style>