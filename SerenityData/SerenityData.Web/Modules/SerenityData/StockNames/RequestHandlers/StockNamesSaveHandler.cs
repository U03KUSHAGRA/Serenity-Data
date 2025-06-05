using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SerenityData.SerenityData.StockNamesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenityData.SerenityData.StockNamesRow;

namespace SerenityData.SerenityData
{
    public interface IStockNamesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class StockNamesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IStockNamesSaveHandler
    {
        public StockNamesSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}