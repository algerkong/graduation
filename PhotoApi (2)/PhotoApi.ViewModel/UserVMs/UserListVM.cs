using PhotoApi.Model;
using System.Collections.Generic;
using System.Linq;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;


namespace PhotoApi.ViewModel.UserVMs
{
    public partial class UserListVM : BasePagedListVM<User_View, UserSearcher>
    {

        protected override IEnumerable<IGridColumn<User_View>> InitGridHeader()
        {
            return new List<GridColumn<User_View>>{
                this.MakeGridHeader(x => x.UserName),
                this.MakeGridHeader(x => x.Password),
                this.MakeGridHeader(x => x.NickName),
                this.MakeGridHeader(x => x.SexType),
                this.MakeGridHeader(x => x.Email),
                this.MakeGridHeader(x => x.PhotoId).SetFormat(PhotoIdFormat),
                this.MakeGridHeaderAction(width: 200)
            };
        }
        private List<ColumnFormatInfo> PhotoIdFormat(User_View entity, object val)
        {
            return new List<ColumnFormatInfo>
            {
                ColumnFormatInfo.MakeDownloadButton(ButtonTypesEnum.Button,entity.PhotoId),
                ColumnFormatInfo.MakeViewButton(ButtonTypesEnum.Button,entity.PhotoId,640,480),
            };
        }


        public override IOrderedQueryable<User_View> GetSearchQuery()
        {
            var query = DC.Set<User>()
                .CheckContain(Searcher.UserName, x => x.UserName)
                .CheckContain(Searcher.NickName, x => x.NickName)
                .CheckEqual(Searcher.SexType, x => x.SexType)
                .CheckContain(Searcher.Email, x => x.Email)
                .Select(x => new User_View
                {
                    ID = x.ID,
                    UserName = x.UserName,
                    Password = x.Password,
                    NickName = x.NickName,
                    SexType = x.SexType,
                    Email = x.Email,
                    PhotoId = x.PhotoId,
                })
                .OrderBy(x => x.ID);
            return query;
        }
    }

    public class User_View : User
    {

    }
}
