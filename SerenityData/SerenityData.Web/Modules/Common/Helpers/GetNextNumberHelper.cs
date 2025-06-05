using Serenity.Data;
using System.Data;
using System.Linq;

namespace SerenityData
{
    public static class GetNextNumberHelper
    {
        public static GetNextOrderNumberResponse GetLastOrderNumber(IDbConnection connection, GetLastOrderNumberRequest request)
        {
            int LocalOrderNumber = request.OrderNumber;

            string FunctionQuery = "Select dbo.ReturnLastOrderNumber()";

            var max = connection.Query<int?>(FunctionQuery, null).FirstOrDefault();

            var response = new GetNextOrderNumberResponse();

            if (max == null) max = 0;
            long l = (long)max;
            //l++;

            response.OrderNumber = l;
            response.Serial = response.OrderNumber.ToString();

            return response;
        }
    }
}
