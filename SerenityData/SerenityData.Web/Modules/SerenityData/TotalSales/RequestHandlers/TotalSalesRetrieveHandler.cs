using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenityData.SerenityData.TotalSalesRow>;
using MyRow = SerenityData.SerenityData.TotalSalesRow;

namespace SerenityData.SerenityData
{
    public interface ITotalSalesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class TotalSalesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITotalSalesRetrieveHandler
    {
        public TotalSalesRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}