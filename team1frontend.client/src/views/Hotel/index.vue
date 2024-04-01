<template>
    <v-main class="main-container">
        <div class="block text-center">
            <el-carousel height="500px">
                <el-carousel-item :interval="1500">
                    <img src="https://www.kkday.com/zh-tw/blog/wp-content/uploads/batch_P1420358.jpg">
                </el-carousel-item>
                <el-carousel-item :interval="1500">
                    <img src="https://i0.wp.com/img.journey.tw/2020-07-29-180230-23.jpg?resize=1100%2C734&quality=99&ssl=1" />
                         </el-carousel-item>
                <el-carousel-item :interval="1500">
                    <img src="https://res.klook.com/images/fl_lossy.progressive,q_65/c_fill,w_2048,h_1371,f_auto/w_80,x_15,y_15,g_south_west,l_Klook_water_br_trans_yhcmh3/activities/kmljdkbp98lfhhycozen/%E4%B9%9D%E6%97%8F%E6%96%87%E5%8C%96%E6%9D%91%E9%96%80%E7%A5%A8-Klook%E5%AE%A2%E8%B7%AF.jpg">
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
    import { ref, computed } from 'vue';
    import Carousel from '../Layout/components/Carousel.vue'; // 確保路徑正確

    const items = ref([
        { name: '台中', acount: 0, image: "https://image.kkday.com/v2/image/get/w_960%2Cc_fit%2Cq_55%2Ct_webp/s1.kkday.com/product_20142/20181024030541_OKzvH/jpg" },
        { name: "台北", acount: 0, image: "https://a.cdn-hotels.com/gdcs/production57/d1344/58e63eaa-73ec-48f3-828a-c287ee898ac3.jpg" },
        { name: "宜蘭", acount: 2, image: "https://a.cdn-hotels.com/gdcs/production159/d242/af7bebaf-1370-41c8-8c63-19575a6c49e8.jpg" },
        { name: "花蓮", acount: 1, image: "https://storage.googleapis.com/smiletaiwan-cms-cwg-tw/article/202312/article-657028cf6664d.jpg" },
        { name: '金門', acount: 1, image: "https://tlife.thsrc.com.tw/s3/post/20230728-l24hIFWmfakd98oejZ7jGcIJzkegT1za2v5G2yYj.jpg" },
        { name: "高雄", acount: 0, image: "https://cpok.tw/wp-content/uploads/2024/01/202403-5.jpg" },

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

</script>

<style>
    .main-container {
        max-width: 2000px; /* 設定最大寬度 */
        margin-left: auto; /* 水平居中 */
        margin-right: auto; /* 水平居中 */
    }

    .text-center {
        text-align: center;
    }

    .el-carousel__item h3 {
        color: #475669;
        opacity: 0.75;
        line-height: 150px;
        margin: 0;
        position: relative;
    }

    .el-carousel__item:nth-child(2n) {
        background-color: #99a9bf;
    }

    .el-carousel__item:nth-child(2n + 1) {
        background-color: #d3dce6;
    }

    img {
        width: 100%;
        height: auto;
    }
</style>
