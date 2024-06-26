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
    /// ModelsTask
    /// </summary>
    [DataContract]
    public partial class ModelsTask :  IEquatable<ModelsTask>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsTask" /> class.
        /// </summary>
        /// <param name="active">False when the task has been done.</param>
        /// <param name="at">When the task was created/last modified.</param>
        /// <param name="clientName">clientName.</param>
        /// <param name="estimatedSeconds">Estimation time for this task in seconds.</param>
        /// <param name="id">Task ID.</param>
        /// <param name="name">Task Name.</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="projectColor">Metadata.</param>
        /// <param name="projectId">Project ID.</param>
        /// <param name="projectName">projectName.</param>
        /// <param name="recurring">Whether this is a recurring task.</param>
        /// <param name="serverDeletedAt">When the task was deleted.</param>
        /// <param name="togglAccountsId">Task assignee, if set above this will be the toggl_account_id for that user.</param>
        /// <param name="trackedSeconds">The value tracked_seconds is in milliseconds, not in seconds..</param>
        /// <param name="userId">Task assignee, if available.</param>
        /// <param name="workspaceId">Workspace ID.</param>
        public ModelsTask(bool? active = default(bool?), string at = default(string), string clientName = default(string), long? estimatedSeconds = default(long?), long? id = default(long?), string name = default(string), string permissions = default(string), string projectColor = default(string), long? projectId = default(long?), string projectName = default(string), bool? recurring = default(bool?), string serverDeletedAt = default(string), string togglAccountsId = default(string), long? trackedSeconds = default(long?), long? userId = default(long?), long? workspaceId = default(long?))
        {
            this.Active = active;
            this.At = at;
            this.ClientName = clientName;
            this.EstimatedSeconds = estimatedSeconds;
            this.Id = id;
            this.Name = name;
            this.Permissions = permissions;
            this.ProjectColor = projectColor;
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.Recurring = recurring;
            this.ServerDeletedAt = serverDeletedAt;
            this.TogglAccountsId = togglAccountsId;
            this.TrackedSeconds = trackedSeconds;
            this.UserId = userId;
            this.WorkspaceId = workspaceId;
        }
        
        /// <summary>
        /// False when the task has been done
        /// </summary>
        /// <value>False when the task has been done</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// When the task was created/last modified
        /// </summary>
        /// <value>When the task was created/last modified</value>
        [DataMember(Name="at", EmitDefaultValue=false)]
        public string At { get; set; }

        /// <summary>
        /// Gets or Sets ClientName
        /// </summary>
        [DataMember(Name="client_name", EmitDefaultValue=false)]
        public string ClientName { get; set; }

        /// <summary>
        /// Estimation time for this task in seconds
        /// </summary>
        /// <value>Estimation time for this task in seconds</value>
        [DataMember(Name="estimated_seconds", EmitDefaultValue=false)]
        public long? EstimatedSeconds { get; set; }

        /// <summary>
        /// Task ID
        /// </summary>
        /// <value>Task ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Task Name
        /// </summary>
        /// <value>Task Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public string Permissions { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        /// <value>Metadata</value>
        [DataMember(Name="project_color", EmitDefaultValue=false)]
        public string ProjectColor { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        /// <value>Project ID</value>
        [DataMember(Name="project_id", EmitDefaultValue=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets ProjectName
        /// </summary>
        [DataMember(Name="project_name", EmitDefaultValue=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Whether this is a recurring task
        /// </summary>
        /// <value>Whether this is a recurring task</value>
        [DataMember(Name="recurring", EmitDefaultValue=false)]
        public bool? Recurring { get; set; }

        /// <summary>
        /// When the task was deleted
        /// </summary>
        /// <value>When the task was deleted</value>
        [DataMember(Name="server_deleted_at", EmitDefaultValue=false)]
        public string ServerDeletedAt { get; set; }

        /// <summary>
        /// Task assignee, if set above this will be the toggl_account_id for that user
        /// </summary>
        /// <value>Task assignee, if set above this will be the toggl_account_id for that user</value>
        [DataMember(Name="toggl_accounts_id", EmitDefaultValue=false)]
        public string TogglAccountsId { get; set; }

        /// <summary>
        /// The value tracked_seconds is in milliseconds, not in seconds.
        /// </summary>
        /// <value>The value tracked_seconds is in milliseconds, not in seconds.</value>
        [DataMember(Name="tracked_seconds", EmitDefaultValue=false)]
        public long? TrackedSeconds { get; set; }

        /// <summary>
        /// Task assignee, if available
        /// </summary>
        /// <value>Task assignee, if available</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// Workspace ID
        /// </summary>
        /// <value>Workspace ID</value>
        [DataMember(Name="workspace_id", EmitDefaultValue=false)]
        public long? WorkspaceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelsTask {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  At: ").Append(At).Append("\n");
            sb.Append("  ClientName: ").Append(ClientName).Append("\n");
            sb.Append("  EstimatedSeconds: ").Append(EstimatedSeconds).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  ProjectColor: ").Append(ProjectColor).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
            sb.Append("  Recurring: ").Append(Recurring).Append("\n");
            sb.Append("  ServerDeletedAt: ").Append(ServerDeletedAt).Append("\n");
            sb.Append("  TogglAccountsId: ").Append(TogglAccountsId).Append("\n");
            sb.Append("  TrackedSeconds: ").Append(TrackedSeconds).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as ModelsTask);
        }

        /// <summary>
        /// Returns true if ModelsTask instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelsTask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelsTask input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.At == input.At ||
                    (this.At != null &&
                    this.At.Equals(input.At))
                ) && 
                (
                    this.ClientName == input.ClientName ||
                    (this.ClientName != null &&
                    this.ClientName.Equals(input.ClientName))
                ) && 
                (
                    this.EstimatedSeconds == input.EstimatedSeconds ||
                    (this.EstimatedSeconds != null &&
                    this.EstimatedSeconds.Equals(input.EstimatedSeconds))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
                ) && 
                (
                    this.ProjectColor == input.ProjectColor ||
                    (this.ProjectColor != null &&
                    this.ProjectColor.Equals(input.ProjectColor))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
                ) && 
                (
                    this.Recurring == input.Recurring ||
                    (this.Recurring != null &&
                    this.Recurring.Equals(input.Recurring))
                ) && 
                (
                    this.ServerDeletedAt == input.ServerDeletedAt ||
                    (this.ServerDeletedAt != null &&
                    this.ServerDeletedAt.Equals(input.ServerDeletedAt))
                ) && 
                (
                    this.TogglAccountsId == input.TogglAccountsId ||
                    (this.TogglAccountsId != null &&
                    this.TogglAccountsId.Equals(input.TogglAccountsId))
                ) && 
                (
                    this.TrackedSeconds == input.TrackedSeconds ||
                    (this.TrackedSeconds != null &&
                    this.TrackedSeconds.Equals(input.TrackedSeconds))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.At != null)
                    hashCode = hashCode * 59 + this.At.GetHashCode();
                if (this.ClientName != null)
                    hashCode = hashCode * 59 + this.ClientName.GetHashCode();
                if (this.EstimatedSeconds != null)
                    hashCode = hashCode * 59 + this.EstimatedSeconds.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.ProjectColor != null)
                    hashCode = hashCode * 59 + this.ProjectColor.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null)
                    hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.Recurring != null)
                    hashCode = hashCode * 59 + this.Recurring.GetHashCode();
                if (this.ServerDeletedAt != null)
                    hashCode = hashCode * 59 + this.ServerDeletedAt.GetHashCode();
                if (this.TogglAccountsId != null)
                    hashCode = hashCode * 59 + this.TogglAccountsId.GetHashCode();
                if (this.TrackedSeconds != null)
                    hashCode = hashCode * 59 + this.TrackedSeconds.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
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
