<script setup lang="ts">

import Card from '../components/Card.vue';

let obras = [
    {
        id: 1,
        titulo: 'DON JUAN',
        descripcion: 'La obra "Don Juan" es un clásico atemporal que explora las travesuras y el encanto del legendario seductor Don Juan. Esta pieza teatral icónica examina la naturaleza humana, el deseo, la moralidad y las consecuencias de nuestras acciones. A través de un cautivador relato, la historia sigue a Don Juan, un personaje carismático y seductor que desafía las normas sociales. Su irresistible magnetismo lo lleva a interactuar con una variedad de personajes, cada uno reflejando diferentes aspectos de la sociedad y la moralidad de la época. "Don Juan" invita a reflexionar sobre la dualidad del ser humano, la moralidad, el amor y la libertad, envuelto en una trama llena de intriga y emociones intensas.',
        diaObra: '22/11/2003',
        horaObra: '13:00',
        imagenObra: '../../IMAGENES/donjuan.jpg',
        reparto: [
            { "nombre": "Luisa Fernández", "rol": "Doña Ana" },
            { "nombre": "Andrés Sánchez", "rol": "Don Juan" },
            { "nombre": "María Gómez", "rol": "Doña Inés" },
            { "nombre": "Javier Rodríguez", "rol": "Don Luis" },
            { "nombre": "Elena Pérez", "rol": "Doña Elvira" },
            { "nombre": "Carlos Martínez", "rol": "Molière" },
            { "nombre": "Ana Ruiz", "rol": "Sganarelle" },
            { "nombre": "Pedro Vázquez", "rol": "Don Gonzalo" }
        ],
        genero: 'romance',
        duracion: 120,
        precio: 20,
        butacas: generarButacas()
    },
    {
        id: 2,
        titulo: 'LA CELESTINA',
        descripcion: 'La Celestina es una obra maestra de la literatura española escrita por Fernando de Rojas en el siglo XV. Esta tragicomedia narra la historia de amor entre Calisto y Melibea, en un contexto lleno de engaños, pasiones y traiciones. La trama se centra en la intervención de la alcahueta Celestina, una mujer astuta y manipuladora que actúa como intermediaria en el romance. A medida que avanza la historia, se entrelazan intrigas que revelan las complejidades de las relaciones humanas y critican la sociedad de la época. "La Celestina" es reconocida por su profundidad psicológica en la construcción de personajes y su aguda crítica social, explorando temas como el amor, la codicia, el poder y la moralidad en un estilo literario cautivador.',
        diaObra: '23/11/2023',
        horaObra: '16:00',
        imagenObra: '../../IMAGENES/celestina.jpg',
        reparto: [
            { "nombre": "Sofía Martínez", "rol": "Celestina" },
            { "nombre": "Diego López", "rol": "Calisto" },
            { "nombre": "Lucía García", "rol": "Melibea" },
            { "nombre": "Javier Rodríguez", "rol": "Sempronio" },
            { "nombre": "Elena Pérez", "rol": "Elicia" },
            { "nombre": "Carlos Gómez", "rol": "Tristán" },
            { "nombre": "Ana Ruiz", "rol": "Pármeno" },
            { "nombre": "Pedro Vázquez", "rol": "Alisa" }
        ],
        genero: 'romance',
        duracion: 150,
        precio: 25,
        butacas: generarButacas()
    },
    {
        id: 3,
        titulo: 'LA FUNCIÓN QUE SALE MAL',
        descripcion: 'La función que sale mal es una obra teatral cómica que gira en torno a un grupo de actores aficionados que intentan representar una obra de teatro, pero todo lo que puede salir mal ¡sale mal! La trama se desarrolla con una sucesión de desastres cómicos, desde problemas técnicos hasta errores de actuación y malentendidos entre los personajes. La obra es una comedia llena de situaciones hilarantes y caóticas que mantienen al público riendo a carcajadas. "La función que sale mal" es conocida por su humor físico, su ingenio y su capacidad para convertir los errores en momentos divertidos e inolvidables para el público.',
        diaObra: '23/11/2023',
        horaObra: '19:00',
        imagenObra: '../../IMAGENES/funcion-sale.mal.jpg',
        reparto: [
            { "nombre": "Luis García", "rol": "Chris" },
            { "nombre": "María López", "rol": "Annie" },
            { "nombre": "Andrés Martínez", "rol": "Jonathan" },
            { "nombre": "Elena Rodríguez", "rol": "Sandra" },
            { "nombre": "Carlos Ruiz", "rol": "Max" },
            { "nombre": "Lucía González", "rol": "Dennis" },
            { "nombre": "Javier Fernández", "rol": "Trevor" },
            { "nombre": "Ana Pérez", "rol": "Robert" }
        ],
        genero: 'thriller',
        duracion: 120,
        precio: 18,
        butacas: generarButacas()
    }, {
        id: 4,
        titulo: 'LAPONIA',
        descripcion: 'Laponia es una región situada en el norte de Europa que abarca partes de Noruega, Suecia, Finlandia y Rusia. Conocida por su belleza natural y su paisaje ártico, Laponia es famosa por ser el hogar de la gente sami, su cultura única y las auroras boreales que se pueden observar durante la temporada de invierno. Esta región ofrece una amplia gama de actividades, como safaris en trineo de perros, excursiones para avistar renos, esquí, senderismo y la oportunidad de experimentar la cultura sami a través de sus tradiciones, como la artesanía, la música y la gastronomía local. Laponia es un destino popular para aquellos que buscan aventuras inolvidables en un entorno natural espectacular.',
        diaObra: '24/11/2023',
        horaObra: '16:00',
        imagenObra: '../../IMAGENES/laponia.jpg',
        reparto: [
            { "nombre": "Erik Larsson", "rol": "Olaf, guía sami" },
            { "nombre": "Ingrid Johansson", "rol": "Kaisa, chamán sami" },
            { "nombre": "Sven Andersson", "rol": "Bjorn, explorador" },
            { "nombre": "Hanna Bergman", "rol": "Lena, viajera aventurera" },
            { "nombre": "Frida Nilsson", "rol": "Elsa, niña sami" },
            { "nombre": "Oskar Magnusson", "rol": "Gunnar, habitante local" },
            { "nombre": "Emma Karlsson", "rol": "Sofia, fotógrafa" },
            { "nombre": "Viktor Lindström", "rol": "Ole, cazador" }
        ],
        genero: 'thriller',
        duracion: 110,
        precio: 22,
        butacas: generarButacas()
    },
    {
        id: 5,
        titulo: 'JOSÉ EL SOÑADOR',
        descripcion: 'José el Soñador es una historia bíblica que relata la vida de José, hijo de Jacob, vendido como esclavo por sus hermanos. La historia sigue la vida de José desde su juventud hasta convertirse en un importante funcionario en Egipto. Conocida por su narrativa llena de intriga, traición y redención, la historia muestra la habilidad de José para interpretar sueños, lo que lo lleva a ganar el favor del faraón y a desempeñar un papel crucial en la historia de Egipto. "José el Soñador" es un relato emocionante que explora temas de fe, perseverancia y perdón, y ha sido una fuente de inspiración para muchas personas a lo largo de los siglos.',
        diaObra: '24/11/2023',
        horaObra: '12:00',
        imagenObra: '../../IMAGENES/jose-el-sonador.jpg',
        reparto: [
            { "nombre": "Ana García", "rol": "José" },
            { "nombre": "Luis Martínez", "rol": "Jacob" },
            { "nombre": "María Fernández", "rol": "Rebeca" },
            { "nombre": "Javier Rodríguez", "rol": "Faraón" },
            { "nombre": "Elena Pérez", "rol": "Esposa de Potifar" },
            { "nombre": "Carlos Sánchez", "rol": "Potifar" },
            { "nombre": "Lucía Martín", "rol": "Mayordomo" },
            { "nombre": "Andrés Gómez", "rol": "Elvisar" }
        ],
        genero: 'drama',
        duracion: 130,
        precio: 20,
        butacas: generarButacas()
    },
    {
        id: 6,
        titulo: 'EL MAGO POP',
        descripcion: 'El Mago Pop es el nombre artístico de Antonio Díaz, un ilusionista español reconocido por sus impresionantes trucos de magia y espectáculos de ilusionismo. Conocido por combinar magia, tecnología y narrativa en sus actuaciones, El Mago Pop ha cautivado al público con sus shows innovadores y sorprendentes. Sus espectáculos suelen incorporar efectos visuales impactantes, interacción con el público y asombrosas ilusiones que desafían la lógica y la percepción. Antonio Díaz, como El Mago Pop, ha logrado llevar la magia a un nivel moderno y cautivador, convirtiéndose en uno de los ilusionistas más reconocidos a nivel internacional.',
        diaObra: '25/11/2023',
        horaObra: '17:30',
        imagenObra: '../../IMAGENES/el-mago-pop.jpg',
        reparto: [
            { "nombre": "Javier Martínez", "rol": "El Mago Pop (Antonio Díaz)" },
            { "nombre": "Lucía García", "rol": "Asistente del Mago" },
            { "nombre": "Andrés Fernández", "rol": "Participante del Público" },
            { "nombre": "María López", "rol": "Asistente Técnico" },
            { "nombre": "Carlos Ruiz", "rol": "Encargado de Escenario" },
            { "nombre": "Elena Sánchez", "rol": "Coordinador de Efectos Especiales" },
            { "nombre": "Pedro González", "rol": "Diseñador de Iluminación" },
            { "nombre": "Ana Martín", "rol": "Gerente de Producción" }
        ],
        genero: 'monologo',
        duracion: 100,
        precio: 15,
        butacas: generarButacas()
    },
    {
        id: 7,
        titulo: 'ILUSIONATE',
        descripcion: 'Ilusionate es una emocionante obra de teatro que fusiona el ilusionismo, la magia y el drama en una experiencia teatral única. Esta obra cautivadora transporta al público a un mundo de sorpresas, ilusiones y emociones. Con un elenco talentoso y efectos visuales impactantes, Ilusionate combina la magia del teatro con increíbles trucos y narrativas que mantienen al espectador absorto en un viaje lleno de misterio y asombro. Esta obra teatral es una oportunidad para sumergirse en un universo de ilusiones y disfrutar de un espectáculo que desafía la imaginación y la percepción.',
        diaObra: '26/11/2023',
        horaObra: '18:15',
        imagenObra: '../../IMAGENES/ilusionate.jpg',
        reparto: [
            { "nombre": "Sofía Martínez", "rol": "Lena, la ilusionista" },
            { "nombre": "Diego López", "rol": "David, el aprendiz de mago" },
            { "nombre": "Lucía García", "rol": "María, la asistente" },
            { "nombre": "Javier Rodríguez", "rol": "Carlos, el escéptico" },
            { "nombre": "Elena Pérez", "rol": "Laura, la espectadora" },
            { "nombre": "Carlos Gómez", "rol": "Jorge, el incrédulo" },
            { "nombre": "Ana Ruiz", "rol": "Paula, la admiradora" },
            { "nombre": "Pedro Vázquez", "rol": "Pablo, el curioso" }
        ],
        genero: 'monologo',
        duracion: 90,
        precio: 12,
        butacas: generarButacas()
    },
    {
        id: 8,
        titulo: 'LAS MIL Y UNA NOCHES',
        descripcion: 'Las Mil y Una Noches es una colección de cuentos y fábulas de origen árabe que se remonta a varios siglos. La historia principal sigue a Scheherezade, quien cuenta historias al rey Shahriar para evitar su ejecución. Estas historias incluyen relatos mágicos, aventuras, fábulas morales y cuentos populares que abarcan un amplio espectro de géneros y temas. Entre los cuentos más conocidos se encuentran "Aladino y la lámpara maravillosa", "Simbad el marino" y "Ali Baba y los cuarenta ladrones". "Las Mil y Una Noches" ha cautivado a lectores durante generaciones con su riqueza narrativa, su imaginación desbordante y su habilidad para entrelazar historias encantadoras y emocionantes.',
        diaObra: '29/11/2023',
        horaObra: '18:00',
        imagenObra: '../../IMAGENES/las-mil-y-una-noches.jpg',
        reparto: [
            { "nombre": "Leyla Khan", "rol": "Scheherezade" },
            { "nombre": "Amir Shah", "rol": "Sultán Shahriar" },
            { "nombre": "Jamil Ahmed", "rol": "Aladino" },
            { "nombre": "Nadia Malik", "rol": "Jasmine" },
            { "nombre": "Karim Hassan", "rol": "Simbad" },
            { "nombre": "Ayesha Khan", "rol": "Scheherezade (joven)" },
            { "nombre": "Rashid Ali", "rol": "Ali Baba" },
            { "nombre": "Yasir Mahmood", "rol": "Genio" }
        ],
        genero: 'comedia',
        duracion: 140,
        precio: 30,
        butacas: generarButacas()
    },
    {
        id: 9,
        titulo: 'EL REY LEÓN',
        descripcion: 'El Rey León es un espectacular musical inspirado en la película de Disney que ha cautivado a audiencias de todo el mundo. Con música de Elton John y letras de Tim Rice, esta producción teatral transporta al público a la majestuosa sabana africana. La historia sigue el viaje de Simba, un joven león destinado a convertirse en rey, a través de sus aventuras, desafíos y el aprendizaje de valiosas lecciones sobre el honor, el coraje y el amor. El espectáculo se destaca por su impresionante puesta en escena, coloridos vestuarios, efectos visuales deslumbrantes y coreografías espectaculares. "El Rey León" es una experiencia teatral emocionante y conmovedora, que combina la magia del cine con la energía y la emoción del teatro en vivo.',
        diaObra: '02/12/2023',
        horaObra: '12:00',
        imagenObra: '../../IMAGENES/ElReyLeon3Aniv200.jpg',
        reparto: [
            { "nombre": "Sofía Martínez", "rol": "Nala" },
            { "nombre": "Diego López", "rol": "Simba" },
            { "nombre": "Lucía García", "rol": "Sarabi" },
            { "nombre": "Javier Rodríguez", "rol": "Mufasa" },
            { "nombre": "Elena Pérez", "rol": "Rafiki" },
            { "nombre": "Carlos Gómez", "rol": "Scar" },
            { "nombre": "Ana Ruiz", "rol": "Timón" },
            { "nombre": "Pedro Vázquez", "rol": "Pumbaa" }
        ],
        genero: 'musical',
        duracion: 150,
        precio: 35,
        butacas: generarButacas()
    },
    {
        id: 10,
        titulo: 'CAMPEONES DE LA COMEDIA',
        descripcion: 'Gloria y Josete se acaban de independizar bajo la tutela de Claudia. Ante la necesidad de encontrar un trabajo para poder tener un sueldo con el que mantenerse, Claudia les propone que intenten dedicarse a algo que les guste de verdad. Ellos quieren ser artistas. Para ello deberían encontrar un representante. Esta comedia hilarante sigue las aventuras de este trío en su búsqueda por la fama y la risa del público.',
        diaObra: '09/12/2023',
        horaObra: '20:00',
        imagenObra: '../../IMAGENES/campeones.jpg',
        reparto: [
            { "nombre": "María García", "rol": "Lola" },
            { "nombre": "Javier Martínez", "rol": "Pedro" },
            { "nombre": "Lucía Rodríguez", "rol": "Ana" },
            { "nombre": "Andrés López", "rol": "Juan" },
            { "nombre": "Elena Pérez", "rol": "Laura" },
            { "nombre": "Carlos Gómez", "rol": "Pablo" },
            { "nombre": "Ana Ruiz", "rol": "Carmen" },
            { "nombre": "Pedro Vázquez", "rol": "Luis" }
        ],
        genero: 'comedia',
        duracion: 110,
        precio: 18,
        butacas: generarButacas()
    },
    {
        id: 11,
        titulo: 'FANGO',
        descripcion: 'Fango es una obra teatral que aborda temas complejos y profundos relacionados con la condición humana, la lucha interna, la redención y las relaciones interpersonales. Esta obra se sumerge en la complejidad de los personajes y sus conflictos, explorando la naturaleza humana a través de diálogos intensos y situaciones emocionales. A menudo, Fango presenta una reflexión sobre la sociedad y sus injusticias, mostrando la lucha de los individuos por encontrar significado y redención en un mundo lleno de desafíos y adversidades.',
        diaObra: '18/12/2023',
        horaObra: '12:00',
        imagenObra: '../../IMAGENES/fango.jpg',
        reparto: [
            { "nombre": "Sara Pérez", "rol": "Laura" },
            { "nombre": "Javier García", "rol": "Carlos" },
            { "nombre": "Lucía Martínez", "rol": "Ana" },
            { "nombre": "Andrés López", "rol": "Diego" },
            { "nombre": "Elena Rodríguez", "rol": "María" },
            { "nombre": "Carlos Fernández", "rol": "Javier" },
            { "nombre": "María Gómez", "rol": "Sofía" },
            { "nombre": "Pedro Ruiz", "rol": "Pablo" }
        ],
        genero: 'monologo',
        duracion: 100,
        precio: 15,
        butacas: generarButacas()
    },
    {
        id: 12,
        titulo: 'DOBLE O NADA',
        descripcion: 'Doble o nada es un thriller emocional ambientado en el hostil ambiente de las altas esferas empresariales. Una historia sobre el amor platónico, traición y engaño, y sobre todo, el poder y la ambición. Este emocionante thriller te mantendrá en vilo hasta el último minuto.',
        diaObra: '25/12/2023',
        horaObra: '20:30',
        imagenObra: '../../IMAGENES/doble-o-nada.jpg',
        reparto: [
            { "nombre": "Laura Martínez", "rol": "Marina" },
            { "nombre": "Diego López", "rol": "Carlos" },
            { "nombre": "Ana Fernández", "rol": "Sandra" },
            { "nombre": "Javier Gómez", "rol": "Mario" },
            { "nombre": "Sofía Rodríguez", "rol": "Laura" },
            { "nombre": "Andrés Pérez", "rol": "Pedro" },
            { "nombre": "Elena Ruiz", "rol": "Lorena" },
            { "nombre": "Carlos Martín", "rol": "Pablo" }
        ],
        genero: 'thriller',
        duracion: 130,
        precio: 25,
        butacas: generarButacas()
    }
];

function generarButacas() {
    const butacas = [];
    for (let i = 0; i < 100; i++) {
        butacas.push({ id: i, estado: 'libre' });
    }
    return butacas;
}
</script>

<template>
    <div class="content">
        <section class="functions">

            <Card v-for="obra in obras" :key="obra.id" :title="obra.titulo" :description="obra.descripcion"
                :dia-obra="obra.diaObra" :image-src="obra.imagenObra" />
        </section>


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
.functions {
  width: 100%;
  height: auto;
  display: flex;
  flex-flow: row wrap;
  justify-content: space-evenly;
}

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