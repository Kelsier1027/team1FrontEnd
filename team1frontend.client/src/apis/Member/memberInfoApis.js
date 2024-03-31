import http from '@/utils/https.js';

export const getMemberInfoAPI = (memberAccount) => {
    return http({
        url: '/api/Members/getMemberInfo',
        method: 'POST',
        // 以 JSON 格式傳送資料
        headers: {
            'Content-Type': 'application/json',
        },
        data: memberAccount,
    });
};
export const updateMemberDetailInfoAPI = (memberDetailInfo) => {
    console.log(memberDetailInfo);
    return http({
        url: '/api/Members/UpdateMemberInfo',
        method: 'POST',
        // 以 JSON 格式傳送資料
        // headers: {
        //     'Content-Type': 'application/json',
        // },
        data: memberDetailInfo,
    });
};
