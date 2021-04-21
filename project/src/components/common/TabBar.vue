<template>
   <van-tabbar v-model="active" route placeholder safe-area-inset-bottom>
      <van-tabbar-item replace icon="home-o" to="/home">首页</van-tabbar-item>
      <van-tabbar-item replace icon="search" to="/search">搜索</van-tabbar-item>
      <van-tabbar-item replace icon="chat-o" to="/chat">聊天</van-tabbar-item>
      <van-tabbar-item replace icon="user-o" to="/user">用户</van-tabbar-item>
    </van-tabbar>
</template>

<script>
export default {
  name: "TabBar",
  data() {
    return {
      active: 0,
    };
  },
  methods:{
  }
}
</script>

<style scoped>

</style>