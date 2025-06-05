using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SerenityData.SerenityData.SoftwareRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenityData.SerenityData.SoftwareRow;

namespace SerenityData.SerenityData
{
    public interface ISoftwareSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class SoftwareSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISoftwareSaveHandler
    {
        public SoftwareSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}