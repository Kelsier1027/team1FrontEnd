<script setup>
import { ref, onMounted } from 'vue';
import SearchForm from '@/views/RentCar/components/IndexForm.vue'
import Criteria from '@/views/RentCar/components/CarCriteria.vue'
import Card from '@/views/RentCar/components/Card.vue'
import { GetCarBrandAPI } from '@/apis/CarBrand';
import { GetCarTransmissionAPI } from '@/apis/CarTransmission';
import { GetCarEnergyTypeAPI } from '@/apis/CarEnergyType';
import { GetCarModelAPI } from '@/apis/CarModel';
import { useCriteriaStore } from '@/stores/criteria';
const transmissiolist = ref([])
const brandList = ref([])
const energyTypeList = ref([])
const carModelList = ref([])
const criteriaStore = useCriteriaStore();
const getCarTransmissions = async () => {
    transmissiolist.value = await GetCarTransmissionAPI();
}
const getCarBrands = async () => {
    brandList.value = await GetCarBrandAPI();
}
const getCarEnergyTypes = async () => {
    energyTypeList.value = await GetCarEnergyTypeAPI();
}
const GetCarModels = async () => {
    carModelList.value = await GetCarModelAPI();
}


onMounted(() => getCarBrands())
onMounted(() => getCarTransmissions())
onMounted(() => getCarEnergyTypes())
onMounted(() => GetCarModels())

</script>

<template>
    <v-main>
        <v-row>
            <v-col cols="3"></v-col>
            <v-col cols="6">
                <div class="d-flex justify-content-center">
                    <div>
                        <div class="mb-6">
                            <SearchForm></SearchForm>
                        </div>
                        <div class="border rounded-4 p-4 d-flex justify-end">
                            <span class="me-12 align-self-end text-h5 text-decoration-underline">篩選條件</span>
                            <div class="me-12">
                                <Criteria title="廠牌" :list=brandList></Criteria>
                            </div>
                            <div class="me-12">
                                <Criteria title="排檔" :list=transmissiolist></Criteria>
                            </div>
                            <div class="me-12">
                                <Criteria title="能源" :list=energyTypeList></Criteria>
                            </div>
                        </div>
                        <v-divider></v-divider>
                        <div class="d-flex flex-wrap">
                            <v-chip v-for="(item, index) in criteriaStore.brandCriteria" :key="item" class="ma-2"
                                closable @click:close="criteriaStore.brandCriteria.splice(index, 1)">
                                {{ item }}
                            </v-chip>
                        </div class>
                        <v-divider></v-divider>
                        <div class="d-flex flex-wrap">
                            <div v-for="item in carModelList" class="mb-6" style="width:calc(50%)">
                                <Card :car-model="item"></Card>
                            </div>
                        </div>
                    </div>
                </div>
            </v-col>
            <v-col cols="3"></v-col>
        </v-row>
    </v-main>
</template>

<style scoped>
.btnbgc {
    background-color: rgb(12, 62, 119)
}
</style>