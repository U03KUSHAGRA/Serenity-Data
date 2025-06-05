using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenityData.SerenityData.SuppliersRow;

namespace SerenityData.SerenityData
{
    public interface ISuppliersDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class SuppliersDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISuppliersDeleteHandler
    {
        public SuppliersDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}