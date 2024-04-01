import { getAttractionsAPI } from "@/apis/Chih/apis/search_attraction";
import { ref, onMounted } from "vue";

export function useAttraction() {
    const attractionList = ref([]);
    const getAttraction = async () => {
        const res = await getAttractionsAPI();
        //console.log(res);
        attractionList.value = res
        //console.log(attractionList.value);
    }
    onMounted(() => getAttraction())
    return {
        attractionList
    }
}




