import httpInstance from "@/utils/https";

export const GetCarBrandAPI = () => {
    return httpInstance({
        url: 'api/brands',
        method: 'GET'
    })
}