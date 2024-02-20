<script setup lang="ts">
defineProps<{
  title: string
  plusClass: string
}>()

</script>

<template>
  <article class="cardInformation">
    <div class="cardInformation__img taquilla">

    </div>
    <div class="cardInformation__text {{ plusClass }}">
      <h2>{{ title }}</h2>
    </div>
  </article>
</template>

<style>
@import url("https://fonts.googleapis.com/css2?family=Montserrat:wght@400;700&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Bebas+Neue&display=swap");


.cardInformation {
  background-color: #ba1313;
  width: 350px;
  height: 450px;
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
  cursor: pointer;
}
.cardInformation .cardInformation__img {
  width: 90%;
  height: 65%;
  border-radius: 15px;
  background-size: cover;
  background-position: center;
}
.cardInformation .taquilla {
  background-image: url("../assets/IMAGENES/Rectangle 208.png");
}
.cardInformation .teatro {
  background-image: url("../assets/IMAGENES/teatro.png");
}
.cardInformation .proteccion {
  background-image: url("../assets/IMAGENES/proteccion.png");
}
.cardInformation .cardInformation__text {
  width: 90%;
  height: auto;
  color: white;
  font-family: "Bebas Neue";
  display: flex;
  flex-direction: column;
  justify-content: left;
  align-items: left;
}
@media screen and (max-width: 767px) {
  .cardInformation {
    background-color: #ba1313;
    width: 150px;
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
  }
}
</style>