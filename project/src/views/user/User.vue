<template>
  <div class="user">
    <div class="container px-4 flex flex-col mt-40">
      <input
        type="text"
        placeholder="用户名"
        class="bg-gray-100 rounded-full mb-8 text-base py-2 px-4"
        name="userName"
        v-model="userid"
      />
      <input
        placeholder="密码"
        type="password"
        class="bg-gray-100 rounded-full mb-8 text-base py-2 px-4"
        name="password"
        v-model="password"
      />
      <van-button class="bg-blue-500 rounded-full text-white text-base" @click="btnLogin">登陆</van-button>
    </div>
  </div>
</template>

<script>
import { userLogin, SearchVirus } from "network/api/user";

export default {
  name: "User",
  data() {
    return {
      userid: "",
      password: "",
    };
  },
  methods: {
    btnLogin() {
      let formData = new FormData();
      formData.append("userid", this.userid);
      formData.append("password", this.password);
      userLogin(formData).then((res) => {
        console.log(res);
      });

      let data = {
        Page: 1,
        Limit: 10,
        Count: 0,
        PageCount: 0,
      };
      SearchVirus(data).then((res) => {
        console.log(res);
      });
    },
  },
};
</script>

<style scoped>
</style>