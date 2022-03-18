<template>
<div class="list-detail">
  <div class="list-title">
      <img src="@/assets/城市.svg" class="img-box" v-if="searchName === '所在区域'"/>
      <img src="@/assets/产业.svg" class="img-box" v-else/>
      <div class="city-name">{{detailInfor.primaryName}}</div>
      <div class="total-box">
        <div class="left-total">
            <div class="total-num">{{detailInfor.investProjectCount}}<span>{{detailInfor.investProjectCountUnit}}</span></div>
            <div class="total-content">土地成交项目</div>
        </div>
        <div class="line-center"></div>
        <div class="right-total">
            <div class="total-num">{{detailInfor.investProjectAmount}}<span>{{detailInfor.investProjectAmountUnit}}</span></div>
            <div class="total-content">披露总成交金额</div>
        </div>
      </div>
  </div>
  <div class="list-content" v-for="(item,index) in detailInfor.projectList" :key="String(index)">
     <div class="content-header"><img src="@/assets/项目.svg" class="project-icon"/><span class="project-name">竞得方：{{item.projectName}}</span></div>
     <div class="content-line">
         <div class="line-title">项目所在地</div>
         <div class="line-content">{{item.projectLocation}}</div>
     </div>
     <div class="content-line">
         <div class="line-title">项目所属产业</div>
         <div class="line-content">{{item.projectIndustry}}</div>
     </div>
      <!-- {{item}} -->
      <div class="list-bottom">
          <div class="bottom-item">
              <div class="item-value">{{item.areaCovered}}</div>
              <div class="item-name"><img src="@/assets/占地面积.svg"/>占地面积</div>
          </div>
          <div class="line-center"></div>
          <div class="bottom-item center-item">
              <div class="item-value">{{item.transactionAmount}}</div>
              <div class="item-name"><img src="@/assets/投资金额.svg"/>成交金额</div>
          </div>
          <div class="line-center"></div>
          <div class="bottom-item center-item">
              <div class="item-value">{{item.transferDate}}</div>
              <div class="item-name"><img src="@/assets/年产值.svg"/>出让日期</div>
          </div>
      </div>
  </div>
    <div class="footer">
        <div class="footer-img">
           <!-- <img src="@/assets/解锁更多投资项目.svg"/> -->
           <div class="footer-img-bg">
             <div class="footer-line-box">
              <img src="@/assets/解锁.svg" class="footer-icon-size"/>
              <span class="footer-img-font">解锁100,000+项目投资</span>
             </div>
             <div class="footer-line-box1">
               <img src="@/assets/登录.svg" class="footer-icon-size"/>
               <span class="footer-img-font2">请登录PC端 rea.deloitte.com.cn</span>
             </div>
            </div>
        </div>
     </div>
</div>
</template>

<script>
import api from "@/request/api";
export default {
  name: 'ListDetail',
  props:{
 
  },
  data () {
    return {
     searchName:"",
     searchId:"",
     detailInfor:{}
    }
  },
  created(){
    this.searchName = this.$route.query.searchName
    this.searchId = this.$route.query.id
    console.log(this.searchId)
    this.getDetail(this.searchName,this.searchId)
  },
  computed:{
  
  },
  methods:{
    getDetail(name,id){
        let secondaryCategory = ''
        if(name === '所在区域'){
          secondaryCategory = '活跃区域'
        }else{
          secondaryCategory = '热点城市'
        }
        api
        .get(`/Industry/GetIndustryProject?primaryCategory=热点产业&secondaryCategory=${secondaryCategory}&currentId=${id}`)
        .then((res) => {
            this.detailInfor = res.data.returnObj
            console.log(this.detailInfor)
        });
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.list-title {
    background: #fff;
    margin: 0.65rem;
    box-shadow: 0 0 20px -4px rgb(39 49 66 / 20%);
    padding: 1rem;
}
.list-content{
    background: #fff;
    margin: 0.65rem;
    box-shadow: 0 0 20px -4px rgb(39 49 66 / 20%);
    padding: 1rem;
    padding-bottom: 0.2rem;
    /* min-height: 10rem; */
}
.img-box{
    margin-top: 1rem;
    margin-left: -1.2rem;
}
.city-name{
    font-size: .875rem;
    color: #333333;
    line-height: 2.5rem;
    border-bottom: 1px solid rgb(211 215 225 / 30%);
    width: 80%;
    margin-left: 10%;
}
.total-box {
    margin-top: 1rem;
}
.left-total {
    float: left;
    width: 50%;
}
.line-center{
    width: 1px;
    height: 22px;
    border-right: 1px solid #acc0d8;
    opacity: 0.4;
    float: left;
    margin-top: 0.5rem;
}
.right-total {
    /* float: left; */
    /* width: 50%; */
}
.total-num{
    font-size: 1.375rem;
    color: #4768C8;
}
.total-num >>> span{
    font-size: .625rem;
    color: #999999;
}
.total-content {
    font-size: .625rem;
    color: #999999;
}
.content-header{
    text-align: left;
    font-size: .875rem;
    color: #000000;
    padding-bottom: .75rem;
    border-bottom: 1px solid rgb(211 215 225 / 40%);
    margin-bottom: 0.5rem;
}
.project-icon{
    float: left;
    margin-right: 0.5rem;
    /* margin-top: 0.1rem; */
}
.project-name{
    line-height: 1rem;
}
.line-title{
    float: left;
    width: 24.5%;
    text-align: left;
    font-size: .75rem;
    color: #999999;
}
.line-content{
    float: left;
    width: 75%;
    text-align: left;
    color: #333333;
    font-size: .75rem;
    min-height: 2rem;
}
.content-line {
    line-height: 2rem;
}
.list-content::after{
    content:'';
    visibility:hidden;
    display:block;
    width:0;
    height:0;
    clear:both;
}
.list-bottom {
    width: 100%;
    height: 2rem;
    float: left;
    margin-top: 1rem;
    margin-bottom: 1.2rem;
}
.bottom-item {
    width: 32.5%;
    float: left;
    text-align: center;
}
.item-value {
    font-size: .875rem;
    color: #666666;
}
.item-name {
    font-size: .75rem;
    color: #999999;
}
.center-item{
    text-align: center;
     /* width: 34% !important; */
}
.item-name >>> img{
    margin-right: 0.2rem;
}
.footer{
 text-align: center;
 width: 100%;
 /* position: fixed; */
 bottom: 0;
 /* background: #fff; */
 padding-top: 1rem;
}
.footer-img >>> img{
  /* width: 94%; */
}
.footer-img{
  /* text-align: center; */
}
</style>
