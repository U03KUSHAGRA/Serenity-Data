using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenityData.SerenityData.SoftwareRow;

namespace SerenityData.SerenityData
{
    public interface ISoftwareDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class SoftwareDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISoftwareDeleteHandler
    {
        public SoftwareDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}