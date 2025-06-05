using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenityData.SerenityData.TenantsRow>;
using MyRow = SerenityData.SerenityData.TenantsRow;

namespace SerenityData.SerenityData
{
    public interface ITenantsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class TenantsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITenantsListHandler
    {
        public TenantsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}