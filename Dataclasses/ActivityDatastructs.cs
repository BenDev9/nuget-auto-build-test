using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassChartsApi.Dataclasses
{
    public struct Style
    {
        [JsonPropertyName("border_color")]
        public object BorderColor { get; set; }

        [JsonPropertyName("custom_class")]
        public object CustomClass { get; set; }
    }

    public struct ActivityPoint
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("polarity")]
        public string Polarity { get; set; }

        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        [JsonPropertyName("score")]
        public int Score { get; set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }

        [JsonPropertyName("timestamp_custom_time")]
        public object TimestampCustomTime { get; set; }

        [JsonPropertyName("style")]
        public Style Style { get; set; }

        [JsonPropertyName("pupil_name")]
        public string PupilName { get; set; }

        [JsonPropertyName("lesson_name")]
        public string LessonName { get; set; }

        [JsonPropertyName("teacher_name")]
        public string TeacherName { get; set; }

        [JsonPropertyName("room_name")]
        public object RoomName { get; set; }

        [JsonPropertyName("note")]
        public string Note { get; set; }

        [JsonPropertyName("_can_delete")]
        public bool CanDelete { get; set; }

        [JsonPropertyName("detention_date")]
        public object DetentionDate { get; set; }

        [JsonPropertyName("detention_time")]
        public object DetentionTime { get; set; }

        [JsonPropertyName("detention_location")]
        public object DetentionLocation { get; set; }

        [JsonPropertyName("detention_type")]
        public object DetentionType { get; set; }
    }

    internal struct ActivityMeta
    {
        [JsonPropertyName("start_date")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("end_date")]
        public DateTime EndDate { get; set; }

        [JsonPropertyName("last_id")]
        public bool LastId { get; set; }

        [JsonPropertyName("step_size")]
        public string StepSize { get; set; }

        [JsonPropertyName("detention_alias_uc")]
        public string DetentionAliasUc { get; set; }
    }

    internal class ActivityReturn
    {
        [JsonPropertyName("success")]
        public int Success { get; set; }

        [JsonPropertyName("data")]
        public List<ActivityPoint>? Data { get; set; }

        [JsonPropertyName("meta")]
        public ActivityMeta? Meta { get; set; }
    }
}
