<script setup lang="ts">
// defineProps<{
//   title?: string
//   description?: string
//   imageSrc?: string
//   diaObra?: string
//   obraId: number
//   }>()
import 'bootstrap/dist/js/bootstrap.bundle.min.js';


</script>

<template>
                <div id="carouselExample" class="carousel slide">
                    <div class="carousel-inner">
                        <div class="carousel-item active">
                            <div>
                                <div class="info">
                                    <h1>EL MAGO POP</h1>
                                    <a href="html/descripcion_funcion.html?id=6" class="cardFunction__button">VER MÁS</a>
                                </div>
                                <div class="containerImg">
                                    <img src="../IMAGENES/el-mago-pop.jpg" class="d-block w-100" alt="...">
                                </div>
                            </div>
                        </div>
                        <div class="carousel-item">
                            <div>
                                <div class="info">
                                    <h1>DOBLE O NADA</h1>
                                    <a href="html/descripcion_funcion.html?id=12" class="cardFunction__button">VER MÁS</a>
                                </div>
                                <div class="containerImg">
                                    <img src="../IMAGENES/doble-o-nada.jpg" class="d-block w-100" alt="...">
                                </div>
                            </div>
                        </div>
                        <div class="carousel-item">
                            <div>
                                <div class="info">
                                    <h1>LAPONIA</h1>
                                    <a href="html/descripcion_funcion.html?id=4" class="cardFunction__button">VER MÁS</a>
                                </div>
                                <div class="containerImg">
                                    <img src="../IMAGENES/laponia.jpg" class="d-block w-100" alt="...">
                                </div>
                            </div>
                        </div>
                    </div>
                    <button class="carousel-control-prev" type="button" data-bs-target="#carouselExample"
                        data-bs-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Previous</span>
                    </button>
                    <button class="carousel-control-next" type="button" data-bs-target="#carouselExample"
                        data-bs-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Next</span>
                    </button>
                </div>
</template>


<style scoped>
@import 'bootstrap/dist/css/bootstrap.min.css';


.carousel {
  margin-top: 50px;
  margin-bottom: 50px;
}

.carousel-inner {
  padding-top: 60px;
  padding-bottom: 60px;
  background-color: #ba1313;
}
.carousel-inner .carousel-item div {
  display: flex;
  justify-content: center;
  align-items: center;
  height: 350px;
  margin-left: 50px;
  margin-right: 50px;
}
.carousel-inner .carousel-item div .info {
  width: 20%;
  display: flex;
  flex-direction: column;
}
.carousel-inner .carousel-item div .info h1 {
  font-family: "Bebas Neue";
  color: #ffffff !important;
  font-size: 80px;
}
.carousel-inner .carousel-item div .containerImg {
  width: 15%;
  height: 90%;
}
.carousel-inner .carousel-item div .containerImg img {
  width: 100%;
  height: auto;
  border-radius: 15px;
}

</style>