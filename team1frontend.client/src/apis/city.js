import httpInstance from "@/utils/https";

export const GetCityAPI = () => {
    return httpInstance({
        url: 'api/cities',
        method: 'GET'
    })
}