import { defineStore } from 'pinia';
import { registerAPI, loginAPI, logoutAPI } from '../apis/auth.js';
import { ref } from 'vue';

export const useMemberStore = defineStore('member', () => {
    // 定義狀態和方法

    // 會員資料及登入狀態
    const memberId = ref(null); // 用戶ID
    const account = ref(null); // 用戶帳號
    const firstName = ref(null); // 用戶名
    const lastName = ref(null); // 用戶姓
    const isLoggedIn = ref(false); // 登入狀態

    const register = async (accountAndPassword) => {
        const response = await registerAPI(accountAndPassword);

        // 處理註冊成功的邏輯（如自動登入、跳轉等）
        // 這裡假設後端在註冊後自動進行登入並返回用戶信息和token
        memberId.value = response.id;
        account.value = response.account;
        firstName.value = response.firstName;
        lastName.value = response.lastName;
    };
    const login = async (accountAndPassword) => {
        // console.log(credentials);
        const response = await loginAPI(accountAndPassword);
        // console.log(response);
        // 設置用戶信息和登入狀態
        // console.log(response);
        memberId.value = response.id;
        account.value = response.account;
        firstName.value = response.firstName;
        lastName.value = response.lastName;
        isLoggedIn.value = true;
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
        login,
        logout,
        register,
    };
});
