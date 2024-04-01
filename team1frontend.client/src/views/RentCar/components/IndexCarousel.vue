<script setup>
const imageList = [
    "src/assets/zh-tw-cju.c5a4127.webp",
    "src/assets/zh-tw-go-points.049a37d.webp",
    "src/assets/zh-tw-hkk.2af7289.webp",
    "src/assets/zh-tw-kh.5365c42.webp",
    "src/assets/zh-tw-oka.d095852.webp",
    "src/assets/zh-tw-sel.49889e3.webp",
]
</script>
<template>
    <v-carousel hide-delimiters cycle height="">
        <v-carousel-item v-for="x in 2" :key="x">
            <v-row>
                <v-col v-for="n in 3" :key="n" class="d-flex child-flex" cols="4">
                    <v-img :src="`${imageList[(x - 1) * 3 + n - 1]}`" aspect-ratio="16/9" class="bg-grey-lighten-2 rounded-xl"
                        cover>
                    </v-img>
                </v-col>
            </v-row>
        </v-carousel-item>
    </v-carousel>
</template>