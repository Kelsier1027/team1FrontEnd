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

// import '@/styles/common.scss';

import signalr from './utils/signalR'
// import axios from 'axios'

const pinia = createPinia();

const app = createApp(App);
app.config.globalProperties.$signalr = signalr.signal;
app.use(ElementPlus);
app.use(vuetify);
app.use(pinia);
app.use(router);
app.mount('#app');
