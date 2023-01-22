using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using ClassChartsApi.Errors;

namespace ClassChartsApi.Api.Dataclasses
{
    internal class LoginReturn
    {
        [JsonPropertyName("success")]
        public int? Success { get; set; }

        [JsonPropertyName("data")]
        public StudentData? Data { get; set; }

        [JsonPropertyName("meta")]
        public LoginMeta? Meta { get; set; }

        public static LoginReturn Create(HttpResponseMessage msg)
        {
            var str = msg.Content.ReadAsStringAsync().Result;
            var loginReturn = JsonSerializer.Deserialize<LoginReturn>(str);
            if (loginReturn != null) return loginReturn;
            else throw new ClassChartsAPIParsingException("Deserialization of Login ran into an error");
        }
    }

    internal class LoginMeta
    {
        [JsonPropertyName("session_id")]
        public string? SessionId { get; set; }
    }

}
