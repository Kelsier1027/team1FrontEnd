import { ref, computed } from 'vue'
import { defineStore } from 'pinia'

export const usetTimeSpanStore = defineStore('timespan', () => {
    const timeSpan = ref([])

    const selectedCity = ref('地區')

    const selectedSeats = ref('座位數')

    const begin = computed(() => timeSpan.value[0])

    const end = computed(() => timeSpan.value[1])

    return {
        selectedCity,
        selectedSeats,
        timeSpan,
        begin,
        end
    }
})