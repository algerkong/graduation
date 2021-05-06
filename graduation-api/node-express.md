### api接口的书写
   + 接受数据
     - get  req.query
     - post req.body  需要body-parser 插件进行解析
        + 注意数据格式 json   x-www-form-urencode   formdata

### 中间件 middlewear
   + 内置中间件 static
   + 自定义中间件 (全局,局部)
   + 第三方中间件 (body-parser)  (拦截器)
   ```js
   //拦截器
    app.use((req, res, next) => {
        console.log('中间件');

        let { token } = req.query
        if (token) {
            next()
        } else {
            res.send('缺少token')
        }
    })

    //如果拦截器没有next() 则程序会卡在哪里

    app.get('/test2', (req, res) => {
        res.send("test2")
    })


    app.listen(3000, () => {
        console.log('http://127.0.0.1:3000')
    })

   ```

   中间件使用 一定要记得next

### 静态资源目录  static
