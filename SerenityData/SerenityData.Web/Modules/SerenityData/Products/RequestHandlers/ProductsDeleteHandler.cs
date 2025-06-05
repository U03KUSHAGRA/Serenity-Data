using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenityData.SerenityData.ProductsRow;

namespace SerenityData.SerenityData
{
    public interface IProductsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProductsDeleteHandler
    {
        public ProductsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}