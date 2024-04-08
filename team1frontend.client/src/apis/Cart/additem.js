import httpInstance from "@/utils/https";

export const AddItemToCart = (memberId, itemId, categoryId, quantity) => {
    return httpInstance({
        url: '/api/CartItems/addCartItem',
        method: 'POST',
        headers: { 'Content-Type': 'application/json' }, // 确保设置了正确的 Content-Type
        data: JSON.stringify({ memberId:memberId, itemId:itemId, categoryId:categoryId, quantity:quantity}) // 确保发送的是 addItemDTO 对象)的 JSON 字符串表示
    })
}