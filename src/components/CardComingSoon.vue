<script setup lang="ts">
defineProps<{
  title?: string
  imageSrc?: string
  diaObra?: string
  obraId: number
}>()

</script>

<template>
  
  <article class="cardFunction">
    <div class="cardFunction__img">
      <img :src="'src/assets/IMAGENES/' + imageSrc" alt="title">
    </div>
    <div class="cardFunction__text">
      <h2>{{ title }}</h2>
      <h3>{{ diaObra }}</h3>
      <h3>{{ obraId }}</h3>
      
    </div>
    <RouterLink :to="'/Obra/' + obraId">
      <button class="cardFunction__button">VER MÁS</button>
    </RouterLink>
    </article>
</template>

<style>
@import url("https://fonts.googleapis.com/css2?family=Montserrat:wght@400;700&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Bebas+Neue&display=swap");


.cardFunction {
  background-color: #ba1313;
  width: 350px;
  height: 550px;
  margin-right: 6%;
  margin-left: 6%;
  margin-top: 3%;
  margin-bottom: 3%;
  border-radius: 15px 15px 5px 5px;
  padding-top: 17px;
  padding-bottom: 17px;
  display: flex;
  flex-direction: column;
  justify-content: space-evenly;
  align-items: center;
  cursor: default;
}
.cardFunction .cardFunction__img {
  width: 90%;
  height: 65%;
}
.cardFunction .cardFunction__img img {
  width: 100%;
  height: 100%;
  border-radius: 15px;
}
.cardFunction .cardFunction__text {
  width: 90%;
  color: white;
  text-align: left;
  font-family: "Bebas Neue";
  font-size: 18px;
  display: flex;
  flex-direction: column;
  justify-content: left;
  align-items: left;
}
.cardFunction .cardFunction__text h2 {
  margin: 0;
  padding: 0;
}
.cardFunction .cardFunction__text h3 {
  margin: 0;
  padding: 0;
}
@media screen and (max-width: 767px) {
  .cardFunction {
    background-color: #ba1313;
    width: 250px;
    height: 250px;
    margin-right: 6%;
    margin-left: 6%;
    margin-top: 3%;
    margin-bottom: 3%;
    border-radius: 15px 15px 5px 5px;
    padding-top: 17px;
    padding-bottom: 17px;
    display: flex;
    flex-direction: column;
    justify-content: space-evenly;
    align-items: center;
    cursor: default;
    margin: 5%;
    position: relative;
  }
  .cardFunction .cardFunction__text {
    padding-top: 6px;
    padding-bottom: 6px;
    font-size: 16px;
  }
  .cardFunction .cardFunction__button {
    text-align: center;
    font-size: 9px;
  }
}

.cardFunction__button {
  color: #ba1313;
  text-decoration: none;
  display: flex;
  justify-content: center;
  align-items: center;
  font-family: "Montserrat";
  font-size: 18px;
  font-weight: bold;
  border: 0;
  border-radius: 50px;
  width: 90%;
  height: 10%;
  background-color: white;
  cursor: pointer;
}
</style>