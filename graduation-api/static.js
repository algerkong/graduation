const express = require('express')
const app = express()

const path = require('path')


app.use('/public',express.static(path.join(__dirname,'./static')))



app.listen(3000, () => {
    console.log('start');
    
})

