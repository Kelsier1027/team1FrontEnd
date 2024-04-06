<template>
    <div class="categoryBox">
        <div><img :src="category.icon" alt="123"></div>
        <div class="catText">{{ category.name }}</div>
    </div>
</template>

<script setup>
import { ref, computed } from 'vue';

defineProps({
    category: {
        type: Object
    }
})






</script>

<style scoped>
.categoryBar {
    display: flex;
}

img {
    height: 100px;
    width: 150px;
    margin: 10px;
}

.catText {
    text-align: center;
}

.categoryBox {
    align-items: center;
    justify-content: center;
    width: 200px;
    height: 150px;
    margin: 10px;
    text-align: center;
    border-radius: 4px;
    border: 1px solid black;

}



/* .categoryBox {
    width: 60vmin;
    height: 50vmin;
    display: grid;
    place-content: center;
    color: white;
    text-shadow: 0 1px 0 #000;

    --border-angle: 0turn;
    --main-bg: conic-gradient(from var(--border-angle),
            #213,
            #112 5%,
            #112 60%,
            #213 95%);

    border: solid 5px transparent;
    border-radius: 2em;
    --gradient-border: conic-gradient(from var(--border-angle),
            transparent 25%,
            #08f,
            #f03 99%,
            transparent);

    background:

        var(--main-bg) padding-box,
        var(--gradient-border) border-box,
        var(--main-bg) border-box;

    background-position: center center;

    animation: bg-spin 3s linear infinite;

    @keyframes bg-spin {
        to {
            --border-angle: 1turn;
        }
    }

    &:hover {
        animation-play-state: paused;
    }
}

@property --border-angle {
    syntax: "<angle>";
    inherits: true;
    initial-value: 1turn;
} */
</style>