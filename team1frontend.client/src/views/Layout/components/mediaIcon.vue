<template>
    <div class="media-icon" id="mediaIcon">
        <div class="foot">
            <div class="icons">
                <img src="../../../../public/assets/Icons/社群icon.jpg" alt="" />
            </div>
            <div class="logo">
                <img src="../../../../public/assets/Images/logo.jpg" alt="" />
                <p>&copy; 2024  Web Design by Wen</p>
            </div>
            <div class="contact">
                <p>CONTACT US</p>
            </div>
        </div>
        <div class="aa">
            <div class="marquee-container">
                    
                <marquee direction="left"
                         scrollamount="10"
                         scrolldelay="10">
                    ⚠️此網站為測試用圖,僅供參考,無商業用途,請勿任意轉載。
                </marquee>
            </div>
        </div>
        
    </div>

</template>
<script setup>
    import { onMounted, onBeforeUnmount} from 'vue';

    const handleScroll = () => {
        const scrollPosition = window.scrollY + window.innerHeight;
        const documentHeight = document.documentElement.scrollHeight;
        const mediaIconElement = document.querySelector('#mediaIcon');
        
        if (scrollPosition+10 >= documentHeight) {
            mediaIconElement.classList.add('fade-in');
        } else {
            mediaIconElement.classList.remove('fade-in');
        }
    };

    onMounted(() => {
        window.addEventListener('scroll', handleScroll);
    });

    onBeforeUnmount(() => {
        window.removeEventListener('scroll', handleScroll);
    });
</script>
<style scoped>


    
</style>