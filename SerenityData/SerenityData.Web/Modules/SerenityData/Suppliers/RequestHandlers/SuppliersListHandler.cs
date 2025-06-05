using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenityData.SerenityData.SuppliersRow>;
using MyRow = SerenityData.SerenityData.SuppliersRow;

namespace SerenityData.SerenityData
{
    public interface ISuppliersListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class SuppliersListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISuppliersListHandler
    {
        public SuppliersListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}