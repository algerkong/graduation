const express = require('express')
const bodyParser = require('body-parser')

const app = express()

app.use(bodyParser.urlencoded({ extended: false }))

app.use(bodyParser.json())

// app.use(function (req, res) {
//     res.setHeader('Content-Type', 'text/plain')
//     res.write('you posted:\n')
//     res.end(JSON.stringify(req.body,null,2))
// })

app.get('/user/login', (req, res) => {
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


app.get('/user', (req, res) => {
    res.send({
        msg: 'ok',
        code: 200,
        name: "刘俊杰",
        age: 18
    })
})

app.post("/user/reg", (req, res) => {
    console.log(req.body);
    //express 不能直接解析消息体
    //需要用 body-parser
    res.send({
        msg: 'ok',
        code: 200,
        err: false
    })
})

app.listen(3000, () => {
    console.log('http://127.0.0.1:3000')
})
