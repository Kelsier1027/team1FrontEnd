<template>
  <v-main>
    <v-parallax src="https://cdn.vuetifyjs.com/images/parallax/material.jpg">
      <v-card class="mx-auto" max-width="777" v-for="item in userTicket" :key="item.id">
        <v-container>
          <v-row dense>
            <v-col cols="12">
              <v-card color="#1F7087" theme="dark">
                <div class="d-flex flex-no-wrap justify-space-between">
                  <div>
                    <v-card-title class="text-h4"> {{ item.ticketName }} </v-card-title>

                    <v-card-subtitle class="text-h6"> No.{{ item.itemId }}</v-card-subtitle>
                    <v-card-subtitle class="text-h6">購買日期{{ item.createTime }}</v-card-subtitle>
                    <v-card-actions>


                      <v-dialog max-width="333">
                        <template v-slot:activator="{ props: activatorProps }">
                          <v-btn v-bind="activatorProps" class="ms-2" size="small" variant="outlined" text="兌換"></v-btn>
                        </template>

                        <template v-slot:default="{ isActive }">
                          <v-card title="QR-Code">
                            <v-card-text style="display: flex;">
                              <img :src="item.imgOfQRCode" style="width: 100%" />
                            </v-card-text>

                            <v-card-actions>
                              <v-spacer></v-spacer>

                              <v-btn text=" 關閉" @click="isActive.value = false"></v-btn>
                            </v-card-actions>
                          </v-card>
                        </template>
                      </v-dialog>



                    </v-card-actions>
                  </div>

                  <v-avatar class="ma-3" rounded="0" size="125">
                    <v-img :src="item.ticketImg"></v-img>
                  </v-avatar>
                </div>
              </v-card>
            </v-col>
          </v-row>
        </v-container>
      </v-card>
    </v-parallax>






  </v-main>

</template>
<script setup>
import { useMemberStore } from '@/stores/memberStore'
import { getUserTicketAPI } from '@/apis/Chih/apis/get_ticket'
import { onMounted, ref } from 'vue';
const member = useMemberStore();
const userTicket = ref({});
const id = member.memberId




const getTicket = async () => {
  try {
    const res = await getUserTicketAPI(55);
    userTicket.value = res.map(item => {
      const date = new Date(item.createTime);
      item.createTime = `${date.getFullYear()}-${String(date.getMonth() + 1).padStart(2, '0')}-${String(date.getDate()).padStart(2, '0')}`;
      return item;
    });
    console.log(res);
    console.log(id);

  } catch (err) {
    console.log(err);

  }
}

onMounted(() => getTicket())



</script>


<style>
.v-card {
  font-size: 30px;
}
</style>