<template>
  <el-breadcrumb :separator-icon="ArrowRight">
    <el-breadcrumb-item :to="{ path: '/' }">首頁</el-breadcrumb-item>
    <el-breadcrumb-item :to="{ path: '/attraction' }">景點</el-breadcrumb-item>
    <el-breadcrumb-item>{{ attractionContent[0]?.attractionName }}</el-breadcrumb-item>

  </el-breadcrumb>
  <h1>{{ attractionContent[0]?.attractionName }}</h1>
  <h4>{{ attractionContent[0]?.attractionContentContextDTO[0].subTitle }}</h4>
  <div class="pictureBox">
    <div class="leftBox"></div>
    <div class="rightBox">
      <div class="imageBox imageBox1"></div>
      <div class="imageBox imageBox2"></div>
    </div>
  </div>
  <ul v-html="attractionContent[0]?.attractionContentContextDTO[0].hightLight"></ul>
  <h2>方案選擇</h2>
  <div class="demo-collapse">
    <el-collapse v-model="activeName" @change="handleChange">
      <Ticket v-for="item in ticketContentList" :ticket="item" :key="item.id" />

    </el-collapse>
  </div>

  <!-- <span class="test">{{ attractionContent[0]?.longitude }}</span> -->
  <h1>地點</h1>
  <Map :lat="attractionContent[0]?.latitude" :lng="attractionContent[0]?.longitude" />

</template>


<script setup>
import { useTicketContent } from './composables/useTicketContent'
import { useAttractionContent } from '@/views/attractionContent/composables/useAttractionContent'
import { getAttractionContentAPI } from '@/apis/get_attractionContent';
import { onMounted, ref } from 'vue';
import { useRoute } from 'vue-router'
import Ticket from './components/Ticket.vue'
import Map from './components/Map.vue'
import { ArrowRight } from '@element-plus/icons-vue'

const attractionContent = ref([])
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
.pictureBox {
  height: 500px;
  width: 1200px;
  border: 2px solid black;
  display: flex;
}

.leftBox {
  height: 500;
  width: 600px;
  border: 1px solid salmon
}

.rightBox {
  width: 600px;
  border: 3px solid blue;
  display: grid;
}

.imageBox {
  height: 250px;
  width: 600px;
  border: 2px solid greenyellow;
}

.titleBox {
  display: grid;
  padding: 5px;
}
</style>