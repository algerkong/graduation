using PhotoApi.Model;
using WalkingTec.Mvvm.Core;


namespace PhotoApi.ViewModel.FriendVMs
{
    public partial class FriendVM : BaseCRUDVM<Friend>
    {

        public FriendVM()
        {
        }

        protected override void InitVM()
        {
        }

        public override void DoAdd()
        {
            base.DoAdd();
        }

        public override void DoEdit(bool updateAllFields = false)
        {
            base.DoEdit(updateAllFields);
        }

        public override void DoDelete()
        {
            base.DoDelete();
        }
    }
}
