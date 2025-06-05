using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenityData.SerenityData.StockTransactionsRow>;
using MyRow = SerenityData.SerenityData.StockTransactionsRow;

namespace SerenityData.SerenityData
{
    public interface IStockTransactionsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class StockTransactionsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IStockTransactionsListHandler
    {
        public StockTransactionsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}