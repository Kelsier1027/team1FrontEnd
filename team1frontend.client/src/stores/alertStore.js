import { ref } from 'vue';
import { defineStore } from 'pinia';

export const useAlertStore = defineStore('alert', () => {
    const alert = ref({
        show: false,
        message: '錯誤',
        type: 'error',
    });

    const showAlert = ({ message, type }) => {
        alert.value.show = true;
        alert.value.message = message;
        alert.value.type = type;
        hideAlert();
    };

    const hideAlert = () => {
        // 過五秒後自動關閉
        setTimeout(() => {
            alert.value.show = false;
        }, 3000);
    };

    return {
        alert,
        showAlert,
        hideAlert,
    };
});
