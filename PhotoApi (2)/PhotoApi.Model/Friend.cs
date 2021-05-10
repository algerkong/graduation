using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace PhotoApi.Model
{
    public class Friend : BasePoco
    {
        [Display(Name = "用户")]
        public string MyUser { get; set; }

        [Display(Name = "好友")]
        public string FriendUser { get; set; }

    }
}
