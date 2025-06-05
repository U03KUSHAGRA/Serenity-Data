using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenityData.SerenityData.SuppliersRow>;
using MyRow = SerenityData.SerenityData.SuppliersRow;

namespace SerenityData.SerenityData
{
    public interface ISuppliersRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class SuppliersRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISuppliersRetrieveHandler
    {
        public SuppliersRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}