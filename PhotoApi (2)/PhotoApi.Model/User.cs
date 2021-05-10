using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace PhotoApi.Model
{
    public enum SexTypeEnum
    {
        [Display(Name = "男")]
        man,
        [Display(Name = "女")]
        woman
    }
    public class User : BasePoco
    {
        [Display(Name = "用户名")]
        [Required(ErrorMessage = "用户名不能为空")]
        public string UserName { get; set; }

        [Display(Name = "密码")]
        [Required(ErrorMessage = "密码不能为空")]
        public string Password { get; set; }

        [Display(Name = "昵称")]
        [Required(ErrorMessage = "昵称不能为空")]
        public string NickName { get; set; }

        [Display(Name = "性别")]
        [Required(ErrorMessage = "性别不能为空")]
        public SexTypeEnum? SexType { get; set; }

        [Display(Name = "邮箱")]
        [Required(ErrorMessage = "邮箱不能为空")]
        public string Email { get; set; }

        [Display(Name = "头像")]
        public FileAttachment Photo { get; set; }
        public Guid? PhotoId { get; set; }
    }
}
