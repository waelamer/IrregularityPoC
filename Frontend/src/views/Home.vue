<template>
  <div class="container">
    
    <HomeComponent msg=""/>
    <DealComponent msg=""></DealComponent>
  </div>
</template>

<script>
// @ is an alias to /src
import HomeComponent from '../components/SearchComponent.vue'
import DealComponent from '../components/DealComponent.vue'



export default {
  name: 'Home',
  components: {
    HomeComponent,DealComponent
  }
}
</script>
