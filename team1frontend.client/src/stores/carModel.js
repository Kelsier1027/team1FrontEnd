import { ref } from 'vue'
import { defineStore } from 'pinia'
import { GetCarModelAPI } from '@/apis/CarModel'

export const useCarModelStore = defineStore('carModel', () => {
    const carModel = ref([])

    const criteria = ref([])

    const resetCarModel = async () => {
        const res = await GetCarModelAPI()
        carModel.value = res
    }

    return {
        carModel,
        resetCarModel
    }
})