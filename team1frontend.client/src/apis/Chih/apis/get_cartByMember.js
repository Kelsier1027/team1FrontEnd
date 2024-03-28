import httpInstance from "@/utils/https";

export function getCartByMemberAPI(id) {
    return httpInstance({
        url: '/api/AttractionTickets/GetCartItems',
        params: {
            memberid: id
        }
    })
}