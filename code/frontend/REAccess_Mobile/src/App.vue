<template>
  <div id="app">
    <div class="header-box">
      <div class="header-left">
        <img src="@/assets/prev.svg" class="prev-img" @click="goBack()">
      </div>
      <div class="header-content" @click="returnHome()">
        <img src="@/assets/logo.png" class="logo-img">
        <span>产城智链</span>
      </div>
      <div class="header-right">
         <el-dropdown trigger="click" class="header-menu">
            <i class="el-icon-more"></i>
            <el-dropdown-menu slot="dropdown">
              <el-dropdown-item> <router-link class="header-list" to="/Contact">联系我们</router-link></el-dropdown-item>
              <el-dropdown-item><router-link class="header-list" to="/Agreement">使用协议</router-link></el-dropdown-item>
              <el-dropdown-item><router-link class="header-list" to="/PrivacyPolicy">隐私政策</router-link></el-dropdown-item>
            </el-dropdown-menu>
        </el-dropdown>
      </div>
    </div>
    <div class="bg-box" v-if="isShowHome">
       <div class="bg-title">产城智链</div>
       <div class="bg-tag">发现你的城市</div>
       <div class="bg-detail">解锁100+维度，洞察240+城市，追踪90+产业</div>
    </div>
     <!-- <img class="bg-img" src="@/assets/background.png"/> -->
    <div id="nav" v-if="!showDetail">
      <el-row>
        <el-col :span="6">
          <router-link to="/SingleIndex">
            <img src="@/assets/单项指标-选中.svg" v-if="routerName=='SingleIndex'"/>
            <img src="@/assets/单项指标-未选中.svg" v-else/>
            <div :class="routerName=='SingleIndex'?'menu-title active-menu':'menu-title'">单项指标</div>
          </router-link> 
        </el-col>
        <el-col :span="6">
           <router-link to="/CityRanking">
              <img src="@/assets/城市排名-选中.svg" v-if="routerName=='CityRanking'"/>
              <img src="@/assets/城市排名-未选中.svg" v-else/>
              <div :class="routerName=='CityRanking'?'menu-title active-menu':'menu-title'">城市排名</div>
           </router-link> 
        </el-col>
        <el-col :span="6">
           <router-link to="/IndustrialInvest">
              <img src="@/assets/产业投资-选中.svg" v-if="routerName=='IndustrialInvest'"/>
              <img src="@/assets/产业投资-未选中.svg" v-else/>
              <div :class="routerName=='IndustrialInvest'?'menu-title active-menu':'menu-title'">产业投资</div>
          </router-link> 
        </el-col>
        <el-col :span="6">
           <router-link to="/SpecialPolicies">
              <img src="@/assets/政策.svg" v-if="routerName=='SpecialPolicies'"/>
              <img src="@/assets/专项政策未选中.svg" v-else/>
              <div :class="routerName=='SpecialPolicies'?'menu-title active-menu':'menu-title'">专项政策</div>
           </router-link> 
        </el-col>
      </el-row>
    </div>
    <router-view v-if="!isShowHome"/>
    <news-card v-if="isShowHome"></news-card>
  </div>
</template>

<script>
import NewsCard from "./views/home/Index.vue"
export default {
  name: 'App',
  components:{
    NewsCard
  },
  data(){
    return{
    }
  },
  computed:{
    isShowHome(){
      const name = this.$route.name
      if (name !== 'Home' || !name) {
        return false
      } else {
        return true
      }
    },
    showDetail(){
       const name = this.$route.name
      if(name === 'Detail' || name === 'Contact' || name === 'Agreement' || name === 'PrivacyPolicy'){
        return true
      }else {
        return false
      }
    },
    routerName(){
      return this.$route.name
    }
  },
  methods:{
    goBack(){
      this.$router.go(-1)
    },
    returnHome(){
      this.$router.push("/")
    }
  }
}
</script>

<style>
body {
  margin: 0 !important;
  font-family: MicrosoftYaHeiUI;
  background:#f7f8fc;
}
#app {
  text-align: center;
}
.bg-img{
  width: 101%;
}
.header-box{
  display: flex;
  width: 100%;
  height: 3.125rem;
  line-height:3.125rem;
  background: black;
}
.header-left{
  float: left;
  width: 20%;
  text-align: left;
  padding-left: .625rem;
}
.header-content{
  float: left;
  width: 60%;
  color: white;
  font-size: 1.0625rem;
  font-weight: bold;
}
.header-right{
  float: left;
  width: 20%;
  text-align: right;
  padding-right: .625rem;
}
.logo-img{
  width: 5.25rem;
  margin-top: 1.1rem;
}
.el-icon-arrow-left{
  color: white;
  font-weight: bold;
}
.el-icon-more{
  color: white;
  font-weight: bold;
}
.el-dropdown-menu{
  background-color: #000000;
  border: 1px solid #000000;
  opacity: 0.9;
}
.el-dropdown-menu__item{
  color: #fff !important;
}
.popper__arrow{
  border-bottom-color: #000000 !important;
}
.popper__arrow::after{
    border-bottom-color: #000000 !important;
}
.el-menu-item.is-active {
   background-color: #000000 !important;
   color: black;
}
.el-dropdown-menu__item:focus, .el-dropdown-menu__item:hover{
  background-color: #000000 !important;
  color: #fff !important;
}
.bg-box{
  width: 100%;
  height: 12rem;
  background: url("./assets/background.png") no-repeat;
  background-size:100.5% 104%; 
  text-align: center;
}
a {
   text-decoration: none;
   font-size: .875rem;
   color: #999999;
   text-align: center;
   opacity: 0.6;
}
#nav{
  padding: 1.2rem 0 1.2rem 0;
  background: #FFFFFF;
  border-radius: 4px;
}
.menu-title {
    opacity: 0.6;
    font-size: .875rem;
    margin-top: 0.3rem;
}
.active-menu{
  color: #333333;
  opacity: 1;
}
.bg-title{
  font-size: 2rem;
  color: #FFFFFF;
  letter-spacing: 0.15rem;
  margin-bottom: .875rem;
  padding-top: 2rem;
}
.bg-tag{
  background: rgba(0,0,0,0.74);
  border-radius: .9375rem;
  font-size: .875rem;
  color: #FFFFFF;
  letter-spacing: .0656rem;
  height: 1.625rem;
  line-height: 1.625rem;
  width: 7.5rem;
  margin: 0 auto;
  margin-bottom: .875rem;
}
.bg-detail{
  background-image: linear-gradient(90deg, rgba(237,178,116,0.00) 0%, rgba(237,179,117,0.87) 50%, rgba(230,177,122,0.00) 100%);
  border-radius: .0625rem;
  font-size: .875rem;
  color: #FFFFFF;
  text-align: center;
  text-shadow: 0 .125rem .1875rem rgba(56,30,24,0.42);
}
.prev-img{
  margin-top: 1.1rem;
}
.header-list{
  color: #fff !important;
  opacity: 1 !important;
}
</style>
