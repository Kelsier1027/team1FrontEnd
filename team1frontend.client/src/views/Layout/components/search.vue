<template>
    <div class="search-panel">
        <form class="search-form" @submit.prevent="submitForm">
            <div class="input-where">
                <input type="text" placeholder="要去哪？" v-model="searchQuery.location" required />
            </div>
            <div class="input-date">
                <Datepicker v-model="searchQuery.dateRange" :range="true" />
            </div>

            <div class="input-headcount">
                <input type="number"
                       :placeholder="placeholderText"
                       required
                       readonly
                       @click="showModal = true" />
            </div>
            <div class="input-submit">
                <button type="submit">搜尋</button>
            </div>
        </form>
        <!-- 數量選擇器的模態窗口 -->
        <div v-if="showModal" class="dropdown-content">
            <!-- 成人數量選擇 -->
            <div class="counter">
                <label>成人</label>
                <button @click.stop="updateCount('adults', -1)" :disabled="searchQuery.adults <= 1">-</button>
                <span>{{ searchQuery.adults }}</span>
                <button @click.stop="updateCount('adults', 1)">+</button>
            </div>
            <!-- 小孩數量選擇 -->
            <div class="counter">
                <label>小孩</label>
                <button @click.stop="updateCount('children', -1)" :disabled="searchQuery.children <= 0">-</button>
                <span>{{ searchQuery.children }}</span>
                <button @click.stop="updateCount('children', 1)">+</button>
            </div>
        </div>
    </div>
</template>

<script setup>
    import { onMounted, onUnmounted, ref, computed } from 'vue';
    import Datepicker from '@vuepic/vue-datepicker';
    import '@vuepic/vue-datepicker/dist/main.css';

    const emit = defineEmits(['search']);

    const searchQuery = ref({
        location: '',
        dateRange: {
            start: null,
            end: null
        },
        adults: 1,
        children: 0,
        infants: 0
    });

    // 使用計算屬性生成 placeholder 文本
    const placeholderText = computed(() => {
        return `成人${searchQuery.value.adults}位 小孩${searchQuery.value.children}位`;
    });

    function submitForm() {
        emit('search', searchQuery.value);
    }
    const showModal = ref(false);

    function updateCount(type, increment) {
        if (type === 'adults') {
            searchQuery.value.adults = Math.max(1, searchQuery.value.adults + increment);
        } else if (type === 'children') {
            searchQuery.value.children = Math.max(0, searchQuery.value.children + increment);
        }
    }
    // 切換顯示模態窗口
    function toggleModal() {
        showModal.value = !showModal.value;
    }

    // 點擊外部時關閉模態窗口
    function closeOnOutsideClick(event) {
        if (!event.target.closest('.modal-content') && !event.target.closest('.input-headcount')) {
            showModal.value = false;
        }
    }
    // 當組件掛載時添加事件監聽器，當組件卸載時移除
    onMounted(() => {
        document.addEventListener('click', closeOnOutsideClick);
    });
    onUnmounted(() => {
        document.removeEventListener('click', closeOnOutsideClick);
    });
</script>

<!-- 添加 CSS 樣式如果有的話 -->
<style scoped>
    
    .search-panel {
        position:relative;
        background-color: #ffd54f;
        padding: 15px;
        border-radius: 8px;
        max-width: 100%; /* 调整为100%以适应父容器的宽度 */
        margin:0px 50px 20px 50px;
        box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
    }

    .search-form {
        display: flex;
        align-items: center; /* 垂直居中 */
        justify-content: space-between; /* 两端对齐 */
        gap: 10px; /* 输入框之间的间隔 */
    }
    .input-where {
        display: flex;
        align-items: center;
        background-color: white;
        border: 1px solid #ccc;
        border-radius: 4px;
        padding: 5px;
        width: 150px;
    }

    .input-submit{
        background-color:powderblue;
        padding:10px;
        border-radius:10px;
    }

    .input-date {
        display: flex;
        align-items: center;
        background-color: white;
        border: 1px solid #ccc;
        border-radius: 4px;
        width: 150px;
    }

        

    .input-group-prepend .input-group-text {
        background-color: #e9ecef;
        border: none;
        padding: 5px 10px; /* 缩小预置组件的填充 */
    }

    .input-group button {
        background-color: #4CAF50;
        color: white;
        border: none;
        border-radius: 4px;
        padding: 5px 15px; /* 减少填充 */
        cursor: pointer;
        transition: background-color 0.3s;
        white-space: nowrap;
    }

        .input-group button:hover {
            background-color: #45a049;
        }
    /*加入購物車的鍵*/
    @media (max-width: 768px) {
        .search-form {
            flex-wrap: wrap; /* 允许换行 */
        }

        .input-group {
            flex-basis: 100%; /* 在小屏幕上调整宽度 */
            justify-content: center;
            margin-bottom: 10px; /* 增加底部间距 */
        }

            .input-group button {
                flex-basis: auto;
            }
    }
    /* 模態窗口樣式 */
    .input-headcount {
        align-items: center;
        padding:7px;
        background-color: white;
        border: 1px solid #ccc;
        border-radius: 4px;
        /* 其他樣式保持不變 */
    }

    .dropdown-content {
        display: block;
        position: absolute;
        background-color: #f9f9f9;
        min-width: 160px;
        box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
        z-index: 1;
        right: 105px;
        padding: 10px;
        border-radius: 4px;
    }

    /* 確保點擊按鈕不會觸發下拉選項的顯示或隱藏 */
    .counter button {
        margin: 0 5px;
    }

    .modal-content {
        background-color: #fefefe;
        margin: auto;
        padding: 20px;
        border: 1px solid #888;
        width: 80%;
        max-width: 500px;
    }

    .close {
        color: #aaa;
        float: right;
        font-size: 28px;
        font-weight: bold;
    }

    .close:hover,
    .close:focus {
        color: black;
        text-decoration: none;
        cursor: pointer;
    }

    .counter {
        display: flex;
        align-items: center;
        justify-content: space-between;
        margin-bottom: 20px;
    }

    .counter button {
        margin: 0 10px;
    }

</style>

