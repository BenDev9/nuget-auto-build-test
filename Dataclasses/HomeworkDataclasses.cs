using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassChartsApi.Api.Dataclasses
{
    public class Homework
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("lesson")]
        public string? Lesson { get; set; }

        [JsonPropertyName("subject")]
        public string? Subject { get; set; }

        [JsonPropertyName("teacher")]
        public string? Teacher { get; set; }

        [JsonPropertyName("homework_type")]
        public string? HomeworkType { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("meta_title")]
        public string? MetaTitle { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("issue_date")]
        public string? IssueDate { get; set; }

        [JsonPropertyName("due_date")]
        public string? DueDate { get; set; }

        [JsonPropertyName("completion_time_unit")]
        public string? CompletionTimeUnit { get; set; }

        [JsonPropertyName("completion_time_value")]
        public string? CompletionTimeValue { get; set; }

        [JsonPropertyName("mark")]
        public int? Mark { get; set; }
    }

    internal class HomeworkStatus
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("mark")]
        public int? Mark { get; set; }

        [JsonPropertyName("mark_relative")]
        public int? MarkRelative { get; set; }

        [JsonPropertyName("ticked")]
        public string? Ticked { get; set; }

        [JsonPropertyName("allow_attachments")]
        public string? AllowAttachments { get; set; }
    }

    internal class HomeworkMeta
    {
        [JsonPropertyName("start_date")]
        public DateTime? StartDate { get; set; }

        [JsonPropertyName("end_date")]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("display_type")]
        public string? DisplayType { get; set; }

        [JsonPropertyName("max_files_allowed")]
        public int? MaxFilesAllowed { get; set; }

        [JsonPropertyName("allowed_file_types")]
        public List<string>? AllowedFileTypes { get; set; }

        [JsonPropertyName("this_week_due_count")]
        public int? ThisWeekDueCount { get; set; }

        [JsonPropertyName("this_week_outstanding_count")]
        public int? ThisWeekOutstandingCount { get; set; }

        [JsonPropertyName("this_week_completed_count")]
        public int? ThisWeekCompletedCount { get; set; }

        [JsonPropertyName("allow_attachments")]
        public bool? AllowAttachments { get; set; }

        [JsonPropertyName("display_marks")]
        public bool? DisplayMarks { get; set; }
    }

    internal class HomeworkReturn
    {
        [JsonPropertyName("success")]
        public int Success { get; set; }
        [JsonPropertyName("data")]
        public List<Homework>? Data { get; set; }
        [JsonPropertyName("meta")]
        public HomeworkMeta? Meta { get; set; }
    }
}
