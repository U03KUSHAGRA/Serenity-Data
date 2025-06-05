using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SerenityData.SerenityData.TotalSalesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenityData.SerenityData.TotalSalesRow;

namespace SerenityData.SerenityData
{
    public interface ITotalSalesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class TotalSalesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITotalSalesSaveHandler
    {
        public TotalSalesSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}