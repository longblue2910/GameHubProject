using GameHub.Domain.Common1;
using GameHub.Domain.Request.User;
using GameHub.WEB.Ultilities;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.WEB.Services
{
    public class UserApiClient : IUserApiClient
    {
        private readonly IHttpClientFactory httpClientFactory;
        private readonly IHttpContextAccessor httpContextAccessor;

        public UserApiClient(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor)
        {
            this.httpClientFactory = httpClientFactory;
            this.httpContextAccessor = httpContextAccessor;
        }
        public async Task<string> Authenticate(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var client = httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44373/api/");
            var response = await client.PostAsync("User/authenticate", httpContent);
            var token = await response.Content.ReadAsStringAsync();

            return token;
        }

        public async Task<UserViewModel> GetById(string id)
        {
            var sessions = httpContextAccessor.HttpContext.Session.GetString("Token");
            var client = httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", sessions);

            client.BaseAddress = new Uri("https://localhost:44373/api/");
            var response = await client.GetAsync($"User/{id}");
            var body = await response.Content.ReadAsStringAsync();
            var user = JsonConvert.DeserializeObject<UserViewModel>(body);

            return user;
        }

        public async Task<UserViewModel> GetByUserName(string UserName)
        {
            var sessions = httpContextAccessor.HttpContext.Session.GetString("Token");
            var client = httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", sessions);

            client.BaseAddress = new Uri("https://localhost:44373/api/");
            var response = await client.GetAsync($"User/get/{UserName}");
            var body = await response.Content.ReadAsStringAsync();
            var user = JsonConvert.DeserializeObject<UserViewModel>(body);

            return user;
        }

        public async Task<PagedResult<UserViewModel>> GetUserPadings(GetUserPagingRequest request)
        {
            var client = httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", request.BearerToken);

            client.BaseAddress = new Uri("https://localhost:44373/api/");
            var response = await client.GetAsync($"User/paging?Keyword={request.Keyword}&PageIndex={request.PageIndex}" +
                $"&PageSize={request.PageSize}&BearerToken={request.BearerToken}");
            var body = await response.Content.ReadAsStringAsync();
            var users = JsonConvert.DeserializeObject<PagedResult<UserViewModel>>(body);

            return users;
        }

        public async Task<string> RegisterUser(RegisterRequest registerRequest)
        {
            var client = httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44373/api/");

            var json = JsonConvert.SerializeObject(registerRequest);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("User/register", httpContent);

            return await response.Content.ReadAsStringAsync();
        }

        public async Task<bool> UpdateUser(string id, UserUpdateRequest registerRequest)
        {
            var client = httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44373/api/");
            var sessions = httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", sessions);

            var json = JsonConvert.SerializeObject(registerRequest);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PutAsync($"User/{id}", httpContent);
            return response.IsSuccessStatusCode;
        }
    }
}
