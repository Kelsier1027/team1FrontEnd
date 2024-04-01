import { ref, computed } from 'vue'
import { defineStore } from 'pinia'
export const useCriteriaStore = defineStore('criteria', () => {
    const brandCriteria = ref([])
    const criteria = computed(() => brandCriteria.value)

    const changeBrandCriteria = (list) => {
        brandCriteria.value = Array.from(list)
    }

    const removeCriteria = (item) => {
        const index = criteria.value.indexOf(item);
        criteria.value.splice(index, 1)
    }

    return {
        brandCriteria,
        changeBrandCriteria,
        removeCriteria
    }
})