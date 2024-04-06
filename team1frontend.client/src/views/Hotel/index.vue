<template>
    <v-main class="main-container">
        <div class="block text-center">
            <el-carousel height="500px">
                <el-carousel-item :interval="1500">
                    <img src="https://kidfq.coach/wp-content/uploads/2023/09/%E5%AE%B6%E5%BA%AD%E6%97%85%E9%81%8A%EF%BC%BF1.webp" />
                </el-carousel-item>
            </el-carousel>
        </div>
        <Search @search="handleSearch" />
        <Carousel :items="items" :currentOffset="currentOffset"
                  :atEndOfList="atEndOfList"
                  :atHeadOfList="atHeadOfList"
                  @move-carousel="moveCarousel"
                  @item-clicked="navigateToHotelList" />
    </v-main>

</template>

<script setup>
    import { useRouter } from 'vue-router';
    
    //搜尋
    import Search from '../Layout/components/search.vue';

    const router = useRouter();
    const searchQuery = ref({
        // ... 你的搜索表单数据
    });

    // 在 index 页面的 script 中
    function handleSearch(searchQuery) {
        // 假设 searchQuery.location 包含了用户输入的搜索地点
        router.push({ path: '/hotel/list', query: { address: searchQuery.location } });
    }

    //旋轉木馬
    import { onMounted, ref, computed } from 'vue';
    import axios from 'axios';
    import Carousel from '../Layout/components/Carousel.vue';
    const items = ref([
        { name: '台南', image: "https://www.taiwanviptravel.com/articles/images/chihkan-tower-fort-provintia-img1.jpg" },
        { name: '台中', image: "https://image.kkday.com/v2/image/get/w_960%2Cc_fit%2Cq_55%2Ct_webp/s1.kkday.com/product_20142/20181024030541_OKzvH/jpg" },
        { name: "台北", image: "https://a.cdn-hotels.com/gdcs/production57/d1344/58e63eaa-73ec-48f3-828a-c287ee898ac3.jpg" },
        { name: "宜蘭", image: "https://a.cdn-hotels.com/gdcs/production159/d242/af7bebaf-1370-41c8-8c63-19575a6c49e8.jpg" },
        { name: "花蓮", image: "https://storage.googleapis.com/smiletaiwan-cms-cwg-tw/article/202312/article-657028cf6664d.jpg" },
        { name: '金門', image: "https://tlife.thsrc.com.tw/s3/post/20230728-l24hIFWmfakd98oejZ7jGcIJzkegT1za2v5G2yYj.jpg" },
        { name: "高雄", image: "https://cpok.tw/wp-content/uploads/2024/01/202403-5.jpg" },
        // 更多項目...
    ]);
    const currentOffset = ref(0);
    const paginationFactor = 220;
    const windowSize = 3;
    const acount = 0;

    const atEndOfList = computed(() => {
        return currentOffset.value <= paginationFactor * -1 * (items.value.length - windowSize);
    });
    const atHeadOfList = computed(() => {
        return currentOffset.value === 0;
    });

    const moveCarousel = (direction) => {
        if (direction === 1 && !atEndOfList.value) {
            currentOffset.value -= paginationFactor;
        } else if (direction === -1 && !atHeadOfList.value) {
            currentOffset.value += paginationFactor;
        }
    };

    // 使用 onMounted 鉤子在組件掛載時發起 API 請求
    onMounted(() => {
        items.value.forEach(async (item, index) => {
            try {
                const response = await axios.get(`https://localhost:7113/api/Hotels/search?address=${encodeURIComponent(item.name)}`);
                // 假设 response 的 data 是一个数组，其长度即为该地区的酒店数量
                items.value[index].acount = response.data.length; // 更新对应地区的酒店数量
            } catch (error) {
                console.log(`搜尋 ${item.name} 地區酒店數量發生錯誤:`, error);
                items.value[index].acount = 0; // 如果请求失败，将数量设置为0
            }
        });
    });
    
</script>

<style scoped>
    .main-container {
        max-width: 100%; /* 確保最大寬度為100% */
        width: 100%; /* 新增，確保容器寬度為100% */
        position: relative;
    }
    .search-panel {
        position: absolute;
        top: 350px;
        left: 40px;
        max-width: 100vw;
    }


    .el-carousel {
        width: 100%; /* 確保旋轉木馬的寬度為100% */
        height:500px;
    }

    .text-center {
        text-align: center;
    }

    img {
        width: 100%; /* 新增，確保圖片寬度為100% */
        height: 100%; /* 保持圖片的高度自動調整以保持宽高比 */
        object-fit: cover; /* 更改為cover，以避免圖片失真 */
    }
</style>