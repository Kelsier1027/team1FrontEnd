import { defineStore } from 'pinia';
import {
    registerAPI,
    loginAPI,
    logoutAPI,
    getLoginInfo,
    registerIdentityAPI,
    checkCookie,
    
} from '../apis/auth.js';

import {
    getMemberInfoAPI,
    updateMemberDetailInfoAPI,
} from '../apis/Member/memberInfoApis.js';
import { ref } from 'vue';

export const useMemberStore = defineStore('member', () => {
    // 定義狀態和方法

    // 會員資料及登入狀態
    const memberId = ref(null); // 用戶ID
    const account = ref(null); // 用戶帳號
    const firstName = ref(null); // 用戶名
    const lastName = ref(null); // 用戶姓
    const profileImage = ref(null); // 用戶頭像，預設為 null
    const isLoggedIn = ref(false); // 登入狀態

    // const gender = ref(null); // 用戶性別
    // const dateOfBirth = ref(null); // 用戶生日
    // const email = ref(null); // 用戶信箱
    // const phoneNumber = ref(null); // 用戶電話
    // const country = ref(null); // 用戶國家
    // const dialCode = ref(null); // 用戶國碼

    const getMemberInfo = async () => {
        // 先確認 cookie 驗證是否有效
        const responseOfCheckCookie = await checkCookie();
        console.log(responseOfCheckCookie);
        // if (!responseOfCheckCookie) {
        //     // 如果 cookie 驗證失敗，執行登出
        //     logout();
        //     return;
        // }
        // console.log('getMemberInfo');
        // 叫用後端API取得用戶信息，自動帶入 cookie 中的 token
        const response = await getLoginInfo();
        console.log(response);
        memberId.value = response.id;
        // 將 account 的空格去除
        account.value = response.account.replace(/\s+/g, '');
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
        // 清除用戶信息和登入狀態
        memberId.value = null;
        account.value = null;
        firstName.value = null;
        lastName.value = null;
        isLoggedIn.value = false;
        await logoutAPI();
    };
    // 取得會員詳細資訊
    const getMemberDetailInfo = async (account) => {
        // const responseOfCheckCookie = await checkCookie();
        // console.log(responseOfCheckCookie);
        // if (!responseOfCheckCookie) {
        //     // 如果 cookie 驗證失敗，執行登出
        //     logout();
        //     return;
        // }
        const response = await getMemberInfoAPI(account);
        console.log(response);
        // 將 API 回傳的資料以物件形式回傳
        return response;
    };
    // 更新會員詳細資訊
    const updateMemberDetailInfo = async (memberDetailInfo) => {
        // const responseOfCheckCookie = await checkCookie();
        // console.log(responseOfCheckCookie);

        // if (!responseOfCheckCookie) {
        //     // // 如果 cookie 驗證失敗，執行登出
        //     // logout();
        //     // return;
        // }
        console.log(memberDetailInfo, 'memberStore');
        const response = await updateMemberDetailInfoAPI(memberDetailInfo);
        console.log(response);
        // 將 API 回傳的資料以物件形式回傳
        return response;
    };
    // 更改會員密碼
    const changePassword = async (changePasswordData) => {
        const response = await changePasswordAPI(changePasswordData);
        console.log(response);
        return response;
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
        getMemberDetailInfo,
        updateMemberDetailInfo,
        changePassword,
    };
});
