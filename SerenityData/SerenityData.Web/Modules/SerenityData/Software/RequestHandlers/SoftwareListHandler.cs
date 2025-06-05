using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenityData.SerenityData.SoftwareRow>;
using MyRow = SerenityData.SerenityData.SoftwareRow;

namespace SerenityData.SerenityData
{
    public interface ISoftwareListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class SoftwareListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISoftwareListHandler
    {
        public SoftwareListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}