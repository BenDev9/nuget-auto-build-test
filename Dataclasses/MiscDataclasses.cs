using System.Text.Json.Serialization;

namespace ClassChartsApi.Dataclasses
{
    public struct Attachment
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }
        [JsonPropertyName("file_name")]
        public string FileName { get; set; }
        public string URL { get {
                if (_file != null) return _file;
                else return _url;
        }}
        public string validated_file { get; set; }
        public string teacher_note { get; set; }
        public List<object> teacher_homework_attachments { get; set; }
        public bool can_delete { get; set; }

        [JsonPropertyName("file")]
        internal string _file { get; set; }

        [JsonPropertyName("url")]
        internal string _url { get; set; }
    }
}