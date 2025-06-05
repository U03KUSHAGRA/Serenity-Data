using Serenity.Services;

namespace SerenityData
{
        public class GetLastOrderNumberRequest : ServiceRequest
        {
        public int OrderNumber { get; set; }
    }

        public class GetNextOrderNumberResponse : ServiceResponse
        {
            public long OrderNumber { get; set; }
            public string Serial { get; set; }
        }
}
