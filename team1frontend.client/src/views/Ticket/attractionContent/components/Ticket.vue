<template>
    <el-collapse-item :name="ticket.id" @click.stop.prevent="toggleTitle" :class=foldStatus>
        <template #title>
            <div class="titleBox">
                <div>{{ ticket.ticketTitle }}</div>

                <div v-if="showTitle">NT${{ ticket.price }}</div>
            </div>

        </template>


        <div @click.stop.prevent>
            <div>{{ ticket.ticketDetail }}</div>
            <div class="d-flex">
                <div class="price">NT${{ ticketTotalPrice }}</div>
                <el-button type="warning" plain @click.stop.prevent="addItem">Warning</el-button>
            </div>
            <el-input-number v-model="num" :min="1" :max="10" @change="handleChange" @click.stop.prevent />
        </div>
    </el-collapse-item>

</template>

<script setup>
import { computed, ref, watch } from 'vue'
import { AddCartItemAPI } from '@/apis/Chih/apis/post_addItem';
import { getCartByMemberAPI } from '@/apis/Chih/apis/get_cartByMember'
import { useMemberStore } from '@/stores/memberStore';
import { useCartStore } from '@/stores/attractionStore'
const memberStore = useMemberStore();
const cartStore = useCartStore();


const showTitle = ref(true);


function toggleTitle() {
    showTitle.value = !showTitle.value
}

const addMessage = ref()



const props = defineProps({
    ticket: {
        type: Object,
        default: () => { }
    },
    cartId: {
        type: Number,
    }

});




const num = ref(1)

const handleChange = (num) => {
    console.log(num);
    console.log(props.ticket.price);
}

const ticketTotalPrice = computed(() => props.ticket.price * num.value);





const addItem = async () => {
    if (memberStore.isLoggedIn == false) {
        alert('請先登入K??');
        return;
    }

    const addItemDTO = {
        CartId: cartStore.cartId,
        ItemId: props.ticket.id,
        Quantity: num.value,
    };
    try {
        const res = await AddCartItemAPI(addItemDTO);
        addMessage.value = res;
        console.log(res);
        console.log(addItemDTO);
    } catch (error) {
        alert(error);

    }



}





watch(() => memberStore.memberId, (newId, oldId) => {
    if (newId !== oldId && newId) {//避免0 !== 1 && 0
        (async () => {
            await cartStore.getCart();
            console.log(cartStore.cartId);
        })();

    }
}, { immediate: false })

</script>

<style>
.el-breadcrumb {
    margin: 10px;
    font-size: 20px;
}

.el-collapse-item__header {
    display: flex;
    height: auto;
    font-size: 20px;

}

.el-tag {
    margin: 5px;
    width: 80px;
    height: 30px;
}

.el-collapse {
    --el-collapse-border-color: red;
}

.el-button {
    margin: auto;
}

.price {
    margin-right: 7px;
    font-size: 20px;
}



button {
    margin-top: 20px;
}
</style>