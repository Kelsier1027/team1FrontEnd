import httpInstance from "@/utils/https";

export function getCategoriesAPI() {
  return httpInstance({
    url: '/api/Attractions/GetCategories',
  })

}