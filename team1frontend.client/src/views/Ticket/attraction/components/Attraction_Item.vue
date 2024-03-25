<template>
  <Router-link class="router-link" :to="{ name: 'AttractionContent', params: { id: attraction.id } }">
    <div class="col">
      <div class="card">
        <div class="card-div">
          <img :src="attraction.mainImage" class="card-img-top" alt="...">
        </div>
        <div class="card-body">
          <h5 class="card-title">{{ attraction.name }}</h5>
          <p class="card-text">{{ attraction.description }}</p>
        </div>
      </div>
    </div>
  </Router-link>

</template>

<script setup>
import { useAttractionContent } from '@/views/Ticket/attractionContent/composables/useAttractionContent';
import { RouterLink } from 'vue-router';


defineProps({
  attraction: {
    type: Object,
    default: () => { }
  }

})



</script>

<style scoped>
.col {
  display: flex;
}

.card-img-top {
  height: 100%;
  width: 100%;
}

.card {
  border: 2px solid black;



}

.card:hover {
  transform: translate3d(0, -10px, 0);
  box-shadow: 0 3px 8px rgba(0, 0, 0, 0.2);

}

.card-text {
  overflow: hidden;
  white-space: nowrap;
  text-overflow: ellipsis;
}

.router-link {
  text-decoration: none;

}

.router-link:hover {
  background-image: linear-gradient(45deg, #93A5CF, #E4EfE9);
}

/* .card-div{

    height: 140px;
    width: 200px;
  } */
/* .img{
    height: 100%;
    width: 100%;
  }  */
</style>