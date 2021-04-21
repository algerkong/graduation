import Vue from 'vue'
import App from './App.vue'
import Vant from 'vant';
import 'vant/lib/index.css';
import { Lazyload } from 'vant';
import router from './router'

Vue.config.productionTip = false

Vue.use(Vant);
Vue.use(Lazyload);

new Vue({
  render: h => h(App),
  router
}).$mount('#app')
