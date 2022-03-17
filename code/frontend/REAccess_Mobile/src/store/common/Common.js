const state = {
  routerName: '',
  searchName: '',
  filterName: '',
  fileName: '',
}

const getters = {}

const mutations = {
  setRouterName (state, value) {
    state.routerName = value
  },
  setSearchName (state, value) {
    state.searchName = value
  },
  setFilterName (state, value) {
    state.filterName = value
  },
  setFileName (state, value) {
    state.fileName = value
  },
}

const actions = {}

export default {
  namespaced: true,
  state,
  getters,
  mutations,
  actions
}
