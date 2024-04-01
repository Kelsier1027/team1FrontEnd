<script setup>
import { ref } from 'vue'
import { useRoute } from 'vue-router';
import { useRouter } from 'vue-router';
import { useField, useForm } from 'vee-validate'
import { GetOrderAPI } from '@/apis/Order'

const carModel = JSON.parse(useRoute().params.str)
const { handleSubmit, handleReset } = useForm({
    validationSchema: {
        name(value) {
            if (value?.length >= 2) return true

            return 'Name needs to be at least 2 characters.'
        },
        phone(value) {
            if (value?.length > 9 && /[0-9-]+/.test(value)) return true

            return 'Phone number needs to be at least 9 digits.'
        },
        licenceId(value) {
            if (value?.length > 9 && /[0-9-]+/.test(value)) return true

            return 'Phone number needs to be at least 9 digits.'
        },
        email(value) {
            if (/^[a-z.-]+@[a-z.-]+\.[a-z]+$/i.test(value)) return true

            return 'Must be a valid e-mail.'
        },
        select(value) {
            if (value) return true

            return 'Select an item.'
        },
        checkbox(value) {
            if (value === '1') return true

            return 'Must be checked.'
        },
    },
})
const name = useField('name')
const phone = useField('phone')
const email = useField('email')
const licenceId = useField('licenceId')
const select = useField('select')
const checkbox = useField('checkbox')

const items = ref([
    '男',
    '女',
    '不方便',
    'Item 4',
])
var data = {}
const submit = handleSubmit(values => {
    values.carBrand = carModel.carBrand.name
    values.carModel = carModel.name
    data = Object.assign({}, values);
    alert(JSON.stringify(values, null, 2))
})
const router = useRouter()
const click = async () => {
    const response = await GetOrderAPI(data)
    console.log(response);
    router.push({
        path: '/toecpay',
        name: 'toecpay',
        params: {
            str: JSON.stringify(response)
        }
    })
}
</script>

<template>
    <v-main>
        <v-row>
            <v-col cols="2"></v-col>
            <v-col cols="5">
                <div class="ma-6 p-4">
                    <v-divider></v-divider>
                    <h1>訂購人資料</h1>
                    <form @submit.prevent="submit">
                        <v-text-field v-model="name.value.value" :counter="10" :error-messages="name.errorMessage.value"
                            label="姓名" variant="underlined" class="my-6"></v-text-field>
                        <v-text-field v-model="phone.value.value" :counter="7"
                            :error-messages="phone.errorMessage.value" label="連絡電話" variant="underlined"
                            class="my-6"></v-text-field>
                        <v-text-field v-model="licenceId.value.value" :counter="7"
                            :error-messages="licenceId.errorMessage.value" label="駕照號碼" variant="underlined"
                            class="my-6"></v-text-field>
                        <v-text-field v-model="email.value.value" :error-messages="email.errorMessage.value"
                            label="E-mail" variant="underlined" class="my-6"></v-text-field>
                        <v-select v-model="select.value.value" :error-messages="select.errorMessage.value"
                            :items="items" label="Select" variant="underlined" class="my-6"></v-select>
                        <v-checkbox v-model="checkbox.value.value" :error-messages="checkbox.errorMessage.value"
                            label="Option" type="checkbox" value="1" variant="underlined" class="my-6"></v-checkbox>

                        <v-btn class="me-4 bg-blue" type="submit" rounded="xl" block>
                            繼續
                        </v-btn>


                    </form>
                    <v-divider></v-divider>
                </div>
            </v-col>
            <v-col cols="3">
                <div class="border border-black rounded-xl ma-6 mt-10 p-5">
                    <h2 class="font-weight-bold mb-10">租車明細</h2>
                    <div class="mb-6">
                        <h4 class="font-weight-thin">車型</h4>
                        <h3>{{ carModel.name }}</h3>
                    </div>
                    <div class="mb-6">
                        <h4 class="font-weight-thin">廠牌</h4>
                        <h3>{{ carModel.carBrand.name }}</h3>
                    </div>
                    <div class="mb-6">
                        <h5 class="font-weight-thin">取車地點</h5>
                        <h4>台北市信義區光復南路495號4樓</h4>
                    </div>
                    <div class="d-flex flex-wrap mb-6">
                        <div class="w-50">
                            <h5 class="font-weight-thin">取車時間</h5>
                            <h4>2020/06/14</h4>
                        </div>
                        <div>
                            <h5 class="font-weight-thin">還車時間</h5>
                            <h4>2020/06/14</h4>
                        </div>
                    </div>
                    <div class="mb-10">
                        <h5 class="font-weight-thin">車輛保險</h5>
                        <h5>車輛碰撞險</h5>
                        <h5>竊盜險</h5>
                    </div>
                    <div class="mb-4">
                        <h2 class="font-weight-black">TWD 105,343</h2>
                        <h5>共 6 天 13 小時，總費用</h5>
                    </div>
                    <div>
                        <v-btn class="me-4 bg-blue" type="button" rounded="xl" @click="click" block>
                            付款
                        </v-btn>
                    </div>

                </div>
            </v-col>
            <v-col cols="2"></v-col>

        </v-row>
    </v-main>
</template>

<style scoped></style>