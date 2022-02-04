<template>
  <div >
    <div class="detail">
      <div class="title">
        <img class="titleIcon" src="@/assets/书签.svg"/>
        <span>{{detailData.fileCategory}}</span>
      </div>
      <hr>
      <div>
        <span class="spanTitle">文件级别</span>
        <span class="spanContent">{{detailData.fileLevel}}</span>
      </div>
      <div>
        <span class="spanTitle">发文机构</span>
        <span class="spanContent">{{detailData.issuingAgency}}</span>
      </div>
      <div>
        <span class="spanTitle">支持领域</span>
        <span class="spanContent">{{detailData.supportAreas}}</span>
      </div>
      <div>
        <span class="spanContent">{{detailData.releaseDate}}</span>
        <img class="titleIcon" src="@/assets/发布时间.svg"/>
        <span class="spanTitle">发布时间</span>
      </div>
      <div>
        <span class="spanContent">{{detailData.closingDate}}</span>
        <img class="titleIcon" src="@/assets/截止日期.svg"/>
        <span class="spanTitle">截止日期</span>
      </div>
    </div>
    <div class="footer">
      <div class="footer-img">
          <img src="@/assets/查看政策详情.svg"/>
      </div>
   </div>
  </div>
</template>

<script>
import api from "@/request/api";
export default {
  name: 'PolicyDetail',
  data () {
    return {
      detailData: {},
    }
  }, 
  created() {
    const policyId = this.$route.query.policyId
    this.getIndexList(policyId)
  },
  methods: {
    getIndexList(policyId){
      api
      .get(`/Industry/GetPolicyDetail?policyId=${policyId}`)
      .then((res) => {
        this.detailData = res.data.returnObj
      });
   },
  }
}
</script>

<style scoped>
.detail {
  margin: 2%;
  background: #FFFFFF;
  box-shadow: 0 0 20px -4px rgba(39,49,66,0.20);
}
.title {
  width: 100%;
  font-size: 14px;
  color: #000000;
}
.spanTitle {
  font-size: 12px;
  color: #999999;
}
.spanContent {
  font-size: 12px;
  color: #333333; 
}
</style>
