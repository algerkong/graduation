import axios from 'axios'
import { Toast } from 'vant'
import store from '../store'
import baseUrl from 'common/const'
import { reject, resolve } from 'core-js/fn/promise'


const tip = msg => {
    Toast({
        message: msg,
        duration: 1000,
        forbidClick: true
    });
}

const toUser = () => {
    router.replace({
        path: '/user',
        query: {
            redirect: router.currentRoute.fullPath
        }
    });
}


/** 
 * 请求失败后的错误统一处理 
 * @param {Number} status 请求失败的状态码
 */
const errorHandle = (status, other) => {
    // 状态码判断
    switch (status) {
        // 401: 未登录状态，跳转登录页
        case 401:
            toUser();
            break;
        // 403 token过期
        // 清除token并跳转登录页
        case 403:
            tip('登录过期，请重新登录');
            localStorage.removeItem('token');
            store.commit('loginSuccess', null);
            setTimeout(() => {
                toLogin();
            }, 1000);
            break;
        // 404请求不存在
        case 404:
            tip('请求的资源不存在');
            break;
        default:
            console.log(other);
    }
}



export function request(config, success, failure) {
    const instance = axios.create({
        baseURL: baseUrl,
        timeout: 5000
    })

    instance.interceptors.request.use(config => {
        return config
    }, err => {
        tip('请先登陆')
    })


    instance.interceptors.response.baseUrl(res => {
        return res.data
    }, err => {
        if (err) {
            errorHandle(err.status)
        } else {
            if (!window.navigator.onLine) {
                store.commit('changeNetwork', false)
            }
        }
    })

    return instance(config)
}

