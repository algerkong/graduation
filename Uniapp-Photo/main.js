import Vue from 'vue'
import App from './App'

import store from './store'
import axios from 'axios'

Vue.prototype.$store = store

axios.defaults.withCredentials = true
Vue.prototype.$axios = axios



Vue.config.productionTip = false

App.mpType = 'app'

const app = new Vue({
    ...App,
		store
})
app.$mount()
