// import { useMemberStore } from '@/stores/memberStore';
// import { AddCartItem } from '@/apis/Chih/apis/post_addItem';
// import { ref } from 'vue'

// const cleanItem = ref({});
// const memberStore = useMemberStore();


// //get cart info
// const useCart = async () => {
//   const res = await getCartByMemberAPI(memberStore.memberId);
//   cartList.value = res;
//   console.log(res);
//   cleanItem.value = res[0].cartItems.map(item => ({
//     id: item.id,
//     ticketName: item.ticketName.trim(), // 清理 ticketName 字段
//     price: item.price,
//   }))
//   console.log(cleanItem);

// };

// export {
//   cleanItem,
//   memberStore,
// }