<template>
    <v-row dense>
        <v-col cols="4" class="pa-0">
            <v-select
                v-model="selectedCountryCode"
                :items="countryCodes"
                item-text="name"
                item-value="dialCode"
                single-line
                dense
                outlined
                label="國碼"
                hide-details
            ></v-select>
        </v-col>
        <v-col cols="8" class="pa-0">
            <v-text-field
                v-model="phoneNumber"
                single-line
                dense
                outlined
                label="電話號碼"
                hide-details
            ></v-text-field>
        </v-col>
    </v-row>
</template>

<script setup>
import { ref } from 'vue';

const selectedCountryCode = ref('+1');
const phoneNumber = ref('');

const countryCodes = [
    { name: '美國', dialCode: '+1' },
    { name: '中國', dialCode: '+86' },
    { name: '日本', dialCode: '+81' },
    // 更多國碼...
];
</script>

<style scoped>
.pa-0 {
    padding: 0 !important;
}
</style>
