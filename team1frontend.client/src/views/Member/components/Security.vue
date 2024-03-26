<template>
    <v-form class="mt-4">
        <div class="changePasswordTitle fontFamily">更改密碼</div>
        <div class="fieldsRow">
            <span class="fields font-weight-medium fontFamily"> 原密碼 </span>
            <span class="dot"> * </span>
        </div>
        <v-text-field
            v-model="firstName"
            :rules="[required, maxLength50]"
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
            v-model="firstName"
            :rules="[required, maxLength50]"
            class="originalField"
            color="#26bec9"
            single-line
            density="comfortable"
            variant="outlined"
            label="新密碼"
        >
        </v-text-field>
        <v-text-field
            v-model="firstName"
            :rules="[required, maxLength50]"
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
        <v-col cols="2">
            <span>dnfd@sdfs.com</span>
        </v-col>
        <v-col cols="2" justify="start">
            <v-btn class="saveBtn" size="large" color="#26bec9" variant="flat"
                ><span class="saveBtnText" style="color: white">刪除會員</span>
            </v-btn>
        </v-col>
    </v-row>
</template>

<script setup></script>

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
