const express = require('express')
const app = express()

// app.use((req, res, next) => {
//     console.log('中间件');

//     let { token } = req.query
//     if (token) {
//         next()
//     } else {
//         res.send('缺少token')
//     }
// })

app.get('/test1',
    (req, res, next) => {
        console.log("中间件");
        next()
    },
    (req, res) => {
        res.send("test1")
    })

app.get('/test2', (req, res) => {
    res.send("test2")
})


app.listen(3000, () => {
    console.log('http://127.0.0.1:3000')
})
