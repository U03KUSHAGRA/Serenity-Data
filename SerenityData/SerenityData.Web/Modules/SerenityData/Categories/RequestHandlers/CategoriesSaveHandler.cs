using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SerenityData.SerenityData.CategoriesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenityData.SerenityData.CategoriesRow;

namespace SerenityData.SerenityData
{
    public interface ICategoriesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class CategoriesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriesSaveHandler
    {
        public CategoriesSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}