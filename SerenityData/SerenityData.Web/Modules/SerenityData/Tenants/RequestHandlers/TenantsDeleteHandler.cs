using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenityData.SerenityData.TenantsRow;

namespace SerenityData.SerenityData
{
    public interface ITenantsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class TenantsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITenantsDeleteHandler
    {
        public TenantsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}