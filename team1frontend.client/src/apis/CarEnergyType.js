import httpInstance from "@/utils/https";

export const GetCarEnergyTypeAPI = () => {
    return httpInstance({
        url: 'api/energytypes',
        method: 'GET'
    })
}