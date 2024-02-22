<script setup lang="ts">
import CardComingSoon from '@/components/CardComingSoon.vue';
import CardInformation from '@/components/CardInformation.vue';
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
      <CardComingSoon title="Diego" imageSrc="campeones.jpg" dia-obra="15/4/44" :obraId="4" />
      <CardComingSoon title="Diego" imageSrc="donjuan.jpg" dia-obra="15/4/44" :obraId="1" />
    </div>
  </section>
  <section class="content">
    <div class="title">
      <h2>INFORMACIÓN DE INTERES</h2>
    </div>
    <div class="articlesInformation">
      <CardInformation title="HORARIOS DE TAQUILLA" plusClass="taquilla"/>
      <CardInformation title="NUESTRO TEATRO" plusClass="teatro"/>
      <CardInformation title="MEDIDAS DE PROTECCIÓN" plusClass="proteccion"/>
    </div>
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

.articlesFunction {
  height: 75%;
  display: flex;
  flex-flow: row wrap;
  justify-content: center;
  align-items: center;
  flex-grow: 1;
  padding-top: 60px;
  padding-bottom: 60px;
}
</style>