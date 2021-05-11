import Vue from 'vue'
import App from './App'

import store from './store'
import axios from 'axios'
import ClUni from "cl-uni";

Vue.use(ClUni, {
	// 进入业务单页时，页面栈只有一个，自定义导航左侧返回按钮跳转的路径
	homePage: "/"
});

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
