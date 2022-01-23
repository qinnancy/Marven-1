import Vue from 'vue'
import Router from 'vue-router'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Home',
      component: () => import('../views/home/Index.vue')
    },
    {
      path: '/Detail',
      name: 'Detail',
      component: () => import('../views/home/Detail.vue')
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
    },
    {
      path: '/Agreement',
      name: 'Agreement',
      component: () => import('../views/standard/Agreement.vue')
    },
    {
      path: '/Contact',
      name: 'Contact',
      component: () => import('../views/standard/Contact.vue')
    }, {
      path: '/PrivacyPolicy',
      name: 'PrivacyPolicy',
      component: () => import('../views/standard/PrivacyPolicy.vue')
    },
  ]
})
