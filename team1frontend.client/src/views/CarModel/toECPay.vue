<script setup>
import { ref } from 'vue';
import { useRoute } from 'vue-router';

const route = useRoute()
const data = ref({})
const form = ref(null)

data.value = JSON.parse(route.params.str)
console.log(data.value)

setTimeout(() => {
    form.submit()
}, 3000)
</script>

<template>
    <v-main>
        <h1>正在跳轉....</h1>
        <v-form :ref=form method="POST" action="https://payment-stage.ecpay.com.tw/Cashier/AioCheckOut/V5">
            <v-text-field v-model="data.MerchantTradeNo" name="MerchantTradeNo" style="display: none;"></v-text-field>
            <v-text-field v-model="data.MerchantTradeDate" name="MerchantTradeDate"
                style="display: none;"></v-text-field>
            <v-text-field v-model="data.TotalAmount" name="TotalAmount" style="display: none;"></v-text-field>
            <v-text-field v-model="data.TradeDesc" name="TradeDesc" style="display: none;"></v-text-field>
            <v-text-field v-model="data.ItemName" name="ItemName" style="display: none;"></v-text-field>
            <v-text-field v-model="data.ReturnURL" name="ReturnURL" style="display: none;"></v-text-field>
            <v-text-field v-model="data.OrderResultURL" name="OrderResultURL" style="display: none;"></v-text-field>
            <v-text-field v-model="data.MerchantID" name="MerchantID" style="display: none;"></v-text-field>
            <v-text-field v-model="data.PaymentType" name="PaymentType" style="display: none;"></v-text-field>
            <v-text-field v-model="data.ChoosePayment" name="ChoosePayment" style="display: none;"></v-text-field>
            <v-text-field v-model="data.EncryptType" name="EncryptType" style="display: none;"></v-text-field>
            <v-text-field v-model="data.CheckMacValue" name="CheckMacValue" style="display: none;"></v-text-field>
            <v-text-field v-model="data.CustomField1" name="CustomField1" style="display: none;"></v-text-field>
            <v-btn type="submit">確定</v-btn>
        </v-form>
    </v-main>
</template>