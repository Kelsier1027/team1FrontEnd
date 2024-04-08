import { createRouter, createWebHistory } from 'vue-router';
import Layout from '@/views/Layout/index.vue';
import Hotel from '@/views/Hotel/index.vue';
import HotelList from '@/views/Hotel/HotelList.vue';
import HotelRoom from '@/views/Hotel/HotelRoom.vue';
import Tour from '@/views/Tour/index.vue';
import Tour2 from '@/views/Tour2/index2.vue';
import Member from '@/views/Member/index.vue';
import AccountSetting from '@/views/Member/components/AccountSetting.vue';
import MembershipBenefits from '@/views/Member/components/MembershipBenefits.vue';
import DiscountCoupons from '@/views/Member/components/DiscountCoupons.vue';
import Coins from '@/views/Member/components/Coins.vue';
import Quests from '@/views/Member/components/Quests.vue';
// import Orders from '@/views/Member/components/Orders.vue';
import Messages from '@/views/Member/components/Messages.vue';
import Favorites from '@/views/Member/components/Favorites.vue';
import Attraction from '@/views/Ticket/attraction/index.vue';
import AttractionContent from '@/views/Ticket/attractionContent/index.vue';
import AttractionOrder from '@/views/Ticket/attractionOrder/index.vue';
import AttractionTicket from '@/views/Ticket/attractionTicket/index.vue';
import AttractionQR from '@/views/Ticket/attractionQR/index.vue';
import CarIndex from '@/views/CarModel/Index.vue';
import CarSearch from '@/views/CarModel/CarSearch.vue';
import Order from '@/views/CarModel/Order.vue';
import Order2 from '@/views/CarModel/Order2.vue';
import toECPay from '@/views/CarModel/toECPay.vue';
import Success from '@/views/CarModel/Success.vue';
import OrdersForHomePage from '@/views/Orders/indexForHomePage.vue';
import Orders from '@/views/Orders/index.vue';
import ConfirmEmailSuccessed from '@/views/Member/components/ConfirmEmailSuccessed.vue';
import ResetPassword from '@/views/Member/components/ResetPassword.vue';
import { useMemberStore } from '@/stores/memberStore.js';
import CartFloatingCard from '@/views/Cart/components/FloatingCart.vue';

// 建立路徑
const routes = [
    {
        path: '/',
        component: Layout,
        children: [
            {
                path: 'ordersForHomePage',
                component: OrdersForHomePage,
                meta: { hideHeader: false },
            },
            {
                path: 'hotel',
                component: Hotel,
                meta: { hideHeader: false },
            },
            {
                path: 'hotel/list',
                name: 'HotelList',
                component: HotelList,
            },

            {
                path: '/hotel-room/:id', // :id 是動態路徑參數
                name: 'HotelRoom',
                component: HotelRoom,
            },
            {
                path: '/Tour',
                name: 'Tour',
                component: Tour,
                meta: { hideHeader: false },
                props: (route) => ({
                    selectedLocation: route.query.selectedLocation,
                    date: route.query.date,
                }),
            },
            {
                path: '/Tour2/:id',
                name: 'Tour2',
                component: Tour2,
            },
            {
                path: 'confirmEmailSuccessed',
                component: ConfirmEmailSuccessed,
                meta: { hideHeader: true },
                name: 'ConfirmEmailSuccessed',
            },
            {
                path: 'resetPassword',
                component: ResetPassword,
                meta: { hideHeader: true },
                name: 'ResetPassword',
                props: (route) => ({
                    memberAccount: route.query.memberAccount,
                    token: route.query.token,
                }),
            },
            {
                path: 'member/',
                component: Member,
                meta: { hideHeader: true, requiresAuth: true },
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
                path: '/',
                component: Attraction,
                meta: { hideHeader: false },
                name: 'Home',
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
                path: '/attraction_ticket',
                component: AttractionTicket,
            },
            {
                path: '/attraction_666',
                component: AttractionQR,
            },
            {
                path: '/rentCar',
                component: CarIndex,
            },
            {
                path: '/rentCar/car',
                component: CarSearch,
            },
            {
                path: '/rentCar/order/:str',
                name: 'order',
                component: Order,
            },
            {
                path: '/rentCar/order2/:str',
                name: 'order2',
                component: Order2,
            },
            {
                path: '/rentCar/toecpay/:str',
                name: 'toecpay',
                component: toECPay,
            },
            {
                path: '/rentCar/success/',
                component: Success,
            },
            // {
            //     path: '/orders/',
            //     meta: { requiresAuth: true },
            //     component: Orders,
            // },
        ],
    },
];

// 建立路由
const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
    routes: routes,
    // 跳轉頁面時，滾動到頂部
    scrollBehavior(to) {
        if (to.path == '/' && Object.keys(to.query).length) {
            return null;
        }
        return {
            top: 0,
        };
    },
});

//在每一次跳轉頁面時，確認是否有登入
router.beforeEach(async (to, from, next) => {
    const memberStore = useMemberStore();

    // 如果路由需要登录验证
    if (to.meta.requiresAuth) {
        // 如果用户未登录
        if (!memberStore.isLoggedIn) {
            // 尝试获取用户信息
            if (await memberStore.isCookieValid()) {
                await memberStore.getMemberInfo();
                next(); // 继续路由跳转
            } else {
                await memberStore.logout(); // 登出
                // 如果在会员页面，跳转到首页
                if (to.path.includes('/member')) {
                    next('/');
                } else {
                    // 跳轉回上一頁
                    next('/');
                }
            }
        } else {
            next(); // 已登录，继续路由跳转
        }
    } else {
        next(); // 不需要登录验证的路由，直接跳转
    }
});

export default router;
