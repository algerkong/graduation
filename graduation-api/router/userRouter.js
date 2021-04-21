const express = require('express')
const router = express.Router()

router.get('/login', (req, res) => {
    console.log('你好')
    console.log(req.query)
    if (req.query.name == "liujunjie" && req.query.pass == "123") {
        console.log('登陆成功');
    } else {
        console.log('登陆失败');
    }
    res.send({
        msg: 'ok',
        code: 200,
        err: false
    })
})


router.get('/user/add', (req, res) => {
    res.send({
        msg: 'ok',
        code: 200,
        name: "刘俊杰",
        age: 18
    })
})



module.exports = router
