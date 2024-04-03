import httpInstance from "@/utils/https";

export const AddCartItemAPI = (addItemDTO) => {
    return httpInstance({
        url: '/api/AttractionTickets/AddCartItem',
        method: 'post',
        headers: { 'Content-Type': 'application/json' }, // 确保设置了正确的 Content-Type
        data: JSON.stringify(addItemDTO) // 确保发送的是 addItemDTO 对象的 JSON 字符串表示
    })
}
