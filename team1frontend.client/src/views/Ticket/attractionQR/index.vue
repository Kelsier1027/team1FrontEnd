<template>
  <v-parallax
          src="/src/assets/images/chih/196642133185623.61b8c0f3b3158.gif"
      style="height: 1300px;">
      <v-main style="font-family: MSJHBD;" >
  <v-container>
      <div style="display: grid;">
        <div class="videodiv">
        <video class="videoqr" ref="video" autoplay></video>
        </div>
        <canvas ref="canvas" style="display: none;"></canvas>
        <div class="btndiv">
        <v-btn @click="scanQRCode" style="width:300px" theme="light">掃描</v-btn>
        </div>
      </div>
    </v-container>
  </v-main>
</v-parallax>
</template>

<script setup>
import { ref, onMounted } from 'vue';
import jsQR from 'jsqr';
import { PostQRcodeAPI } from '@/apis/Chih/apis/post_QRcode.js'

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
    PostQRcodeAPI(code.data);
  } else {
    console.log("未找到QRCODE");
  }
};
</script>

<style scoped>
.videoqr {
  border: 3px solid black
  
}

.btndiv{
  text-align: center;
}

.videodiv{
  text-align: center;
}
</style>