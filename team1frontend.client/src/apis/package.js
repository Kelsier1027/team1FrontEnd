import httpInstance from "@/utils/https";

export function getPackageItem() {
  return httpInstance({
    url: '/api/Package',
  })

}