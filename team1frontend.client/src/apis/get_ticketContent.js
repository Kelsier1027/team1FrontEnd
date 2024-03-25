import httpInstance from "@/utility/http";

export function getTicketContentAPI(ticketId) {
  return httpInstance({
    url: `/api/AttractionTickets/GetTicketById/${ticketId}`
  })
}
