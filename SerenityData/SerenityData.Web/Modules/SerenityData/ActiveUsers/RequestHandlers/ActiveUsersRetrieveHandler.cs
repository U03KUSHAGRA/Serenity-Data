using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenityData.SerenityData.ActiveUsersRow>;
using MyRow = SerenityData.SerenityData.ActiveUsersRow;

namespace SerenityData.SerenityData
{
    public interface IActiveUsersRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ActiveUsersRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IActiveUsersRetrieveHandler
    {
        public ActiveUsersRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}