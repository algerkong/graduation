using PhotoApi.Model;
using WalkingTec.Mvvm.Core;


namespace PhotoApi.ViewModel.FriendVMs
{
    public partial class FriendBatchVM : BaseBatchVM<Friend, Friend_BatchEdit>
    {
        public FriendBatchVM()
        {
            ListVM = new FriendListVM();
            LinkedVM = new Friend_BatchEdit();
        }

    }

    /// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class Friend_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
