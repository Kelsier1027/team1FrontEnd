<template>
    <div class="categoryBox">
        <div><img :src="category.icon" alt="123"></div>
        <div class="catText">{{ category.name }}</div>
    </div>
</template>

<script setup>
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
</style>