<template>
  <div class="city-detail">
   <filter-index title="产业类别" :filterList="filterList" @searchData="searchData"></filter-index>
   <industrial-policy title="产业类别" :searchName="searchName" :rankingData="rankingData"></industrial-policy>
   <div class="footer">
      <div class="footer-img">
          <!-- <a href="https://rea.deloitte.com.cn"><div class="link-web"></div></a> -->
          <img src="@/assets/解锁产业政策.svg"/>
      </div>
   </div>
  </div>
</template>

<script>
import api from "@/request/api";
import FilterIndex from "../../components/FilterIndex.vue";
import IndustrialPolicy from '../../components/IndustrialPolicy.vue';
export default {
  name: 'specialPolicies',
  components:{
    FilterIndex,
    IndustrialPolicy
  },
  data(){
    return{
      searchName:"",
      filterList:[],
      rankingData:{}
    }
  },
  created(){
   this.getIndexList()
  },
  methods:{
   searchData(cityName){
    this.searchName = cityName
     api
      .get(`/Industry/GetPolicyData?dataCount=5`)
      .then((res) => {
        this.rankingData = res.data.returnObj
      });
   },
   getIndexList(){
      api
      .get('/Util/GetPolicyList')
      .then((res) => {
        this.filterList = res.data.returnObj
        this.searchData(this.filterList[0])
      });
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
