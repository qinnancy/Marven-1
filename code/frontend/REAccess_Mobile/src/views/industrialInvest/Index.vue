<template>
  <div class="city-detail">
   <div :class="chooseItem==='list'?'shift-tab active-tab':'shift-tab'" @click="shiftTag('list')">
     <img src="@/assets/上市.svg" class="tab-img"/><span>A股上市企业投资</span>
   </div>
   <div :class="chooseItem==='land'?'shift-tab active-tab':'shift-tab'"  @click="shiftTag('land')">
     <img src="@/assets/产业用地.svg" class="tab-img"/><span>产业用地获取</span>         
   </div>
     <filter-index :title="chooseOption" :filterList="options" @searchData="searchData"></filter-index>
  </div>
</template>

<script>
import api from "@/request/api";
import FilterIndex from "../../components/FilterIndex.vue";
export default {
  name: 'IndustrialInvest',
  components:{
    FilterIndex,
  },
  data(){
    return{
       chooseItem:"list",
       chooseOption:"看活跃区域",
       options: ['看活跃区域','看热点产业']
    }
  },
  created(){
  },
  methods:{
    shiftTag(value){
      this.chooseItem = value
    },
    searchData(value){
      this.chooseOption = value
    }
  }
}
</script>

<style scoped>
.city-detail{
  background: #fff;
  width: 100%;
  min-height: 79.8vh;
  border-top: 1px solid #f0f1f4;
}
.shift-tab{
  background: #D5D5D5;
  border-radius: 4px 4px 0 0;
  width: 50%;
  float: left;
  height: 4rem;
  line-height: 4rem;
  font-size: .875rem;
  color: #666666;
}
.shift-tab >>> span{
  margin-left: 1.2rem;
}
.tab-img {
    position: absolute;
    margin-top: 1.55rem;
}
.active-tab{
  color: #333333;
  background: #FFFFFF;
}
</style>
