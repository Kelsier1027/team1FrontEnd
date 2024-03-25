import httpInstance from "@/utility/http";

export function getCategoriesAPI() {
  return httpInstance({
    url: '/api/Attractions/GetCategories',
  })

}