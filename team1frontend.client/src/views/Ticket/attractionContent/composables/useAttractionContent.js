import { getAttractionContentAPI } from "@/apis/Chih/apis/get_attractionContent";
import { ref, onMounted } from 'vue'


export function useAttractionContent() {
    const content = ref([]);
    const getContent = async () => {
        const res = await getAttractionContentAPI();
        content.value = res;
        console.log("Content!");

    }

    onMounted(() => getContent())
    return {
        content
    }

}