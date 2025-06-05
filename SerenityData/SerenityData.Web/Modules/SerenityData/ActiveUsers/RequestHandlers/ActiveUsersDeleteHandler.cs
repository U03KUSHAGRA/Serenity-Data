using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenityData.SerenityData.ActiveUsersRow;

namespace SerenityData.SerenityData
{
    public interface IActiveUsersDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ActiveUsersDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IActiveUsersDeleteHandler
    {
        public ActiveUsersDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}