using ClassChartsApi.Api.Dataclasses;
using ClassChartsApi.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassChartsApi.Dataclasses
{
    internal class PingData : StudentData
    {
        [JsonPropertyName("announcements_count")]
        public int? AnnouncementsCount { get; set; }

        [JsonPropertyName("messages_count")]
        public int? MessagesCount { get; set; }

        [JsonPropertyName("pusher_channel_name")]
        public string? PusherChannelName { get; set; }

        [JsonPropertyName("has_birthday")]
        public bool? HasBirthday { get; set; }

        [JsonPropertyName("has_new_survey")]
        public bool? HasNewServay { get; set; }

        [JsonPropertyName("survey_id")]
        public string? SurveyId { get; set; }
    }

    public struct PingMeta
    {
        [JsonPropertyName("session_id")]
        public string? SessionID { get; set; }
        [JsonPropertyName("version")]
        public string? Version { get; set; }
    }

    internal class PingReturn
    {
        public int success { get; set; }
        public PingData? data { get; set; }
        public PingMeta meta { get; set; }

        public static PingReturn Create(HttpResponseMessage msg)
        {
            var str = msg.Content.ReadAsStringAsync().Result;
            var pingReturn = JsonSerializer.Deserialize<PingReturn>(str);
            if (pingReturn != null) return pingReturn;
            else throw new ClassChartsAPIParsingException("Deserialization of Ping ran into an error");
        }
    }
}
