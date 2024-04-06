import { defineStore } from 'pinia';
import {
    registerAPI,
    loginAPI,
    logoutAPI,
    getLoginInfo,
    registerIdentityAPI,
    checkCookie,
    forgetPasswordAPI,
    getEmailVerificationInfoAPI,
    getEmailVerificationEmailAPI,
    resetPasswordAPI,
    changePasswordAPI,
} from '../apis/auth.js';

import {
    getMemberInfoAPI,
    updateMemberDetailInfoAPI,
} from '../apis/Member/memberInfoApis.js';
import { ref, computed } from 'vue';
import { useRouter, useRoute } from 'vue-router';

export const useMemberStore = defineStore('member', () => {
    // 定義狀態和方法
    const router = useRouter();
    const route = useRoute();
    // 供外部使用的狀態和方法，使用 computed 來監聽狀態變化
    // 判斷是否有從資料庫取得的對應資料，如果有則回傳，否則執行 getMemberInfo 後取得再回傳
    const memberId = computed(() => {
        if (dbMemberId.value !== null) {
            return dbMemberId.value;
        } else {
            getMemberInfo();
            return dbMemberId.value;
        }
    });
    const account = computed(() => {
        if (dbAccount.value !== null) {
            return dbAccount.value;
        } else {
            getMemberInfo();
            return dbAccount.value;
        }
    });

    const firstName = computed(() => {
        if (dbFirstName.value !== null) {
            return dbFirstName.value;
        } else {
            getMemberInfo();
            return dbFirstName.value;
        }
    });
    const lastName = computed(() => {
        if (dbLastName.value !== null) {
            return dbLastName.value;
        } else {
            getMemberInfo();
            return dbLastName.value;
        }
    });
    const isLoggedIn = ref(false); // 是否登入，預設為 false
    const profileImage = ref(null); // 用戶頭像，預設為 null

    // 從資料庫取得的會員資料
    const dbMemberId = ref(null); // 用戶ID
    const dbAccount = ref(null); // 用戶帳號
    const dbFirstName = ref(null); // 用戶名
    const dbLastName = ref(null); // 用戶姓
    const dbProfileImage = ref(null); // 用戶頭像，預設為 null

    const getMemberInfo = async () => {
        // 先確認 cookie 驗證是否有效
        const responseOfCheckCookie = await checkCookie();
        // console.log(responseOfCheckCookie);
        if (!responseOfCheckCookie) {
            // 如果 cookie 驗證失敗，執行登出
            logout();
            return;
        }
        // console.log('getMemberInfo');
        // 叫用後端API取得用戶信息，自動帶入 cookie 中的 token
        const response = await getLoginInfo();
        // console.log(response);
        dbMemberId.value = response.id;
        // 將 account 的空格去除
        dbAccount.value = response.account.replace(/\s+/g, '');
        dbFirstName.value = response.firstName;
        dbLastName.value = response.lastName;
        isLoggedIn.value = true;
    };
    const register = async (emailAndPassword) => {
        const responseOfRegisterIdentityAPI = await registerIdentityAPI(
            emailAndPassword
        );
        // 如果註冊 IdentityUser 成功，先登入 IdentityUser 再註冊客製化會員
        await loginAPI(emailAndPassword);
        await registerAPI();
        await getMemberInfo();
    };
    const login = async (emailAndPassword) => {
        const response = await loginAPI(emailAndPassword);
        // 如果登入成功，取得用戶信息
        console.log('登入成功');
        await getMemberInfo();
    };
    const logout = async () => {
        // 清除用戶信息和登入狀態
        dbMemberId.value = null;
        dbAccount.value = null;
        dbFirstName.value = null;
        dbLastName.value = null;
        isLoggedIn.value = false;
        await logoutAPI();
        // 檢查目前是否在會員/member 之下的頁面，如果是則導向首頁
        if (route.path.includes('/member')) {
            router.push('/');
        }
    };
    // 取得會員詳細資訊
    const getMemberDetailInfo = async (account) => {
        const response = await getMemberInfoAPI(account);

        return response;
    };
    // 更新會員詳細資訊
    const updateMemberDetailInfo = async (memberDetailInfo) => {
        const response = await updateMemberDetailInfoAPI(memberDetailInfo);

        return response;
    };
    // 更改會員密碼
    const changePassword = async (changePasswordData) => {
        const response = await changePasswordAPI(changePasswordData);
        // console.log(response);
        return response;
    };
    // 確認 cookie 驗證是否有效
    const isCookieValid = () => {
        const response = checkCookie();
        // console.log(response);
        return response;
    };
    // 忘記密碼
    const sendForgetPasswordEmail = async (email) => {
        const response = await forgetPasswordAPI(email);
        // console.log(response);
        return response;
    };
    // 透過 cookie 驗證取得信箱驗證資訊
    const getEmailVerificationInfo = async () => {
        const response = await getEmailVerificationInfoAPI();
        // console.log(response);
        return response;
    };
    // 透過信箱取得驗證信
    const getEmailVerificationEmail = async (email) => {
        const response = await getEmailVerificationEmailAPI(email);
        // console.log(response);
        return response;
    };
    // 重設密碼
    const resetPassword = async (resetPasswordData) => {
        const response = await resetPasswordAPI(resetPasswordData);
        // console.log(response);
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
        isCookieValid,
        sendForgetPasswordEmail,
        getEmailVerificationInfo,
        getEmailVerificationEmail,
        resetPassword,
    };
});
