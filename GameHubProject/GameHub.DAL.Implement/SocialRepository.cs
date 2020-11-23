using GameHub.DAL.Interface;
using GameHub.Domain.Request.Social;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.DAL.Implement
{
    public class SocialRepository : ISocialRepository
    {
        private const string TokenValidationUrl = "http://graph.facebook.com/debug_token?input_token={0}&access_token={1}|{2}";
        private const string UserInfoUrl = "http://graph.facebook.com/me?fields=id,first_name,last_name,picture,email,birthday,hometown,gender&access_token={0}";
        private readonly FacebookAuthSettings facebookAuthSettings;
        private readonly IHttpClientFactory httpClientFactory;

        public SocialRepository(FacebookAuthSettings facebookAuthSettings, IHttpClientFactory httpClientFactory)
        {
            this.facebookAuthSettings = facebookAuthSettings;
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<FacebookTokenValidationResult> ValidateAccessTokenAsync(string accessToken)
        {
            var formmattedUrl = string.Format(TokenValidationUrl, accessToken, "183233463424827",
                "dbe4fc7a355de19e54d6e2719f147637");

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(formmattedUrl);
            httpWebRequest.Method = "GET";
            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)httpWebRequest.GetResponse();
            }
            catch (WebException ex)
            {
                response = (HttpWebResponse)ex.Response;
            }
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    using (StreamReader sr = new StreamReader(responseStream))
                    {
                        responseData = sr.ReadToEnd();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream).Dispose();
                }
                return JsonConvert.DeserializeObject<FacebookTokenValidationResult>(responseData);

            }
        }

        public async Task<FacebookUserInfoResult> GetUserInfoAsync(string accessToken)
        {
            var formmattedUrl = string.Format(UserInfoUrl, accessToken);

            var result = await httpClientFactory.CreateClient().GetAsync(formmattedUrl);
            result.EnsureSuccessStatusCode();
            var reponseAsString = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<FacebookUserInfoResult>(reponseAsString);
        }
    }
}
