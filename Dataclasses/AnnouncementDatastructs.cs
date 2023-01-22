using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassChartsApi.Dataclasses
{
    public struct Announcement
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("school_name")]
        public string SchoolName { get; set; }

        [JsonPropertyName("teacher_name")]
        public string TeacherName { get; set; }

        [JsonPropertyName("school_logo")]
        public string SchoolLogo { get; set; }

        [JsonPropertyName("sticky")]
        public string Sticky { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonPropertyName("attachments")]
        public List<Attachment> Attachments { get; set; }

        [JsonPropertyName("for_pupils")]
        public List<object> ForPupils { get; set; }

        [JsonPropertyName("comment_visibility")]
        public string CommentVisibility { get; set; }

        [JsonPropertyName("allow_comments")]
        public string AllowComments { get; set; }

        [JsonPropertyName("allow_reactions")]
        public string AllowReactions { get; set; }

        [JsonPropertyName("allow_consent")]
        public string AllowConsent { get; set; }

        [JsonPropertyName("priority_pinned")]
        public string PriorityPinned { get; set; }

        [JsonPropertyName("requires_consent")]
        public string RequiresConsent { get; set; }

        [JsonPropertyName("can_change_consent")]
        public bool CanChangeConsent { get; set; }

        [JsonPropertyName("consent")]
        public object Consent { get; set; }

        [JsonPropertyName("pupil_consents")]
        public List<object> PupilConsents { get; set; }
    }

    internal class AnnouncementsReturn
    {
        [JsonPropertyName("success")]
        public int Success { get; set; }

        [JsonPropertyName("data")]
        public List<Announcement>? Data { get; set; }

        [JsonPropertyName("meta")]
        public List<object>? Meta { get; set; }
    }
}
