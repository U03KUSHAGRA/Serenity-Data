using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SerenityData.SerenityData.StockTransactionsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenityData.SerenityData.StockTransactionsRow;

namespace SerenityData.SerenityData
{
    public interface IStockTransactionsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class StockTransactionsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IStockTransactionsSaveHandler
    {
        public StockTransactionsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}