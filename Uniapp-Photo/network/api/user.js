import { request } from '../request'


export function userLogin(formData) {
    return request({
        method: 'post',
        url: '/_login/Login',
        data: formData,
        headers: {
            'Content-Type': 'multipart/form-data'
        }
    })
}


export function userLogout(id) {
    return request({
        method: 'get',
        url: '/_login/Logout/' + id
    })
}

export function SearchVirus(data) {
    return request({
        method: 'post',
        url: '/Virus/Search',
        data: data
    })
}