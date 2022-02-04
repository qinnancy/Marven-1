<template>
  <div class="list-detail">
      <img src="@/assets/城市.svg" v-if="searchName === '看活跃区域'"/>
      <img src="@/assets/产业.svg" v-else/>
  </div>
</template>

<script>
export default {
  name: 'ListDetail',
  props:{
 
  },
  data () {
    return {
     searchName:""
    }
  },
  created(){
    this.searchName = this.$route.query.searchName
    console.log(this.searchName)
  },
  computed:{
  
  },
  methods:{
    
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
