using PhotoApi.Model;
using WalkingTec.Mvvm.Core;


namespace PhotoApi.ViewModel.UserVMs
{
    public partial class UserVM : BaseCRUDVM<User>
    {

        public UserVM()
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
