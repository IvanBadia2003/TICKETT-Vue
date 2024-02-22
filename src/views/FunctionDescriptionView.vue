<script setup lang="ts">

import { ref, onMounted } from 'vue';
import axios from 'axios';
import { useRoute } from 'vue-router';


interface Obra {
  obraId: number;
  titulo: string;
  diaObra: Date;
  imagen: string;
  genero: string;
  horaObra: Date;
}

const datosApi = ref<Array<Obra>>([]);
const route = useRoute();

onMounted(async () => {
  try {
    const id = route.params.id;
    const response = await axios.get(`http://localhost:5000/Obra/${id}`);
    console.log("Fetch para sacar descripcion de obra hecho");
    datosApi.value = response.data;
  } catch (error) {
    console.error('Error al hacer la petición:', error);
  }
});



</script>
<template>
  <div class="content">
    <h2>{{ datosApi.titulo }}</h2>
    <section class="first">
      <div class="principal">
        <div>
          <img :src="'../src/assets/IMAGENES/' + datosApi.imagen" :alt="`${datosApi.titulo}`">
        </div>
        <div>
          <a href="#" id="seleccionarButacas">SELECCIONAR BUTACAS</a>
        </div>
      </div>
      <div class="secundary">
        <div class="date">
          <h3>Horario</h3>
          <div class="date__data">
            <h3>Dia: {{ datosApi.diaObra }}</h3>
            <h3>Hora: {{ datosApi.horaObra }}</h3>
          </div>
        </div>
        <div class="information">
          <h3>Información</h3>
          <div class="information__data">
            <h3></h3>
            <h3></h3>
            <h3></h3>
          </div>
        </div>
      </div>

    </section>

    <section>
      <div class="description">

        <h3>Descripcion</h3>
        <div>
          <p></p>
        </div>

      </div>
      <div class="cast">
        <h3>Reparto</h3>
        <div>
          <ul>
          </ul>
        </div>
      </div>

    </section>

  </div>
</template>
  
<style scoped>
@import url("https://fonts.googleapis.com/css2?family=Montserrat:wght@400;700&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Bebas+Neue&display=swap");
@import url("https://fonts.googleapis.com/css?family=Merryweather");

.content {
  width: 100%;
  height: auto;
}

h2 {
  font-family: "Bebas Neue";
  font-size: 60px;
  margin-top: 20px;
  margin-bottom: 0;
}

section {
  width: 100%;
  height: auto;
  display: flex;
  flex-direction: column;
}

section h3 {
  margin: 0;
}

.principal {
  width: 100%;
  height: auto;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  padding-top: 16px;
  padding-bottom: 16px;
}

.principal h3 {
  font-family: "Montserrat";
  color: #ba1313;
}

.principal div {
  display: flex;
  flex-direction: column;
  text-align: center;
  justify-content: center;
}

.principal div img {
  border-radius: 21px;
}

.principal div a {
  color: #ba1313;
  text-decoration: none;
  margin-top: 15px;
  font-family: "Montserrat";
  font-size: 18px;
  font-weight: bold;
  border-radius: 50px;
  border: 3px solid #ba1313;
  width: 100%;
}

.date {
  width: 100%;
  height: 25%;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  padding-top: 16px;
  padding-bottom: 16px;
}

.date h3 {
  font-family: "Montserrat";
  color: #ba1313;
}

.date__data {
  border: 1px solid gray;
  text-align: left;
  padding: 16px;
  margin: 16px;
  border-radius: 7px;
}

.date__data h3 {
  font-family: "Montserrat";
  color: black;
  padding: 5px;
}

.information {
  width: 100%;
  height: 25%;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  padding-top: 16px;
  padding-bottom: 16px;
}

.information h3 {
  font-family: "Montserrat";
  color: #ba1313;
}

.information__data {
  border: 1px solid gray;
  text-align: left;
  padding: 16px;
  margin: 16px;
  border-radius: 7px;
}

.information__data h3 {
  font-family: "Montserrat";
  color: black;
  padding: 5px;
}

.description {
  width: 100%;
  height: 50%;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  padding-top: 16px;
  padding-bottom: 16px;
}

.description h3 {
  font-family: "Montserrat";
  color: #ba1313;
}

.description div {
  margin-left: 30px;
  margin-right: 30px;
  text-align: left;
}

.description div p {
  font-size: 18px;
  font-family: "Merryweather";
  text-align: justify;
}

.cast {
  width: 100%;
  height: 50%;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  padding-top: 16px;
  padding-bottom: 16px;
}

.cast h3 {
  font-family: "Montserrat";
  color: #ba1313;
}

.cast div {
  margin-left: 30px;
  margin-right: 30px;
  text-align: left;
}

.cast div ul {
  font-size: 18px;
  font-family: "Merryweather";
  list-style: none;
  text-align: justify;
}

/* PARA ORDENADORES */
@media screen and (min-width: 767px) {
  .first {
    flex-direction: row;
    justify-content: center;
  }

  .principal {
    width: 30%;
    height: 100%;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    padding-top: 16px;
    padding-bottom: 16px;
    align-items: center;
  }

  .principal h3 {
    font-family: "Montserrat";
    color: #ba1313;
  }

  .principal h2 {
    font-size: 48px;
  }

  .principal div {
    height: 100%;
    width: 300px;
    display: flex;
    flex-direction: column;
    text-align: center;
    justify-content: center;
  }

  .principal div img {
    border-radius: 21px;
  }

  .principal div a {
    color: #ba1313;
    text-decoration: none;
    margin-top: 15px;
    font-family: "Montserrat";
    font-size: 18px;
    font-weight: bold;
    border-radius: 50px;
    border: 3px solid #ba1313;
    width: 98%;
  }

  .secundary {
    width: 30%;
    height: 100%;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    padding-top: 16px;
    padding-bottom: 16px;
    margin-left: 0;
    margin-top: 0;
  }

  .secundary h3 {
    font-family: "Montserrat";
    color: #ba1313;
  }

  .secundary .date {
    width: 100%;
    height: 50%;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    padding-top: 16px;
    padding-bottom: 16px;
  }

  .secundary .date h3 {
    font-family: "Montserrat";
    color: #ba1313;
  }

  .secundary .information {
    width: 100%;
    height: 50%;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    padding-top: 16px;
    padding-bottom: 16px;
  }

  .secundary .information h3 {
    font-family: "Montserrat";
    color: #ba1313;
  }

  .description {
    align-items: flex-start;
  }

  .description h3 {
    margin-left: 120px;
  }

  .description div {
    margin-left: 120px;
    margin-right: 120px;
  }

  .description div p {
    font-size: 20px;
  }

  .cast {
    align-items: flex-start;
  }

  .cast h3 {
    margin-left: 120px;
  }

  .cast div {
    margin-left: 120px;
    margin-right: 120px;
  }

  .cast div ul {
    padding: 0;
  }
}
</style>