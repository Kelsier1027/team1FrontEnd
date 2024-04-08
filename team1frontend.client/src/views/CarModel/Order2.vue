<script setup>
import { ref } from 'vue'
import { useRoute } from 'vue-router';
import { useRouter } from 'vue-router';
import { useField, useForm } from 'vee-validate'
import { usetTimeSpanStore } from '@/stores/timeSpan';
import { AddItemToCart } from '@/apis/Cart/additem';
import Cart from '@/views/Ticket/components/cart.vue'

const timeSpanStore = usetTimeSpanStore()
const timeSpan = timeSpanStore.timeSpan[1].getDate() - timeSpanStore.timeSpan[0].getDate()
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

            return 'Phone number needs to be at least 10 digits.'
        },
        email(value) {
            if (/^[a-z.-.0-9]+@[a-z.-]+\.[a-z]+$/i.test(value)) return true

            return 'Must be a valid e-mail.'
        },
        select(value) {
            if (value) return true

            return 'Select an item.'
        },
    },
})
const name = useField('name')
const phone = useField('phone')
const email = useField('email')
const licenceId = useField('licenceId')
const select = useField('select')
const canSubmit = ref(true)

const autoMemberInfo = function (e) {
    if (e.target.checked) {
        name.value.value = "Guest";
        phone.value.value = "0912345678";
        licenceId.value.value = "V4441532563";
        email.value.value = "ForTest31@gmail.com";
        select.value.value = '男'
    } else {
        name.value.value = "";
        phone.value.value = "";
        licenceId.value.value = "";
        email.value.value = "";
        select.value.value = ""
    }
}


const items = ref([
    '男',
    '女',
    '不方便',
])
var data = {}
const submit = handleSubmit(values => {
    values.carBrand = carModel.carBrand.name
    values.carModel = carModel.name
    values.total = carModel.feePerDay * timeSpan
    data = Object.assign({}, values);
    console.log(carModel)
    canSubmit.value = false
})
const router = useRouter()
const click = async () => {
    await AddItemToCart(55, carModel.id, 4, 1);
}

</script>

<template>
    <v-main>
        <Cart></Cart>
        <div class="row">
            <div class="col-2"></div>
            <div class="col-5">
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
                            :items="items" label="性別" variant="underlined" class="my-6"></v-select>
                        <v-checkbox label="使用當前會員資料" type="checkbox" value="1" class="my-6"
                            @click="e => autoMemberInfo(e)"></v-checkbox>
                        <v-btn class="me-4 bg-blue" type="submit" rounded="xl" block>
                            繼續
                        </v-btn>
                    </form>
                    <v-divider></v-divider>
                </div>
            </div>
            <div class="col-3">
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
                            <h4>{{ timeSpanStore.begin }}</h4>
                        </div>
                        <div>
                            <h5 class="font-weight-thin">還車時間</h5>
                            <h4>{{ timeSpanStore.end }}</h4>
                        </div>
                    </div>
                    <div class="mb-10">
                        <h5 class="font-weight-thin">車輛保險</h5>
                        <h5>車輛碰撞險</h5>
                        <h5>竊盜險</h5>
                    </div>
                    <div class="mb-4">
                        <h2 class="font-weight-black">TWD {{ carModel.feePerDay * timeSpan }}</h2>
                        <h5>共 {{ timeSpan }} 天，總費用
                        </h5>
                    </div>
                    <div>
                        <v-btn class="me-4 bg-blue" type="button" rounded="xl" @click="click" block :disabled=canSubmit>
                            加入購物車
                        </v-btn>
                    </div>

                </div>
            </div>
            <div class="col-2"></div>
        </div>
    </v-main>
</template>

<style scoped></style>