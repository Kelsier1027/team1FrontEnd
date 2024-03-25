//axios basic package
import axios from "axios";

const httpInstance = axios.create({
    baseURL: 'https://localhost:7189',
    timeout: 3000
})

// axios請求器攔截
httpInstance.interceptors.request.use(config => {
    return config
}, e => Promise.reject(e))

// axios響應式攔截器
httpInstance.interceptors.response.use(res => res.data, e => {
    return Promise.reject(e)
})

export default httpInstance;


