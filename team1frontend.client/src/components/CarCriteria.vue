<script setup>
import { ref } from 'vue'
import { useCriteriaStore } from '@/stores/criteria';
const criteriaStore = useCriteriaStore()
defineProps({
    title: {
        type: String
    },
    list: {
        type: Array,
        default: () => []
    },
})



</script>
<template>
    <div class="dropdown dropdown-center">
        <button class="btn btn-lg dropdown-toggle text-white" type="button" data-bs-toggle="dropdown"
            style="background-color: rgb(12, 62, 119);width: 180px;">
            {{ title }}
        </button>
        <div class="dropdown-menu">
            <div class="ms-4">
                <v-checkbox v-for="item in list" v-model="criteriaStore.brandCriteria" :label=item.name :value=item.name
                    hide-details class="text-grey-darken-4"
                    @change="(e) => click(e, `${title}-${item.id}`)"></v-checkbox>
            </div>
        </div>
    </div>
</template>