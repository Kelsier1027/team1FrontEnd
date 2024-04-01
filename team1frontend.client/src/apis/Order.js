import httpInstance from "@/utils/https";

export const GetOrderAPI = (data) => {
    return httpInstance({
        url: 'api/ECPay',
        method: 'POST',
        data
    })
}