import Vue from 'vue'
import Router from 'vue-router'
import HelloWorld from '@/components/HelloWorld'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Home',
      component: () => import('../views/home/Index.vue')
    },
    {
      path: '/SingleIndex',
      name: 'SingleIndex',
      component: () => import('../views/singleIndex/Index.vue')
    },
    {
      path: '/CityRanking',
      name: 'CityRanking',
      component: () => import('../views/cityRanking/Index.vue')
    },
    {
    path: '/IndustrialInvest',
      name: 'IndustrialInvest',
      component: () => import('../views/industrialInvest/Index.vue')
    },
    {
      path: '/SpecialPolicies',
      name: 'SpecialPolicies',
      component: () => import('../views/specialPolicies/Index.vue')
    }
  ]
})
