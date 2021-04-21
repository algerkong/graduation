import Vue from 'vue'
import VueRouter from 'vue-router'

const Home = ()=> import('../views/home/Home')
const Chat= ()=> import('../views/chat/Chat')
const User = ()=> import('../views/user/User')
const Search = ()=> import('../views/search/Search')


Vue.use(VueRouter)
const routes = [
  {
    path:'',
    redirect:'/home'
  },
  {
    path: '/home',
    component:Home
  },
    {
    path: '/chat',
    component:Chat
  },
    {
    path: '/user',
    component:User
  },
    {
    path: '/search',
    component:Search
  },
]
const router = new VueRouter({
  routes,
  mode:'history'
})

export default  router
