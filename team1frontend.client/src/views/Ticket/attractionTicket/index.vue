<template>
    <v-main style="font-family: MSJHBD">
        <v-parallax
            src="https://cdn.vuetifyjs.com/images/parallax/material.jpg"
        >
            <v-card
                class="mx-auto"
                max-width="777"
                v-for="item in userTicket"
                :key="item.id"
            >
                <v-container>
                    <v-row dense>
                        <v-col cols="12">
                            <v-card color="#808080" theme="dark">
                                <div
                                    class="d-flex flex-no-wrap justify-space-between"
                                >
                                    <div>
                                        <v-card-title class="text-h4">
                                            {{ item.ticketName }}
                                        </v-card-title>

                                        <v-card-subtitle class="text-h6">
                                            No.{{
                                                item.itemId
                                            }}</v-card-subtitle
                                        >
                                        <v-card-subtitle class="text-h6"
                                            >購買日期{{
                                                item.createTime
                                            }}</v-card-subtitle
                                        >
                                        <v-card-subtitle
                                            class="text-h6"
                                            v-if="item.isUse == true"
                                            style="
                                                color: red;
                                                line-height: 30px;
                                                font-weight: bold;
                                            "
                                            >已使用</v-card-subtitle
                                        >
                                        <transition
                                            name="stamp"
                                            @enter="enterStamp"
                                        >
                                            <Stamp
                                                style="
                                                    position: absolute;
                                                    top: 45px;
                                                    right: 250px;
                                                "
                                                size="large"
                                                color="error"
                                                content="已使用"
                                                :rotate="45"
                                                v-if="item.isUse == true"
                                            />
                                        </transition>
                                        <v-card-subtitle
                                            class="text-h6"
                                            v-if="item.isUse == false"
                                            style="
                                                color: white;
                                                line-height: 30px;
                                                font-weight: bold;
                                            "
                                            >未使用</v-card-subtitle
                                        >
                                        <v-card-actions>
                                            <v-dialog
                                                max-width="333"
                                                style="margin-top: 250px"
                                            >
                                                <template
                                                    v-slot:activator="{
                                                        props: activatorProps,
                                                    }"
                                                >
                                                    <v-btn
                                                        v-bind="activatorProps"
                                                        class="ms-2"
                                                        size="small"
                                                        variant="outlined"
                                                        text="兌換"
                                                    ></v-btn>
                                                </template>

                                                <template
                                                    v-slot:default="{
                                                        isActive,
                                                    }"
                                                >
                                                    <v-card title="QR-Code">
                                                        <v-card-text
                                                            style="
                                                                display: flex;
                                                            "
                                                        >
                                                            <img
                                                                :src="
                                                                    item.imgOfQRCode
                                                                "
                                                                style="
                                                                    width: 100%;
                                                                "
                                                            />
                                                        </v-card-text>

                                                        <v-card-actions>
                                                            <v-spacer></v-spacer>

                                                            <v-btn
                                                                text=" 關閉"
                                                                @click="
                                                                    isActive.value = false
                                                                "
                                                            ></v-btn>
                                                        </v-card-actions>
                                                    </v-card>
                                                </template>
                                            </v-dialog>
                                        </v-card-actions>
                                    </div>
                                    <div class="dashed-line-wrapper">
                                        <svg
                                            class="dashed-line"
                                            height="165"
                                            width="100%"
                                        >
                                            <line
                                                x1="250"
                                                y1="0"
                                                x2="250"
                                                y2="100%"
                                                style="
                                                    stroke: #000;
                                                    stroke-width: 2;
                                                    stroke-dasharray: 5, 5;
                                                "
                                            />
                                        </svg>
                                    </div>
                                    <v-avatar
                                        class="ma-3"
                                        rounded="0"
                                        size="125"
                                    >
                                        <v-img
                                            :src="item.ticketImg"
                                            style=""
                                        ></v-img>
                                    </v-avatar>
                                </div>
                            </v-card>
                        </v-col>
                    </v-row>
                </v-container>
            </v-card>
        </v-parallax>
    </v-main>
</template>
<script setup>
import { useMemberStore } from '@/stores/memberStore';
import { getUserTicketAPI } from '@/apis/Chih/apis/get_ticket';
import { onMounted, ref, onUnmounted } from 'vue';
import Stamp from '@/views/Ticket/components/stamp.vue';
const member = useMemberStore();
const userTicket = ref({});
const id = member.memberId;
const pollingInterval = ref(null);
const show = ref(false);

function enterStamp(el, done) {
    // 這裡可以使用 JavaScript 直接操作 DOM 來添加動畫
    // 例如使用 Web Animations API
    el.animate(
        [
            // keyframes
            { transform: 'scale(0) rotate(0deg)', opacity: 0 },
            { transform: 'scale(1.2) rotate(-20deg)', opacity: 1 },
            { transform: 'scale(1) rotate(45deg)', opacity: 1 },
        ],
        {
            // timing options
            duration: 500,
            fill: 'forwards',
        }
    ).finished.then(done);
}

setTimeout(() => {
    show.value = true;
}, 500);

const goPolling = () => {
    if (pollingInterval.value !== null) return;
    console.log('開始pol');

    pollingInterval.value = setInterval(() => {
        getTicket();
    }, 2000);
};

const stopPolling = () => {
    console.log('結束pol');
    if (pollingInterval.value !== null) {
        clearInterval(pollingInterval.value);
        pollingInterval.value = null;
    }
};

const getTicket = async () => {
    try {
        const res = await getUserTicketAPI(55);
        userTicket.value = res.map((item) => {
            const date = new Date(item.createTime);
            item.createTime = `${date.getFullYear()}-${String(
                date.getMonth() + 1
            ).padStart(2, '0')}-${String(date.getDate()).padStart(2, '0')}`;
            return item;
        });
        console.log(res);
        console.log(id);
    } catch (err) {
        console.log(err);
    }
};

onMounted(() => {
    getTicket();
    goPolling();
});

onUnmounted(() => {
    stopPolling();
});
</script>

<style scoped>
.v-card {
    font-size: 30px;
    position: relative;
    margin: 7px;
}
.dashed-line-wrapper {
    position: absolute;
    top: 0;
    right: 150px;
    height: 100%;
}
</style>
