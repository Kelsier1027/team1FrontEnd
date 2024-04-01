import httpInstance from "@/utils/https";


export function getAttractionContentAPI(itemId) {
    return httpInstance({
        url: '/api/Attractions/AttractionsContent',
        params: {
            id: itemId
        }
    })
}