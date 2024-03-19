<template>
    <div class="search-panel">
        <form class="search-form" @submit.prevent="submitForm">
            <div class="input-group">
                <input type="text" placeholder="要去哪裡？" v-model="searchQuery.location" required />
            </div>
            <div class="input-group">
                <input type="date" v-model="searchQuery.checkInDate" required />
            </div>
            <div class="input-group">
                <input type="number" placeholder="成人" v-model.number="searchQuery.adults" min="1" required />
            </div>
            <div class="input-group">
                <input type="number" placeholder="小孩" v-model.number="searchQuery.children" min="0" required />
            </div>
            <div class="input-group">
                <input type="number" placeholder="嬰兒" v-model.number="searchQuery.infants" min="0" required />
            </div>
            <div class="input-group">
                <button type="submit">搜尋</button>
            </div>
        </form>
    </div>
</template>

<script setup>
import { ref } from 'vue';

const emit = defineEmits(['search']);

const searchQuery = ref({
  location: '',
  checkInDate: '',
  adults: 1,
  children: 0,
  infants: 0
});

function submitForm() {
  emit('search', searchQuery.value);
}
</script>

<!-- 添加 CSS 樣式如果有的話 -->
<style scoped>
    .input-group {
        margin-bottom: 10px;
    }

    .input-group input[type="text"],
    .input-group input[type="number"],
    .input-group input[type="date"] {
        width: 100%;
        padding: 10px;
        margin: 4px 0;
        display: inline-block;
        border: 1px solid #ccc;
        border-radius: 4px;
        box-sizing: border-box;
    }

    .input-group button {
        width: 100%;
        background-color: #4CAF50;
        color: white;
        padding: 14px 20px;
        margin: 8px 0;
        border: none;
        border-radius: 4px;
        cursor: pointer;
    }

        .input-group button:hover {
            background-color: #45a049;
        }

    .search-panel {
        background-color: #ffd54f; /* 您喜歡的顏色 */
        padding: 15px;
        border-radius: 8px;
        max-width: 900px; /* 或者根據您的設計需求調整 */
        margin: 20px auto; /* 讓搜索面板在頁面中間顯示 */
    }

    .search-form {
        display: flex;
        flex-wrap: wrap;
        gap: 10px;
        justify-content: center;
    }

    .input-group {
        flex: 1
    }
</style>
