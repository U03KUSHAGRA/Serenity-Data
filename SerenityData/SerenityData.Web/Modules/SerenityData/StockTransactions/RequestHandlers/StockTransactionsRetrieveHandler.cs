using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenityData.SerenityData.StockTransactionsRow>;
using MyRow = SerenityData.SerenityData.StockTransactionsRow;

namespace SerenityData.SerenityData
{
    public interface IStockTransactionsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class StockTransactionsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IStockTransactionsRetrieveHandler
    {
        public StockTransactionsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}