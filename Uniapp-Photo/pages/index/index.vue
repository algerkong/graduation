<template>
	<view class="content"><button class="btn" @click="btnClick">按钮</button></view>
</template>

<script>
import { userLogin, SearchVirus, userLogout } from '../../network/api/user';
import types from '../../common/types';
export default {
	data() {
		return {
			userid: 'admin',
			password: '000000'
		};
	},
	onLoad() {},
	methods: {
		btnClick() {
			let that = this;
			let formData = new FormData();
			formData.append('userid', this.userid);
			formData.append('password', this.password);
			formData.append('rememberLogin', 'true');
			formData.append('cookie', 'true');
			
			
			
			
			// console.log("点击")
			// uni.request({
			//     url: 'http://127.0.0.1:9311/api/_login/Login', //仅为示例，并非真实接口地址。
			// 		method:'POST',
			//     data: formData,
			//     header: {
			//         'Content-Type': 'multipart/form-data' //自定义请求头信息
			//     },
			//     success: (res) => {
			//         console.log("请求",res.data);
			//         this.text = 'request success';
			//     }
			// });

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

<style></style>
