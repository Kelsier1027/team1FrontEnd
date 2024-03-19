<template>
    <v-main>
        <h1>Hotel飯店</h1>
        <Search @search="handleSearch" />
        <Carousel :items="items" :currentOffset="currentOffset" :atEndOfList="atEndOfList" :atHeadOfList="atHeadOfList" @move-carousel="moveCarousel" />
    </v-main>

</template>

<script setup>

    //搜尋
    import Search from '../Layout/components/search.vue';

    function handleSearch(searchQuery) {
        // 處理搜索邏輯
    }

    //旋轉木馬
    import { ref, computed } from 'vue';
    import Carousel from '../Layout/components/Carousel.vue'; // 確保路徑正確

    const items = ref([
        { name: '台中', image: "https://image.kkday.com/v2/image/get/w_960%2Cc_fit%2Cq_55%2Ct_webp/s1.kkday.com/product_20142/20181024030541_OKzvH/jpg" },
        { name: "台北", image: "https://a.cdn-hotels.com/gdcs/production57/d1344/58e63eaa-73ec-48f3-828a-c287ee898ac3.jpg" },
        { name: '台中', image: "https://image.kkday.com/v2/image/get/w_960%2Cc_fit%2Cq_55%2Ct_webp/s1.kkday.com/product_20142/20181024030541_OKzvH/jpg" }
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

