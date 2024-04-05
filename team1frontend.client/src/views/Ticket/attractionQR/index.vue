<template>
  <v-main>
    <v-container>
      <div style="display: grid;">
        <video ref="video" autoplay></video>
        <canvas ref="canvas" style="display: none;"></canvas>

        <v-btn @click="scanQRCode" style="width:300px">掃描</v-btn>
      </div>
    </v-container>
  </v-main>
</template>

<script setup>
import { ref, onMounted } from 'vue';
import jsQR from 'jsqr';

const video = ref(null);
const canvas = ref(null);

onMounted(() => {
  navigator.mediaDevices.getUserMedia({ video: { facingMode: "environment" } })
    .then(stream => {
      video.value.srcObject = stream;
    });
});

const scanQRCode = () => {
  if (!canvas.value) return;
  const context = canvas.value.getContext('2d');

  // 調整 canvas 大小
  canvas.width = video.value.videoWidth;
  canvas.height = video.value.videoHeight;

  // 繪製到 canvas 上
  context.drawImage(video.value, 0, 0, canvas.value.width, canvas.value.height);

  // 獲取QR數據 用jsQR解析
  const imageData = context.getImageData(0, 0, canvas.value.width, canvas.value.height);
  const code = jsQR(imageData.data, imageData.width, imageData.height, {
    inversionAttempts: "dontInvert",
  });

  if (code) {
    console.log("找到QRCODE==>", code.data);
    // call api 驗證
  } else {
    console.log("未找到QRCODE");
  }
};
</script>
