<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router';

import SoyHeader from './components/SoyHeader.vue'
import SoyFooter from './components/SoyFooter.vue';

</script>

<template>
  <head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

  </head>


  <header>
    <SoyHeader />
  </header>


  <main>
    <RouterView/>

  </main>



  <SoyFooter />
</template>







