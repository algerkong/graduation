using PhotoApi.Model;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;


namespace PhotoApi.ViewModel.FriendVMs
{
    public partial class FriendTemplateVM : BaseTemplateVM
    {
        [Display(Name = "用户")]
        public ExcelPropety MyUser_Excel = ExcelPropety.CreateProperty<Friend>(x => x.MyUser);
        [Display(Name = "好友")]
        public ExcelPropety FriendUser_Excel = ExcelPropety.CreateProperty<Friend>(x => x.FriendUser);

        protected override void InitVM()
        {
        }

    }

    public class FriendImportVM : BaseImportVM<FriendTemplateVM, Friend>
    {

    }

}
