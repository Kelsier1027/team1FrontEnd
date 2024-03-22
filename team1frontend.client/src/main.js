//import './assets/main.css';
// import '@/assets/js/jquery.min.js';

import { createApp } from 'vue';
import ElementPlus from 'element-plus';
import 'element-plus/dist/index.css';
import { createPinia } from 'pinia';
import App from './App.vue';
import router from './router';
// import thor from 'thor-x'
// import 'thor-x/dist/index.css'

import 'vuetify/styles';
import vuetify from './plugins/vuetify';

import '@/styles/common.scss';

// import signalr from './utils/signalR'
import axios from 'axios'

// // 引入懒加载指令插件并且注册
// import { lazyPlugin } from '@/directives';
// // 引入全局组件插件
// import { componentPlugin } from '@/components';

const pinia = createPinia();

const app = createApp(App);
// app.config.globalProperties.$signalr = signalr.signal;
axios.defaults.baseURL = "http://localhost:5102"
app.config.globalProperties.$http = axios;
app.use(ElementPlus);
app.use(vuetify);
app.use(pinia);
app.use(router);
app.mount('#app');
