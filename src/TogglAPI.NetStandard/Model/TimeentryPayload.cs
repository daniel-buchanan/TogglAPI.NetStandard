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
    /// TimeentryPayload
    /// </summary>
    [DataContract]
    public partial class TimeentryPayload :  IEquatable<TimeentryPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeentryPayload" /> class.
        /// </summary>
        /// <param name="billable">Whether the time entry is marked as billable, optional, default false.</param>
        /// <param name="createdWith">Must be provided when creating a time entry and should identify the service/application used to create it.</param>
        /// <param name="description">Time entry description, optional.</param>
        /// <param name="duration">Time entry duration. For running entries should be negative, preferable -1.</param>
        /// <param name="duronly">Deprecated: Used to create a time entry with a duration but without a stop time. This parameter can be ignored..</param>
        /// <param name="pid">Project ID, legacy field.</param>
        /// <param name="projectId">Project ID, optional.</param>
        /// <param name="sharedWithUserIds">List of user IDs to share this time entry with.</param>
        /// <param name="start">Start time in UTC, required for creation. Format: 2006-01-02T15:04:05Z.</param>
        /// <param name="startDate">If provided during creation, the date part will take precedence over the date part of \&quot;start\&quot;. Format: 2006-11-07.</param>
        /// <param name="stop">Stop time in UTC, can be omitted if it&#39;s still running or created with \&quot;duration\&quot;. If \&quot;stop\&quot; and \&quot;duration\&quot; are provided, values must be consistent (start + duration &#x3D;&#x3D; stop).</param>
        /// <param name="tagAction">Can be \&quot;add\&quot; or \&quot;delete\&quot;. Used when updating an existing time entry.</param>
        /// <param name="tagIds">IDs of tags to add/remove.</param>
        /// <param name="tags">Names of tags to add/remove. If name does not exist as tag, one will be created automatically.</param>
        /// <param name="taskId">Task ID, optional.</param>
        /// <param name="tid">Task ID, legacy field.</param>
        /// <param name="uid">Time Entry creator ID, legacy field.</param>
        /// <param name="userId">Time Entry creator ID, if omitted will use the requester user ID.</param>
        /// <param name="wid">Workspace ID, legacy field.</param>
        /// <param name="workspaceId">Workspace ID, required.</param>
        public TimeentryPayload(bool? billable = default(bool?), string createdWith = default(string), string description = default(string), int? duration = default(int?), bool? duronly = default(bool?), int? pid = default(int?), int? projectId = default(int?), List<int?> sharedWithUserIds = default(List<int?>), string start = default(string), string startDate = default(string), string stop = default(string), string tagAction = default(string), List<int?> tagIds = default(List<int?>), List<string> tags = default(List<string>), int? taskId = default(int?), int? tid = default(int?), int? uid = default(int?), int? userId = default(int?), int? wid = default(int?), int? workspaceId = default(int?))
        {
            this.Billable = billable;
            this.CreatedWith = createdWith;
            this.Description = description;
            this.Duration = duration;
            this.Duronly = duronly;
            this.Pid = pid;
            this.ProjectId = projectId;
            this.SharedWithUserIds = sharedWithUserIds;
            this.Start = start;
            this.StartDate = startDate;
            this.Stop = stop;
            this.TagAction = tagAction;
            this.TagIds = tagIds;
            this.Tags = tags;
            this.TaskId = taskId;
            this.Tid = tid;
            this.Uid = uid;
            this.UserId = userId;
            this.Wid = wid;
            this.WorkspaceId = workspaceId;
        }
        
        /// <summary>
        /// Whether the time entry is marked as billable, optional, default false
        /// </summary>
        /// <value>Whether the time entry is marked as billable, optional, default false</value>
        [DataMember(Name="billable", EmitDefaultValue=false)]
        public bool? Billable { get; set; }

        /// <summary>
        /// Must be provided when creating a time entry and should identify the service/application used to create it
        /// </summary>
        /// <value>Must be provided when creating a time entry and should identify the service/application used to create it</value>
        [DataMember(Name="created_with", EmitDefaultValue=false)]
        public string CreatedWith { get; set; }

        /// <summary>
        /// Time entry description, optional
        /// </summary>
        /// <value>Time entry description, optional</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Time entry duration. For running entries should be negative, preferable -1
        /// </summary>
        /// <value>Time entry duration. For running entries should be negative, preferable -1</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// Deprecated: Used to create a time entry with a duration but without a stop time. This parameter can be ignored.
        /// </summary>
        /// <value>Deprecated: Used to create a time entry with a duration but without a stop time. This parameter can be ignored.</value>
        [DataMember(Name="duronly", EmitDefaultValue=false)]
        public bool? Duronly { get; set; }

        /// <summary>
        /// Project ID, legacy field
        /// </summary>
        /// <value>Project ID, legacy field</value>
        [DataMember(Name="pid", EmitDefaultValue=false)]
        public int? Pid { get; set; }

        /// <summary>
        /// Project ID, optional
        /// </summary>
        /// <value>Project ID, optional</value>
        [DataMember(Name="project_id", EmitDefaultValue=false)]
        public int? ProjectId { get; set; }

        /// <summary>
        /// List of user IDs to share this time entry with
        /// </summary>
        /// <value>List of user IDs to share this time entry with</value>
        [DataMember(Name="shared_with_user_ids", EmitDefaultValue=false)]
        public List<int?> SharedWithUserIds { get; set; }

        /// <summary>
        /// Start time in UTC, required for creation. Format: 2006-01-02T15:04:05Z
        /// </summary>
        /// <value>Start time in UTC, required for creation. Format: 2006-01-02T15:04:05Z</value>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public string Start { get; set; }

        /// <summary>
        /// If provided during creation, the date part will take precedence over the date part of \&quot;start\&quot;. Format: 2006-11-07
        /// </summary>
        /// <value>If provided during creation, the date part will take precedence over the date part of \&quot;start\&quot;. Format: 2006-11-07</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Stop time in UTC, can be omitted if it&#39;s still running or created with \&quot;duration\&quot;. If \&quot;stop\&quot; and \&quot;duration\&quot; are provided, values must be consistent (start + duration &#x3D;&#x3D; stop)
        /// </summary>
        /// <value>Stop time in UTC, can be omitted if it&#39;s still running or created with \&quot;duration\&quot;. If \&quot;stop\&quot; and \&quot;duration\&quot; are provided, values must be consistent (start + duration &#x3D;&#x3D; stop)</value>
        [DataMember(Name="stop", EmitDefaultValue=false)]
        public string Stop { get; set; }

        /// <summary>
        /// Can be \&quot;add\&quot; or \&quot;delete\&quot;. Used when updating an existing time entry
        /// </summary>
        /// <value>Can be \&quot;add\&quot; or \&quot;delete\&quot;. Used when updating an existing time entry</value>
        [DataMember(Name="tag_action", EmitDefaultValue=false)]
        public string TagAction { get; set; }

        /// <summary>
        /// IDs of tags to add/remove
        /// </summary>
        /// <value>IDs of tags to add/remove</value>
        [DataMember(Name="tag_ids", EmitDefaultValue=false)]
        public List<int?> TagIds { get; set; }

        /// <summary>
        /// Names of tags to add/remove. If name does not exist as tag, one will be created automatically
        /// </summary>
        /// <value>Names of tags to add/remove. If name does not exist as tag, one will be created automatically</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Task ID, optional
        /// </summary>
        /// <value>Task ID, optional</value>
        [DataMember(Name="task_id", EmitDefaultValue=false)]
        public int? TaskId { get; set; }

        /// <summary>
        /// Task ID, legacy field
        /// </summary>
        /// <value>Task ID, legacy field</value>
        [DataMember(Name="tid", EmitDefaultValue=false)]
        public int? Tid { get; set; }

        /// <summary>
        /// Time Entry creator ID, legacy field
        /// </summary>
        /// <value>Time Entry creator ID, legacy field</value>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public int? Uid { get; set; }

        /// <summary>
        /// Time Entry creator ID, if omitted will use the requester user ID
        /// </summary>
        /// <value>Time Entry creator ID, if omitted will use the requester user ID</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Workspace ID, legacy field
        /// </summary>
        /// <value>Workspace ID, legacy field</value>
        [DataMember(Name="wid", EmitDefaultValue=false)]
        public int? Wid { get; set; }

        /// <summary>
        /// Workspace ID, required
        /// </summary>
        /// <value>Workspace ID, required</value>
        [DataMember(Name="workspace_id", EmitDefaultValue=false)]
        public int? WorkspaceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeentryPayload {\n");
            sb.Append("  Billable: ").Append(Billable).Append("\n");
            sb.Append("  CreatedWith: ").Append(CreatedWith).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Duronly: ").Append(Duronly).Append("\n");
            sb.Append("  Pid: ").Append(Pid).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  SharedWithUserIds: ").Append(SharedWithUserIds).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Stop: ").Append(Stop).Append("\n");
            sb.Append("  TagAction: ").Append(TagAction).Append("\n");
            sb.Append("  TagIds: ").Append(TagIds).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  Tid: ").Append(Tid).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Wid: ").Append(Wid).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
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
            return this.Equals(input as TimeentryPayload);
        }

        /// <summary>
        /// Returns true if TimeentryPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeentryPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeentryPayload input)
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
                    this.CreatedWith == input.CreatedWith ||
                    (this.CreatedWith != null &&
                    this.CreatedWith.Equals(input.CreatedWith))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.Duronly == input.Duronly ||
                    (this.Duronly != null &&
                    this.Duronly.Equals(input.Duronly))
                ) && 
                (
                    this.Pid == input.Pid ||
                    (this.Pid != null &&
                    this.Pid.Equals(input.Pid))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.SharedWithUserIds == input.SharedWithUserIds ||
                    this.SharedWithUserIds != null &&
                    this.SharedWithUserIds.SequenceEqual(input.SharedWithUserIds)
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.Stop == input.Stop ||
                    (this.Stop != null &&
                    this.Stop.Equals(input.Stop))
                ) && 
                (
                    this.TagAction == input.TagAction ||
                    (this.TagAction != null &&
                    this.TagAction.Equals(input.TagAction))
                ) && 
                (
                    this.TagIds == input.TagIds ||
                    this.TagIds != null &&
                    this.TagIds.SequenceEqual(input.TagIds)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.Tid == input.Tid ||
                    (this.Tid != null &&
                    this.Tid.Equals(input.Tid))
                ) && 
                (
                    this.Uid == input.Uid ||
                    (this.Uid != null &&
                    this.Uid.Equals(input.Uid))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Wid == input.Wid ||
                    (this.Wid != null &&
                    this.Wid.Equals(input.Wid))
                ) && 
                (
                    this.WorkspaceId == input.WorkspaceId ||
                    (this.WorkspaceId != null &&
                    this.WorkspaceId.Equals(input.WorkspaceId))
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
                if (this.CreatedWith != null)
                    hashCode = hashCode * 59 + this.CreatedWith.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Duronly != null)
                    hashCode = hashCode * 59 + this.Duronly.GetHashCode();
                if (this.Pid != null)
                    hashCode = hashCode * 59 + this.Pid.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.SharedWithUserIds != null)
                    hashCode = hashCode * 59 + this.SharedWithUserIds.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.Stop != null)
                    hashCode = hashCode * 59 + this.Stop.GetHashCode();
                if (this.TagAction != null)
                    hashCode = hashCode * 59 + this.TagAction.GetHashCode();
                if (this.TagIds != null)
                    hashCode = hashCode * 59 + this.TagIds.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.Tid != null)
                    hashCode = hashCode * 59 + this.Tid.GetHashCode();
                if (this.Uid != null)
                    hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Wid != null)
                    hashCode = hashCode * 59 + this.Wid.GetHashCode();
                if (this.WorkspaceId != null)
                    hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
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
