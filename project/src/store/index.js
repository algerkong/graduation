import Vue from 'vue'
import Vuex from 'vuex'
import types from 'common/types'

Vue.use(Vuex)

const state = {
    user: {},
    token: null
}

const mutations = {
    [types.LOGIN]: (state, data) => {
        state.token = data;
        console.log(data);
    },
    [types.LOGOUT]: (state) => {
        state.token = null;
    },
}

const store = new Vuex.Store({
    state: state,
    mutations: mutations
})

export default store
