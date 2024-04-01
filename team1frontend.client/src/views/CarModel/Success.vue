<script setup>

</script>

<template>
    <v-row justify="center">
        <v-col cols="8">
            <h1>付款結果</h1>
            <v-divider></v-divider>
            <div class="d-flex justify-center my-12 position-relative">
                <v-card width="500" elevation="10">
                    <div class="d-flex justify-center align-center" style="height:250px">
                        <font-awesome-icon icon="fa-solid fa-circle-check" style="color: #63E6BE;font-size:1000%" />
                    </div>
                    <v-divider></v-divider>
                    <v-card-text>
                        <div class="font-weight-bold mb-2 text-h4 d-flex justify-center">
                            成功付款
                        </div>
                        <v-divider></v-divider>
                        <v-list lines="three">
                            <v-list-item v-for="n in 3" :key="n" :title="'Item ' + n"
                                subtitle="Lorem ipsum dolor sit amet consectetur adipisicing elit"></v-list-item>
                        </v-list>
                    </v-card-text>
                </v-card>
                <div class="position-absolute bottom-0 end-0">
                    <v-btn rounded="xl" size="x-large" to="/">回首頁</v-btn>
                </div>
            </div>
            <v-divider></v-divider>
        </v-col>
    </v-row>
</template>