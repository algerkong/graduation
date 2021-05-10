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
      <van-button
        v-if="this.$store.state.isLogin"
        class="bg-red-500 rounded-full text-white text-base mt-4"
        @click="btnLogout"
      >退出登录</van-button>
    </div>
  </div>
</template>

<script>
import { userLogin, SearchVirus, userLogout } from "network/api/user";
import types from "common/types";

export default {
  name: "User",
  data() {
    return {
      userid: "",
      password: "",
    };
  },
  created() {},
  methods: {
    btnLogin() {
      let that = this;
      let formData = new FormData();
      formData.append("userid", this.userid);
      formData.append("password", this.password);
      formData.append("rememberLogin", "true");
      formData.append("cookie", "true");

      userLogin(formData).then((res) => {
        console.log(res);
        that.$toast("登录成功");
        that.$cookies.set(types.ISLOGIN, true);
        that.$store.commit(types.LOGIN);
        console.log(that.$cookies.keys());
        let data = {
          Page: 1,
          Limit: 10,
          Count: 0,
          PageCount: 0,
        };
        SearchVirus(data).then((res) => {
          console.log(res);
        });
      });
    },

    btnLogout() {
      let that = this;
      userLogout(that.$store.state.token).then((res) => {
        that.$store.commit(types.LOGOUT);
        this.$cookies.remove(types.ISLOGIN);
        console.log(res);
      });
    },
  },
};
</script>

<style scoped>
</style>