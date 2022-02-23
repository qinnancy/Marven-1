<template>
  <div class="home" id="content">
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
              <div class="new-tag-box">
                <div class="news-tag-box" v-for="(itag,itagNum) in item.newTags" :key="itagNum">
                    <div class="new-tag">{{itag}}</div>
                </div>
              </div>
            </div>
            <div class="news-date">{{item.newsReleaseDate}}</div>
        </div>
      </div>
      <div v-loading="loading" class="loading-box">{{loadingContent}}</div>
      <div class="footer">沪ICP备14034737号-3</div>
  </div>
</template>

<script>
import api from "@/request/api";
export default {
  name: 'Home',
  data(){
    return{
      newsList:[],
      currentPage: 1,
      pageSize: 5,
      loading:false,
      loadingContent:null,
    }
  },
  created(){
    this.getNewList()
  },
  mounted() {
    window.addEventListener("scroll", this.scrollBottom, true);
  },
  methods:{
    scrollBottom() {
    // 滚动到页面底部时
        const el = document.getElementById("content");
        const windowHeight = window.screen.height;
        const scrollTop = document.documentElement.scrollTop || document.body.scrollTop;
        const contentHeight = el.clientHeight;
        const toBottom = contentHeight - windowHeight - scrollTop;
        if (toBottom < -360 && !this.loadingContent) {
        // console.log(toBottom)
          this.loading = true;
          // 请求的数据未加载完成时
          this.currentPage = this.currentPage+1
          this.getNewList();
        }else{
           this.loading = false;
        }
    },
    getNewList(){
      api
      .get(`/Rank/GetNewsList?currentPage=${this.currentPage}&pageSize=${this.pageSize}`)
      .then((res) => {
        // console.log('-----',res.data);
        const data = res.data.returnObj
        if(data.length !== 0){
          data.map((item)=>{
              this.newsList.push(item)
          })
          this.newsList.map((item)=>{
            if(item.newsImage.indexOf("http://reaapi.ftechsoftware.com/") === -1){
                item.newsImage = 'http://reaapi.ftechsoftware.com/'+item.newsImage
            }
          })
        }else{
           this.loadingContent ="没有更多资讯"
        }
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
  font-size: 1.125rem;
  color: #000000;
  text-align: left;
  padding: 1rem 1rem 0.5rem 1rem;
  font-weight: bold;
}
.news-card{
  background: #FFFFFF;
  box-shadow: 0 1px 20px 1px rgba(0,0,0,0.06);
  margin-bottom: 0.8rem;
  min-height: 5rem;
  padding: 1rem;
}
.news-card::after{
    content:"";
    height:0px;
    width:0px;
    clear:both;
    display:block;
    overflow: hidden;
}
.news-img-box{
  width: 33%;
  vertical-align: middle;
  height: 100%;
  float: left;
}
.news-img{
  width: 100%;
  height: 100%;
  line-height: 6.25rem;
  border-radius: .125rem;
}
.news-content-box{
  float: left;
  width: 67%;
  text-align: left;
}
.new-title{
  font-size: .875rem;
  color: #333333;
  width: 100%;
  /* overflow: hidden;
  white-space: nowrap;
  text-overflow: ellipsis; */
  padding-left: 0.5rem;
  margin-top: 0.2rem;
  font-weight: bold;
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
  margin-top: .5rem;
}
.news-buttom-box{
  padding-left: 0.5rem;
  /* width: 80%; */
  height: 1.25rem;
  overflow: hidden;
  /* overflow: hidden;
  white-space: nowrap;
  text-overflow: ellipsis; */
}
.new-tag-box{
  width: 53%;
  overflow: hidden;
  white-space: nowrap;
  text-overflow: ellipsis;
  float: left;
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
  font-weight: bold;
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
  margin-top: 0.5rem;
  margin-bottom: 2rem;
}
.loading-box {
    font-size: .75rem;
    color: #999999;
    /* margin-top: 29px; */
}
</style>
