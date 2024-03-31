<script setup>
import { ref, onMounted } from 'vue';
import { useMemberStore } from '@/stores/memberStore';
const memberStore = useMemberStore();

const items = ref([
    {
        title: '帳號設定',
        value: '帳號設定',
        props: {
            // minHeight: '41px',
            prependIcon: 'mdi-cog-outline',
            to: '/member/accountSetting',
        },
    },
    {
        title: '我的會籍禮遇',
        value: '我的會籍禮遇',
        props: {
            // minHeight: '41px',
            prependIcon: 'mdi-diamond-stone',
            to: '/member/membershipBenefits',
        },
    },
    {
        title: 'HKday 折扣券',
        value: 'HKday 折扣券',
        props: {
            // minHeight: '41px',
            prependIcon: 'mdi-ticket-confirmation-outline',
            to: '/member/discountCoupons',
        },
    },
    {
        title: 'HKday Coins',
        value: 'HKday Coins',
        props: {
            // minHeight: '41px',
            prependIcon: 'mdi-bitcoin',
            to: '/member/coins',
        },
    },
    {
        title: '解任務，賺獎勵',
        value: '解任務，賺獎勵',
        props: {
            // minHeight: '41px',
            prependIcon: 'mdi-flag-checkered',
            to: '/member/quests',
        },
    },
    {
        title: '訂單管理',
        value: '訂單管理',
        props: {
            // minHeight: '41px',
            prependIcon: 'mdi-form-select',
            to: '/member/orders',
        },
    },
    {
        title: '訊息管理',
        value: '訊息管理',
        props: {
            // minHeight: '41px',
            prependIcon: 'mdi-chat-outline',
            to: '/member/messages',
        },
    },
    {
        title: '我的收藏',
        value: '我的收藏',
        props: {
            // minHeight: '41px',
            prependIcon: 'mdi-heart-outline',
            to: '/member/favorites',
        },
    },
]);
</script>

<template>
    <v-main style="background-color: #f5f5f5">
        <v-container class="container">
            <v-row>
                <v-col cols="3">
                    <div class="page-aside">
                        <v-card class="aside-box" variant="flat">
                            <v-card-title
                                class="text-center align-center justify-center"
                                ><v-btn
                                    icon="mdi-account"
                                    size="120px"
                                    elevation="0"
                                    border="1"
                                    color="#f5f5f5"
                                    class=""
                                >
                                </v-btn>
                                <div
                                    class="font-weight-bold text-subtitle-1"
                                    style="
                                        margin: 10px 0 4px;
                                        font-size: 16px;
                                        font-family: 'Noto Sans TC', '微软雅黑',
                                            'Microsoft YaHei', 'sans'-serif;
                                        color: #333333;
                                    "
                                >
                                    {{ memberStore.firstName + ' ' }}

                                    {{ memberStore.lastName }}
                                </div>
                                <div
                                    style="
                                        font-size: 14px;
                                        font-family: 'Noto Sans TC', '微软雅黑',
                                            'Microsoft YaHei', 'sans'-serif;
                                        color: #666666;
                                        height: 23px;
                                    "
                                    class="d-flex justify-center align-center"
                                >
                                    白銀會員
                                </div>

                                <div class="account-group">
                                    <div class="account">
                                        <img
                                            src="https://cdn.kkday.com/pc-web/assets/img/KKday_member_icon.svg"
                                            class="channel-icon"
                                        />
                                        <div class="channel-name">
                                            <div>小白旅遊 會員</div>
                                            <div class="channel-login-id">
                                                {{ memberStore.account }}
                                            </div>
                                        </div>
                                        <v-icon
                                            icon="mdi-check-circle-outline"
                                            color="rgb(61, 200, 200)"
                                            size="22px"
                                        />
                                    </div>
                                </div>
                            </v-card-title>
                        </v-card>
                        <v-card
                            variant="flat"
                            class="page-menu list-item-group"
                        >
                            <v-list
                                class="-listitem custom-list-item"
                                Height="41px"
                                :items="items"
                            >
                            </v-list>
                        </v-card>
                    </div>
                </v-col>
                <v-col cols="9"> <RouterView /></v-col>
            </v-row>
        </v-container>
    </v-main>
</template>

<style scoped>
.container {
    padding-right: 15px;
    padding-left: 15px;
    margin-right: auto;
    margin-left: auto;
}

@media (min-width: 768px) {
    .container {
        width: 750px;
    }
}

@media (min-width: 992px) {
    .container {
        width: 970px;
    }
}

@media (min-width: 1200px) {
    .container {
        width: 1170px;
    }
}

.page-aside .account-group {
    border-top: 1px solid #eee;
    margin: 15px -15px 0;
    padding: 10px 15px 0;
}

.page-aside .account {
    display: flex;
    -webkit-box-align: start;
    -ms-flex-align: start;
    align-items: flex-start;
    position: relative;
    margin-top: 10px;
    text-align: left;
    line-height: 1.4;
}

.page-aside .account .channel-icon {
    -webkit-box-flex: 0;
    -ms-flex: 0 0 auto;
    flex: 0 0 auto;
    height: 20px;
    margin-right: 10px;
}

.page-aside .account .channel-name {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 auto;
    flex: 1 1 auto;
    min-width: 0;
    font-size: 14px;
}
.account span {
    vertical-align: top;
}

.page-aside .account .channel-login-id {
    text-overflow: ellipsis;
    white-space: nowrap;
    overflow: hidden;
    font-size: 12px;
}
.page-aside .aside-box {
    padding: 15px;
    background-color: #fff;
    border-radius: 6px;
    margin-bottom: 15px;
}
.page-menu {
    list-style: none;
    padding-left: 0;
    background-color: #fff;
    border-radius: 5px;
    margin-top: 15px;
}
.list-item-group {
    line-height: 1.5;
}
.v-list {
    padding: 0 0 0 0 !important;
}
:deep(.v-list-item) {
    height: 21px !important;
    padding: 0px 15px 0px 0px !important;
    margin: 0px 0px 0px 0px !important;
    display: flex;
    align-items: center;
}
:deep(.v-list-item--active) {
    /* color: rgb(34, 155, 155) !important; */
}
:deep(.v-list-item--active) .v-list-item-title {
    color: rgb(30, 145, 145) !important;
}
:deep(.v-list-item--active .v-icon) {
    color: rgb(30, 145, 145) !important;

    border-left: 4px solid #26bec9;
}
:deep(.v-list-item--active .v-list-item__overlay) {
    color: rgb(61, 200, 200) !important;
}
:deep(.custom-list-item .v-list-item-title) {
    font-size: 14px;
    color: #333333;
    font-family: Noto Sans TC, 微软雅黑, Microsoft YaHei, sans-serif;
    height: 21px;
    display: flex;
    align-items: center;
}
:deep(.v-list-item__spacer) {
    display: none; /* 移除间隙 */
}
:deep(.custom-list-item .v-list-item) {
    margin: 0px 0px !important;
}

:deep(.v-list-item .v-icon) {
    margin-right: 20px;
    padding: 0px 0px 0px 25px !important;
}

:deep(.aside-box) {
    padding-right: 0px !important;
    padding-left: 0px !important;
    padding-bottom: 7px !important;
}
</style>
