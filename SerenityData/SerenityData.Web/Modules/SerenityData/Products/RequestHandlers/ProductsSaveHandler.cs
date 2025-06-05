using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SerenityData.SerenityData.ProductsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenityData.SerenityData.ProductsRow;

namespace SerenityData.SerenityData
{
    public interface IProductsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProductsSaveHandler
    {
        public ProductsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}