import httpInstance from "@/utils/https";

export const AddCartItem = (addItemDTO) => {
  return httpInstance({
    url: '/api/AttractionTickets/AddCartItem',
    method: 'post',
    data: 'addItemDTO'
  })
}


