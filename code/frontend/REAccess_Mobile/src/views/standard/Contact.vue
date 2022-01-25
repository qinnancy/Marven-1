<template>
  <div class="contact">
    <img src="@/assets/蓝色背景.png" class="header-img"/>
     <div class="">
       <div class="line"></div>
       <div class="point"></div>
       <div>联系我们</div>
       <div></div>
       <div></div>
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
  margin-top: -4rem;
  background: linear-gradient(to right, rgba(255,0,0,0), rgba(255,0,0,1));
  /* background: linear-gradient(to right, rgba(255,255,255,0), rgb(255,255,255,1)); */
}
</style>

