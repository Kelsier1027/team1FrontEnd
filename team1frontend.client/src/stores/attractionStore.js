import { defineStore } from "pinia";
import { useMemberStore } from "./memberStore";
import { getCartByMemberAPI } from "@/apis/Chih/apis/get_cartByMember";



export const useCartStore = defineStore('cart', {
  state: () => ({
    cartId: null,
  }),

  getters: {

  },

  actions: {

    async getCart() {
      const memberStore = useMemberStore();
      const res = await getCartByMemberAPI(memberStore.memberId)
      this.cartId = res[0].cartId;
    }
  }



})