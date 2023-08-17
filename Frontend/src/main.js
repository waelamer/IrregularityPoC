import * as Vue from 'vue'
import App from './App.vue'
// import router from './router'
import store from './store'
import Searchcomponent from './components/SearchComponent.vue'
import Dealcomponent from './components/DealComponent.vue'

// import axios from 'axios';
import 'bootstrap/dist/css/bootstrap.min.css'
import 'bootstrap/dist/js/bootstrap.min.js'


import VueSweetalert2 from 'vue-sweetalert2';
import 'sweetalert2/dist/sweetalert2.min.css';

// const MainApp = createApp(App,{
//     store,router  
// });
// Vue.use(VueResource);

// Vue.createApp(App).use(store).use(router).mount('#app');
Vue.createApp(App)
    .use(store)
    .use(VueSweetalert2)
    .component('Searchcomponent', Searchcomponent)
    .component('Dealcomponent', Dealcomponent)
    .mount('#app');