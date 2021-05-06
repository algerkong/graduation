<template>
  <div class="home">
    <div class="banner">
      <van-swipe class="my-swipe" :autoplay="3000" :height="200" indicator-color="black">
        <van-swipe-item v-for="(image, index) in images" :key="index">
            <img class="banner-img" v-lazy="image" />
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
        'https://ns-strategy.cdn.bcebos.com/ns-strategy/upload/fc_big_pic/part-00273-2958.jpg',
        'https://ss0.bdstatic.com/70cFvHSh_Q1YnxGkpoWK1HF6hhy/it/u=1596977024,2747475854&fm=26&gp=0.jpg',
        'https://ss2.bdstatic.com/70cFvnSh_Q1YnxGkpoWK1HF6hhy/it/u=2026388599,3583792811&fm=26&gp=0.jpg',
        'https://ss0.bdstatic.com/70cFvHSh_Q1YnxGkpoWK1HF6hhy/it/u=1775464494,3658319800&fm=26&gp=0.jpg',
      ],
    };
  },
}
</script>

<style scoped>
 .my-swipe .banner-img {
    width: 100%;
  }
  
</style>