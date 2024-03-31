<script setup>
import { getPackageItem } from '@/apis/package';
import { onMounted,ref } from 'vue';
import { useRoute } from 'vue-router';
// 使用 useRoute 函数获取路由信息
const route = useRoute();
const id = route.params.id;
const PackageItem = ref([]);
const getPackageItems = async () => {
    const res = await getPackageItem(id);
    PackageItem.value = res;
}
const getPackageList = () => {
    return PackageItem.value.map(item => ({
        id: item.id,
        name: item.name,
        price: item.price,
        applyBeginDate:formatDate(item.applyBeginDate),
        applyEndDate:formatDate(item.applyEndDate),
        imageUrl: '/assets/Images/' + item.image,
        canSold:item.canSold,
        store :parseInt(item.totalNum)-parseInt(item.canSold),
        description:item.description
    }));
}
const formatDate = (dateString) => {
    const year = dateString.substr(0, 4);
    const month = dateString.substr(5, 2);
    const day = dateString.substr(8, 2);
    return `${year}/${month}/${day}`;
}
let obj = ref([
    {
        id: 1,
        name: 1,
        price: 1,
        applyBeginDate:1,
        applyEndDate:1,
        imageUrl:1,
        canSold:1,
        store:1,
        description:1

    },
]);
onMounted(async() => {
  await getPackageItems();
    obj.value = getPackageList();
    console.log(obj.value);
    // this.loadPDF(obj.value[0]);
});

</script>
<!-- <script>


export default {
  data() {
    return {
      currentPage: 1,
      numPages: 0,
      scale: 1.5,
      minScale: 1,
      maxScale: 3,
      pdf: null,
      context: null
    };
  },
  methods: {
    async loadPDF(para_pdfURL) {
      const canvas = this.$refs.pdfCanvas;
      this.context = canvas.getContext('2d');
      const pdfURL = para_pdfURL;
      // const pdfURL = '/path/to/your/pdf/file.pdf';

      const loadingTask = pdfjsLib.getDocument(pdfURL);
      loadingTask.promise.then(pdf => {
        this.pdf = pdf;
        this.numPages = pdf.numPages;
        this.renderPage(this.currentPage);
      }).catch(err => {
        console.error('Error loading PDF:', err);
      });
    },
    renderPage(pageNumber) {
      this.pdf.getPage(pageNumber).then(page => {
        const viewport = page.getViewport({ scale: this.scale });
        const canvas = this.$refs.pdfCanvas;
        canvas.height = viewport.height;
        canvas.width = viewport.width;

        const renderContext = {
          canvasContext: this.context,
          viewport: viewport
        };
        page.render(renderContext);
      });
    },
    previousPage() {
      if (this.currentPage > 1) {
        this.currentPage--;
        this.renderPage(this.currentPage);
      }
    },
    nextPage() {
      if (this.currentPage < this.numPages) {
        this.currentPage++;
        this.renderPage(this.currentPage);
      }
    },
    zoomIn() {
      if (this.scale < this.maxScale) {
        this.scale += 0.1;
        this.renderPage(this.currentPage);
      }
    },
    zoomOut() {
      if (this.scale > this.minScale) {
        this.scale -= 0.1;
        this.renderPage(this.currentPage);
      }
    }
  }
}
</script> -->
<template>
<template v-for="item in obj">
  <div class="container h-100 py-5">
    <div class="topProduct">
      <v-row class="align-center"> <!-- 使用 v-row 来创建栅格行，并设置 align 属性为 "center" 使内容垂直居中 -->
        <v-col cols="6"> <!-- 使用 v-col 来创建栅格列，并设置 cols 属性为 "6" 使其占据 6 栅格宽度，即占据一半的宽度 -->
          <img :src="item.imageUrl"  class="card-img" style="width: 100%; object-fit: cover;" alt="">
        </v-col>
        <v-col cols="1"></v-col> <!-- 创建一个占据 1 栅格宽度的空列，用作左右内容之间的间隔 -->
        <v-col cols="5"> <!-- 创建一个占据 5 栅格宽度的列，用作右边内容的容器 -->
          <div> <!-- 这里使用了您之前提到的 ms-10 类，用于添加左边距 -->
            <table>
              <thead>
                <tr>
                  <!-- <th class="push-td">12345<span class="m-5 p-2"></span></th> -->
                </tr>
              </thead>
              <tbody>
                <tr class="cate-mt">
                  <td>商品名稱 :</td>
                  <td class="td-r">{{ item.name }}</td>
                </tr>
                <tr>
                  <td>商品編號 :</td>
                  <td class="td-r">{{ item.id }}</td>
                </tr>
                <tr>
                  <td>已賣 :</td>
                  <td class="td-r">{{ item.canSold }}</td>
                </tr>

                <tr>
                  <td>庫存量 :</td>
                  <td class="td-r">{{ item.store }}</td>
                </tr>
                <tr>
                  <td>價格$ :</td>
                  <td class="td-r">{{ item.price }}</td>
                </tr>
              </tbody>
            </table>
            <v-btn size="large" width="200">
                購買
              </v-btn>
            <!-- <div class="d-flex justify-center">
              <v-btn size="large" width="200">
                購買
              </v-btn>
            </div> -->
          </div>
        </v-col>
      </v-row>
    </div>
    <div class="TBborder">
      <p class="PBack">商品介紹</p>
      <div>
    <div>
      <canvas ref="pdfCanvas"></canvas>
    </div>
    <div>
      <button @click="previousPage" :disabled="currentPage === 1">Previous</button>
      <button @click="nextPage" :disabled="currentPage === numPages">Next</button>
      <button @click="zoomOut" :disabled="scale <= minScale">Zoom Out</button>
      <button @click="zoomIn" :disabled="scale >= maxScale">Zoom In</button>
    </div>
  </div>
    </div>
    <!-- <div class="botproduct">
      <div v-for="(item, index) in picture" :key="index">
        <img class="card-img" src="/assets/Images/台東.jpg" style="width: 100%" alt="" />
      </div>
      <div class="spec-Out">
        <p class="spec-name">{{ detail.name }}</p>
        <p class="Spec">
          商品介紹:
          {{ detail.productSpec }}
        </p>
      </div>
    </div> -->
  </div>
</template>
</template>




<style scoped>
.custom-btn {
  margin-top: 100px;
  /* 向下移动按钮 */
  margin-left: 150px;
  transform: scale(1.2);
  width: 200px;
}

canvas {
  border: 1px solid black;
}
.topProduct {
  border-top-left-radius: 15px;
  border-top-right-radius: 15px;
  background: #ffff;
  padding: 10% 10%;
}

.ProName {
  border-bottom: 7px solid #578c7a;
  margin-bottom: 130px;
  margin-left: 50px;
  margin-right: 50px;
  /* name:墾丁三天兩夜; */
}

.ProName-P {
  padding-left: 50px;
  font-size: 24px;
  font-weight: 800;
}

.card-img {
  width: 200px;
  /* 将图片宽度设置为200像素 */
  height: auto;
  /* 保持宽高比 */
  /* padding: 0% 5%;
  margin-bottom: 50px; */
}


.Pro-right {
  margin-left: 150px;
  border-bottom: 5px solid #ffff;
  color: #ffff;
}

p {
  font-size: 20px;
}

.add-btn {
  margin: 20px;
}

.TBborder {
  border-top: 5px solid #578c7a;
  border-bottom: 5px solid #578c7a;
}

.PBack {
  background: #ffff;
  margin: 0%;
  padding-left: 20%;
  font-size: 22px;
  font-weight: 800;
  padding-top: 10px;
  padding-bottom: 10px;
}

.botproduct {
  background: #ffff;
  margin-top: 0;
  padding: 15%;
  border-bottom-left-radius: 15px;
  border-bottom-right-radius: 15px;
}

.spec-Out {
  padding: 50px;
  max-width: 1000px;
  align-content: center;
  border: #578c7a solid 5px;
  border-radius: 10px;
}

.Spec {
  white-space: pre-wrap;
  margin-top: 30px;
}

/* .add-btn-buy {
  margin-left: 30px;
  padding: 5px 35px 5px 35px;
  border: none;
  border-radius: 5px;
  background: #d3989938;
  font-size: 20px;
} */

/* .add-btn-like {
  margin-top: -1000px;  
  margin-left: 30px; 
  margin-right: 30px; 
  padding: 5px 35px 5px 35px;
  border: none;
  border-radius: 5px;
  background: rgba(221, 138, 209, 0.192);
  font-size: 20px;
} */

.add-btn {
  margin-bottom: 35px;
  margin-left: 82.5px;
  padding: 5px 30px 5px 30px;
  border: none;
  border-radius: 5px;
  background: #578c7a;
  color: #fff;
  font-size: 20px;
  font-weight: 700;
}

td {
  font-size: 18px;
  font-weight: 600;
  padding-bottom: 10px;
}

.push-td {
  color: #ffff;
}

.like-i {
  color: #e9cb89;
}

.buy-i {
  color: #d39899;
}

.spec-name {
  font-size: 24px;
  font-weight: 800;
  padding: 20px;
  border-bottom: 3px solid #578c7a;
}
</style>
