import httpInstance from "@/utility/http";



export function getAttractionsAPI(inputkeyword, category) {
    return httpInstance({
        url: '/api/Attractions/Search',
        params: {
            keyword: inputkeyword,
            CategoryId: category,
        }
    })
}

