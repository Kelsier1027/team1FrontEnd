import httpInstance from "@/utility/http";


export function getAttractionContentAPI(itemId) {
    return httpInstance({
        url: '/api/Attractions/AttractionsContent',
        params: {
            id: itemId
        }
    })
}