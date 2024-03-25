import { getTicketContentAPI } from '@/apis/get_ticketContent'
import { ref, onMounted } from 'vue'

export function useTicketContent(id) {
  const ticketContentList = ref([]);
  const getContent = async () => {
    const res = await getTicketContentAPI(id);
    ticketContentList.value = res;
    console.log(res);


  }

  onMounted(() => getContent());

  return {
    ticketContentList
  }
}