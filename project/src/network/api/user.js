import { request } from '../request'

export default {
    userLogin: user => {
        return request({
            URL: '_login/Login',
            data: {

            }
        })
    }
}