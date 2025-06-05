using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenityData.SerenityData.StockNamesRow>;
using MyRow = SerenityData.SerenityData.StockNamesRow;

namespace SerenityData.SerenityData
{
    public interface IStockNamesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class StockNamesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IStockNamesListHandler
    {
        public StockNamesListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}