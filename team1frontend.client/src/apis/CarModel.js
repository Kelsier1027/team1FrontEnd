import httpInstance from "@/utils/https";

export const GetCarModelAPI = () => {
    return httpInstance({
        url: 'api/carmodels',
        method: 'GET'
    })
}