using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenityData.SerenityData.StockTransactionsRow;

namespace SerenityData.SerenityData
{
    public interface IStockTransactionsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class StockTransactionsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IStockTransactionsDeleteHandler
    {
        public StockTransactionsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}