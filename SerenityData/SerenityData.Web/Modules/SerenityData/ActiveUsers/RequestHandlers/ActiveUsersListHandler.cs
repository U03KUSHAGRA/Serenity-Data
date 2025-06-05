using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenityData.SerenityData.ActiveUsersRow>;
using MyRow = SerenityData.SerenityData.ActiveUsersRow;

namespace SerenityData.SerenityData
{
    public interface IActiveUsersListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ActiveUsersListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IActiveUsersListHandler
    {
        public ActiveUsersListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}