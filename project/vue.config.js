module.exports = {
  configureWebpack:{
    resolve:{
      extensions:[],
      alias:{
        'assets':'@/assets',
        'components':'@/components',
        'network':'@/network',
        'common':'@/common',
        'router':'@/router',
        'views':'@/views',
      }
    }
  }

}