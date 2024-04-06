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
    });
};

export const loginAPI = (emailAndPassword) => {
    // console.log(emailAndPassword);
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
    // console.log('getLoginInfo');
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
// 更改會員密碼
export const changePasswordAPI = (changePasswordData) => {
    console.log(changePasswordData);
    return http({
        url: '/api/Members/updatePassword',
        method: 'POST',
        data: changePasswordData,
    });
};
// 忘記密碼
export const forgetPasswordAPI = (username) => {
    // console.log({ username });

    return http({
        url: '/api/Members/GetResetPasswordEmail',
        headers: {
            'Content-Type': 'application/json',
        },
        method: 'POST',
        data: username,
    });
};
// 取得信箱驗證資訊
export const getEmailVerificationInfoAPI = () => {
    return http({
        url: '/api/Members/GetEmailVerificationInfo',
        method: 'GET',
    });
};

// 發送信箱驗證信
export const getEmailVerificationEmailAPI = (email) => {
    return http({
        url: '/api/Members/GetConfirmRegisterMail',
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        data: email,
    });
};

// 送出重設的新密碼
export const resetPasswordAPI = (resetPasswordData) => {
    return http({
        url: '/api/Members/ResetPassword',
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        data: resetPasswordData,
    });
};

// 使用 valid-google-login 來驗證 google token
export const googleLoginAPI = (token) => {
    return http({
        url: '/api/Members/GoogleLogin',
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        data: token,
    });
};
