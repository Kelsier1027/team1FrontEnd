// 封裝與會員相關的API
import http from '@/utils/https.js';

export const registerIdentityAPI = ({ email, password }) => {
    return http({
        url: '/register',
        method: 'POST',
        // 以 JSON 格式傳送資料
        headers: {
            'Content-Type': 'application/json',
        },
        data: { email, password },
    });
};

export const registerAPI = () => {
    return http({
        url: '/api/Members/registerToMember',
        method: 'GET',
        data: { email, password },
    });
};

export const loginAPI = (emailAndPassword) => {
    console.log(emailAndPassword);
    return http({
        // cookies
        url: '/login?useCookies=true',
        method: 'POST',
        // 以 JSON 格式傳送資料
        headers: {
            'Content-Type': 'application/json',
        },
        data: emailAndPassword,
    });
};

export const logoutAPI = () => {
    return http({
        url: '/api/Members/logout',
        method: 'POST',
    });
};

export const getLoginInfo = () => {
    console.log('getLoginInfo');
    return http({
        headers: {
            'Access-Control-Allow-Origin': 'https://localhost:7113', // 將回應標頭中的 Access-Control-Allow-Origin: 設定為 https://localhost:7113
        },
        url: '/api/Members/getLoginInfo',
        method: 'GET',
        // 強制帶入 cookies
        withCredentials: true,
    });
};
// 確認cookie驗證是否有效
export const checkCookie = () => {
    return http({
        url: '/api/Members/checkCookie',
        method: 'GET',
        // 強制帶入 cookies
        withCredentials: true,
    });
};
