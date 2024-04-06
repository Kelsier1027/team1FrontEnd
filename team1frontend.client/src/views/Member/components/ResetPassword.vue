<template>
    <v-main>
        <v-row class="d-flex justify-center">
            <v-spacer></v-spacer>
            <v-col col="8">
                <v-form
                    ref="resetPasswordForm"
                    @submit.prevent="resetPassword"
                    class="mt-4"
                >
                    <div class="resetPasswordTitle fontFamily">重設密碼</div>

                    <div class="fontFamily detailInfo">
                        新密碼長度必須至少 6 個字元，且至少包含 1 個數字和 1
                        個英文字母 1 個特殊字元
                    </div>

                    <v-text-field
                        v-model="newPassword"
                        :rules="[
                            required,
                            hasNumber,
                            hasLetter,
                            minLength6,
                            hasSpecialCharacter,
                        ]"
                        class="originalField"
                        color="#26bec9"
                        single-line
                        density="comfortable"
                        variant="outlined"
                        label="新密碼"
                        clearable
                        :append-inner-icon="visible ? 'mdi-eye-off' : 'mdi-eye'"
                        :type="visible ? 'text' : 'password'"
                        @click:append-inner="visible = !visible"
                    >
                    </v-text-field>
                    <v-text-field
                        v-model="confirmPassword"
                        :rules="[
                            required,
                            hasNumber,
                            hasLetter,
                            minLength6,
                            hasSpecialCharacter,
                            passwordMatch,
                        ]"
                        class="originalField mt-2"
                        color="#26bec9"
                        single-line
                        density="comfortable"
                        variant="outlined"
                        label="再次確認新密碼"
                        clearable
                        :append-inner-icon="
                            visible2 ? 'mdi-eye-off' : 'mdi-eye'
                        "
                        :type="visible2 ? 'text' : 'password'"
                        @click:append-inner="visible2 = !visible2"
                    >
                    </v-text-field>
                    <div
                        class="d-flex justify-start"
                        style="margin-top: -18px; margin-bottom: 0"
                    >
                        <div
                            class="mb-3"
                            style="color: red; font-size: 13px; margin-top: 0"
                        >
                            {{ errorMessage }}
                        </div>
                    </div>

                    <v-btn
                        type="submit"
                        width="100%"
                        class="resetPassword-btn mt-2"
                        size="large"
                        variant="flat"
                        ><span class="" style="">重新設定</span>
                    </v-btn>
                </v-form>
            </v-col>
            <v-spacer></v-spacer>
        </v-row>
    </v-main>
</template>

<script setup>
import { ref, onMounted, watch } from 'vue';
import { useRoute, useRouter } from 'vue-router';
import { useMemberStore } from '@/stores/memberStore';
import { useAlertStore } from '@/stores/alertStore';
const alertStore = useAlertStore();
const visible = ref(false);
const visible2 = ref(false);
const loading = ref(false);
const memberStore = useMemberStore();
const errorMessage = ref('');
// 使用 useRoute() 取得路由實例
const route = useRoute();
// 使用 useRouter() 取得路由實例
const router = useRouter();

// 來自路由的會員帳號與 token
const memberAccount = ref(route.query.memberAccount);
const token = ref(route.query.token);

// 更改密碼表單實例
const resetPasswordForm = ref(null);

// 更改密碼表單資料
const newPassword = ref('');
const confirmPassword = ref('');

// alertStore.showAlert({
//     message: '密碼重設成功',
//     type: 'success',
// });

const resetPassword = async () => {
    // 檢查表單是否通過驗證
    const isValid = await resetPasswordForm.value.validate();

    // console.log(isValid.valid);
    if (isValid.valid) {
        // console.log('resetPassword');
        // 將所需資料打包為物件
        const data = {
            account: memberAccount.value,
            password: newPassword.value,
            confirmPassword: confirmPassword.value,
            token: token.value,
        };

        console.log('正在重設密碼...');
        // 呼叫 API 重設密碼
        const result = await memberStore.resetPassword(data);
        console.log(result);
        if (result) {
            console.log('重設密碼成功');
            // 使用 vuetify 3 的 alert 告知使用者，密碼重設成功
            alertStore.showAlert({
                message: '密碼重設成功',
                type: 'success',
            });
            // 重設密碼成功，導向登入頁
            router.push('/');
        } else {
            console.log('重設密碼失敗');
            // 重設密碼失敗，顯示錯誤訊息
            // errorMessage.value = '重設密碼失敗，請重新取得重設密碼信件';
            alertStore.showAlert({
                message: '重設密碼失敗，請重新取得重設密碼信件',
                type: 'error',
            });
            // 重設密碼失敗，導向登入頁
            router.push('/');
        }
    }
};

// 更改密碼表單規則
const required = (v) => !!v || '此欄位為必填';
// 檢查密碼至少包含 1 個數字
const hasNumber = (v) => /\d/.test(v) || '密碼至少包含 1 個數字';
// 檢查密碼至少包含 1 個英文字母
const hasLetter = (v) => /[a-zA-Z]/.test(v) || '密碼至少包含 1 個英文字母';
// 檢查密碼長度至少 6 個字元
const minLength6 = (v) => (v && v.length >= 6) || '密碼長度至少 6 個字元';
// 檢查密碼至少包含一個特殊字元
const hasSpecialCharacter = (v) =>
    /[!@#$%^&*()_+\-=\[\]{};':"\\|,.<>\/?]+/.test(v) ||
    '密碼至少包含一個特殊字元';
// 檢查新密碼與確認密碼是否相同
const passwordMatch = (v) => v === newPassword.value || '密碼不相符';
</script>

<style scoped>
:deep(.fontFamily) {
    font-family: 'Noto Sans TC', 微软雅黑, 'Microsoft YaHei', sans-serif;
}
:deep(.resetPasswordTitle) {
    font-size: 22px;
    font-weight: 700;
    color: #333333;
    padding-left: 10px;
    margin-bottom: 20px;
}

:deep(.fields) {
    color: #555555;
    font-size: 14px;
    margin-top: 0;
    margin-bottom: 10px;
}
:deep(.dot) {
    color: #e65f50;
    font-size: 14px;
}
:deep(.fieldsRow) {
    margin-bottom: 5px;
}
:deep(.detailInfo) {
    font-size: 13px;
    color: rgb(156, 157, 160);
    margin-bottom: 20px;
}
:deep(.resetPassword-btn) {
    font-weight: 500;
    font-size: 14px;
    color: white;
    border-radius: 5px;
    background-color: #5cbbc7;
    transition: background-color 0.3s;
}
:deep(.resetPassword-btn:hover) {
    background-color: #428c8c;
    font-size: 16px;
}
</style>
