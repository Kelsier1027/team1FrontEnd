import httpInstance from "@/utils/https";

export function getUserTicketAPI(id) {
  return httpInstance({
    url: '/api/AttractionsOrder/GetUserTicket',
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    data: id

  })
}
