using PhotoApi.Model;
using WalkingTec.Mvvm.Core;


namespace PhotoApi.ViewModel.UserVMs
{
    public partial class UserBatchVM : BaseBatchVM<User, User_BatchEdit>
    {
        public UserBatchVM()
        {
            ListVM = new UserListVM();
            LinkedVM = new User_BatchEdit();
        }

    }

    /// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class User_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
