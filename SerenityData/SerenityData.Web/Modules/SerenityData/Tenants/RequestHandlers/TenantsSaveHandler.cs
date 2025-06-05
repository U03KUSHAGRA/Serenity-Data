using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SerenityData.SerenityData.TenantsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenityData.SerenityData.TenantsRow;

namespace SerenityData.SerenityData
{
    public interface ITenantsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class TenantsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITenantsSaveHandler
    {
        public TenantsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}