<template>

  <div class="block text-center">
    <el-carousel height="500px" motion-blur>
      <div class="searchBar">
        <div style="display: flex;">
          <div class="searchBarBG">
            <el-input class="searchInput" @keyup.enter="search" v-model="keyword" style="width: 240px"
              placeholder="搜尋"/>
          </div>
          <div class="searchBarBG">

            <el-button type="primary" icon="Search" @click="search" dir="">搜尋</el-button>

          </div>
        </div>
      </div>
      <!-- <el-carousel-item v-for="item in 4" :key="item" :interval="1500">
      </el-carousel-item> -->
      <el-carousel-item :interval="1500">
        <img src="@/assets/images/chih/0x01.webp">
      </el-carousel-item>
      <el-carousel-item :interval="1500">
        <img src="@/assets/images/chih/0x02.webp">
      </el-carousel-item>
      <el-carousel-item :interval="1500">
        <img src="@/assets/images/chih/0x03.webp">
      </el-carousel-item>
      <el-carousel-item :interval="1500">
        <img src="@/assets/images/chih/0x04.webp">
      </el-carousel-item>
      <el-carousel-item :interval="1500">
        <img src="@/assets/images/chih/0x05.webp">
      </el-carousel-item>

    </el-carousel>
  </div>

  <div>
    <div id="categoryBar" class="category_bar">
    <el-scrollbar class="scrollbar">
      <div class="scrollbar-flex-content">

        <AttractionCategory v-for="item in categoryList" :category="item" :key="item.id" @click="categoryQuery(item.id)" />

      </div>
    </el-scrollbar>
  </div>
  </div>


  <div class="row row-cols-1 row-cols-md-5 g-4 card-container">

    <AttractionItem v-for="item in attractionList" :attraction="item" :key="item.id" />
    <el-empty :image-size="200" v-if="attractionList == 0" />

  
  </div>



</template>

<script setup>
import { useAttraction } from '@/views/Ticket/attraction/composables/useAttraction';
import { onMounted, ref,watch } from 'vue';
import { Calendar, Search } from '@element-plus/icons-vue'
import AttractionItem from './Attraction_Item.vue'
import AttractionCategoryVue from './AttractionCategory.vue';
import AttractionCategory from './AttractionCategory.vue'
import axios from 'axios';
import { getAttractionsAPI } from '@/apis/Chih/apis/search_attraction';
import { useRouter } from 'vue-router';
import { useRoute } from 'vue-router';
import { useCategories } from '../composables/useCategories'

const { attractionList } = useAttraction();
const { categoryList } = useCategories();
const keyword = ref('')
const category = ref('1')
const router = useRouter();
const route = useRoute();
console.log(attractionList);
console.log(categoryList);


function categoryQuery(id){
  if(id===9){
    category.value=0;
  }
  else{
    category.value=id;
  }
  
  search()
}




const search = async () => {
  try {
    const res = await getAttractionsAPI(keyword.value,category.value);
    console.log(res);
    //更新篩選後的list
    attractionList.value = res;
    //更新搜尋後的url
   
    router.push({ query: { keyword:keyword.value ,category:category.value } });
    categoryBar.scrollIntoView({ behavior: 'smooth' });


  } catch (error) {
    console.error('Error occurred while searching:', error);

  }
}

//判斷url若有keyword或Category賦值給keyword並search()
onMounted(()=>{
  if(route.query.keyword||route.query.category){
  keyword.value=route.query.keyword;
  category.value=route.query.category;
  search();
}
});





</script>

<style scoped>

.card-container {
  display: flex;
  margin-top: 5px;
}

.demonstration {
  color: var(--el-text-color-secondary);
}

.el-carousel__item h3 {
  color: #475669;
  opacity: 0.75;
  line-height: 150px;
  margin: 0;
  text-align: center;
  position: relative;
}

.el-carousel__item:nth-child(2n) {
  background-color: #99a9bf;
}

.el-carousel__item:nth-child(2n + 1) {
  background-color: #d3dce6;
}

.searchBar {
  display: flex;
  align-items: center;
  position: absolute;
  left: 200px;
  top: 300px;
  z-index: 99;
  padding: 3px;
  border: white solid 2px;
  background-color: white;
  border-radius: 10px;
}

.searchBarBG {
  background-color: #FFFFFF;
  padding: 2px;

}

img {
  width: 100%;
  height: 100%;
}

.scrollbar-flex-content {
  display: flex;
}



</style>