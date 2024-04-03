import httpInstance from "@/utils/https";

export const delitem = (Id) => {
    return httpInstance({
        url: `/api/CartItems/DeleteCartItem`,
        method: 'Delete',        
        params: { "id":Id} // 确保发送的是 addItemDTO 对象的 JSON 字符串表示
    })
}