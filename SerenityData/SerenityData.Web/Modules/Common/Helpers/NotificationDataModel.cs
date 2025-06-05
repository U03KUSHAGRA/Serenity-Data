namespace SerenityData.Common
{
    public class NotificationDataModel
    {
        public string to { get; set; }
        public RequestDataModel data { get; set; }
        public RequestNotificationDataModel notification { get; set; }
    }
    

    public class RequestDataModel
    {
        public string ShortDesc { get; set; }
        public string IncidentNo { get; set; }
        public string Description { get; set; }

    }
    public class RequestNotificationDataModel
    {
        public string title { get; set; }
        public string Body { get; set; }
        public string sound { get; set; }

    }
}
