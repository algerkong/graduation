using PhotoApi.Model;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;


namespace PhotoApi.ViewModel.UserVMs
{
    public partial class UserTemplateVM : BaseTemplateVM
    {
        [Display(Name = "用户名")]
        public ExcelPropety UserName_Excel = ExcelPropety.CreateProperty<User>(x => x.UserName);
        [Display(Name = "密码")]
        public ExcelPropety Password_Excel = ExcelPropety.CreateProperty<User>(x => x.Password);
        [Display(Name = "昵称")]
        public ExcelPropety NickName_Excel = ExcelPropety.CreateProperty<User>(x => x.NickName);
        [Display(Name = "性别")]
        public ExcelPropety SexType_Excel = ExcelPropety.CreateProperty<User>(x => x.SexType);
        [Display(Name = "邮箱")]
        public ExcelPropety Email_Excel = ExcelPropety.CreateProperty<User>(x => x.Email);

        protected override void InitVM()
        {
        }

    }

    public class UserImportVM : BaseImportVM<UserTemplateVM, User>
    {

    }

}
