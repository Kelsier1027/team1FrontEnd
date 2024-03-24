// axios 基礎的配置
import axios from 'axios';
import { useMemberStore } from '../stores/memberStore.js';
const httpInstance = axios.create({
    baseURL: 'https://localhost:7113',
    // timeout: 5000,
});

// 攔截器

// axios 請求攔截器
httpInstance.interceptors.request.use(
    (config) => {
        // 1. 從 pinia 中獲取 token
        // const memberStore = useMemberStore();
        // 2. 按照接口文檔添加 token
        // const token = memberStore.userInfo.token;
        // if (token) {
        //     config.headers.Authorization = `Bearer ${token}`;
        // }

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
