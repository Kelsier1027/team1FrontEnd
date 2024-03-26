<template>
    <div class="search-panel">
        <form class="search-form" @submit.prevent="submitForm">
            <div class="input-group">
                <input type="text" placeholder="要去哪？" v-model="searchQuery.location" required />
            </div>
            <div class="input-group">
                <input type="date" v-model="searchQuery.checkInDate" required />
            </div>
          
            <div class="input-group input-headcount">
                <div class="input-group-prepend">
                    <span class="input-group-text" id="adults-addon">成人</span>
                </div>
                <input type="number" class="form-control"  v-model.number="searchQuery.adults" min="1" aria-label="成人" aria-describedby="adults-addon" required />

                <div class="input-group-prepend">
                    <span class="input-group-text" id="children-addon">小孩</span>
                </div>
                <input type="number" class="form-control"  v-model.number="searchQuery.children" min="0" aria-label="小孩" aria-describedby="children-addon" required />
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
        display: flex; /* 使用flex布局 */
        flex-wrap: wrap; /* 允许元素在需要时换行 */
    }

        .input-group input[type="text"],
        .input-group input[type="number"],
        .input-group input[type="date"] {
            width: 100%;
            padding: 10px;
            margin: 4px 0;
            background-color:white;
            display: inline-block;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
            flex-grow: 1;
            flex-basis: calc(33.333% - 20px); /* 分配每个输入框占行的三分之一，减去间隙 */
            text-align: left;
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
    .input-headcount{
        color:black;
        border:black;
    }
</style>
