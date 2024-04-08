<template>
    <v-card width="250px" class="d-flex flex-column">
        <v-card-item class="pa-0">
            <v-row>
                <v-col cols="3">
                    <v-avatar
                        color="rgba(38, 190, 201,1)"
                        size="50"
                        class="ma-3"
                        :text="memberFirstLetter"
                    >
                    </v-avatar>
                </v-col>
                <v-col
                    cols="6"
                    class="d-flex align-center ps-5"
                    style="font-weight: bold; font-size: 15px; color: #333333"
                >
                    {{ memberStore.firstName + ' ' + memberStore.lastName }}
                </v-col>
                <v-col cols="3" class="d-flex justify-end align-center">
                    <v-icon
                        icon="mdi-cog-outline"
                        class="me-4"
                        @click="toMemberAccountSetting"
                    ></v-icon>
                </v-col>
            </v-row>
            <v-divider class="ma-0 pa-0"></v-divider>
            <v-list
                class="-listitem custom-list-item"
                :items="items2"
                density="compact"
                style="font-size: 14px"
            >
            </v-list>
            <v-divider class="ma-0 pa-0"></v-divider>
            <v-list
                class="-listitem custom-list-item"
                :items="items3"
                density="compact"
                style="font-size: 14px"
            >
            </v-list>
            <v-divider class="m-0"></v-divider>
            <div class="p-2 d-flex justify-center align-center">
                <v-btn variant="plain" block @click="Logout">
                    <div class="font-weight-bold logoutBtn fontFamily">
                        登出
                    </div>
                </v-btn>
            </div>
        </v-card-item>
    </v-card>
</template>

<script setup>
import { ref, computed } from 'vue';
import { useMemberStore } from '@/stores/memberStore';
import { useRoute, useRouter } from 'vue-router';
const router = useRouter();
const route = useRoute();

const memberStore = useMemberStore();

console.log(memberStore.account[0]);
const memberFirstLetter = computed(() => {
    // 返回會員帳號的第一個字母
    return memberStore.account[0];
});

const toMemberAccountSetting = () => {
    router.push('/member/accountSetting');
};

const items1 = ref([
    {
        title: memberStore.account,
        value: '帳號設定',
        props: {
            // minHeight: '41px',
            prependIcon: 'mdi-cog-outline',
            to: '/member/accountSetting',
        },
    },
]);
const items2 = ref([
    {
        title: '我的會籍禮遇',
        subtitle: '我的會籍禮遇',
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
]);

const items3 = ref([
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
function Logout() {
    memberStore.logout();
}
</script>

<style scoped>
:deep(.fontFamily) {
    font-family: 'Noto Sans TC', '微软雅黑', 'Microsoft YaHei', 'sans-serif';
    /* border-bottom: 1px solid #dfdfdf; */
}
:deep(.logoutBtn) {
    font-size: 15px !important;
    font-weight: 600 !important;
    color: #333333 !important;
}
</style>
