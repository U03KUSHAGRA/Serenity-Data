using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenityData.SerenityData.StockNamesRow;

namespace SerenityData.SerenityData
{
    public interface IStockNamesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class StockNamesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IStockNamesDeleteHandler
    {
        public StockNamesDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}