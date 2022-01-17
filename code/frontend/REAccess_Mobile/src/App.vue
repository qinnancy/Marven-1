<template>
  <div id="app">
    <img class="bg-img" src="@/assets/background.png"/>
    <div id="nav">
      <router-link to="/SingleIndex">单项指标</router-link> |
      <router-link to="/CityRanking">城市排名</router-link> |
      <router-link to="/IndustrialInvest">产业投资</router-link> |
      <router-link to="/SpecialPolicies">专项政策</router-link> 
    </div>
    <router-view/>
  </div>
</template>

<script>
import api from "./request/api";
export default {
  name: 'App',
  data(){
    return{

    }
  },
  created(){
    this.getApi()
  },
  methods:{
    getApi(){
      api
      .get("GetInfoByID", {
        ID: "666",
      })
      .then((res) => {
        console.log(res);
      });
    }
  }
}
</script>

<style>
body {
  margin: 0 !important;
}
#app {
  text-align: center;
}
.bg-img{
  width: 101%;
}
</style>
