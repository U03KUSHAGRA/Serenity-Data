
using System.IO;
using System.Net.Mail;
using System.Net;
using Serenity.Data;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Data;

using System.Net.Mime;
using Newtonsoft.Json;
namespace SerenityData.Common
{
    public class NotificationHelper
    {
        public static String SendNotificationFromFirebaseCloud(string to, string title, string Body)
        {
            var result = "-1";
            var webAddr = "https://fcm.googleapis.com/fcm/send";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Headers.Add(HttpRequestHeader.Authorization, "key=AAAAhvx1Q3I:APA91bFuwZNQGVTYDRsi7AtK2mNHI0Yi_yl-zaaAZ1M3guujIQ1R3W35Y_5_73TyE2NH_ZrmreyPM10tPZLTEXRHvJBlA4Z4yJDzeMF02ybMtRKUWquZqHI30Er_Yr88hOp-8_mJzTwM");
            httpWebRequest.Method = "POST";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                NotificationDataModel smsQueue = new NotificationDataModel
                {
                    to = to,
                    data = new RequestDataModel
                    {
                        ShortDesc = "any Desc",
                        IncidentNo = "any number",
                        Description = "any number",

                    },
                    notification = new RequestNotificationDataModel
                    {
                        title = title,
                        Body = Body,
                        sound = "default"
                    }

                };
                string json = JsonConvert.SerializeObject(smsQueue);

                streamWriter.Write(json);
                streamWriter.Flush();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            return result;
        }
    }
}
