using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenityData.SerenityData.TotalSalesRow;

namespace SerenityData.SerenityData
{
    public interface ITotalSalesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class TotalSalesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITotalSalesDeleteHandler
    {
        public TotalSalesDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}