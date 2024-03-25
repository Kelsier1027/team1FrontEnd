import { createRouter, createWebHistory } from 'vue-router'
import Attraction from '@/views/attraction/index.vue'
import AttractionContent from '@/views/attractionContent/index.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/attraction',
      component: Attraction,

    },
    {
      path: '/attraction_content/:id',
      component: AttractionContent,
      name: 'AttractionContent',

    }
    // {
    //   path: '/about',
    //   name: 'about',
    //   // route level code-splitting
    //   // this generates a separate chunk (About.[hash].js) for this route
    //   // which is lazy-loaded when the route is visited.
    //   component: () => import('../views/AboutView.vue')
    // }
  ],
  scrollBehavior(to, from, savedPosition) {
    // 滾動到頂部
    return { top: 0 };
  },
})

export default router
