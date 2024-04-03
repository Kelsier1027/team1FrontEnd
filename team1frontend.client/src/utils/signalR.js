import * as signalR from '@microsoft/signalr'
const url = "https://localhost:7113/ChatHub"
const signal = new signalR.HubConnectionBuilder()
  .withUrl(url, {
    skipNegotiation: true,
    transport: signalR.HttpTransportType.WebSockets
  })
  .configureLogging(signalR.LogLevel.Information)
  .build()
signal.on('SendAll', (res) => {
  console.log(res, '收到消息')
})
signal.start().then(() => {
  if (window.Notification) {
    if (Notification.permission === 'granted') {
      console.log('允許通知')
    } else if (Notification.permission !== 'denied') {
      console.log('需要通知權限')
      Notification.requestPermission((permission) => { console.log("權限通知",permission) })
    } else if (Notification.permission === 'denied') {
      console.log('拒絕通知')
    }
  } else {
    console.error('不支援Notification')
  }
  console.log('聯接成功')
})
signal.onclose((err)=>{
    console.log("聯接斷開 執行函數onclose",err)
})
export default {
  signal
}