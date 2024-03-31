import httpInstance from "@/utils/https";

  export function getPackageItem(id) {
    return httpInstance({
        url: 'api/Package',
        params: {
            id: id
        }
    });
};