using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SerenityData.SerenityData.ActiveUsersRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenityData.SerenityData.ActiveUsersRow;

namespace SerenityData.SerenityData
{
    public interface IActiveUsersSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ActiveUsersSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IActiveUsersSaveHandler
    {
        public ActiveUsersSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}