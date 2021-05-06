import Vue from 'vue'
import App from './App.vue'
import Vant from 'vant';
import 'vant/lib/index.css';
import { Lazyload } from 'vant';
import router from './router'
import "tailwindcss/tailwind.css"
import store from './store'

Vue.config.productionTip = false

Vue.use(Vant);
Vue.use(Lazyload);

Vue.prototype.$store = store

import axios from 'axios'
axios.defaults.withCredentials = true
Vue.prototype.$axios = axios

new Vue({
  render: h => h(App),
  router
}).$mount('#app')
