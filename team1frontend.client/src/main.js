//import './assets/main.css';
// import '@/assets/js/jquery.min.js';

import { createApp } from 'vue';
// import ElementPlus from 'element-plus';
// import 'element-plus/dist/index.css';
import { createPinia } from 'pinia';
import App from './App.vue';
import router from './router';

import 'vuetify/styles';
import vuetify from './plugins/vuetify';

// import '@/styles/common.scss';

// // 引入懒加载指令插件并且注册
// import { lazyPlugin } from '@/directives';
// // 引入全局组件插件
// import { componentPlugin } from '@/components';

const pinia = createPinia();

const app = createApp(App);
// app.use(ElementPlus);
app.use(vuetify);
app.use(pinia);
app.use(router);
app.mount('#app');
