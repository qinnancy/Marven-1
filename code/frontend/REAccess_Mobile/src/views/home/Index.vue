<template>
  <div class="home">
     <div class="news-title">
       资讯
     </div>
      <div class="news-card" v-for="item in newsList" :key="item.id" @click="toNewDetail(item)">
        <div class="news-img-box"><img :src="item.newsImage" class="news-img"/></div>
        <div class="news-content-box">
            <div class="new-title">{{item.newsTitle}}</div>
            <div class="news-content">{{item.newsContent}}</div>
            <div class="news-buttom-box">
              <span class="news-tag-title">产城智链：</span>
              <div class="news-tag-box" v-for="(itag,itagNum) in item.newTags" :key="itagNum">
                  <div class="new-tag">{{itag}}</div>
              </div>
            </div>
            <div class="news-date">{{item.newsReleaseDate}}</div>
        </div>
      </div>
      <div class="footer">Copyright “c”2021-2022 rea.dolitte.com.cn 沪ICP备14034737号-3</div>
  </div>
</template>

<script>
import api from "@/request/api";
export default {
  name: 'Home',
  data(){
    return{
      newsList:[]

    }
  },
  created(){
    this.getNewList()
  },
  methods:{
    getNewList(){
      api
      .get("/Rank/GetNewsList")
      .then((res) => {
        console.log(res)
        this.newsList = res.data.returnObj
        this.newsList.map((item)=>{
          item.newsImage = 'http://47.242.106.96:8088/'+item.newsImage
        })
      });
    },
    toNewDetail(obj){
      this.$router.push({path: `/Detail?id=${obj.id}`})
    }
  }
}
</script>
<style scoped>
.news-title{
  font-size: 1rem;
  color: #000000;
  text-align: left;
  padding: 1rem 1rem 0.5rem 1rem;
  font-weight: bold;
}
.news-card{
  background: #FFFFFF;
  box-shadow: 0 1px 20px 1px rgba(0,0,0,0.06);
  margin-bottom: 0.8rem;
  height: 5rem;
  padding: 1rem 1.5rem 1rem 1.5rem;
}
.news-img-box{
  width: 30%;
  vertical-align: middle;
  height: 100%;
  float: left;
}
.news-img{
  width: 100%;
  height: 100%;
  line-height: 6.25rem;
}
.news-content-box{
  float: left;
  width: 70%;
  text-align: left;
}
.new-title{
  font-size: .875rem;
  color: #333333;
  width: 100%;
  overflow: hidden;
  white-space: nowrap;
  text-overflow: ellipsis;
  padding-left: 0.5rem;
  margin-top: 0.5rem;
}
.news-content{
  font-size: .625rem;
  color: #999999;
  width: 100%;
  overflow: hidden;
  white-space: nowrap;
  text-overflow: ellipsis;
  padding-left: 0.5rem;
  margin-bottom: 1rem;
}
.news-buttom-box{
  padding-left: 0.5rem;
  width: 80%;
  height: 1.125rem;
  overflow: hidden;
  /* overflow: hidden;
  white-space: nowrap;
  text-overflow: ellipsis; */
}
.news-tag-box{
  border: .0313rem solid #999999;
  border-radius: 2px;
  float: left;
  padding: 0 .25rem 0 .25rem;
  margin-right: .25rem;
  margin-bottom: 1rem;
  /* overflow: hidden;
  white-space: nowrap;
  text-overflow: ellipsis; */
}
.news-tag-title{
  font-size: .625rem;
  color: #333333;
  float: left;
}
.new-tag{
  font-size: .625rem;
  color: #999999;
}
.news-date{
  font-size: .625rem;
  color: #B0B0B0;
  text-align: right;
  overflow: hidden;
  white-space: nowrap;
  text-overflow: ellipsis;
  margin-top: -1rem;
}
.footer{
  font-size: .625rem;
  color: #2C2C2C;
  margin-top: 4rem;
  margin-bottom: 2rem;
}
</style>
