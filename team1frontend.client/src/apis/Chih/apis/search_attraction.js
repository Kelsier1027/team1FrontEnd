import httpInstance from "@/utils/https";



export function getAttractionsAPI(inputkeyword, category) {
    return httpInstance({
        url: '/api/Attractions/Search',
        params: {
            keyword: inputkeyword,
            CategoryId: category,
        }
    })
}

