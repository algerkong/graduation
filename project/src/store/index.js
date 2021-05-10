import Vue from 'vue'
import Vuex from 'vuex'
import types from 'common/types'

Vue.use(Vuex)

const state = {
    user: {},
    isLogin: null
}

const mutations = {
    [types.LOGIN]: (state) => {
        state.isLogin = true;

    },
    [types.LOGOUT]: (state) => {
        state.isLogin = false;

    },
}

const store = new Vuex.Store({
    state: state,
    mutations: mutations
})

export default store
