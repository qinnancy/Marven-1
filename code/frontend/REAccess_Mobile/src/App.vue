<template>
  <div id="app">
    <div class="header-box">
      <div class="header-left">
        <!-- <img src="http://reaapi.ftechsoftware.com/RealTimeInfoImgs/logo.png" style="display:none"/> -->
        <img src="@/assets/prev.svg" class="prev-img" @click="goBack()" v-if="!isShowHome">
      </div>
      <div class="header-content" @click="returnHome()" 
        v-if="routerName !== 'PolicyDetail' && routerName !== 'ListDetail' && routerName !== 'LandDetail'">
        <img src="@/assets/logo.svg" class="logo-img">
        <span class="title"> 丨 产城智链</span>
      </div>
      <div class="header-policy" @click="returnPolicy()" v-else-if="routerName === 'PolicyDetail'">
        <span class="title">政策</span>
      </div>
       <div class="header-detail" @click="returnDetail(titleName,routerName)" v-else-if="routerName === 'ListDetail' || routerName === 'LandDetail'">
        <span class="title">{{titleName}}</span>
       </div>
      <div class="header-right">
         <el-dropdown trigger="click" class="header-menu">
            <i class="el-icon-more"></i>
            <el-dropdown-menu slot="dropdown">
              <el-dropdown-item> <router-link class="header-list" to="/Contact">联系我们</router-link></el-dropdown-item>
              <el-dropdown-item><router-link class="header-list" to="/Agreement">试用协议</router-link></el-dropdown-item>
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
            <img src="@/assets/单项指标-选中.svg" v-if="routerName=='SingleIndex'" class="img-size"/>
            <img src="@/assets/单项指标-未选中.svg" v-else class="img-size"/>
            <div :class="routerName=='SingleIndex'?'menu-title active-menu':'menu-title'">单项指标</div>
          </router-link> 
        </el-col>
        <el-col :span="6">
           <router-link to="/CityRanking">
              <img src="@/assets/城市排名-选中.svg" v-if="routerName=='CityRanking'" class="img-size"/>
              <img src="@/assets/城市排名-未选中.svg" v-else class="img-size"/>
              <div :class="routerName=='CityRanking'?'menu-title active-menu':'menu-title'">城市排名</div>
           </router-link> 
        </el-col>
        <el-col :span="6">
           <router-link to="/IndustrialInvest">
              <img src="@/assets/产业投资-选中.svg" v-if="routerName=='IndustrialInvest'" class="img-size"/>
              <img src="@/assets/产业投资-未选中.svg" v-else class="img-size"/>
              <div :class="routerName=='IndustrialInvest'?'menu-title active-menu':'menu-title'">产业投资</div>
          </router-link> 
        </el-col>
        <el-col :span="6">
            <router-link to="/SpecialPolicies">
                <img src="@/assets/政策 选中.svg" v-if="routerName=='SpecialPolicies'" class="img-size" @click="goToPolice()"/>
                <img src="@/assets/专项政策未选中.svg" v-else class="img-size" @click="goToPolice()"/>
                <div :class="routerName=='SpecialPolicies'?'menu-title active-menu':'menu-title'" @click="goToPolice()">专项政策</div>
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
      if(name === 'Detail' || name === 'Contact' || name === 'Agreement' || name === 'PrivacyPolicy' 
      || name === 'ListDetail' || name === 'LandDetail' || name === 'PolicyDetail'){
        return true
      }else {
        return false
      }
    },
    routerName(){
      return this.$route.name
    },
    titleName(){
      const searchName = this.$route.query.searchName.replace("看","")
      return searchName
    }
  },
  methods:{
    goBack(){
      this.$router.go(-1)
    },
    returnHome(){
      this.$router.push("/")
    },
    returnPolicy(){
      this.$router.push("/SpecialPolicies")
    },
    returnDetail(titleName,routerName){
      this.$router.push(`/IndustrialInvest`)
      window.localStorage.setItem('searchName', '看'+titleName)
      window.localStorage.setItem('routerName', routerName)
    },
    goToPolice(){
      window.localStorage.setItem('filterName', '')
    }
  }
}
</script>

<style>
body {
  margin: 0 !important;
  /* font-family: MicrosoftYaHeiUI; */
  background:#f7f8fc;
  -webkit-text-size-adjust: 100% !important;
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
  font-size: 1rem;
  font-weight: bold;
  padding-left: 6%;
}
.header-policy{
  float: left;
  width: 60%;
  color: white;
  font-size: 1rem;
  font-weight: bold;
  padding-left: 30%;
}
.header-detail{
  float: left;
  width: 60%;
  color: white;
  font-size: 1rem;
  font-weight: bold;
  padding-left: 24%;
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
  float: left;
  margin-right: .125rem;
}
.title{
  float: left;
  font-size: 1.0625rem;
  margin-top: .125rem;
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
  background-color: #000000 !important;
  border: 1px solid #000000 !important;
  opacity: 0.9 !important;
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
  margin-bottom: .625rem;
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
  height: 2rem;
  line-height: 2rem;
  font-weight: bold;
}
.prev-img{
  margin-top: 1.1rem;
}
.header-list{
  color: #fff !important;
  opacity: 1 !important;
}
.img-size{
  width: 1.625rem;
  height: 1.625rem;
}
</style>
