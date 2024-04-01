<script setup>
import Form from '@/views/RentCar/components/IndexForm.vue';
import Carousel from '@/views/RentCar/components/IndexCarousel.vue';
</script>

<template>
    <v-main>
        <div class="">
            <img src="../../assets/banner.6e663b8.webp" class="object-fit-cover w-100 position-absolute ">
        </div>
        <div class="d-flex justify-content-center align-items-center position-relative mb-16"
            style="height:70vh;width: 100vw;">
            <div class="">
                <h1 class="textprimary fw-bold headtextsize">最好用的租車平台</h1>
                <div class="textprimary text-lg mt-6 mb-16" data-v-81d20e1e="">Fast, Smart, and Simple</div>
                <Form style="width:65vw"></Form>
            </div>
        </div>
        <v-row>
            <v-col></v-col>
            <v-col cols="8">
                <Carousel></Carousel>
            </v-col>
            <v-col></v-col>
        </v-row>
    </v-main>
</template>
<style scoped>
.headtextsize {
    font-size: 50px
}

.textprimary {
    color: rgb(12, 62, 119);
}

.text-lg {
    font-size: 25px;
}
</style>
