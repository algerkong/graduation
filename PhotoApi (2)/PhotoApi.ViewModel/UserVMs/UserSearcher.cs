using PhotoApi.Model;
using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;


namespace PhotoApi.ViewModel.UserVMs
{
    public partial class UserSearcher : BaseSearcher
    {
        [Display(Name = "用户名")]
        public String UserName { get; set; }
        [Display(Name = "昵称")]
        public String NickName { get; set; }
        [Display(Name = "性别")]
        public SexTypeEnum? SexType { get; set; }
        [Display(Name = "邮箱")]
        public String Email { get; set; }

        protected override void InitVM()
        {
        }

    }
}
