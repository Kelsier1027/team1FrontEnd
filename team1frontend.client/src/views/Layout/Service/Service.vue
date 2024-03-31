<template>
  <div>
    <button v-if="!isOpen" @click="toggleChat" class="toggle-button chat-box text-white"
      style="background-color: blue;"><svg xmlns="http://www.w3.org/2000/svg" width="20" height="20" fill="currentColor"
        class="bi bi-headset" viewBox="0 0 16 16">
        <path
          d="M8 1a5 5 0 0 0-5 5v1h1a1 1 0 0 1 1 1v3a1 1 0 0 1-1 1H3a1 1 0 0 1-1-1V6a6 6 0 1 1 12 0v6a2.5 2.5 0 0 1-2.5 2.5H9.366a1 1 0 0 1-.866.5h-1a1 1 0 1 1 0-2h1a1 1 0 0 1 .866.5H11.5A1.5 1.5 0 0 0 13 12h-1a1 1 0 0 1-1-1V8a1 1 0 0 1 1-1h1V6a5 5 0 0 0-5-5" />
      </svg>客服</button>
    <div v-if="isOpen" class="chat-container">
      <div class="chat-box">
        <div style="height:30px; background-color: blue;display: flex; justify-content: flex-end;align-items: center;">
          <button class="text-white " @click="ChatClose" style="margin-right: 20px;">X</button>
        </div>
        <div class="chat-history d-flex flex-column">
          <div v-for="(message, index) in messages" :key="index" class="message p-2"
            style="max-width: 250px;word-wrap: break-word;"
            :class="{ 'sent': message.sender === 'me', 'received': message.sender !== 'me' }">
            <div>
              {{ message.text }}
            </div>
          </div>
        </div>
        <div class="chat-input">
          <textarea style=" font-size: 14px;max-height: 40px; min-height: 40px;overflow-y: auto; background-color: whitesmoke;" :rows="1" autosize v-model="newMessage" @keydown.enter.prevent="handleEnterKey" placeholder=""></textarea>
          <button @click="sendMessage">Send</button>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref } from 'vue';

const isOpen = ref(false);
const messages = ref([]);
const newMessage = ref('');

const toggleChat = () => {
  isOpen.value = !isOpen.value;
  setTimeout(()=>{
  scroll()
})
};
const ChatClose = () => {
  isOpen.value = !isOpen.value;  
};
let scroll=()=>{
  let cahtHistory = document.querySelector('.chat-history')
  cahtHistory.scrollTop=cahtHistory.scrollHeight
}

const handleEnterKey = (event) => {
  // 检查是否按下了 Shift 键
  if (event.shiftKey) {
    // 如果按下了 Shift 键，则不阻止默认行为，允许换行
    return;
  }
  // 否则，阻止默认行为，并发送消息
  event.preventDefault();
  sendMessage();
};

const sendMessage = () => {
  if (newMessage.value.trim() !== '') {
    messages.value.push({
      text: newMessage.value.trim(),
      sender: 'me'
    });
    newMessage.value = '';
  }

  setTimeout(()=>{
  scroll()
})
};

import { defineProps } from 'vue';
const props = defineProps();
</script>

<style>
.chat-box {
  width: 300px;
  border: 1px solid #ccc;
  border-radius: 5px;
  overflow: hidden;
  position: fixed;
  bottom: 20px;
  right: 20px;
}

.chat-history {
  height: 400px;
  overflow-y: auto;
  padding: 10px;
  background-color: white;
}

.message {
  padding: 5px 10px;
  margin-bottom: 5px;
  border-radius: 10px 0 10px 10px;
  display: block;
  justify-content: flex-end;
}

.message.sent {
  background-color: #c2e3f6;
  align-self: flex-end;
}

.message.received {
  background-color: #f0f0f0;
}

.chat-input {
  display: flex;
  align-items: center;
  padding: 10px;
  background-color: white;
}

.chat-input textarea {
  flex: 1;
  padding: 5px;
  border-radius: 5px;
  border: 1px solid #ccc;
}

.chat-input button {
  height: 38px;
  width: 70px;
  display: flex;
  align-items: center;
  text-align: center;
  padding: 5px 10px;
  margin-left: 10px;
  border: none;
  border-radius: 5px;
  background-color: #007bff;
  color: white;
  cursor: pointer;
}
</style>