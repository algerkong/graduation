<template>
  <div id="app">
    <router-view />
    <tab-bar />
  </div>
</template>

<script>
import TabBar from "@/components/common/TabBar";
export default {
  name: "App",
  components: { TabBar },
  data() {
    return {
      active: 0,
    };
  },
};
</script>

<style>
@import "assets/css/base.css";
/* ./src/index.css */
/*! @import */
@tailwind base;
@tailwind components;
@tailwind utilities;
</style>
