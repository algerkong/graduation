<template>
  <div class="user">
    <div class="container px-4 flex flex-col mt-40">
      <input
        type="text"
        placeholder="用户名"
        class="bg-gray-100 rounded-full mb-8 text-base py-2 px-4"
        name="userName"
      />
      <input
        placeholder="密码"
        type="password"
        class="bg-gray-100 rounded-full mb-8 text-base py-2 px-4"
        name="password"
      />
      <van-button class="bg-blue-500 rounded-full text-white text-base">登陆</van-button>
    </div>
  </div>
</template>

<script>
export default {
  name: "User",
};
</script>

<style scoped>
</style>