import Vue from 'vue'
import App from './App.vue'
import Vant from 'vant';
import 'vant/lib/index.css';
import { Lazyload } from 'vant';
import router from './router'
import "tailwindcss/tailwind.css"
import store from './store'
import { Toast } from 'vant';
import axios from 'axios'
import VueCookies from 'vue-cookies'


Vue.config.productionTip = false

Vue.use(Vant);
Vue.use(Lazyload);
Vue.use(Toast);

Vue.use(VueCookies)

Vue.prototype.$store = store
Vue.prototype.$toast = Toast
Vue.prototype.$cookies = VueCookies


axios.defaults.withCredentials = true
Vue.prototype.$axios = axios


router.beforeEach((to, from, next) => {
  if (to.matched.some(record => record.meta.requiresAuth)) {

    console.log('aaa');

    if (store.state.token == null) {
      next({
        path: '/user'
      })
    } else {
      next()
    }
  } else {
    next()
  }
})

new Vue({
  render: h => h(App),
  router
}).$mount('#app')
