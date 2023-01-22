using ClassChartsApi.Api.Dataclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassChartsApi.Errors;
using ClassChartsApi.Dataclasses;

namespace ClassChartsApi
{
    internal class ClasschartsHTTPClient
    {
        int? student_id;
        string code;
        DateTime dob;

        private HttpClient client;
        private Uri baseAddress = new Uri("https://www.classcharts.com/apiv2student");

        public ClasschartsHTTPClient(string code, DateTime dob)
        {
            client = new HttpClient();
            this.code = code;
            this.dob = dob;
        }

        public async Task<HttpResponseMessage> AuthorizedRequest(HttpMethod verb, string url, Dictionary<string, string> data)
        {
            HttpRequestMessage httpRequest = new HttpRequestMessage(verb, url)
            {
                RequestUri = new Uri(baseAddress + url),
                Content = new FormUrlEncodedContent(data)
            };

            HttpResponseMessage res = await client.SendAsync(httpRequest);

            if (res.IsSuccessStatusCode)
            {
                return res;
            }
            else
            {
                throw new ClassChartsAPIException($"{res.StatusCode}: {await res.Content.ReadAsStringAsync()}");
            }
        }

        public async Task<HttpResponseMessage> AuthorizedRequest(HttpMethod verb, string url)
        {
            HttpRequestMessage httpRequest = new HttpRequestMessage(verb, new Uri(baseAddress + url));
            var res = await client.SendAsync(httpRequest);

            if (res.IsSuccessStatusCode)
            {
                return res;
            }
            else
            {
                throw new ClassChartsAPIException($"{res.StatusCode}: {await res.Content.ReadAsStringAsync()}");
            }
        }

        public LoginReturn Login()
        {
            var data = new Dictionary<string, string>()
                {
                    { "_method", "POST" },
                    { "code", code.ToUpper() },
                    { "dob", dob.ToString("dd/MM/yyyy") },
                    { "remember_me", "1" },
                    { "recaptcha-token", "no-token-avaliable" }
                };

            HttpRequestMessage httpRequest = new()
            {
                Method = HttpMethod.Post,
                Content = new FormUrlEncodedContent(data),
                RequestUri = new Uri(baseAddress + "/login")
            };

            var response = client.Send(httpRequest);

            var loginReturn = LoginReturn.Create(response);

            if(loginReturn.Data != null && loginReturn.Meta != null)
            {
                student_id = loginReturn.Data.Id;

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", loginReturn.Meta.SessionId);

                return loginReturn;
            }
            else
            {
                throw new ClassChartsAPIException();
            }
        }
    
        public async Task<PingReturn> Ping()
        {
            var data = new Dictionary<string, string>()
            {
                { "include_data", "true" }
            };

            HttpResponseMessage res = await this.AuthorizedRequest(HttpMethod.Post, "/ping", data);

            PingReturn ret = PingReturn.Create(res);

            return ret;
        }
    }
}
