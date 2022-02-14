<template>
  <div class="contact">
    <!-- <img src="@/assets/蓝色背景.png" class="header-img"/> -->
     <div class="contract-header">
       <div class="icon-box">
          <div class="line"></div>
          <div class="point"></div>
       </div>
       <div class="contract-content">联系我们</div>
       <div class="icon-box">
          <div class="point"></div>
          <div class="line-left"></div>
       </div>
     </div>
     <div class="contract-box">
       <div class="img-box"><img src="@/assets/联系我们.svg"/></div>
       <img src="@/assets/邮箱.svg" class="email-img"/><span class="email-font">邮箱</span>
       <div class="address-font">rea@deloitte.com.cn</div>
     </div>
  </div>
</template>

<script>
import api from "@/request/api";
export default {
  name: 'Contact',
  data(){
    return{
    }
  },
  created(){
   
  },
  methods:{
   
  }
}
</script>
<style scoped>
.header-img{
  width: 100%;
}
.line{
  width: 2.5rem;
  height: .0625rem;
  float: left;
  margin-top: 2rem;
  background: linear-gradient(to right, rgba(255,0,0,0), rgb(255,255,255,1));
  /* background: linear-gradient(to right, rgba(255,255,255,0), rgb(255,255,255,1)); */
}
.line-left{
  width: 2.5rem;
  height: .0625rem;
  float: left;
  margin-top: 2rem;
  background: linear-gradient(to left, rgba(255,0,0,0), rgb(255,255,255,1));
}
.point{
  width: .4375rem;
  height: .4375rem;
  transform: rotate(45deg);
  background: #fff;
  float: left;
  margin-top: 1.8rem;
}
.contract-header{
  background: url("../../assets/蓝色背景.png") no-repeat;
  width: 100%;
  height: 4.6875rem;
  background-size: 100%;
}
.contract-content{
  font-size: 1rem;
  color: #FFFFFF;
  float: left;
  margin-top: 1.3rem;
  width: 6rem;
  font-weight: bold;
}
.icon-box{
  margin-right: 2rem;
  margin-left: 25%;
  /* padding-top: 10%; */
}
.contract-box {
  background: #FFFFFF;
  box-shadow: 0 1px 20px 1px rgba(0,0,0,0.06);
  border-radius: 4px;
  width: 90%;
  height: 25rem;
  margin-top: -1.2rem;
  margin-left: 5%;
}
.img-box{
  padding-top: 2.5rem;
  padding-bottom: 2.5rem;
}
.email-font{
  font-size: .875rem;
  color: #999999;
  float: left;
}
.address-font{
  font-size: 1.125rem;
  color: #333333;
  margin-top: 2rem;
}
.email-img{
    float: left;
    margin-top: .15rem;
    margin-left: 44%;
    margin-right: .25rem;
}
</style>

