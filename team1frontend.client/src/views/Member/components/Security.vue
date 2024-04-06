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
            clearable
            :append-inner-icon="visible ? 'mdi-eye-off' : 'mdi-eye'"
            :type="visible ? 'text' : 'password'"
            @click:append-inner="visible = !visible"
        >
        </v-text-field>
        <div class="fieldsRow mt-2">
            <span class="fields font-weight-medium fontFamily"> 新密碼 </span>
            <span class="dot"> * </span>
        </div>
        <div class="fontFamily detailInfo">
            新密碼長度必須至少 6 個字元，且至少包含 1 個數字和 1 個英文字母 1
            個特殊字元
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
            clearable
            :append-inner-icon="visible2 ? 'mdi-eye-off' : 'mdi-eye'"
            :type="visible2 ? 'text' : 'password'"
            @click:append-inner="visible2 = !visible2"
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
            :append-inner-icon="visible3 ? 'mdi-eye-off' : 'mdi-eye'"
            :type="visible3 ? 'text' : 'password'"
            @click:append-inner="visible3 = !visible3"
        >
        </v-text-field>
        <v-row justify="end" style="margin-top: -10px; margin-bottom: -2px">
            <v-col cols="auto">
                <v-btn
                    class="saveBtn btn"
                    size="large"
                    variant="flat"
                    @click="saveChangePassword"
                    ><span class="saveBtnText">儲存</span>
                </v-btn>
            </v-col>
        </v-row>
    </v-form>
    <hr style="color: gray" />
    <div class="validateLoginEmailTitle fontFamily">驗證登入信箱</div>
    <div>
        <span class="mr-2">{{ memberStore.account }}</span
        ><span
            style="
                color: white;
                padding: 2px 5px;
                border-radius: 2px;
                font-size: 12px;
            "
            class="fontFamily"
            :class="isEmailVerified ? 'blueBG' : 'grayBG'"
            ><v-icon icon="mdi-shield-half"></v-icon
            >{{ emailVerificationInfo }}</span
        >
    </div>
    <v-btn
        v-if="!isEmailVerified"
        class="mt-2"
        variant="outlined"
        @click="getEmailVerification"
        >重新發送驗證信</v-btn
    >
    <hr style="color: gray" />
    <div class="deleteAccountTitle fontFamily">刪除會員</div>
    <v-row class="d-flex justify-space-between">
        <v-col cols="auto">
            <span>{{ memberStore.account }}</span>
        </v-col>
        <v-col cols="auto">
            <v-btn class="deleteBtn" size="large" variant="flat"
                ><span class="">刪除會員</span>
            </v-btn>
        </v-col>
    </v-row>
</template>

<script setup>
import { ref, computed, onMounted } from 'vue';
import { useMemberStore } from '@/stores/memberStore.js';
import { useAlertStore } from '@/stores/alertStore.js';

const alertStore = useAlertStore();

const memberStore = useMemberStore();
const visible = ref(false);
const visible2 = ref(false);
const visible3 = ref(false);

const isEmailVerified = ref(false);
// 驗證信箱訊息
const emailVerificationInfo = computed(() =>
    isEmailVerified.value ? '已驗證' : '尚未驗證'
);

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
    const validate = await changePasswordForm.value.validate();
    console.log(validate.valid);
    if (validate.valid) {
        // 建立一個物件，包含更改密碼表單的資料
        let changePasswordData = {
            account: memberStore.account,
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
                alertStore.showAlert({
                    message: '密碼變更成功',
                    type: 'success',
                });
            }
        } catch (error) {
            console.log(error);
            alertStore.showAlert({
                message: '密碼變更失敗',
                type: 'error',
            });
        }
    }
};
// 取得信箱驗證信
const getEmailVerification = async () => {
    try {
        // 呼叫取得信箱驗證信的 API
        const emailVerification = await memberStore.getEmailVerificationEmail(
            memberStore.account
        );
        if (emailVerification) {
            alertStore.showAlert({
                message: '驗證信發送成功',
                type: 'success',
            });
        } else {
            alertStore.showAlert({
                message: '驗證信發送失敗',
                type: 'error',
            });
        }
    } catch (error) {
        console.log(error);
        alertStore.showAlert({
            message: '驗證信發送失敗',
            type: 'error',
        });
    }
};

onMounted(async () => {
    const bool = await memberStore.getEmailVerificationInfo();
    console.log(bool);
    if (bool) {
        isEmailVerified.value = true;
    } else {
        isEmailVerified.value = false;
    }
});
</script>

<style scoped>
:deep(.blueBG) {
    background-color: #26bec9;
}
:deep(.grayBG) {
    background-color: darkgrey;
}

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
:deep(.btn) {
    font-weight: 500;
    font-size: 14px;
    color: white;
    border-radius: 5px;
    background-color: #5cbbc7;
    transition: background-color 0.3s;
}
:deep(.btn:hover) {
    background-color: #428c8c;
    color: white;

    font-size: 16px;
}
:deep(.deleteBtn) {
    font-weight: 500;
    font-size: 14px;
    color: white;
    border-radius: 5px;
    background-color: #5cbbc7;
    transition: background-color 0.3s;
}
:deep(.deleteBtn:hover) {
    background-color: #428c8c;
    color: white;
    font-weight: bolder;
    font-size: 14px;
}
:deep(.detailInfo) {
    font-size: 14px;
    color: rgb(156, 157, 160);
    margin-bottom: 5px;
}
</style>
