<template>
  <div class="city-detail">
   <div :class="chooseItem==='list'?'shift-tab active-tab':'shift-tab'" @click="shiftTag('list')">
     <img src="@/assets/上市.svg" class="tab-img"/><span>A股上市企业投资</span>
   </div>
   <div :class="chooseItem==='land'?'shift-tab active-tab':'shift-tab'"  @click="shiftTag('land')">
     <img src="@/assets/产业用地.svg" class="tab-img"/><span>产业用地获取</span>         
   </div>
     <invest-filter-index :title="chooseOption" :filterList="options" @searchData="searchData"></invest-filter-index>
     <invest-data :filterList="filterList" :searchName="chooseOption" :tabName="chooseItem"></invest-data>
     <div class="footer">
        <div class="footer-img">
           <img src="@/assets/解锁更多投资项目.svg"/>
        </div>
     </div>
  </div>
</template>

<script>
import api from "@/request/api";
import InvestFilterIndex from "../../components/InvestFilterIndex.vue";
import InvestData from "../../components/InvestData.vue";
export default {
  name: 'IndustrialInvest',
  components:{
    InvestFilterIndex,
    InvestData
  },
  data(){
    return{
       chooseItem:"list",
       chooseOption:"看活跃区域",
       options: ['看活跃区域','看热点产业'],
       filterList: []
    }
  },
  created(){
    this.getInvestList()
  },
  methods:{
    shiftTag(value){
      this.chooseItem = value
      this.getInvestList()
    },
    searchData(value){
      this.chooseOption = value
      this.getInvestList()
    },
    getInvestList(){
      if(this.chooseItem === 'list'){
        if(this.chooseOption === '看活跃区域'){
            api
            .get('/Industry/GetActiveAreaRank')
            .then((res) => {
              this.filterList = res.data.returnObj
            });
        }else{
            api
            .get('/Industry/GetHotIndustryRank')
            .then((res) => {
              this.filterList = res.data.returnObj
            });
        }
      }else{
        if(this.chooseOption === '看活跃区域'){
            api
            .get('/Industry/GetIndusrtyActiveRegion')
            .then((res) => {
              this.filterList = res.data.returnObj
            });
        }else{
            api
            .get('/Industry/GetLandHotIndustryRank')
            .then((res) => {
              this.filterList = res.data.returnObj
            });
        }
      }
    },
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
  margin-bottom: 1rem;
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
.footer{
 text-align: center;
 width: 100%;
 position: fixed;
 bottom: 0;
 background: #fff;
 /* padding: 1rem; */
}
.footer-img >>> img{
  width: 94%;
}
.footer-img{
  text-align: center;
}
</style>
