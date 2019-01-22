using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using WebShop.Models;

namespace WebShop.Helper
{
    public static class RequestHelper
    {

        public static string SendPostRequest(string apiUrl, object data)
        {
            using (WebClient client = new WebClient())
            {
                string inputJson = (new JavaScriptSerializer()).Serialize(data);
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                var json = client.UploadString(apiUrl, inputJson);
                return json;     
            }
        }

        public static string GetRequest(string apiUrl)
        {
            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                return client.DownloadString(apiUrl);
            }
        }
    }
}