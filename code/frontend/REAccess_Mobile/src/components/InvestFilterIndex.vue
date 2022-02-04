<template>
  <div class="filter-box">
      <div class="filter-name"><span @click="showDrawer">{{title}}<a class="el-icon-arrow-down"></a></span></div>
      <div class="drawer-box">
        <el-drawer
          :visible.sync="drawer"
          :direction="direction"
          :before-close="handleClose">
          <div v-for="(item,index) in filterList" :key="String(index)" :class="selectValue===item || (!selectValue && index === 0)? 'filter-item active-item':'filter-item'" @click="chooseIndex(item,index)">
            {{item}}
          </div>
        </el-drawer>
      </div>
  </div>
</template>

<script>
export default {
  name: 'FilterIndex',
  props:{
   title: String,
   filterList: Array
  },
  data () {
    return {
      drawer:false,
      direction: 'ttb',
      selectValue:"",
    }
  },
  created(){
  },
  computed:{
  },
  methods:{
    showDrawer(){
      this.drawer = true
    },
    handleClose(){
       this.drawer = false
    },
    chooseIndex(item){
       this.selectValue = item
       setTimeout(()=>{
        this.$emit('searchData',item);
        this.drawer = false
       },500)
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.filter-box{
  padding: 1rem;
}
.filter-name{
  font-size: .875rem;
  color: #4768C8 !important;
  text-align: center;
}
.el-icon-arrow-down{
  margin-left: 0.5rem;
}
.el-icon-arrow-up{
  margin-left: 0.5rem;
}
.drawer-box >>> .el-dialog__close {
  display: none !important;
}
.drawer-box >>> .el-drawer__header{
  display: none;
}
.drawer-box >>> .el-drawer__open .el-drawer.ttb{
  padding: 1rem  0.5rem !important;
  margin-top: 3.125rem !important;
  height: 15% !important;
}
.drawer-titile{
  border-bottom: 1px solid rgb(211 215 225 / 40%);
  padding-bottom: 1rem;
}
.filter-item{
  font-size: .75rem;
  color: #666666;
  height: 1.875rem;
  line-height: 1.875rem;
  text-align: left;
  padding: 0 1rem;
  margin: 0.5rem 0;
}
.active-item{
  color: #4D69C9;
  background-image: linear-gradient(270deg, rgba(230,239,255,0.20) 0%, #E6EFFF 80%, rgba(232,240,255,0.24) 100%);
}
.active-item::after{
  content: url('../assets/选中.svg');
  float: right;
}
</style>
