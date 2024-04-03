import httpInstance from "@/utils/https";

export const AddItemToCart = (memberId, itemId, categoryId, quantity) => {
    return httpInstance({
        url: '/api/CartItems/addCartItem',
        method: 'post',
        headers: { 'Content-Type': 'application/json' }, // 确保设置了正确的 Content-Type
        data: { "memberId" :memberId,"itemId":itemId,"categoryId":categoryId,"quantity":quantity} // 确保发送的是 addItemDTO 对象的 JSON 字符串表示
    })
}