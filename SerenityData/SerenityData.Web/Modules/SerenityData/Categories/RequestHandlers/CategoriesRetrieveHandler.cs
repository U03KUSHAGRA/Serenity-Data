using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenityData.SerenityData.CategoriesRow>;
using MyRow = SerenityData.SerenityData.CategoriesRow;

namespace SerenityData.SerenityData
{
    public interface ICategoriesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class CategoriesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriesRetrieveHandler
    {
        public CategoriesRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}