<template>
  <v-main>
    <Cart />
    <v-container>

      <!--麵包屑導航-->
      <el-breadcrumb :separator-icon="ArrowRight">
        <el-breadcrumb-item :to="{ path: '/' }">首頁</el-breadcrumb-item>
        <el-breadcrumb-item :to="{ path: '/attraction' }">景點</el-breadcrumb-item>
        <el-breadcrumb-item>{{ attractionContent[0]?.attractionName }}</el-breadcrumb-item>
      </el-breadcrumb>
      <!--內文-->
      <h1>{{ attractionContent[0]?.attractionName }}</h1>
      <h4>{{ attractionContent[0]?.attractionContentContextDTO[0].subTitle }}</h4>
      <div class="tag">
        <el-tag type="danger" style="font-size: 17px;">熱賣中</el-tag>
        <el-tag type="success" style="font-size: 17px;" >推薦</el-tag>
        <el-tag type="warning" style="font-size: 17px;">限量</el-tag>
      </div>
      <div class="pictureBox">
        <div class="leftBox"><img :src="attractionContent[0]?.attractionContentImageDTO[0]?.image"></div>
        <div class="rightBox">
          <div class="imageBox imageBox1"><img :src="attractionContent[0]?.attractionContentImageDTO[1]?.image"></div>
          <div class="imageBox imageBox2"><img :src="attractionContent[0]?.attractionContentImageDTO[2]?.image"></div>
        </div>
      </div>
      <div class="block">
      <ul v-html="attractionContent[0]?.attractionContentContextDTO[0].hightLight" style="font-size: 20px;"></ul>
      </div>
      <div class="block">
      <h2>方案選擇</h2>
      <div class="demo-collapse">
        <el-collapse v-model="activeName" @change="handleChange">
          <Ticket v-for="item in ticketContentList" :ticket="item" :key="item.id" />

        </el-collapse>
        
      </div>
    </div>

      <!-- <span class="test">{{ attractionContent[0]?.longitude }}</span> -->
      <div class="block">
      <h2>地點</h2>
      <Map :lat="attractionContent[0]?.latitude" :lng="attractionContent[0]?.longitude" />
    </div>
    </v-container>
  </v-main>
</template>


<script setup>
import { useTicketContent } from '@/views/Ticket/attractionContent/composables/useTicketContent'
import { useAttractionContent } from '@/views/Ticket/attractionContent/composables/useAttractionContent'
import { getAttractionContentAPI } from '@/apis/Chih/apis/get_attractionContent';
import { computed, onMounted, ref } from 'vue';
import { useRoute } from 'vue-router'
import { ArrowRight } from '@element-plus/icons-vue'
import Ticket from './components/Ticket.vue'
import Map from './components/Map.vue'
import Cart from '../components/cart.vue'

const attractionContent = ref({})
const route = useRoute();
const id = route.params.id
const { ticketContentList } = useTicketContent(id);


const loadContent = async () => {
  const res = await getAttractionContentAPI(id);
  attractionContent.value = res
  console.log(attractionContent);
  console.log(id);
}



onMounted(() => loadContent());
</script>



<style scoped>
.tag{
  margin-bottom: 15px;
}

.block{
  margin-top:50px;
}
.imageBox1{
  margin-bottom:4px;
}
.leftBox{
  margin-right: 4px;
}
.leftBox img{
 border-top-left-radius: 20px;
 border-bottom-left-radius: 20px;
}
.imageBox1 img{
  border-top-right-radius: 20px;
}
.imageBox2 img{
  border-bottom-right-radius: 20px;
}

img {
  width: 100%;
  height: 100%;
}

.imageBox {
  display: flex;
}


.pictureBox {
  height: 505px;
  width: 1200px;
  display: flex;
}

.leftBox {
  height: 500;
  width: 600px;

}

.rightBox {
  width: 600px;

  display: grid;
}

.imageBox {
  height: 250px;
  width: 600px;

}

.titleBox {
  display: grid;
  padding: 5px;
}

:deep(.contain) {
  display: flex;
  height: 200px;
  width: 200px;
}
</style>