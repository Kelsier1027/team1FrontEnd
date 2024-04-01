import { createRouter, createWebHistory } from 'vue-router';
import Home from '@/views/Home/index.vue';
import Layout from '@/views/Layout/index.vue';
import Hotel from '@/views/Hotel/index.vue';
import HotelList from '@/views/Hotel/HotelList.vue';
import HotelRoom from '@/views/Hotel/HotelRoom.vue';
import Attraction from '@/views/Ticket/attraction/index.vue';
import AttractionContent from '@/views/Ticket/attractionContent/index.vue'
import AttractionOrder from '@/views/Ticket/attractionOrder/index.vue'
import Tour from '@/views/Tour/index.vue';
import Member from '@/views/Member/index.vue';
import AccountSetting from '@/views/Member/components/AccountSetting.vue';
import MembershipBenefits from '@/views/Member/components/MembershipBenefits.vue';
import DiscountCoupons from '@/views/Member/components/DiscountCoupons.vue';
import Coins from '@/views/Member/components/Coins.vue';
import Quests from '@/views/Member/components/Quests.vue';
import Orders from '@/views/Member/components/Orders.vue';
import Messages from '@/views/Member/components/Messages.vue';
import Favorites from '@/views/Member/components/Favorites.vue';
import RentCar from '@/views/RentCar/index.vue'
import CarSearch from '@/views/RentCar/CarSearch.vue'
import Order from '@/views/RentCar/Order.vue'
import Order2 from '@/views/RentCar/Order2.vue'
import toECPay from '@/views/RentCar/toECPay.vue'
import Success from '@/views/RentCar/Success.vue'
import Tour2 from '@/views/Tour2/index2.vue';
import { onMounted } from 'vue';



// 建立路徑
const routes = [
    {
        path: '/',
        component: Layout,
        children: [
            {
                path: '',
                component: Home,
                meta: { hideHeader: false },
            },
            {
                path: 'home',
                component: Home,
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
                path: 'rentCar',
                component: RentCar,
                meta: { hideHeader: false },
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
                path: '/rentCartoecpay/:str',
                name: 'toecpay',
                component: toECPay
            },
            {
                path: '/rentCar/success/',
                component: Success
            },
            {
                path: '/attraction',
                component: Attraction,
                meta: { hideHeader: false },
            },
            {
                path: '/attraction_content/:id',
                component: AttractionContent,
                name: 'AttractionContent',
            },
            {
                path: '/Tour',
                name: 'Tour',
                path: '/attraction_order',
                component: AttractionOrder,
            },
            {
                path: 'tour',
                component: Tour,
                meta: { hideHeader: false },
                props: (route) => ({ selectedLocation: route.query.selectedLocation, date: route.query.date })
            },
            {
                path: '/Tour2/:id',
                name: 'Tour2',
                component: Tour2, 
              },
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
           
        ],
    },
];

// 建立路由
const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
    routes: routes,
    // 跳轉頁面時，滾動到頂部
    scrollBehavior(to) {

        if (to.path == '/attraction') {
            return null;
        }

        return {
            top: 0,
        };
    },
});

export default router;
