<template>
  <div class="home">
    <div class="banner">
      <van-swipe :autoplay="3000" >
      <van-swipe-item v-for="(image, index) in images" :key="index">
        <img v-lazy="image"/>
      </van-swipe-item>
    </van-swipe>
    </div>
  </div>
</template>

<script>
export default {
  name: "Home",
   data() {
    return {
      images: [
        'https://img01.yzcdn.cn/vant/apple-1.jpg',
        'https://img01.yzcdn.cn/vant/apple-2.jpg',
      ],
    };
  },
}
</script>

<style scoped>
  .banner{
    height: 200px;
  }
</style>