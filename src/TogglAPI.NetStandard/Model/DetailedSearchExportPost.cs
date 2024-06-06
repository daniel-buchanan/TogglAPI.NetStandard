/* 
 * Toggl API
 *
 * Public Toggl API. Note: We use BasicAuth in a specific way. By the standard you provide `Authentication` header with `base64(user_name:password)` as a `credential`. In our case it will be `base64(user_name:api_token)`.
 *
 * OpenAPI spec version: 9
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = TogglAPI.NetStandard.Client.SwaggerDateConverter;

namespace TogglAPI.NetStandard.Model
{
    /// <summary>
    /// DetailedSearchExportPost
    /// </summary>
    [DataContract]
    public partial class DetailedSearchExportPost :  IEquatable<DetailedSearchExportPost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedSearchExportPost" /> class.
        /// </summary>
        /// <param name="billable">Whether the time entry is set as billable, optional, premium feature..</param>
        /// <param name="clientIds">Client IDs, optional, filtering attribute. To filter records with no clients, use [null]..</param>
        /// <param name="description">Description, optional, filtering attribute..</param>
        /// <param name="durationFormat">Duration format, optional, default \&quot;classic\&quot;. Can be \&quot;classic\&quot;, \&quot;decimal\&quot; or \&quot;improved\&quot;..</param>
        /// <param name="endDate">End date, example time.DateOnly. Should be greater than Start date..</param>
        /// <param name="enrichResponse">EnrichResponse, optional, default false. It will force the detailed report to return as much information as possible, as it does for the export..</param>
        /// <param name="firstId">firstId.</param>
        /// <param name="firstRowNumber">firstRowNumber.</param>
        /// <param name="firstTimestamp">firstTimestamp.</param>
        /// <param name="groupIds">Group IDs, optional, filtering attribute..</param>
        /// <param name="grouped">Whether time entries should be grouped, optional, default false..</param>
        /// <param name="hideAmounts">Whether amounts should be hidden, optional, default false..</param>
        /// <param name="maxDurationSeconds">Max duration seconds, optional, filtering attribute. Time Audit only, should be greater than MinDurationSeconds..</param>
        /// <param name="minDurationSeconds">Min duration seconds, optional, filtering attribute. Time Audit only, should be less than MaxDurationSeconds..</param>
        /// <param name="orderBy">Order by field, optional, default \&quot;date\&quot;. Can be \&quot;date\&quot;, \&quot;user\&quot;, \&quot;duration\&quot;, \&quot;description\&quot; or \&quot;last_update\&quot;..</param>
        /// <param name="orderDir">Order direction, optional. Can be ASC or DESC..</param>
        /// <param name="pageSize">PageSize defines the number of items per page, optional, default 50..</param>
        /// <param name="postedFields">postedFields.</param>
        /// <param name="projectIds">Project IDs, optional, filtering attribute. To filter records with no projects, use [null]..</param>
        /// <param name="rounding">Whether time should be rounded, optional, default from workspace settings..</param>
        /// <param name="roundingMinutes">Rounding minutes value, optional, default from workspace settings. Should be 0, 1, 5, 6, 10, 12, 15, 30, 60 or 240..</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="startDate">Start date, example time.DateOnly. Should be less than End date..</param>
        /// <param name="tagIds">Tag IDs, optional, filtering attribute. To filter records with no tags, use [null]..</param>
        /// <param name="taskIds">Task IDs, optional, filtering attribute. To filter records with no tasks, use [null]..</param>
        /// <param name="timeEntryIds">TimeEntryIDs filters by time entries. This was added to support retro-compatibility with reports v2..</param>
        /// <param name="userIds">User IDs, optional, filtering attribute..</param>
        public DetailedSearchExportPost(bool? billable = default(bool?), List<long?> clientIds = default(List<long?>), string description = default(string), string durationFormat = default(string), string endDate = default(string), bool? enrichResponse = default(bool?), long? firstId = default(long?), long? firstRowNumber = default(long?), long? firstTimestamp = default(long?), List<long?> groupIds = default(List<long?>), bool? grouped = default(bool?), bool? hideAmounts = default(bool?), long? maxDurationSeconds = default(long?), long? minDurationSeconds = default(long?), string orderBy = default(string), string orderDir = default(string), long? pageSize = default(long?), List<string> postedFields = default(List<string>), List<long?> projectIds = default(List<long?>), long? rounding = default(long?), long? roundingMinutes = default(long?), string startTime = default(string), string startDate = default(string), List<long?> tagIds = default(List<long?>), List<long?> taskIds = default(List<long?>), List<long?> timeEntryIds = default(List<long?>), List<long?> userIds = default(List<long?>))
        {
            this.Billable = billable;
            this.ClientIds = clientIds;
            this.Description = description;
            this.DurationFormat = durationFormat;
            this.EndDate = endDate;
            this.EnrichResponse = enrichResponse;
            this.FirstId = firstId;
            this.FirstRowNumber = firstRowNumber;
            this.FirstTimestamp = firstTimestamp;
            this.GroupIds = groupIds;
            this.Grouped = grouped;
            this.HideAmounts = hideAmounts;
            this.MaxDurationSeconds = maxDurationSeconds;
            this.MinDurationSeconds = minDurationSeconds;
            this.OrderBy = orderBy;
            this.OrderDir = orderDir;
            this.PageSize = pageSize;
            this.PostedFields = postedFields;
            this.ProjectIds = projectIds;
            this.Rounding = rounding;
            this.RoundingMinutes = roundingMinutes;
            this.StartTime = startTime;
            this.StartDate = startDate;
            this.TagIds = tagIds;
            this.TaskIds = taskIds;
            this.TimeEntryIds = timeEntryIds;
            this.UserIds = userIds;
        }
        
        /// <summary>
        /// Whether the time entry is set as billable, optional, premium feature.
        /// </summary>
        /// <value>Whether the time entry is set as billable, optional, premium feature.</value>
        [DataMember(Name="billable", EmitDefaultValue=false)]
        public bool? Billable { get; set; }

        /// <summary>
        /// Client IDs, optional, filtering attribute. To filter records with no clients, use [null].
        /// </summary>
        /// <value>Client IDs, optional, filtering attribute. To filter records with no clients, use [null].</value>
        [DataMember(Name="client_ids", EmitDefaultValue=false)]
        public List<long?> ClientIds { get; set; }

        /// <summary>
        /// Description, optional, filtering attribute.
        /// </summary>
        /// <value>Description, optional, filtering attribute.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Duration format, optional, default \&quot;classic\&quot;. Can be \&quot;classic\&quot;, \&quot;decimal\&quot; or \&quot;improved\&quot;.
        /// </summary>
        /// <value>Duration format, optional, default \&quot;classic\&quot;. Can be \&quot;classic\&quot;, \&quot;decimal\&quot; or \&quot;improved\&quot;.</value>
        [DataMember(Name="duration_format", EmitDefaultValue=false)]
        public string DurationFormat { get; set; }

        /// <summary>
        /// End date, example time.DateOnly. Should be greater than Start date.
        /// </summary>
        /// <value>End date, example time.DateOnly. Should be greater than Start date.</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// EnrichResponse, optional, default false. It will force the detailed report to return as much information as possible, as it does for the export.
        /// </summary>
        /// <value>EnrichResponse, optional, default false. It will force the detailed report to return as much information as possible, as it does for the export.</value>
        [DataMember(Name="enrich_response", EmitDefaultValue=false)]
        public bool? EnrichResponse { get; set; }

        /// <summary>
        /// Gets or Sets FirstId
        /// </summary>
        [DataMember(Name="first_id", EmitDefaultValue=false)]
        public long? FirstId { get; set; }

        /// <summary>
        /// Gets or Sets FirstRowNumber
        /// </summary>
        [DataMember(Name="first_row_number", EmitDefaultValue=false)]
        public long? FirstRowNumber { get; set; }

        /// <summary>
        /// Gets or Sets FirstTimestamp
        /// </summary>
        [DataMember(Name="first_timestamp", EmitDefaultValue=false)]
        public long? FirstTimestamp { get; set; }

        /// <summary>
        /// Group IDs, optional, filtering attribute.
        /// </summary>
        /// <value>Group IDs, optional, filtering attribute.</value>
        [DataMember(Name="group_ids", EmitDefaultValue=false)]
        public List<long?> GroupIds { get; set; }

        /// <summary>
        /// Whether time entries should be grouped, optional, default false.
        /// </summary>
        /// <value>Whether time entries should be grouped, optional, default false.</value>
        [DataMember(Name="grouped", EmitDefaultValue=false)]
        public bool? Grouped { get; set; }

        /// <summary>
        /// Whether amounts should be hidden, optional, default false.
        /// </summary>
        /// <value>Whether amounts should be hidden, optional, default false.</value>
        [DataMember(Name="hide_amounts", EmitDefaultValue=false)]
        public bool? HideAmounts { get; set; }

        /// <summary>
        /// Max duration seconds, optional, filtering attribute. Time Audit only, should be greater than MinDurationSeconds.
        /// </summary>
        /// <value>Max duration seconds, optional, filtering attribute. Time Audit only, should be greater than MinDurationSeconds.</value>
        [DataMember(Name="max_duration_seconds", EmitDefaultValue=false)]
        public long? MaxDurationSeconds { get; set; }

        /// <summary>
        /// Min duration seconds, optional, filtering attribute. Time Audit only, should be less than MaxDurationSeconds.
        /// </summary>
        /// <value>Min duration seconds, optional, filtering attribute. Time Audit only, should be less than MaxDurationSeconds.</value>
        [DataMember(Name="min_duration_seconds", EmitDefaultValue=false)]
        public long? MinDurationSeconds { get; set; }

        /// <summary>
        /// Order by field, optional, default \&quot;date\&quot;. Can be \&quot;date\&quot;, \&quot;user\&quot;, \&quot;duration\&quot;, \&quot;description\&quot; or \&quot;last_update\&quot;.
        /// </summary>
        /// <value>Order by field, optional, default \&quot;date\&quot;. Can be \&quot;date\&quot;, \&quot;user\&quot;, \&quot;duration\&quot;, \&quot;description\&quot; or \&quot;last_update\&quot;.</value>
        [DataMember(Name="order_by", EmitDefaultValue=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// Order direction, optional. Can be ASC or DESC.
        /// </summary>
        /// <value>Order direction, optional. Can be ASC or DESC.</value>
        [DataMember(Name="order_dir", EmitDefaultValue=false)]
        public string OrderDir { get; set; }

        /// <summary>
        /// PageSize defines the number of items per page, optional, default 50.
        /// </summary>
        /// <value>PageSize defines the number of items per page, optional, default 50.</value>
        [DataMember(Name="page_size", EmitDefaultValue=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// Gets or Sets PostedFields
        /// </summary>
        [DataMember(Name="postedFields", EmitDefaultValue=false)]
        public List<string> PostedFields { get; set; }

        /// <summary>
        /// Project IDs, optional, filtering attribute. To filter records with no projects, use [null].
        /// </summary>
        /// <value>Project IDs, optional, filtering attribute. To filter records with no projects, use [null].</value>
        [DataMember(Name="project_ids", EmitDefaultValue=false)]
        public List<long?> ProjectIds { get; set; }

        /// <summary>
        /// Whether time should be rounded, optional, default from workspace settings.
        /// </summary>
        /// <value>Whether time should be rounded, optional, default from workspace settings.</value>
        [DataMember(Name="rounding", EmitDefaultValue=false)]
        public long? Rounding { get; set; }

        /// <summary>
        /// Rounding minutes value, optional, default from workspace settings. Should be 0, 1, 5, 6, 10, 12, 15, 30, 60 or 240.
        /// </summary>
        /// <value>Rounding minutes value, optional, default from workspace settings. Should be 0, 1, 5, 6, 10, 12, 15, 30, 60 or 240.</value>
        [DataMember(Name="rounding_minutes", EmitDefaultValue=false)]
        public long? RoundingMinutes { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Start date, example time.DateOnly. Should be less than End date.
        /// </summary>
        /// <value>Start date, example time.DateOnly. Should be less than End date.</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Tag IDs, optional, filtering attribute. To filter records with no tags, use [null].
        /// </summary>
        /// <value>Tag IDs, optional, filtering attribute. To filter records with no tags, use [null].</value>
        [DataMember(Name="tag_ids", EmitDefaultValue=false)]
        public List<long?> TagIds { get; set; }

        /// <summary>
        /// Task IDs, optional, filtering attribute. To filter records with no tasks, use [null].
        /// </summary>
        /// <value>Task IDs, optional, filtering attribute. To filter records with no tasks, use [null].</value>
        [DataMember(Name="task_ids", EmitDefaultValue=false)]
        public List<long?> TaskIds { get; set; }

        /// <summary>
        /// TimeEntryIDs filters by time entries. This was added to support retro-compatibility with reports v2.
        /// </summary>
        /// <value>TimeEntryIDs filters by time entries. This was added to support retro-compatibility with reports v2.</value>
        [DataMember(Name="time_entry_ids", EmitDefaultValue=false)]
        public List<long?> TimeEntryIds { get; set; }

        /// <summary>
        /// User IDs, optional, filtering attribute.
        /// </summary>
        /// <value>User IDs, optional, filtering attribute.</value>
        [DataMember(Name="user_ids", EmitDefaultValue=false)]
        public List<long?> UserIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailedSearchExportPost {\n");
            sb.Append("  Billable: ").Append(Billable).Append("\n");
            sb.Append("  ClientIds: ").Append(ClientIds).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DurationFormat: ").Append(DurationFormat).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  EnrichResponse: ").Append(EnrichResponse).Append("\n");
            sb.Append("  FirstId: ").Append(FirstId).Append("\n");
            sb.Append("  FirstRowNumber: ").Append(FirstRowNumber).Append("\n");
            sb.Append("  FirstTimestamp: ").Append(FirstTimestamp).Append("\n");
            sb.Append("  GroupIds: ").Append(GroupIds).Append("\n");
            sb.Append("  Grouped: ").Append(Grouped).Append("\n");
            sb.Append("  HideAmounts: ").Append(HideAmounts).Append("\n");
            sb.Append("  MaxDurationSeconds: ").Append(MaxDurationSeconds).Append("\n");
            sb.Append("  MinDurationSeconds: ").Append(MinDurationSeconds).Append("\n");
            sb.Append("  OrderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  OrderDir: ").Append(OrderDir).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PostedFields: ").Append(PostedFields).Append("\n");
            sb.Append("  ProjectIds: ").Append(ProjectIds).Append("\n");
            sb.Append("  Rounding: ").Append(Rounding).Append("\n");
            sb.Append("  RoundingMinutes: ").Append(RoundingMinutes).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  TagIds: ").Append(TagIds).Append("\n");
            sb.Append("  TaskIds: ").Append(TaskIds).Append("\n");
            sb.Append("  TimeEntryIds: ").Append(TimeEntryIds).Append("\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetailedSearchExportPost);
        }

        /// <summary>
        /// Returns true if DetailedSearchExportPost instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailedSearchExportPost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailedSearchExportPost input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Billable == input.Billable ||
                    (this.Billable != null &&
                    this.Billable.Equals(input.Billable))
                ) && 
                (
                    this.ClientIds == input.ClientIds ||
                    this.ClientIds != null &&
                    this.ClientIds.SequenceEqual(input.ClientIds)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DurationFormat == input.DurationFormat ||
                    (this.DurationFormat != null &&
                    this.DurationFormat.Equals(input.DurationFormat))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.EnrichResponse == input.EnrichResponse ||
                    (this.EnrichResponse != null &&
                    this.EnrichResponse.Equals(input.EnrichResponse))
                ) && 
                (
                    this.FirstId == input.FirstId ||
                    (this.FirstId != null &&
                    this.FirstId.Equals(input.FirstId))
                ) && 
                (
                    this.FirstRowNumber == input.FirstRowNumber ||
                    (this.FirstRowNumber != null &&
                    this.FirstRowNumber.Equals(input.FirstRowNumber))
                ) && 
                (
                    this.FirstTimestamp == input.FirstTimestamp ||
                    (this.FirstTimestamp != null &&
                    this.FirstTimestamp.Equals(input.FirstTimestamp))
                ) && 
                (
                    this.GroupIds == input.GroupIds ||
                    this.GroupIds != null &&
                    this.GroupIds.SequenceEqual(input.GroupIds)
                ) && 
                (
                    this.Grouped == input.Grouped ||
                    (this.Grouped != null &&
                    this.Grouped.Equals(input.Grouped))
                ) && 
                (
                    this.HideAmounts == input.HideAmounts ||
                    (this.HideAmounts != null &&
                    this.HideAmounts.Equals(input.HideAmounts))
                ) && 
                (
                    this.MaxDurationSeconds == input.MaxDurationSeconds ||
                    (this.MaxDurationSeconds != null &&
                    this.MaxDurationSeconds.Equals(input.MaxDurationSeconds))
                ) && 
                (
                    this.MinDurationSeconds == input.MinDurationSeconds ||
                    (this.MinDurationSeconds != null &&
                    this.MinDurationSeconds.Equals(input.MinDurationSeconds))
                ) && 
                (
                    this.OrderBy == input.OrderBy ||
                    (this.OrderBy != null &&
                    this.OrderBy.Equals(input.OrderBy))
                ) && 
                (
                    this.OrderDir == input.OrderDir ||
                    (this.OrderDir != null &&
                    this.OrderDir.Equals(input.OrderDir))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.PostedFields == input.PostedFields ||
                    this.PostedFields != null &&
                    this.PostedFields.SequenceEqual(input.PostedFields)
                ) && 
                (
                    this.ProjectIds == input.ProjectIds ||
                    this.ProjectIds != null &&
                    this.ProjectIds.SequenceEqual(input.ProjectIds)
                ) && 
                (
                    this.Rounding == input.Rounding ||
                    (this.Rounding != null &&
                    this.Rounding.Equals(input.Rounding))
                ) && 
                (
                    this.RoundingMinutes == input.RoundingMinutes ||
                    (this.RoundingMinutes != null &&
                    this.RoundingMinutes.Equals(input.RoundingMinutes))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.TagIds == input.TagIds ||
                    this.TagIds != null &&
                    this.TagIds.SequenceEqual(input.TagIds)
                ) && 
                (
                    this.TaskIds == input.TaskIds ||
                    this.TaskIds != null &&
                    this.TaskIds.SequenceEqual(input.TaskIds)
                ) && 
                (
                    this.TimeEntryIds == input.TimeEntryIds ||
                    this.TimeEntryIds != null &&
                    this.TimeEntryIds.SequenceEqual(input.TimeEntryIds)
                ) && 
                (
                    this.UserIds == input.UserIds ||
                    this.UserIds != null &&
                    this.UserIds.SequenceEqual(input.UserIds)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Billable != null)
                    hashCode = hashCode * 59 + this.Billable.GetHashCode();
                if (this.ClientIds != null)
                    hashCode = hashCode * 59 + this.ClientIds.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DurationFormat != null)
                    hashCode = hashCode * 59 + this.DurationFormat.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.EnrichResponse != null)
                    hashCode = hashCode * 59 + this.EnrichResponse.GetHashCode();
                if (this.FirstId != null)
                    hashCode = hashCode * 59 + this.FirstId.GetHashCode();
                if (this.FirstRowNumber != null)
                    hashCode = hashCode * 59 + this.FirstRowNumber.GetHashCode();
                if (this.FirstTimestamp != null)
                    hashCode = hashCode * 59 + this.FirstTimestamp.GetHashCode();
                if (this.GroupIds != null)
                    hashCode = hashCode * 59 + this.GroupIds.GetHashCode();
                if (this.Grouped != null)
                    hashCode = hashCode * 59 + this.Grouped.GetHashCode();
                if (this.HideAmounts != null)
                    hashCode = hashCode * 59 + this.HideAmounts.GetHashCode();
                if (this.MaxDurationSeconds != null)
                    hashCode = hashCode * 59 + this.MaxDurationSeconds.GetHashCode();
                if (this.MinDurationSeconds != null)
                    hashCode = hashCode * 59 + this.MinDurationSeconds.GetHashCode();
                if (this.OrderBy != null)
                    hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                if (this.OrderDir != null)
                    hashCode = hashCode * 59 + this.OrderDir.GetHashCode();
                if (this.PageSize != null)
                    hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.PostedFields != null)
                    hashCode = hashCode * 59 + this.PostedFields.GetHashCode();
                if (this.ProjectIds != null)
                    hashCode = hashCode * 59 + this.ProjectIds.GetHashCode();
                if (this.Rounding != null)
                    hashCode = hashCode * 59 + this.Rounding.GetHashCode();
                if (this.RoundingMinutes != null)
                    hashCode = hashCode * 59 + this.RoundingMinutes.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.TagIds != null)
                    hashCode = hashCode * 59 + this.TagIds.GetHashCode();
                if (this.TaskIds != null)
                    hashCode = hashCode * 59 + this.TaskIds.GetHashCode();
                if (this.TimeEntryIds != null)
                    hashCode = hashCode * 59 + this.TimeEntryIds.GetHashCode();
                if (this.UserIds != null)
                    hashCode = hashCode * 59 + this.UserIds.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
