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
    /// BasePost
    /// </summary>
    [DataContract]
    public partial class BasePost :  IEquatable<BasePost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BasePost" /> class.
        /// </summary>
        /// <param name="billable">Whether the time entry is set as billable, optional, premium feature..</param>
        /// <param name="clientIds">Client IDs, optional, filtering attribute. To filter records with no clients, use [null]..</param>
        /// <param name="description">Description, optional, filtering attribute..</param>
        /// <param name="endDate">End date, example time.DateOnly. Should be greater than Start date..</param>
        /// <param name="groupIds">Group IDs, optional, filtering attribute..</param>
        /// <param name="maxDurationSeconds">Max duration seconds, optional, filtering attribute. Time Audit only, should be greater than MinDurationSeconds..</param>
        /// <param name="minDurationSeconds">Min duration seconds, optional, filtering attribute. Time Audit only, should be less than MaxDurationSeconds..</param>
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
        public BasePost(bool? billable = default(bool?), List<int?> clientIds = default(List<int?>), string description = default(string), string endDate = default(string), List<int?> groupIds = default(List<int?>), int? maxDurationSeconds = default(int?), int? minDurationSeconds = default(int?), List<string> postedFields = default(List<string>), List<int?> projectIds = default(List<int?>), int? rounding = default(int?), int? roundingMinutes = default(int?), string startTime = default(string), string startDate = default(string), List<int?> tagIds = default(List<int?>), List<int?> taskIds = default(List<int?>), List<int?> timeEntryIds = default(List<int?>), List<int?> userIds = default(List<int?>))
        {
            this.Billable = billable;
            this.ClientIds = clientIds;
            this.Description = description;
            this.EndDate = endDate;
            this.GroupIds = groupIds;
            this.MaxDurationSeconds = maxDurationSeconds;
            this.MinDurationSeconds = minDurationSeconds;
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
        public List<int?> ClientIds { get; set; }

        /// <summary>
        /// Description, optional, filtering attribute.
        /// </summary>
        /// <value>Description, optional, filtering attribute.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// End date, example time.DateOnly. Should be greater than Start date.
        /// </summary>
        /// <value>End date, example time.DateOnly. Should be greater than Start date.</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Group IDs, optional, filtering attribute.
        /// </summary>
        /// <value>Group IDs, optional, filtering attribute.</value>
        [DataMember(Name="group_ids", EmitDefaultValue=false)]
        public List<int?> GroupIds { get; set; }

        /// <summary>
        /// Max duration seconds, optional, filtering attribute. Time Audit only, should be greater than MinDurationSeconds.
        /// </summary>
        /// <value>Max duration seconds, optional, filtering attribute. Time Audit only, should be greater than MinDurationSeconds.</value>
        [DataMember(Name="max_duration_seconds", EmitDefaultValue=false)]
        public int? MaxDurationSeconds { get; set; }

        /// <summary>
        /// Min duration seconds, optional, filtering attribute. Time Audit only, should be less than MaxDurationSeconds.
        /// </summary>
        /// <value>Min duration seconds, optional, filtering attribute. Time Audit only, should be less than MaxDurationSeconds.</value>
        [DataMember(Name="min_duration_seconds", EmitDefaultValue=false)]
        public int? MinDurationSeconds { get; set; }

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
        public List<int?> ProjectIds { get; set; }

        /// <summary>
        /// Whether time should be rounded, optional, default from workspace settings.
        /// </summary>
        /// <value>Whether time should be rounded, optional, default from workspace settings.</value>
        [DataMember(Name="rounding", EmitDefaultValue=false)]
        public int? Rounding { get; set; }

        /// <summary>
        /// Rounding minutes value, optional, default from workspace settings. Should be 0, 1, 5, 6, 10, 12, 15, 30, 60 or 240.
        /// </summary>
        /// <value>Rounding minutes value, optional, default from workspace settings. Should be 0, 1, 5, 6, 10, 12, 15, 30, 60 or 240.</value>
        [DataMember(Name="rounding_minutes", EmitDefaultValue=false)]
        public int? RoundingMinutes { get; set; }

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
        public List<int?> TagIds { get; set; }

        /// <summary>
        /// Task IDs, optional, filtering attribute. To filter records with no tasks, use [null].
        /// </summary>
        /// <value>Task IDs, optional, filtering attribute. To filter records with no tasks, use [null].</value>
        [DataMember(Name="task_ids", EmitDefaultValue=false)]
        public List<int?> TaskIds { get; set; }

        /// <summary>
        /// TimeEntryIDs filters by time entries. This was added to support retro-compatibility with reports v2.
        /// </summary>
        /// <value>TimeEntryIDs filters by time entries. This was added to support retro-compatibility with reports v2.</value>
        [DataMember(Name="time_entry_ids", EmitDefaultValue=false)]
        public List<int?> TimeEntryIds { get; set; }

        /// <summary>
        /// User IDs, optional, filtering attribute.
        /// </summary>
        /// <value>User IDs, optional, filtering attribute.</value>
        [DataMember(Name="user_ids", EmitDefaultValue=false)]
        public List<int?> UserIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BasePost {\n");
            sb.Append("  Billable: ").Append(Billable).Append("\n");
            sb.Append("  ClientIds: ").Append(ClientIds).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  GroupIds: ").Append(GroupIds).Append("\n");
            sb.Append("  MaxDurationSeconds: ").Append(MaxDurationSeconds).Append("\n");
            sb.Append("  MinDurationSeconds: ").Append(MinDurationSeconds).Append("\n");
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
            return this.Equals(input as BasePost);
        }

        /// <summary>
        /// Returns true if BasePost instances are equal
        /// </summary>
        /// <param name="input">Instance of BasePost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BasePost input)
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
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.GroupIds == input.GroupIds ||
                    this.GroupIds != null &&
                    this.GroupIds.SequenceEqual(input.GroupIds)
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
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.GroupIds != null)
                    hashCode = hashCode * 59 + this.GroupIds.GetHashCode();
                if (this.MaxDurationSeconds != null)
                    hashCode = hashCode * 59 + this.MaxDurationSeconds.GetHashCode();
                if (this.MinDurationSeconds != null)
                    hashCode = hashCode * 59 + this.MinDurationSeconds.GetHashCode();
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
