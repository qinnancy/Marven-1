<template>
  <div class="city-detail">
   <filter-index title="选择城市" :filterList="filterList" @searchData="searchData"></filter-index>
   <city-data title="选择城市" :searchName="searchName" :rankingData="rankingData"></city-data>
    <div class="footer">
        <div class="footer-img">
           <!-- <a href="https://rea.deloitte.com.cn"><div class="link-web"></div></a> -->
           <img src="@/assets/解锁城市.svg"/>
        </div>
   </div>
  </div>
</template>

<script>
import api from "@/request/api";
import FilterIndex from "../../components/FilterIndex.vue";
import CityData from "../../components/CityData.vue";
export default {
  name: 'CityRanking',
  components:{
    FilterIndex,
    CityData
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
      .get(`/Rank/GetCityRank?selectCity=${cityName}`)
      .then((res) => {
        this.rankingData = res.data.returnObj
      });
   },
   getIndexList(){
      api
      .get('/Util/GetCityList')
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
 /* position: fixed; */
 bottom: 0;
 background: #fff;
 margin-top: 2rem;
 /* padding: 1rem; */
}
.footer-img >>> img{
  width: 94%;
}
.footer-img{
  text-align: center;
}
</style>

