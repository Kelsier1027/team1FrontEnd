<template>
    <v-form ref="changePasswordForm" class="mt-4">
        <div class="changePasswordTitle fontFamily">更改密碼</div>
        <div class="fieldsRow">
            <span class="fields font-weight-medium fontFamily"> 原密碼 </span>
            <span class="dot"> * </span>
        </div>
        <v-text-field
            v-model="oldPassword"
            :rules="[required]"
            class="originalField"
            color="#26bec9"
            single-line
            density="comfortable"
            variant="outlined"
            label="原密碼"
        >
        </v-text-field>
        <div class="fieldsRow">
            <span class="fields font-weight-medium fontFamily"> 新密碼 </span>
            <span class="dot"> * </span>
        </div>
        <div class="fontFamily">
            新密碼長度必須至少 10 個字元，且至少包含 1 個數字和 1 個英文字母
        </div>
        <v-text-field
            v-model="newPassword"
            :rules="[
                required,
                hasNumber,
                hasLetter,
                minLength6,
                hasSpecialCharacter,
                passwordNotMatch,
            ]"
            class="originalField"
            color="#26bec9"
            single-line
            density="comfortable"
            variant="outlined"
            label="新密碼"
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
            class="originalField"
            color="#26bec9"
            single-line
            density="comfortable"
            variant="outlined"
            label="再次確認新密碼"
        >
        </v-text-field>
        <v-row justify="end" style="margin-top: -10px; margin-bottom: -2px">
            <v-col cols="auto">
                <v-btn
                    class="saveBtn"
                    size="large"
                    color="#26bec9"
                    variant="flat"
                    ><span class="saveBtnText" style="color: white">儲存</span>
                </v-btn>
            </v-col>
        </v-row>
    </v-form>
    <hr style="color: gray" />
    <div class="validateLoginEmailTitle fontFamily">驗證登入信箱</div>
    <div>
        <span>dnfd@sdfs.com</span
        ><span
            style="
                background-color: darkgrey;
                color: white;
                padding: 2px 5px;
                border-radius: 2px;
                font-size: 12px;
            "
            class="fontFamily"
            ><v-icon icon="mdi-shield-half"></v-icon>尚未驗證</span
        >
    </div>
    <v-btn class="mt-2" variant="outlined">重新發送驗證信</v-btn>
    <hr style="color: gray" />
    <div class="deleteAccountTitle fontFamily">刪除會員</div>
    <v-row justify="space-between">
        <v-col cols="6">
            <span>dnfd@sdfs.com</span>
        </v-col>
        <v-col cols="2" justify="start">
            <v-btn class="saveBtn" size="large" color="#26bec9" variant="flat"
                ><span class="saveBtnText" style="color: white">刪除會員</span>
            </v-btn>
        </v-col>
    </v-row>
</template>

<script setup>
import { ref, computed, onMounted } from 'vue';
import { useMemberStore } from '@/stores/memberStore.js';

const memberStore = useMemberStore();

// 更改密碼表單實例
const changePasswordForm = ref(null);

// 更改密碼表單資料
const oldPassword = ref('');
const newPassword = ref('');
const confirmPassword = ref('');

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
// 檢查舊密碼與新密碼不可相同
const passwordNotMatch = (v) =>
    v !== oldPassword.value || '新密碼不可與舊密碼相同';

// 檢查新密碼與確認密碼是否相同
const passwordMatch = (v) => v === newPassword.value || '密碼不相符';

// 儲存更改密碼
const saveChangePassword = async () => {
    if (changePasswordForm.value.validate().valid) {
        // 建立一個物件，包含更改密碼表單的資料
        let changePasswordData = {
            oldPassword: oldPassword.value,
            newPassword: newPassword.value,
            confirmPassword: confirmPassword.value,
        };
        try {
            // 呼叫更改密碼的 API
            const changeSuccessed = await memberStore.changePassword(
                changePasswordData
            );
            if (changeSuccessed) {
                // 更改密碼成功，清空表單資料
                oldPassword.value = '';
                newPassword.value = '';
                confirmPassword.value = '';
            }
        } catch (error) {
            console.log(error);
        }
    }
};
</script>

<style scoped>
.validateLoginEmailTitle {
    font-size: 18px;
    font-weight: 700;
    color: #333333;
    padding-left: 10px;
    border-left: 5px solid #333333;
    margin-bottom: 20px;
}
.deleteAccountTitle {
    font-size: 18px;
    font-weight: 700;
    color: #333333;
    padding-left: 10px;
    border-left: 5px solid #333333;
    margin-bottom: 20px;
}
:deep(.fontFamily) {
    font-family: 'Noto Sans TC', 微软雅黑, 'Microsoft YaHei', sans-serif;
}
:deep(.changePasswordTitle) {
    font-size: 18px;
    font-weight: 700;
    color: #333333;
    padding-left: 10px;
    border-left: 5px solid #333333;
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
</style>
