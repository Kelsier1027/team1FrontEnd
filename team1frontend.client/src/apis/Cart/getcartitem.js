import httpInstance from "@/utils/https";

export const getcartitem = (cartId,categoryId) => {
    return httpInstance({
        url: `/api/CartItems/GetCartItems`,        
        params: { "cartId":cartId,"categoryId":categoryId} // 确保发送的是 addItemDTO 对象的 JSON 字符串表示
    })
}