import { ref, computed } from 'vue'
import { defineStore } from 'pinia'

export const usetTimeSpanStore = defineStore('timespan', () => {
    const timeSpan = ref([])

    const selectedCity = ref('地區')

    const selectedSeats = ref('座位數')

    const begin = computed(() => `${timeSpan.value[0].getFullYear()}/${(timeSpan.value[0].getMonth() + 1).toString().padStart(2, '0')}/${timeSpan.value[0].getDate().toString().padStart(2, '0')}`)

    const end = computed(() => `${timeSpan.value[1].getFullYear()}/${(timeSpan.value[1].getMonth() + 1).toString().padStart(2, '0')}/${timeSpan.value[1].getDate().toString().padStart(2, '0')}`)

    return {
        selectedCity,
        selectedSeats,
        timeSpan,
        begin,
        end
    }
})