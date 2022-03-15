import Vue from 'vue'
import Vuex, { Store } from 'vuex'

import common from './common/Common'
Vue.use(Vuex)

export default new Store({
  modules: {
    common: {
      namespaced: true,
      modules: {
        common
      }
    }
  }
})
