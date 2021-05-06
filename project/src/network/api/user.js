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

export function SearchVirus(data) {
    return request({
        method: 'post',
        url: '/Virus/Search',
        data: data
    })
}