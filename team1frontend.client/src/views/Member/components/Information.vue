<template>
    <v-form
        ref="formRef"
        @submit.prevent="saveMemberInfo"
        style="padding: 20px 10px"
    >
        <v-row class="start">
            <v-col>
                <div class="fieldsRow">
                    <span class="fields font-weight-medium fontFamily">
                        名
                    </span>
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
                    label="名"
                >
                </v-text-field>
            </v-col>
            <v-col>
                <div class="fieldsRow">
                    <span class="fields font-weight-medium fontFamily">
                        姓
                    </span>
                    <span class="dot"> * </span>
                </div>
                <v-text-field
                    v-model="lastName"
                    :rules="[required, maxLength50]"
                    single-line
                    class="originalField"
                    color="#26bec9"
                    density="comfortable"
                    variant="outlined"
                    label="姓"
                >
                </v-text-field>
            </v-col>
            <v-col>
                <div class="fieldsRow">
                    <span class="fields font-weight-medium fontFamily">
                        性別
                    </span>
                    <span class="dot"> </span>
                </div>
                <v-select
                    v-model="selectedGender"
                    :rules="[]"
                    single-line
                    color="#26bec9"
                    label="-請選擇-"
                    density="comfortable"
                    :items="genderOptions"
                    variant="outlined"
                ></v-select>
            </v-col>
        </v-row>
        <v-row>
            <v-col>
                <div class="fieldsRow">
                    <span class="fields font-weight-medium fontFamily">
                        出生日期
                    </span>
                    <span class="dot"> </span>
                </div>
                <v-menu
                    :close-on-content-click="false"
                    transition="scale-transition"
                    scrollable="false"
                >
                    <template v-slot:activator="{ props }">
                        <v-text-field
                            class="calendar"
                            color="#26bec9"
                            single-line
                            density="comfortable"
                            variant="outlined"
                            label="YYYY-MM-DD"
                            v-bind="props"
                            v-model="birthday"
                        >
                            <template v-slot:append-inner>
                                <v-icon
                                    icon="mdi-calendar-month-outline"
                                    size="19"
                                />
                            </template>
                        </v-text-field>
                    </template>

                    <v-date-picker
                        v-model="date"
                        color="#26bec9"
                        no-title
                        hide-header
                        range
                        scrollable
                        locale="zh-tw"
                        value="yyyy/MM/dd"
                    >
                    </v-date-picker>
                </v-menu>
            </v-col>
            <v-col>
                <div class="fieldsRow">
                    <span class="fields font-weight-medium fontFamily">
                        國家/地區
                    </span>
                    <span class="dot"> </span>
                </div>
                <v-autocomplete
                    v-model="selectedCountry"
                    single-line
                    auto-select-first
                    :items="countries"
                    color="#26bec9"
                    density="comfortable"
                    variant="outlined"
                    label="國家/地區"
                >
                </v-autocomplete>
            </v-col>
            <v-col> </v-col>
        </v-row>
        <v-row>
            <v-col cols="4">
                <div class="fieldsRow">
                    <span class="fields font-weight-medium fontFamily">
                        電話號碼
                    </span>
                    <span class="dot"> * </span>
                </div>
                <v-row class="dialSelector">
                    <v-col cols="4">
                        <v-select
                            class="dialSelect"
                            :class="{
                                hoveredBorder: isHoveredOnly,
                                blueBorder: isFocused,
                            }"
                            v-model="selectedDialCode"
                            :items="dialCodes"
                            item-title="code"
                            single-line
                            density="comfortable"
                            variant="plain"
                            outlined
                            label="國碼"
                            hide-details
                            @focus="isFocused = true"
                            @blur="isFocused = false"
                            @mouseenter="isHovered = true"
                            @mouseleave="isHovered = false"
                            ><template v-slot:item="{ props, item }">
                                <v-list-item
                                    v-bind="props"
                                    :title="item.raw.country"
                                    :subtitle="item.raw.code"
                                ></v-list-item> </template
                        ></v-select>
                    </v-col>
                    <v-col cols="8">
                        <v-text-field
                            v-model="phoneNumber"
                            :rules="[required, numberOnly, maxLength15]"
                            type="number"
                            hide-spin-buttons
                            class="dialSelectorField"
                            single-line
                            color="#26bec9"
                            density="comfortable"
                            variant="plain"
                            @focus="isFocused = true"
                            @blur="isFocused = false"
                            @mouseenter="isHovered = true"
                            @mouseleave="isHovered = false"
                            :class="{
                                hoveredBorder: isHoveredOnly,
                                blueBorder: isFocused,
                            }"
                        ></v-text-field>
                    </v-col>
                </v-row>
            </v-col>

            <v-col cols="8">
                <div class="fieldsRow">
                    <span class="fields font-weight-medium fontFamily">
                        聯絡 E-mail
                    </span>
                    <span class="dot"> * </span>
                </div>
                <v-text-field
                    v-model="email"
                    :rules="[required, emailFormat, maxLength50]"
                    single-line
                    class="originalField"
                    color="#26bec9"
                    density="comfortable"
                    variant="outlined"
                    label="聯絡 E-mail"
                >
                </v-text-field>
            </v-col>
        </v-row>
        <v-row justify="end" style="margin-top: 8px; margin-bottom: -2px">
            <v-col cols="auto">
                <v-btn class="saveBtn btn" type="submit" variant="flat"
                    ><span class="saveBtnText">儲存</span>
                </v-btn>
            </v-col>
        </v-row>
    </v-form>
</template>

<script setup>
import { useMemberStore } from '@/stores/memberStore.js';
import { useRouter } from 'vue-router';
import { ref, computed, onMounted } from 'vue';
import { useDate } from 'vuetify';
import { useAlertStore } from '@/stores/alertStore.js';
const alertStore = useAlertStore();
const router = useRouter();
const memberStore = useMemberStore();

// 性別選項
const genderOptions = ref([
    {
        title: '-請選擇-',
        value: null,
    },
    {
        title: '男',
        value: true,
    },
    {
        title: '女',
        value: false,
    },
]);

// date picker
const adpter = useDate();
const date = ref([]);

// 選擇國家/地區 v-autocomplete
// 建立一個國家清單
const countries = ref([
    { id: 1, title: '台灣' },
    { id: 2, title: '日本' },
    { id: 3, title: '美國' },
    { id: 4, title: '中國' },
    { id: 5, title: '韓國' },
]);

// 選擇國家電話區碼的 v-select

// 建立一個國家電話區碼清單
const dialCodes = ref([
    { id: 1, code: '+886', country: '台灣' },
    { id: 2, code: '+81', country: '日本' },
    { id: 3, code: '+1', country: '美國' },
    { id: 4, code: '+86', country: '中國' },
    { id: 5, code: '+82', country: '韓國' },
]);
// 選擇的國家電話區碼

// 回傳國家電話區碼的物件
const countryCodeProps = (dialCode) => {
    return {
        text: 'dialCode.dialCode',
        value: 'dialCode.country',
    };
};

// 為 .dialSelect 以及 .dialSelectorField 建立 focus 狀態變數
const isFocused = ref(false);
// 為 .dialSelect 以及 .dialSelectorField 建立 hover 狀態變數
const isHovered = ref(false);

// 判斷 如果 isHovered 為 true 時 isFocused 為 true 輸出 false ，否則輸出 isHovered 值
const isHoveredOnly = computed(() => {
    // console.log(isHovered.value, isFocused.value);
    if (isHovered.value && isFocused.value) {
        // console.log('false');
        return false;
    } else {
        // console.log('true');
        return isHovered.value;
    }
});
const formRef = ref(null);
const account = ref(null);
const firstName = ref('');
const lastName = ref('');
const selectedGender = ref(genderOptions.value[0].value);
const birthday = computed(() => {
    // console.log(date);
    // 將日期格式轉換成 yyyy-MM-dd
    if (date.value.length === 0) return '';

    let formatedDate = date.value.toISOString().split('T')[0];
    // console.log(formatedDate);
    return formatedDate;
});
const selectedCountry = ref(countries.value[0].title);
const selectedDialCode = ref(dialCodes.value[0].code);
const phoneNumber = ref('');
const email = ref('');

// v-form 表單驗證規則
const required = (v) => !!v || '此欄位必填';
const emailFormat = (v) => /.+@.+\..+/.test(v) || '錯誤的 email 格式';
// 判斷長度在50字元以內
const maxLength50 = (v) => (v && v.length <= 50) || '最多只能輸入50個字';
const maxLength15 = (v) => (v && v.length <= 15) || '最多只能輸入15個字';
const passwordUpperCase = (v) =>
    /[A-Z]/.test(v) || '密碼需包含至少一個大寫字母';
const passwordLowerCase = (v) =>
    /[a-z]/.test(v) || '密碼需包含至少一個小寫字母';
// 只可輸入數字
const numberOnly = (v) => /^[0-9]*$/.test(v) || '只能輸入數字';
const passwordNumber = (v) => /[0-9]/.test(v) || '密碼需包含至少一個數字';
const HasNoSpecialWords = (v) => !/[^A-Za-z0-9]/.test(v) || '不能包含特殊字符';

const getMemberDetailInfo = async (memberAccount) => {
    let memberDetailInfo = await memberStore.getMemberDetailInfo(memberAccount);
    // console.log(memberDetailInfo);
    // 將 memberDetailInfo 中的資料填入表單
    account.value = memberDetailInfo.account;
    firstName.value = memberDetailInfo.firstName;
    lastName.value = memberDetailInfo.lastName;
    selectedGender.value = memberDetailInfo.gender;
    // 使用 memberDetailInfo.dateOfBirth (yyyy-MM-dd) 建立時間型別的物件
    date.value = new Date(memberDetailInfo.dateOfBirth);
    selectedCountry.value = memberDetailInfo.country;
    selectedDialCode.value = memberDetailInfo.dialCode;
    phoneNumber.value = memberDetailInfo.phoneNumber;
    // 如果 memberDetailInfo.email 有值，則將值填入 email，否則填入 memberDetailInfo.account
    email.value = memberDetailInfo.email
        ? memberDetailInfo.email
        : memberDetailInfo.account;
};
const saveMemberInfo = async () => {
    // 檢查表單是否通過驗證
    const validResult = await formRef.value.validate();
    // console.log(validResult.valid);
    if (validResult.valid) {
        // console.log('表單驗證通過');
        // 建立一個物件，將表單資料填入
        let memberInfoForUpdate = {
            account: account.value,
            firstName: firstName.value,
            lastName: lastName.value,
            gender: selectedGender.value,
            dateOfBirth: birthday.value,
            country: selectedCountry.value,
            dialCode: selectedDialCode.value,
            phoneNumber: phoneNumber.value,
            email: email.value,
        };
        // console.log(memberInfoForUpdate, 'Infomation');
        try {
            // 呼叫 memberStore 中的 updateMemberDetailInfo 方法
            const updatedMemberInfo = await memberStore.updateMemberDetailInfo(
                memberInfoForUpdate
            );
            // console.log(updatedMemberInfo);
            getMemberDetailInfo(memberStore.account);
            memberStore.getMemberInfo();
            alertStore.showAlert({
                message: '資料變更成功',
                type: 'success',
            });
        } catch (error) {
            console.log(error);
            alertStore.showAlert({
                message: '資料變更失敗',
                type: 'error',
            });
        }
    }
};

// 在 mounted 時執行
onMounted(() => {
    // 檢查 memberStore 中的 account 是否有值
    if (memberStore.account) {
        // 如果有值，則執行 getMemberDetailInfo
        let accountFromPinia = memberStore.account;
        // 去除 accountFromPinia 中的空白字元
        accountFromPinia = accountFromPinia.replace(/\s+/g, '');
        getMemberDetailInfo(accountFromPinia);
    } else {
        // 如果沒有值，則導回首頁
        router.push('/'); // router 這個方法是 vue-router 提供的
    }
});
</script>

<style scoped>
:deep(.fontFamily) {
    font-family: 'Noto Sans TC', '微软雅黑', 'Microsoft YaHei', 'sans-serif';
    /* border-bottom: 1px solid #dfdfdf; */
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
:deep(.v-col) {
    padding: 0 10px;
}
:deep(.start) {
    margin-top: 10px;
}
:deep(.calendar .v-field__append-inner) {
    padding-left: 10px;
    border-left: 1px solid #dfdfdf;
}

/* date picker 大小調整 */
:deep(.v-date-picker-controls) {
    padding: 0 !important;
    width: 200px !important;
}

:deep(.v-date-picker) {
    padding: 0 !important;
    /* width: 252px !important;
    height: 300px !important; */
    width: 256px !important;
    height: auto !important;
}
:deep(.v-date-picker-controls__month-btn) {
    width: 120px !important;
    padding-right: 0px !important;
    padding-left: 10px !important;
}
:deep(.v-date-picker-month) {
    width: 252px !important;
    padding: 0;
}
:deep(.v-date-picker-month__days) {
    padding: 0 !important;
    margin: 0 !important;
    column-gap: 0px !important;
    flex: 1 1;
    justify-content: center !important;
}

:deep(.v-date-picker-month__day) {
    height: 34px !important;
    width: 34px !important;

    padding: 0 !important;
    margin: 0 !important;
    column-gap: 0px !important;
    flex: 1 1;
    justify-content: space-around !important;
}
:deep(.v-date-picker-month__day-btn) {
    height: 34px !important;
    border-radius: 4px !important;
}
:deep(.v-date-picker-month__day--selected .v-btn__content) {
    color: white !important;
}
:deep(.v-btn--variant-outlined) {
    border: 0;
}
:deep(.dialSelect) {
    /* max-width: 70px !important; */
    border: 1px solid #a9a9a9 !important;
    border-right: 0 !important;
    width: 87.25px !important;
    height: 48px !important;
    border-radius: 4px 0 0 4px !important;
}
:deep(.dialSelect .v-input__control) {
    /* width: 70px !important; */
}
:deep(.dialSelector) {
    margin: 0;
    /* width: 250px !important; */
}
:deep(.dialSelector .v-col) {
    padding: 0;
}
:deep(.dialSelector .v-field--appended) {
    padding-right: 0;
}
:deep(.dialSelector .v-field__input) {
    padding-left: 10px;
}
:deep(.dialSelectorField) {
    border: 1px solid #a9a9a9 !important;
    border-left: 0 !important;
    width: 170.95px !important;
    height: 48px !important;
    border-radius: 0 4px 4px 0 !important;
    margin-left: -3px !important;
}
:deep(.dialSelector .v-field__input) {
    padding-top: 4px !important;
    padding-left: 11px !important;
}
:deep(.dialSelector .v-field-label) {
    padding-left: 11px !important;
}
:deep(.dialSelector .v-field__append-inner) {
    padding-top: 10px !important;
}
:deep(.dialSelector .hoveredBorder) {
    border-color: black !important;
    /* border-width: 10px !important; */
}
:deep(.dialSelector .blueBorder) {
    border-color: #26bec9 !important;
}
:deep(.saveBtnText) {
    font-family: 'Noto Sans TC', 微软雅黑, 'Microsoft YaHei', sans-serif;
    color: white;
    font-weight: 400;
    /* font-size: 14px; */
}
:deep(.saveBtn) {
    height: 42.39px !important;
    width: 77px !important;
}
:deep(.originalField .v-messages__message) {
    margin-bottom: 20px;
}
:deep(.dialSelectorField .v-input__details) {
    /* 將座標位置向下移 */
    margin-top: 6px;
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
</style>
