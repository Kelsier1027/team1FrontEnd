// 封裝與會員相關的API
import http from '@/utils/https.js';

export const registerAPI = ({ account, password }) => {
    return http({
        url: '/api/Members/register',
        method: 'POST',
        data: { account, password },
    });
};

export const loginAPI = ({ account, password }) => {
    // console.log(account, password);
    return http({
        url: '/api/Members/login',
        method: 'POST',
        data: { account, password },
    });
};

export const logoutAPI = () => {
    return http({
        url: '/api/Members/logout',
        method: 'POST',
    });
};
