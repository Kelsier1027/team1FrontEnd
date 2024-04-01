<script setup>
import { ref, onMounted } from 'vue'
import { GetCityAPI } from '@/apis/city';
import { useRouter } from 'vue-router';
import { usetTimeSpanStore } from '@/stores/timeSpan'


const timeSpanStore = usetTimeSpanStore()

const cities = ref([])
const selectedSeats = ref('')
const selectedCity = ref('')
const init = async () => {
    cities.value = await GetCityAPI();
}
const timeSpan = ref([])
selectedCity.value = timeSpanStore?.selectedCity
selectedSeats.value = timeSpanStore?.selectedSeats
timeSpan.value = timeSpanStore?.timeSpan
const citySelectClick = (name) => {
    selectedCity.value = name
}
const seatSelectClick = (name) => {
    selectedSeats.value = name
}

onMounted(() => init())

const dialog = ref(false)
const dialogtext = ref('')
const router = useRouter()

const btnClick = () => {
    if (selectedCity.value === '地區') {
        dialogtext.value = '請選擇租車地區'
        dialog.value = true
        return
    }
    if (timeSpan.value?.length === 0 || timeSpan.value === null) {
        dialogtext.value = '請選擇租車時間'
        dialog.value = true
        return
    }
    timeSpanStore.timeSpan = timeSpan.value
    timeSpanStore.selectedCity = selectedCity.value
    timeSpanStore.selectedSeats = selectedSeats.value
    router.push({
        path: '/rentCar/car',
    })
}
</script>
<template>
    <div class="border rounded-4 p-4 pb-3 mt-6" style="background-color: white;border-color:black;">
        <form class="row row-cols-lg-auto g-3 d-flex justify-content-around align-items-center">
            <div class="col-12">
                <div class="dropdown-center ">
                    <div class="btn border dropdown-toggle rounded-pill px-3" data-bs-toggle="dropdown"
                        aria-expanded="false">
                        <font-awesome-icon icon="location-dot" />
                        <input v-model="selectedCity" type="text" class="form-control d-inline border-0 w-75 mx-3"
                            disabled style="background-color: white;">
                    </div>
                    <ul class="dropdown-menu">
                        <li v-for="item in cities">
                            <div class="dropdown-item" @click="citySelectClick(item.name)">{{ item.name }}</div>
                        </li>
                    </ul>
                </div>
            </div>
            <div class="col-12">
                <div class="dropdown-center ">
                    <div class="btn border dropdown-toggle rounded-pill px-3" data-bs-toggle="dropdown"
                        aria-expanded="false">
                        <font-awesome-icon icon="car" />
                        <input v-model="selectedSeats" type="text" class="form-control d-inline border-0 w-75 mx-3"
                            disabled style="background-color: white;">
                    </div>
                    <ul class="dropdown-menu">
                        <li>
                            <div class="dropdown-item" @click="seatSelectClick('不限')">不限</div>
                        </li>
                        <li>
                            <div class="dropdown-item" @click="seatSelectClick('2人座以上')">2人座以上</div>
                        </li>
                        <li>
                            <div class="dropdown-item" @click="seatSelectClick('4人座以上')">4人座以上</div>
                        </li>
                        <li>
                            <div class="dropdown-item" @click="seatSelectClick('5人座以上')">5人座以上</div>
                        </li>
                        <li>
                            <div class="dropdown-item" @click="seatSelectClick('7人座以上')">7人座以上</div>
                        </li>
                    </ul>
                </div>
            </div>
            <div class="col-12">
                <el-date-picker v-model="timeSpan" type="datetimerange" start-placeholder="取車日期" end-placeholder="還車日期"
                    format="YYYY-MM-DD HH:00" date-format="YYYY/MM/DD ddd" time-format="A HH:00"
                    :style="{ borderRadius: '80px' }" style="height:50px"></el-date-picker>
            </div>
            <div class="col-12">
                <button type="submit" class="btn btnbgc rounded-pill text-white"
                    style="height:50px;width: 100px;font-size: 1.25rem;" @click.prevent="(e) => btnClick(e)">搜尋</button>
                <v-dialog v-model="dialog" width="400">
                    <v-card max-width="400" prepend-icon="mdi-alert-circle" :text=dialogtext>
                        <template v-slot:actions>
                            <v-btn class="ms-auto" text="確定" @click="dialog = false"></v-btn>
                        </template>
                    </v-card>
                </v-dialog>
            </div>
        </form>
    </div>
</template>

<style scoped>
.border-secondary {
    border-color: rgb(212 212 212 1);
}

.bg-primary {
    --tw-bg-opacity: 1;
    background-color: rgb(0 49 104 / var(--tw-bg-opacity));
}

.text-white {
    --tw-text-opacity: 1;
    color: rgb(255 255 255 / var(--tw-text-opacity));
}

.btnbgc {
    background-color: rgb(12, 62, 119)
}
</style>