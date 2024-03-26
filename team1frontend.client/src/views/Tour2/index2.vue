<!-- <h3>台東</h3> -->
<template>

  <div class="container h-100 py-5">
    <div class="topProduct">
      <div class="ProName">
        <p class="ProName-P">{{ detail.name }}</p>
      </div>

      <!-- <script>
export default {
  data() {
    return {
      detail: {
        name: '墾丁3天2夜' // 产品名称的默认值
      }
    };
  }
};
</script> -->

      <div>
        <div class="Pro-lef d-flex">
          <img class="card-img" src="/assets/Images/台東.jpg" style="width: 500px; object-fit: cover" alt="" />
          <div class="Pro-right">12加寬</div>
          <div>
            <table>
              <thead>
                <tr>
                  <th class="push-td">12345<span class="m-5 p-2"></span></th>
                </tr>
              </thead>
              <tbody>
                <tr class="cate-mt">
                  <td>商品名稱 :</td>
                  <td class="td-r">{{ detail.id }}</td>
                </tr>
                <tr>
                  <td>商品編號 :</td>
                  <td class="td-r">{{ detail.categoryName }}</td>
                </tr>
                <tr>
                  <td>已賣 :</td>
                  <td class="td-r">{{ detail.brandName }}</td>
                </tr>
                <!-- <tr>
                  <td>庫存量 :</td>
                  <td class="td-r">{{ detail.inventory }}</td>
                </tr> -->
                <tr>
                  <td>庫存量 :</td>
                  <td class="td-r">{{ detail.inventory }}</td>
                </tr>
                <tr>
                  <td>價格$ :</td>
                  <!-- <td class="td-r">{{ detail.price.toLocaleString() }}</td> -->
                </tr>
              </tbody>
            </table>
            <div>
              <v-btn class="custom-btn">
                購買
              </v-btn>

              <!-- <button class="add-btn" @click.stop="this.toSoppingCart(detail)">
                直接購買
              </button> -->
            </div>
            <div>
              <!-- <button class="add-btn-buy">
                <i class="fa-solid fa-cart-shopping buy-i" @click.stop="buyDirectly(detail)"></i>
              </button> -->
              <button class="add-btn-like">
                <i v-if="MId == 0" class="fa-regular fa-star like-i" data-bs-toggle="modal"
                  data-bs-target="#loginModal"></i>

                <i v-else-if="!status.upshot" @click="CallProductFavorites()" class="fa-regular fa-star like-i"></i>
                <i v-else @click="CallUnFavorites(status.deleteId)" class="fa-solid fa-star like-i"></i>
              </button>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="TBborder">
      <p class="PBack">商品介紹</p>
    </div>
    <div class="botproduct">
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
    </div>
  </div>
</template>

<script>
import axios from "axios";
// import utility from "../../../public/utility";
import { useRouter, useRoute } from "vue-router";

export default {
  // mixins: [utility],
  name: "DetailProduct",
  setup() {
    const router = useRouter();
    const route = useRoute();
    const toSoppingCart = (productSelItem) => {
      // 將本頁prdoctItem傳入並存sessionStorage
      sessionStorage.setItem("productSelItem", JSON.stringify(productSelItem));
      router.push(`/ShoppingCart`);
    };

    return { toSoppingCart };
  },
  data() {
    return {
      detail: {},
      coverimg: "",
      picture: [],
      MId: 0,
      PId: 0,
      status: {},
      cartsSelect: [],
    };
  },
  created() {
    // this.scrollToTop();

    this.CallDetailProductsApi();
    this.CallFavoritesStatus();
    this.getStorageCart();
  },
  mounted() {
    this.GetMemberId();
  },

  methods: {
    async CallDetailProductsApi() {
      let detailId = this.$route.path.slice(9);

      this.PId = detailId;
      console.log(detailId);
      axios
        .get(`https://localhost:7259/api/Product/DetailProducts?Id=${detailId}`)
        .then((response) => {
          this.detail = response.data;
          this.picture = this.detail.source;

          this.coverimg = this.detail.source[0];
          this.picture = this.picture.slice(1);
          console.log(this.picture);
        })
        .catch((error) => {
          console.log(error);
        });
    },
    async GetMemberId() {
      this.MId = await this.fetchMemberId();
      console.log(this.MId);
    },
    async CallProductFavorites() {
      await axios
        .post(
          `https://localhost:7259/api/Favorites/ProductFavorites?memberId=${this.MId}&productId=${this.PId}`
        )
        .then((response) => {
          console.log(response.data);
          let res = response.data;
          if (res.upshot) {
            this.status.deleteId = res.deleteId;
            this.status.upshot = true;
            this.showAlert(res.reply);
          }
        })
        .catch((error) => {
          console.log(error);
        });
    },
    async CallUnFavorites(deleteId) {
      axios
        .delete(`https://localhost:7259/api/favorites/unfavorites/${deleteId}`)
        .then((response) => {
          if (response) {
            this.status.upshot = false;
            this.status.deleteId = 0;
            this.showAlert("取消收藏成功");
          }
          console.log(response);
        })
        .catch((error) => {
          console.log(error);
        });
    },
    async CallFavoritesStatus() {
      let memberId = await this.fetchMemberId();
      axios
        .get(
          `https://localhost:7259/api/Favorites/FavoritesStatus?memberId=${memberId}&productId=${this.PId}`
        )
        .then((response) => {
          this.status = response.data;
          console.log(this.status);
        })
        .catch((error) => {
          console.log(error);
        });
    },

    // 購物車行為
    saveLocalStorage(saveName, val) {
      localStorage.setItem(saveName, JSON.stringify(val));
    },
    // 將localStorage 已存JSON字串轉回物件 存在指定data參數
    // saveName與data相同
    getlocalStorage(saveName) {
      this[saveName] = JSON.parse(localStorage.getItem(saveName)); // 與this.saveName相同
    },
    // 從Storage取使用者購物車紀錄
    getStorageCart() {
      this.getlocalStorage("cartsSelect");
      // 防呆 假如storage沒存過 將值存為空陣列
      if (!this.cartsSelect) {
        this.cartsSelect = [];
      }
    },
    buyDirectly(item) {
      // 防呆 依id確認購物車有沒有商品 有的話更新陣列數量+1 沒有新增一筆
      let findProduct = this.cartsSelect.find((a) => a.Id == item.id);

      if (findProduct) {
        // 已在購物車 找到index 修改物件值
        let index = this.cartsSelect.indexOf(findProduct);
        this.cartsSelect[index].Qty++;
      } else {
        // 未在購物車 加入陣列
        this.cartsSelect.push({
          Id: item.id,
          Qty: 1,
          Name: item.name,
          Price: item.price,
          Cover: `https://localhost:7027/ProductImgFiles/${this.detail.source[0]}`,
        });
      }

      this.showAlert("加入成功");
      // 儲存到storage
      this.saveLocalStorage("cartsSelect", this.cartsSelect);
    },
  },
};
</script>

<style scoped>
.custom-btn {
  margin-top: 100px;
  /* 向下移动按钮 */
  margin-left: 150px;
  transform: scale(1.2);
  width: 200px;
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

.add-btn-like {
  margin-top: -1000px;
  /* 向上移动按钮 */
  margin-left: 30px;
  margin-right: 30px;
  padding: 5px 35px 5px 35px;
  border: none;
  border-radius: 5px;
  background: rgba(221, 138, 209, 0.192);
  font-size: 20px;
}

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
