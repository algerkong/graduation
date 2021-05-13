module.exports = {
  configureWebpack: {
    resolve: {
      extensions: [],
      alias: {
        'assets': '@/assets',
        'components': '@/components',
        'network': '@/network',
        'common': '@/common',
        'router': '@/router',
        'views': '@/views',
        'store': '@/store'
      }
    }
  },
  devServer: {
    proxy: {
      '/api': {
        target: 'http://127.0.0.1:9311/api/',
        changeOrigin: true,
        pathRewrite: {
          '/api': ''
        }
      }
    }
  }

}