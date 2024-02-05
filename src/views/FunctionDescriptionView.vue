  <script setup lang="ts">
   import { obras } from '../assets/server/server.js';
  
  const obtenerTituloObra = (id: string | number | string[]) => {
    // Convertir id a string o number si es un array
    const idConvertido = Array.isArray(id) ? id[0] : id;
  
    const obra = obras.find((obra) => obra.id == idConvertido);
    return obra ? obra.titulo : 'Obra no encontrada';
  }; 


  </script>
<template>
    <div>
      <p>Id: {{ $route.params.id }}</p>
       <p>Título de la obra: {{  obtenerTituloObra($route.params.id)  }}</p>
     </div>
  </template>
  
  