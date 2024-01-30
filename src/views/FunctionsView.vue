<script setup lang="ts">

import Card from '../components/Card.vue';

const obras = [
    { title: 'campeones', id: 1, description: 'La puta mejor peli', diaObra: 'mañana', imageSrc: '../IMAGENES/campeones.jpg' },
    { title: 'Jurasic Park 2', id: 2, description: 'La puta mejor peli', diaObra: 'mañana' },
    { title: 'Jurasic Park 3', id: 3, description: 'La puta mejor peli', diaObra: 'mañana' },
    { title: 'Jurasic Park 3', id: 3, description: 'La puta mejor peli', diaObra: 'mañana' },
    { title: 'Jurasic Park 3', id: 3, description: 'La puta mejor peli', diaObra: 'mañana' },
    { title: 'Jurasic Park 3', id: 3, description: 'La puta mejor peli', diaObra: 'mañana' },
    { title: 'Jurasic Park 3', id: 3, description: 'La puta mejor peli', diaObra: 'mañana' },
    { title: 'Jurasic Park 3', id: 3, description: 'La puta mejor peli', diaObra: 'mañana' },
    { title: 'Jurasic Park 3', id: 3, description: 'La puta mejor peli', diaObra: 'mañana' },
    { title: 'Jurasic World', id: 4, description: 'La puta mejor peli', diaObra: 'mañana' }
]
</script>

<template>
    <div class="content">

        <Card v-for="obra in obras" :key="obra.id" :title="obra.title" :description="obra.description"
            :dia-obra="obra.diaObra" :image-src="obra.imageSrc" />


        <aside class="sidebar" id="sidebar">

            <div class="filter">
                <div class="filter__search">
                    <input type="text" placeholder="BUSCAR...">
                    <img src="../../iconos/icons8-búsqueda-500-ROJO 1.png" alt="">
                </div>
                <div class="filter__gender">
                    <ul>
                        <li><input type="checkbox" class="genre" value="drama">DRAMA</li>
                        <li><input type="checkbox" class="genre" value="romance">ROMANCE</li>
                        <li><input type="checkbox" class="genre" value="comedia">COMEDIA</li>
                        <li><input type="checkbox" class="genre" value="musical">MUSICAL</li>
                        <li><input type="checkbox" class="genre" value="monologo">MONÓLOGO</li>
                        <li><input type="checkbox" class="genre" value="thriller">THRILLER</li>
                    </ul>
                </div>
                <div class="close" id="close" onclick="cerrarFiltros()">
                    cerrar
                </div>
            </div>
        </aside>
    </div>
</template>

<style>
.content {
    width: 100%;
    height: auto;
    display: flex;
    flex-direction: column;
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

}
</style>