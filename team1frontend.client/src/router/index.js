import { createRouter, createWebHistory } from 'vue-router';
import Home from '@/views/Home/index.vue';
import Layout from '@/views/Layout/index.vue';
import Member from '@/views/Member/index.vue';
import AccountSetting from '@/views/Member/components/AccountSetting.vue';
import MembershipBenefits from '@/views/Member/components/MembershipBenefits.vue';
import DiscountCoupons from '@/views/Member/components/DiscountCoupons.vue';
import Coins from '@/views/Member/components/Coins.vue';
import Quests from '@/views/Member/components/Quests.vue';
import Orders from '@/views/Member/components/Orders.vue';
import Messages from '@/views/Member/components/Messages.vue';
import Favorites from '@/views/Member/components/Favorites.vue';
import Attraction from '@/views/Ticket/attraction/index.vue';
import AttractionContent from '@/views/Ticket/attractionContent/index.vue'
import AttractionOrder from '@/views/Ticket/attractionOrder/index.vue'
import CarIndex from '@/views/CarModel/Index.vue'
import CarSearch from '@/views/CarModel/CarSearch.vue'
import Order from '@/views/CarModel/Order.vue'
import Order2 from '@/views/CarModel/Order2.vue'
import toECPay from '@/views/CarModel/toECPay.vue'
import Success from '@/views/CarModel/Success.vue'


// 建立路徑
const routes = [
    {
        path: '/',
        component: Layout,
        children: [
            {
                path: 'member/',
                component: Member,
                meta: { hideHeader: true },
                children: [
                    {
                        path: '',
                        component: AccountSetting,
                    },
                    {
                        path: 'accountSetting',
                        component: AccountSetting,
                    },
                    {
                        path: 'membershipBenefits',
                        component: MembershipBenefits,
                    },
                    {
                        path: 'discountCoupons',
                        component: DiscountCoupons,
                    },
                    {
                        path: 'coins',
                        component: Coins,
                    },
                    {
                        path: 'quests',
                        component: Quests,
                    },
                    {
                        path: 'orders',
                        component: Orders,
                    },
                    {
                        path: 'messages',
                        component: Messages,
                    },
                    {
                        path: 'favorites',
                        component: Favorites,
                    },
                ],
            },
            {
                path: '',
                component: Attraction,
                meta: { hideHeader: false },
            },
            {
                path: '/attraction_content/:id',
                component: AttractionContent,
                name: 'AttractionContent',
            },
            {
                path: '/attraction_order',
                component: AttractionOrder,
            },
            {
                path: '/rentCar',
                component: CarIndex
            },
            {
                path: '/rentCar/car',
                component: CarSearch
            },
            {
                path: '/rentCar/order/:str',
                name: 'order',
                component: Order
            },
            {
                path: '/rentCar/order2/:str',
                name: 'order2',
                component: Order2
            },
            {
                path: '/rentCar/toecpay/:str',
                name: 'toecpay',
                component: toECPay
            },
            {
                path: '/rentCar/success/',
                component: Success
            }
        ],
    },
];

// 建立路由
const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
    routes: routes,
    // 跳轉頁面時，滾動到頂部
    scrollBehavior(to) {
        if (to.path == '/attraction' && Object.keys(to.query).length) {
            return null;
        }
        return {
            top: 0,
        };
    },
});

export default router;
