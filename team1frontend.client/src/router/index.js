import { createRouter, createWebHistory } from 'vue-router';
import Home from '@/views/Home/index.vue';
import Layout from '@/views/Layout/index.vue';
import Hotel from '@/views/Hotel/index.vue';
import HotelList from '@/views/Hotel/HotelList.vue';
import HotelRoom from '@/views/Hotel/HotelRoom.vue';
import RentCar from '@/views/RentCar/index.vue';
import Ticket from '@/views/Ticket/index.vue';
import Tour from '@/views/Tour/index.vue';


// 建立路徑
const routes = [
    {
        path: '/',
        component: Layout,
        children: [
            {
                path: '',
                component: Home,
            },
            {
                path: 'home',
                component: Home,
            },
            {
                path: 'hotel',
                component: Hotel,
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
            },
            {
                path: 'ticket',
                component: Ticket,
            },
            {
                path: 'tour',
                component: Tour,
            },
        ],
    },
];

// 建立路由
const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
    routes: routes,
    // 跳轉頁面時，滾動到頂部
    scrollBehavior() {
        return {
            top: 0,
        };
    },
});

export default router;
