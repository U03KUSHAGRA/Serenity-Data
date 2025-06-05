using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenityData.SerenityData.StockNamesRow>;
using MyRow = SerenityData.SerenityData.StockNamesRow;

namespace SerenityData.SerenityData
{
    public interface IStockNamesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class StockNamesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IStockNamesRetrieveHandler
    {
        public StockNamesRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}