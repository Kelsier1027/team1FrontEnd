import httpInstance from "@/utils/https";

export const GetCarTransmissionAPI = () => {
    return httpInstance({
        url: 'api/transmissions',
        method: 'GET'
    })
}