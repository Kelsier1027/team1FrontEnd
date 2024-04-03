<!-- components/Carousel.vue -->
<template>
    <div class="card-carousel-wrapper">
        <div class="card-carousel--nav__left" @click="$emit('move-carousel', -1)" :disabled="atHeadOfList"></div>
        <div class="card-carousel">
            <div class="card-carousel--overflow-container">
                <div class="card-carousel-cards" :style="{ transform: 'translateX(' + currentOffset + 'px)'}">
                    <div class="card-carousel--card" v-for="item in items" :key="item.name" @click="navigateToHotelList(item.name)">
                        <img :src="item.image" />
                        <div class="card-carousel--card--footer">
                            <p>{{ item.name }}</p>
                            <p>{{ item.acount }}間房間</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="card-carousel--nav__right" @click="$emit('move-carousel', 1)" :disabled="atEndOfList"></div>
    </div>
</template>

<script setup>

    import { useRouter } from 'vue-router';

    const props = defineProps({
        items: Array,
        currentOffset: Number,
        atEndOfList: Boolean,
        atHeadOfList: Boolean,
        acount: Number,
    });

    const router = useRouter();

    function navigateToHotelList(itemName) {
        router.push({ path: '/hotel/list', query: { name: itemName } });
        console.log(itemName);
    }

</script>

<style scoped>

    /* 這裡直接使用你提供的 CSS 樣式 */
    body {
        background: #f8f8f8;
        color: #2c3e50;
        /*font-family: "Source Sans Pro", sans-serif;*/
    }

    .card-carousel-wrapper {
        display: flex;
        align-items: center;
        justify-content: center;
        margin: 20px 0 40px;
        color: #666a73;
    }

    .card-carousel {
        display: flex;
        justify-content: center;
        width: 740px;
    }

    .card-carousel--overflow-container {
        overflow: hidden;
    }

    .card-carousel--nav__left, .card-carousel--nav__right {
        display: inline-block;
        width: 15px;
        height: 15px;
        padding: 10px;
        box-sizing: border-box;
        border-top: 2px solid #42b883;
        border-right: 2px solid #42b883;
        cursor: pointer;
        margin: 0 20px;
        transition: transform 150ms linear;
    }

        .card-carousel--nav__left[disabled], .card-carousel--nav__right[disabled] {
            opacity: 0.2;
            border-color: black;
        }

    .card-carousel--nav__left {
        transform: rotate(-135deg);
    }

        .card-carousel--nav__left:active {
            transform: rotate(-135deg) scale(0.9);
        }

    .card-carousel--nav__right {
        transform: rotate(45deg);
    }

        .card-carousel--nav__right:active {
            transform: rotate(45deg) scale(0.9);
        }

    .card-carousel-cards {
        display: flex;
        transition: transform 150ms ease-out;
        transform: translatex(0px);
    }

        .card-carousel-cards .card-carousel--card {
            margin: 0 10px;
            cursor: pointer;
            box-shadow: 0 4px 15px 0 rgba(40, 44, 53, 0.06), 0 2px 2px 0 rgba(40, 44, 53, 0.08);
            background-color: #fff;
            border-radius: 4px;
            z-index: 3;
            margin-bottom: 2px;
        }

            .card-carousel-cards .card-carousel--card img {
                vertical-align: bottom;
                border-top-left-radius: 4px;
                border-top-right-radius: 4px;
                transition: opacity 150ms linear;
                user-select: none;
                width: 200px;
                height: 200px;
                object-fit: cover;
            }
</style>
