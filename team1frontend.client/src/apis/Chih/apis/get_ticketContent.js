import httpInstance from "@/utils/https";

export function getTicketContentAPI(ticketId) {
    return httpInstance({
        url: `/api/AttractionTickets/GetTicketById/${ticketId}`
    })
}
