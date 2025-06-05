using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenityData.SerenityData.SoftwareRow>;
using MyRow = SerenityData.SerenityData.SoftwareRow;

namespace SerenityData.SerenityData
{
    public interface ISoftwareRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class SoftwareRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISoftwareRetrieveHandler
    {
        public SoftwareRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}