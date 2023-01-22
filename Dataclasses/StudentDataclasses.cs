using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassChartsApi.Api.Dataclasses
{
    public class StudentData
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        [JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        [JsonPropertyName("display_behaviour")]
        public bool? DisplayBehaviour { get; set; }

        [JsonPropertyName("display_parent_behaviour")]
        public bool? DisplayParentBehaviour { get; set; }

        [JsonPropertyName("display_homework")]
        public bool? DisplayHomework { get; set; }

        [JsonPropertyName("display_rewards")]
        public bool? DisplayRewards { get; set; }

        [JsonPropertyName("display_detentions")]
        public bool? DisplayDetentions { get; set; }

        [JsonPropertyName("display_report_cards")]
        public bool? DisplayReportCards { get; set; }

        [JsonPropertyName("display_classes")]
        public bool? DisplayClasses { get; set; }

        [JsonPropertyName("display_announcements")]
        public bool? DisplayAnnouncements { get; set; }

        [JsonPropertyName("display_academic_reports")]
        public bool? DisplayAcademicReports { get; set; }

        [JsonPropertyName("display_attendance")]
        public bool? DisplayAttendance { get; set; }

        [JsonPropertyName("display_attendance_type")]
        public object? DisplayAttendanceType { get; set; }

        [JsonPropertyName("display_attendance_percentage")]
        public bool? DisplayAttendancePercentage { get; set; }

        [JsonPropertyName("display_activity")]
        public bool? DisplayActivity { get; set; }

        [JsonPropertyName("display_mental_health")]
        public bool? DisplayMentalHealth { get; set; }

        [JsonPropertyName("display_mental_health_no_tracker")]
        public bool? DisplayMentalHealthNoTracker { get; set; }

        [JsonPropertyName("display_timetable")]
        public bool? DisplayTimetable { get; set; }

        [JsonPropertyName("is_disabled")]
        public bool? IsDisabled { get; set; }

        [JsonPropertyName("display_two_way_communications")]
        public bool? DisplayTwoWayCommunications { get; set; }

        [JsonPropertyName("display_absences")]
        public bool? DisplayAbsences { get; set; }

        [JsonPropertyName("can_upload_attachments")]
        public bool? CanUploadAttachments { get; set; }

        [JsonPropertyName("display_event_badges")]
        public bool? DisplayEventBadges { get; set; }

        [JsonPropertyName("display_avatars")]
        public bool? DisplayAvatars { get; set; }

        [JsonPropertyName("display_concern_submission")]
        public bool? DisplayConcernSubmission { get; set; }

        [JsonPropertyName("display_custom_fields")]
        public bool? DisplayCustomFields { get; set; }

        [JsonPropertyName("pupil_concerns_help_text")]
        public string? PupilConcernsHelpText { get; set; }

        [JsonPropertyName("allow_pupils_add_timetable_notes")]
        public bool? AllowPupilsAddTimetableNotes { get; set; }

        [JsonPropertyName("detention_alias_plural_uc")]
        public string? DetentionAliasPluralUc { get; set; }
    }
}
