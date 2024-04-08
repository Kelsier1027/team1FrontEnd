import httpInstance from "@/utils/https";

export const createOrder = (data) => {
    return httpInstance({
        url: '/api/CartItems/CreatOrder',
        method: 'post',
        headers: { 'Content-Type': 'application/json' }, // 确保设置了正确的 Content-Type
        data // 确保发送的是 addItemDTO 对象的 JSON 字符串表示
    })
}
