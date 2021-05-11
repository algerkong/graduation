<template>
	
	<view class="content">
		<view class="top-bar">
			<cl-search class="top-search" v-model="val" placeholder="搜索图片、文章、链接" @search="btnClick">
				<cl-avatar src="" slot="prepend"></cl-avatar>
			</cl-search>
		</view>
		<view class="banner">
			<swiper :indicator-dots="true" :autoplay="true" :interval="3000" :duration="1000">
				<swiper-item v-for="item in list">
					<view class="swiper-item">
						<image :src="item" mode=""></image>
					</view>
				</swiper-item>
			</swiper>
			<view class="banner-tab">
				
			</view>
		</view>
		
	</view>
</template>

<script>
import { userLogin, SearchVirus, userLogout } from '../../network/api/user';
import types from '../../common/types';
export default {
	data() {
		return {
			active:0,
			userid: 'admin',
			password: '000000',
			val:'',
			list: [
				'https://img1.baidu.com/it/u=2346282507,2171850944&fm=26&fmt=auto&gp=0.jpg',
				'https://img1.baidu.com/it/u=167741595,2706197548&fm=26&fmt=auto&gp=0.jpg'
				,'https://img0.baidu.com/it/u=1423826927,3205389665&fm=11&fmt=auto&gp=0.jpg',
				]
		};
	},
	onLoad() {
		console.log(this.list)
	},
	methods: {
		btnClick() {
			let that = this;
			let formData = new FormData();
			formData.append('userid', this.userid);
			formData.append('password', this.password);
			formData.append('rememberLogin', 'true');
			formData.append('cookie', 'true');

			userLogin(formData).then(res => {
				console.log("请求成功",res);
				that.$store.commit(types.LOGIN);
				let data = {
					Page: 1,
					Limit: 10,
					Count: 0,
					PageCount: 0
				};
				SearchVirus(data).then(res => {
					console.log(res);
				});
			});
		}
	}
};
</script>

<style lang="scss">
	.content{
		min-height: 100vh;
		background-image: linear-gradient( 0deg,  rgb(247, 247, 247) 80%,#2C405A 85% );
	}
	.top-bar{
		padding: 20rpx;
	}
	.top-search{
		// height: 30rpx;
		background-color: #2C405A;
	}
	.banner{
		margin: 0 40rpx;
		border-radius: 20rpx 20rpx;
		overflow: hidden;
		swiper{
			height: 200rpx;
			
		}
		.swiper-item image{
			width: 100%;
			overflow: hidden;
		}
		
		.banner-tab{
			width: 100%;
			height: 100rpx;
			background-color: #FFFFFF;
		}
	}
</style>
