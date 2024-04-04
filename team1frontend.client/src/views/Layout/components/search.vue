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
                <div class="input-group-prepend">
                    <!--<span class="input-group-text" id="adults-addon">成人</span>-->
                </div>
                <input type="number" class="form-control" :placeholder="placeholderText" min="1" aria-label="成人" aria-describedby="adults-addon" required />

                <!--<div class="input-children">
                    <span class="input-group-text" id="children-addon">小孩</span>
                </div>-->
                <!--<input type="number" class="form-control" v-model.number="searchQuery.children" min="0" aria-label="小孩" aria-describedby="children-addon" required />-->
            </div>


            <div class="input-submit">
                <button type="submit">搜尋</button>
            </div>
        </form>
    </div>
</template>

<script setup>
    import { ref, computed } from 'vue';
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
</script>

<!-- 添加 CSS 樣式如果有的話 -->
<style scoped>
    .search-panel {
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

    .Datepicker, .input-group input[type="text"],
    .input-group input[type="number"] {
        border: none;
        outline: none;
        max-width: 140px; /* 限制输入框宽度 */
        text-align: center; /* 文字居中 */
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
</style>

