<script setup lang="ts">
defineProps<{
    title?: string
    description?: string
    imageSrc?: string
    diaObra?: string
    key: number
}>()


</script>

<template>
          <RouterLink to="/function/{{key}}">
            <article class="card">

                <div class="imgContainer">
                    <img src="../assets/IMAGENES/{{ imageSrc }}" alt="title">
                </div>
                <div class="card__description">
                    <h2>{{ title }}</h2>
                    <h3>{{ diaObra }}</h3>
                </div>
            </article>
          </RouterLink>

</template>

<style>
@import url("https://fonts.googleapis.com/css2?family=Montserrat:wght@400;700&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Bebas+Neue&display=swap");




.card {
  background-color: #ba1313;
  width: auto;
  height: auto;
  margin: 10px;
  flex-basis: calc(50% - 20px);
  border-radius: 15px 15px 5px 5px;
  transition: all 300ms ease;
  cursor: pointer;
  /* PARA ORDENADORES */
}
.card .imgContainer {
  height: 65%;
  margin-top: 5%;
}
.functions .card .imgContainer img {
  width: 90%;
  height: 100%;
  border-radius: 15px;
}
.functions .card__description {
  height: auto;
  color: white;
  text-align: left;
}
.functions .card__description h2 {
  margin-top: 5%;
  margin-bottom: 0;
  margin-left: 6%;
  margin-right: 6%;
  font-family: "Bebas Neue";
}
.functions .card__description h3 {
  margin-top: 0;
  margin-bottom: 5%;
  margin-left: 6%;
  font-family: "Montserrat";
}
@media screen and (min-width: 767px) {
  .functions .card {
    flex-basis: calc(33% - 20px);
  }
}

.card:hover {
  transform: scale(1.05);
}

.sidebar {
  display: none;
  position: fixed;
  right: 0;
  width: 28%;
  height: auto;
  background-color: #fff;
}
.sidebar .filter {
  width: 100%;
  height: auto;
  position: relative;
  margin-top: 10%;
}
.sidebar .filter__search {
  width: 100%;
  height: auto;
  display: flex;
  align-items: center;
  justify-content: center;
}
.sidebar .filter__search input {
  width: 90%;
  border-radius: 50px;
  height: 30px;
}
.sidebar .filter__search img {
  position: absolute;
  left: 75%;
  width: 20px;
  cursor: pointer;
}
.sidebar .filter__gender {
  width: 100%;
  height: auto;
  display: flex;
  justify-content: center;
}
.sidebar .filter__gender ul {
  width: 100%;
  padding: 0;
  list-style: none;
  text-align: left;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: flex-start;
  margin-right: 50%;
  margin-left: 50%;
  font-size: 13px;
  font-family: "Montserrat";
}
.sidebar .filter__gender ul li {
  display: flex;
  justify-content: center;
  align-items: center;
  padding: 2%;
}
.sidebar .filter__gender ul li input {
  appearance: none;
  -webkit-appearance: none;
  -moz-appearance: none;
  width: 20px;
  height: 20px;
  border: 1px solid #ba1313;
  background-color: #fff;
}
.sidebar .filter__gender ul li input:checked {
  background-color: #ba1313;
}

.close {
  padding: 12px;
  background-color: #ba1313;
  border: 2px solid black;
  color: white;
  font-family: "Montserrat";
}

.iconFilter {
  display: block;
  height: auto;
  width: auto;
  background-color: #ba1313;
  border-radius: 50px;
  padding: 9px;
  color: #fff;
  font-family: "Montserrat";
  margin-left: 70%;
  margin-top: 15px;
  margin-right: 15px;
  margin-bottom: 15px;
  cursor: pointer;
}

/* PARA ORDENADORES */
@media screen and (min-width: 767px) {
  .functions {
    width: 70%;
    margin: 15px;
  }
  .functions .card {
    flex-basis: calc(33% - 20px);
  }
  .sidebar {
    display: block !important;
  }
  .sidebar .filter__search img {
    left: 82%;
    width: 25px;
  }
  .sidebar .filter__gender ul {
    font-size: 18px;
  }
  .iconFilter {
    display: none;
  }
  .close {
    display: none;
  }
}


/*# sourceMappingURL=funciones.css.map */</style>