using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenityData.SerenityData.TenantsRow>;
using MyRow = SerenityData.SerenityData.TenantsRow;

namespace SerenityData.SerenityData
{
    public interface ITenantsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class TenantsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITenantsRetrieveHandler
    {
        public TenantsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}