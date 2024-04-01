<template>
    <v-main>
        <h1>Hotel飯店</h1>
        <Search @search="handleSearch" />
        <Carousel :items="items" :currentOffset="currentOffset" 
                  :atEndOfList="atEndOfList" 
                  :atHeadOfList="atHeadOfList" 
                  @move-carousel="moveCarousel" 
                  @item-clicked="navigateToHotelList"/>
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
    
</script>

