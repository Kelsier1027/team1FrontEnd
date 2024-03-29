// axios 基礎的配置
import axios from 'axios';
axios.defaults.withCredentials = true; // 跨域請求時發送 cookies
import { useMemberStore } from '../stores/memberStore.js';
const httpInstance = axios.create({
    baseURL: 'https://localhost:7113',
    // 將回應標頭中的 Access-Control-Allow-Origin: 設定為 https://localhost:7113
    headers: {
        'Access-Control-Allow-Origin': 'https://localhost:7113',
    },
    withCredentials: true, // 跨域請求時發送 cookies
    // timeout: 5000,
});

// 攔截器

// axios 請求攔截器
httpInstance.interceptors.request.use(
    (config) => {
        return config;
    },
    (e) => {
        Promise.reject(e);
    }
);

// axios 響應式攔截器
httpInstance.interceptors.response.use(
    (res) => res.data,
    (e) => {
        // 統一處理錯誤
        return Promise.reject(e);
    }
);

export default httpInstance;
