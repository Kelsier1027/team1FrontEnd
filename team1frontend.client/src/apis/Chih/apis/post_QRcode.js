import httpInstance from "@/utils/https";

export const PostQRcodeAPI = (qrdata) => {
  return httpInstance({
    url: '/api/AttractionsOrder/ScanQRCode',
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    data: qrdata
  })
}