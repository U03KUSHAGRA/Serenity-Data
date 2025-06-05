using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenityData.SerenityData.ProductsRow>;
using MyRow = SerenityData.SerenityData.ProductsRow;

namespace SerenityData.SerenityData
{
    public interface IProductsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProductsRetrieveHandler
    {
        public ProductsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}