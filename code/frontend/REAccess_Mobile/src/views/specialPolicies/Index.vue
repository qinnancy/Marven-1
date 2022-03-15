<template>
  <div class="city-detail">
   <filter-index title="产业类别" :filterList="filterList" @searchData="searchData" :filterName="filterPageName"></filter-index>
   <industrial-policy title="产业类别" :searchName="searchName" :rankingData="rankingData"></industrial-policy>
   <div class="footer">
      <div class="footer-img">
          <!-- <a href="https://rea.deloitte.com.cn"><div class="link-web"></div></a> -->
          <!-- <img src="@/assets/解锁产业政策.svg"/> -->
          <div class="footer-img-bg">
             <div class="footer-line-box">
              <img src="@/assets/解锁.svg" class="footer-icon-size"/>
              <span class="footer-img-font">解锁更多产业政策</span>
             </div>
             <div class="footer-line-box1">
               <img src="@/assets/登录.svg" class="footer-icon-size"/>
               <span class="footer-img-font2">请登录PC端 (rea.deloitte.com.cn)</span>
             </div>
            </div>
      </div>
   </div>
  </div>
</template>

<script>
import api from "@/request/api";
import { mapState} from 'vuex'
import FilterIndex from "../../components/FilterIndex.vue";
import IndustrialPolicy from '../../components/IndustrialPolicy.vue';
export default {
  name: 'specialPolicies',
  components:{
    FilterIndex,
    IndustrialPolicy
  },
  computed: {
    ...mapState('common/common', ['filterName']),
  },
  data(){
    return{
      searchName:"",
      filterPageName:"",
      filterList:[],
      dataList:[],
      rankingData:{}
    }
  },
  created(){
  //  this.filterName = window.localStorage.getItem('filterName')
   this.filterPageName = this.filterName
   this.getIndexList()
  },
  methods:{
   searchData(cityName){
    // window.localStorage.setItem('filterName', cityName)
    this.$store.commit('common/common/setFilterName', cityName)
    this.searchName = cityName
    const industryId = this.dataList.filter((item)=>
    item.policyName === cityName)[0].policyId
     api
      .get(`/Industry/GetPolicyData?industryId=${industryId}&dataCount=5`)
      .then((res) => {
        this.rankingData = res.data.returnObj
      });
   },
   getIndexList(){
      api
      .get('/Util/GetPolicyList')
      .then((res) =>  {
        this.dataList = res.data.returnObj
        this.dataList.map((item)=>{
          this.filterList.push(item.policyName)
        })
        if(this.filterPageName){
          this.searchData(this.filterPageName)
        }else{
          this.searchData(this.filterList[0])
        }
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
  /* width: 94%; */
}
.footer-img{
  /* text-align: center; */
}
</style>
