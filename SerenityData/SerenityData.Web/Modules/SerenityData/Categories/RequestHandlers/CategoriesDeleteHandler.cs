using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenityData.SerenityData.CategoriesRow;

namespace SerenityData.SerenityData
{
    public interface ICategoriesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class CategoriesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriesDeleteHandler
    {
        public CategoriesDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}