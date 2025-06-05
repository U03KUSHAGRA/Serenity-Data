using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SerenityData.SerenityData.SuppliersRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenityData.SerenityData.SuppliersRow;

namespace SerenityData.SerenityData
{
    public interface ISuppliersSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class SuppliersSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISuppliersSaveHandler
    {
        public SuppliersSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}