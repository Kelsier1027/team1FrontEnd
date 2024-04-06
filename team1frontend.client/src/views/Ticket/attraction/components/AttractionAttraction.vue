<template>

  <div class="block text-center">

    <el-carousel height="500px" motion-blur>
      <div class="title">
        探索你的玩樂世界
      </div>
      <div class="searchBar">
        <div style="display: flex;">
          <div class="searchBarBG">
            <el-input class="searchInput" @keyup.enter="search" v-model="keyword"
              style="width: 340px;height: 50px;font-size: 20px;" placeholder="關鍵字搜尋" />
          </div>
          <div class="searchBarBG">

            <el-button type="primary" icon="Search" @click="search" dir=""
              style="width: 100px;height: 50px;;font-size: 20px;">搜尋</el-button>

          </div>
        </div>
      </div>
      <!-- <el-carousel-item v-for="item in 4" :key="item" :interval="1500">
      </el-carousel-item> -->

      <el-carousel-item :interval="1000">
        <img src="@/assets/images/chih/0x01.webp">
      </el-carousel-item>
      <el-carousel-item :interval="1000">
        <img src="@/assets/images/chih/0x02.webp">
      </el-carousel-item>
      <el-carousel-item :interval="1000">
        <img src="@/assets/images/chih/0x03.webp">
      </el-carousel-item>
      <el-carousel-item :interval="1000">
        <img src="@/assets/images/chih/0x04.webp">
      </el-carousel-item>
      <el-carousel-item :interval="1000">
        <img src="@/assets/images/chih/0x05.webp">
      </el-carousel-item>

    </el-carousel>
  </div>

  <div class="attraction_body">
    <div>
      <div id="categoryBar" class="category_bar">
        <el-scrollbar class="scrollbar">
          <div class="scrollbar-flex-content">

            <AttractionCategory v-for="item in categoryList" :category="item" :key="item.id"
              @click="categoryQuery(item.id)" />

          </div>
        </el-scrollbar>
      </div>
    </div>


    <transition-group name="list" tag="div" class="row row-cols-1 row-cols-md-5 g-4 card-container">
      <AttractionItem v-for="item in attractionList" :attraction="item" :key="item.id" />
    </transition-group>
    <el-empty :image-size="200" v-if="attractionList == 0" />

  
  </div>




</template>

<script setup>
import { useAttraction } from '@/views/Ticket/attraction/composables/useAttraction';
import { onMounted, ref, watch } from 'vue';
import { Calendar, Search } from '@element-plus/icons-vue'
import AttractionItem from './Attraction_Item.vue'
import AttractionCategoryVue from './AttractionCategory.vue';
import AttractionCategory from './AttractionCategory.vue'
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


function categoryQuery(id) {
  if (id === 9) {
    category.value = 0;
  }
  else {
    category.value = id;
  }

  search()
}




const search = async () => {
  try {
    const res = await getAttractionsAPI(keyword.value, category.value);
    console.log(res);
    //更新篩選後的list
    attractionList.value = res;
    //更新搜尋後的url

    router.push({ query: { keyword: keyword.value, category: category.value } });
    // categoryBar.scrollIntoView({ behavior: 'smooth' });


  } catch (error) {
    console.error('Error occurred while searching:', error);

  }
}

//判斷url若有keyword或Category賦值給keyword並search()
onMounted(() => {
  if (route.query.keyword || route.query.category) {
    keyword.value = route.query.keyword;
    category.value = route.query.category;
    search();
  }
});





</script>

<style scoped>
.attraction_body {
  padding-top: 10px;
  padding-left: 150px;
  padding-right: 150px;
  padding-bottom: 20px;
  height: auto;
}


.list-enter-active,
.list-leave-active {
  transition: opacity 0.5s;
}

.list-enter,
.list-leave-to

/* 在Vue 2中是.list-leave-active */
  {
  opacity: 0;
}

.vcontain {
  height: 1200px;
}

.title {
  position: relative;
  z-index: 100;
  font-size: 100px;
  color: #FFFFFF;

}

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
  left: 300px;
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