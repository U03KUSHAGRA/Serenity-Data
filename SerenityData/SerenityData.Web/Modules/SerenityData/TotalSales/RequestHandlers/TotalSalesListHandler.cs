using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenityData.SerenityData.TotalSalesRow>;
using MyRow = SerenityData.SerenityData.TotalSalesRow;

namespace SerenityData.SerenityData
{
    public interface ITotalSalesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class TotalSalesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITotalSalesListHandler
    {
        public TotalSalesListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}