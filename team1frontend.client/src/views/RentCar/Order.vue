<script setup>
import { useRoute } from 'vue-router';
const route = useRoute()
const carModel = JSON.parse(route.params.str)
</script>

<template>
    <v-main>
        <v-row>
            <v-col cols="2"></v-col>
            <v-col cols="5">
                <div class="ma-4">
                    <div class="mb-12">
                        <v-img :aspect-ratio="16 / 9" class="bg-grey" :src="`../../src/assets/${carModel.mainImage}`"
                            height="400"></v-img>
                    </div>
                    <h1 class="text-h4 font-weight-bold mb-6">{{ carModel.name }} {{ carModel.carBrand.name }}</h1>
                    <div class="mb-6">
                        <v-row>
                            <v-col>
                                <font-awesome-icon class="fa-2x" icon="car" /><span class="text-h5 mx-3">{{
                            carModel.seats }}人座</span>
                            </v-col>
                            <v-col>
                                <font-awesome-icon class="fa-2x" icon="gear" /><span class="text-h5 mx-3">{{
                            carModel.carTransmission.name }}</span>
                            </v-col>
                            <v-col>
                                <font-awesome-icon class="fa-2x" icon="gas-pump" /><span class="text-h5 mx-3">{{
                            carModel.carEnergyType.name }}</span>
                            </v-col>
                        </v-row>
                    </div>
                    <hr>
                    <div class="my-6">
                        <h4 class="mb-4">車輛保險</h4>
                        <ul class="d-flex flex-wrap">
                            <li class="w-50">
                                <h5>車輛碰撞險</h5>
                            </li>
                            <li class="w-50">
                                <h5>竊盜險</h5>
                            </li>
                            <li class="w-50">
                                <h5>第三方責任險</h5>
                            </li>
                            <li class="w-50">
                                <h5>強制險</h5>
                            </li>
                            <li class="w-50">
                                <h5>駕駛人傷害險</h5>
                            </li>
                        </ul>
                    </div>
                    <div class="my-6">
                        <h4 class="mb-4">車輛配備</h4>
                        <ul class="d-flex flex-wrap">
                            <li class="w-50">
                                <h5>GPS導航</h5>
                            </li>
                            <li class="w-50">
                                <h5>CD播放器</h5>
                            </li>
                            <li class="w-50">
                                <h5>觸控螢幕影音</h5>
                            </li>
                            <li class="w-50">
                                <h5>AUX音源孔</h5>
                            </li>
                            <li class="w-50">
                                <h5>USB接孔</h5>
                            </li>
                            <li class="w-50">
                                <h5>藍芽</h5>
                            </li>
                            <li class="w-50">
                                <h5>高級音響</h5>
                            </li>
                        </ul>
                    </div>
                    <hr>
                    <div class="my-6">
                        <h4 class="mb-4">注意事項</h4>
                        <ul class="">
                            <li>
                                <h5>一日以上，每小時 TWD 1500 元，滿 6 小時，計一日費用</h5>
                            </li>
                            <li>
                                <h5>超里程說明：超過200公里/日,每公里收取20元</h5>
                            </li>
                            <li>
                                <h5>燃油政策：同取車油量</h5>
                            </li>
                            <li>
                                <h5>退訂政策：(嚴格) 取車日9天前免費取消預約，4天前取消將退50%的租金，未符合條件不退款。</h5>
                            </li>
                        </ul>
                    </div>
                    <div class="my-6">
                        <h4 class="mb-4">用車須知</h4>
                        <ul class="">
                            <li>
                                <h5>費用不包含燃油費、停車費、高速公路過路費與甲租乙還費用。</h5>
                            </li>
                            <li>
                                <h5>高速公路過路費(ETC)：收費規定將依照取車店家現場說明指示</h5>
                            </li>
                            <li>
                                <h5>如需攜帶寵物，請事先洽詢客服;未事先告知，店家將保留出租權益。</h5>
                            </li>
                        </ul>
                    </div>
                    <div class="my-6">
                        <h4 class="mb-4">店家政策</h4>
                        <ul class="">
                            <li>
                                <h5>需簽訂本票或需質押等值物品</h5>
                            </li>
                            <li>
                                <h5>車輛損害需負擔營業損失</h5>
                            </li>
                            <li>
                                <h5>車輛損害須負擔折舊損失</h5>
                            </li>
                            <li>
                                <h5>外籍旅客需現場預刷押金</h5>
                            </li>
                            <li>
                                <h5>駕照需持滿一年(進口車持滿二年)</h5>
                            </li>
                            <li>
                                <h5>需現場預付押金</h5>
                            </li>
                            <li>
                                <h5>駕駛或同行人需攜帶本人信用卡取車</h5>
                            </li>
                        </ul>
                    </div>
                </div>
            </v-col>
            <v-col cols="3">
                <div class="border border-black rounded-xl ma-4 p-5">
                    <h3 class="ma-5">取車時間</h3>
                    <h2 class="ma-5">2022/12/28</h2>
                    <h3 class="ma-5">還車時間</h3>
                    <h2 class="ma-5">2022/12/28</h2>
                    <h2 class="ma-5 mt-8 font-weight-bold">TWD 9000</h2>
                    <h4 class="ma-5 mt-3">共 6 天 13 小時，總費用</h4>
                    <v-btn :to="{ name: 'order2', params: { str: route.params.str } }"
                        class="font-weight-bold text-h5 text-white bg-blue" rounded="xl" size="x-large"
                        block>我要租車</v-btn>
                </div>
            </v-col>
            <v-col cols="2"></v-col>
        </v-row>
    </v-main>
</template>

<style scoped></style>