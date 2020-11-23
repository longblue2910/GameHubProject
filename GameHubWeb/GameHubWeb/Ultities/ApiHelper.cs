using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace GameHubWeb.Ultities
{
    public static class ApiHelper<T> where T : class
    {
        public static T HttpPostAsync(string apiName, string method, object model)
        {
            string result = string.Empty;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@$"{Common.apiUrl}/{apiName}");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = method;
            using (var streamWrite = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);
                streamWrite.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}
