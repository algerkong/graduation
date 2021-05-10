using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;


namespace PhotoApi.ViewModel.FriendVMs
{
    public partial class FriendSearcher : BaseSearcher
    {
        [Display(Name = "用户")]
        public String MyUser { get; set; }
        [Display(Name = "好友")]
        public String FriendUser { get; set; }

        protected override void InitVM()
        {
        }

    }
}
