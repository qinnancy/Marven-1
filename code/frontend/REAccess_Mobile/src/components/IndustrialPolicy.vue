<template>
  <div class="filter-data">
      <div class="filter-title"><img src="@/assets/政策.svg" class="logo-box"/>
        <div class="search-title">{{searchName}}</div>
        <div class="unit-box">共{{rankingData.industrialPolicyCount}}份</div>
      </div>
      <div v-for="(item,index) in rankingData.industrialPolicis" :key="String(index)" class="line-box" @click="policyDetail(item.policyId, item.fileName)">
        <div class="file">
          {{item.fileName}}
        </div>
        <div class="province">
          {{item.province}}
        </div>
        <div class="city">
          {{item.city}}
        </div>
         <div class="goto-order"><img src="@/assets/next.svg"/></div>
        <!-- <img src="@/assets/政策 选中.svg" class="logo-box"/> -->
      </div>
  </div>
</template>

<script>
export default {
  name: 'IndustrialPolicy',
  props:{
   title: String,
   searchName: String,
   rankingData: Object
  },
  data () {
    return {
    }
  },
  created(){
   
  },
  computed:{
  
  },
  methods:{
    policyDetail(policyId, fileName) {
      this.$router.push({path: `/PolicyDetail?policyId=${policyId}`})
      // window.localStorage.setItem('fileName', fileName)
      this.$store.commit('common/common/setFileName', fileName)
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.filter-title{
  background-image: linear-gradient(-85deg, #FFFFFF 0%, #E6EFFF 98%);
  border-radius: .25rem .25rem 0 0;
  height: 3rem;
  line-height: 3rem;
  text-align: left;
  padding: 0 1.5rem;
}
.logo-box{
  float: left;
  margin-top: 0.8rem;
  margin-right: 1rem;
}
.search-title{
  font-size: 1rem;
  color: #000000;
  float: left;
  max-width: 50%;
  overflow: hidden;
  white-space: nowrap;
  text-overflow: ellipsis;
  font-weight: 700;
}
.unit-box{
  background: #E3EBFF;
  border-radius: 4px;
  float: right;
  height: 1.25rem;
  line-height: 1.25rem;
  padding: 0 0.5rem;
  font-size: .625rem;
  color: #666666;
  margin-top: 0.8rem;
  /* margin-right: 1rem; */
}
/* .unit-box::before{
    position: absolute;
    content: '';
    width: 0;
    height: 0;
    border-bottom: 6px solid #E3EBFF;
    border-left: 14px solid transparent;
    margin-left: -1.2rem;
    margin-top: 14px;
} */
.line-box{
  min-height: 4rem;
  line-height: 4rem;
  font-size: .75rem;
  color: #333333;
  margin: 0 1.5rem 0 1.5rem;
  border-bottom: 1px solid #EEEFF3;
}
.line-box::after{
    content:"";
    height:0px;
    width:0px;
    clear:both;
    display:block;
    overflow: hidden;
}
.num-order{
  width: 10% !important;
}
.line-item{
  float: left;
  width: 20%;
  text-align: left;
}
.uni-font{
 color: #666666;
}
.order-img{
  float: left;
  margin-top: 1.25rem;
}
.amount-box{
  margin-left: 0%;
  text-align: center;
}
.img-item{
  float: left;
  margin-top: 1.375rem;
  margin-right: 1.25rem
}
.file{
  width: 40%;
  float: left;
  line-height: 1.2rem;
  /* height: 3rem; */
  text-overflow: -o-ellipsis-lastline;
  overflow: hidden;
  text-overflow: ellipsis;
  display: -webkit-box;
  -webkit-line-clamp: 2;
  line-clamp: 2;
  -webkit-box-orient: vertical;
  margin-top: 1rem;
  text-align: left;
}
.province{
  float: left;
  width: 20%;
  white-space: nowrap;
  text-overflow: ellipsis;
  overflow: hidden;
  word-break: break-all;
}
.city{
  float: left;
  width: 30%;
  font-size: 12px;
  color: #999999;
  line-height: 1rem;
  margin-top: 1.5rem;
  overflow: hidden;
  text-overflow: ellipsis;
  display: -webkit-box;
  -webkit-line-clamp: 2;
  line-clamp: 2;
  -webkit-box-orient: vertical;
}
.goto-order{
  width: 8% !important;
  text-align: right !important;
  float: left;
}
.goto-order >>> img{
    width: 0.7rem;
    margin-top: 1.6rem;
    float: right;
}
.filter-data{
  min-height: 23.5rem;
}
</style>
