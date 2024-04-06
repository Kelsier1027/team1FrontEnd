//import './assets/main.css';
// import '@/assets/js/jquery.min.js';

import { createApp } from 'vue';
import ElementPlus from 'element-plus';
import 'element-plus/dist/index.css';
import { createPinia } from 'pinia';
import App from './App.vue';
import router from './router';
import 'bootstrap/dist/css/bootstrap.min.css'
import * as ElementPlusIconsVue from '@element-plus/icons-vue'
// import thor from 'thor-x'
// import 'thor-x/dist/index.css'

/* import the fontawesome core */
import { library } from '@fortawesome/fontawesome-svg-core'

/* import font awesome icon component */
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome'

/* import specific icons */
import { faLocationDot } from '@fortawesome/free-solid-svg-icons'
import { faCar } from '@fortawesome/free-solid-svg-icons'
import { faGear } from '@fortawesome/free-solid-svg-icons'
import { faGasPump } from '@fortawesome/free-solid-svg-icons'
import { faCircleCheck } from '@fortawesome/free-solid-svg-icons'
/* add icons to the library */
library.add(faLocationDot)
library.add(faCar)
library.add(faGear)
library.add(faGasPump)
library.add(faCircleCheck)

import 'vuetify/styles';
import vuetify from './plugins/vuetify';

// import '@/styles/common.scss';

import signalr from './utils/signalR'
 import axios from 'axios'

const pinia = createPinia();

const app = createApp(App);
for (const [key, component] of Object.entries(ElementPlusIconsVue)) {
  app.component(key, component)
}

// app.config.globalProperties.$signalr = signalr.signal;
//axios.defaults.baseURL = "http://localhost:5102"
app.config.globalProperties.$http = axios;
app.config.globalProperties.$signalr = signalr.signal;
app.use(ElementPlus);
app.use(vuetify);
app.use(pinia);
app.component('font-awesome-icon', FontAwesomeIcon)
app.use(router);
app.component('font-awesome-icon', FontAwesomeIcon)
app.mount('#app');
