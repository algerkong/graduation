using PhotoApi.Model;
using System.Collections.Generic;
using System.Linq;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;


namespace PhotoApi.ViewModel.FriendVMs
{
    public partial class FriendListVM : BasePagedListVM<Friend_View, FriendSearcher>
    {

        protected override IEnumerable<IGridColumn<Friend_View>> InitGridHeader()
        {
            return new List<GridColumn<Friend_View>>{
                this.MakeGridHeader(x => x.MyUser),
                this.MakeGridHeader(x => x.FriendUser),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Friend_View> GetSearchQuery()
        {
            var query = DC.Set<Friend>()
                .CheckContain(Searcher.MyUser, x => x.MyUser)
                .CheckContain(Searcher.FriendUser, x => x.FriendUser)
                .Select(x => new Friend_View
                {
                    ID = x.ID,
                    MyUser = x.MyUser,
                    FriendUser = x.FriendUser,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Friend_View : Friend
    {

    }
}
