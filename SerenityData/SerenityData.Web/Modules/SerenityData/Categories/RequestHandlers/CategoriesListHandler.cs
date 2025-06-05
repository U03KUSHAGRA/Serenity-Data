using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenityData.SerenityData.CategoriesRow>;
using MyRow = SerenityData.SerenityData.CategoriesRow;

namespace SerenityData.SerenityData
{
    public interface ICategoriesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CategoriesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriesListHandler
    {
        public CategoriesListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}