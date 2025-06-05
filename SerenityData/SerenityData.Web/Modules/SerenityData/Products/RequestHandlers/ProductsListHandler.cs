using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenityData.SerenityData.ProductsRow>;
using MyRow = SerenityData.SerenityData.ProductsRow;

namespace SerenityData.SerenityData
{
    public interface IProductsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProductsListHandler
    {
        public ProductsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}