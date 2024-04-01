import { getCategoriesAPI } from "@/apis/Chih/apis/get_attractionCategories";
import { ref, onMounted } from 'vue';

export function useCategories() {
    const categoryList = ref([]);
    const getCategories = async () => {
        const res = await getCategoriesAPI();
        categoryList.value = res;
        console.log(res);

    }

    onMounted(() => getCategories());
    return {
        categoryList
    }

} 