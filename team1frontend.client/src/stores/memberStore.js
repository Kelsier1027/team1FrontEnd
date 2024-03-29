import { defineStore } from 'pinia';
import {
    registerAPI,
    loginAPI,
    logoutAPI,
    getLoginInfo,
    registerIdentityAPI,
} from '../apis/auth.js';
import { ref } from 'vue';

export const useMemberStore = defineStore('member', () => {
    // 定義狀態和方法

    // 會員資料及登入狀態
    const memberId = ref(null); // 用戶ID
    const account = ref(null); // 用戶帳號
    const firstName = ref(null); // 用戶名
    const lastName = ref(null); // 用戶姓
    const isLoggedIn = ref(false); // 登入狀態

    const getMemberInfo = async () => {
        // console.log('getMemberInfo');
        // 叫用後端API取得用戶信息，自動帶入 cookie 中的 token
        const response = await getLoginInfo();
        console.log(response);
        memberId.value = response.id;
        account.value = response.account;
        firstName.value = response.firstName;
        lastName.value = response.lastName;
        isLoggedIn.value = true;
    };
    const register = async (emailAndPassword) => {
        console.log(emailAndPassword);
        const responseOfRegisterIdentityAPI = await registerIdentityAPI(
            emailAndPassword
        );
        // 如果註冊 IdentityUser 成功，先登入 IdentityUser 再註冊客製化會員
        if (responseOfRegisterIdentityAPI) {
            const responseOfLoginAPI = await loginAPI(emailAndPassword);
            if (responseOfLoginAPI) {
                await registerAPI();
            }
        }
    };
    const login = async (emailAndPassword) => {
        const response = await loginAPI(emailAndPassword);
        // 如果登入成功，取得用戶信息
        console.log('登入成功');
        // await getMemberInfo();
    };
    const logout = async () => {
        await logoutAPI();
        // 清除用戶信息和登入狀態
        memberId.value = null;
        account.value = null;
        firstName.value = null;
        lastName.value = null;
        isLoggedIn.value = false;
    };

    return {
        memberId,
        account,
        firstName,
        lastName,
        isLoggedIn,
        getMemberInfo,
        login,
        logout,
        register,
    };
});
