<script setup lang="ts">
import Carousel from '@/components/Carousel.vue';



</script>


<template>
    Vista HomeView

    <section class="content">

        <Carousel />
    </section>
    <section class="content__gray">
        <div class="title">
                <h2>PRÓXIMAS FUNCIONES</h2>
            </div>
            <div class="articlesFunction">

            </div>
    </section>
    <section class="content">

    </section>


</template>


<style scoped>
.content {
    background-color: white;
    width: 100%;
    height: auto;
    display: flex;
    flex-direction: column;
    overflow: hidden;
    position: relative;
}

.content__gray {
    background-color: #D9D9D9;
    width: 100%;
    height: auto;
    display: flex;
    flex-direction: column;
    overflow: hidden;
    position: relative;
}

.title {
  background-color: #ba1313;
  color: white;
  text-decoration: none;
  height: auto;
}
.title h2 {
  font-family: "Bebas Neue";
  font-size: 30px;
}
.articlesInformation {
  height: 75%;
  display: flex;
  flex-flow: row wrap;
  justify-content: center;
  align-items: center;
  padding: 60px;
}
</style>