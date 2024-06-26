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
    /// ModelsTrackReminder
    /// </summary>
    [DataContract]
    public partial class ModelsTrackReminder :  IEquatable<ModelsTrackReminder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsTrackReminder" /> class.
        /// </summary>
        /// <param name="createdAt">Reminder creation time.</param>
        /// <param name="frequency">Frequency of the reminder in days, should be either 1 or 7.</param>
        /// <param name="groupIds">Groups IDs to send the reminder to.</param>
        /// <param name="reminderId">Reminder ID.</param>
        /// <param name="threshold">Threshold is the number of hours after which the reminder will be sent.</param>
        /// <param name="userIds">User IDs to send the reminder to.</param>
        /// <param name="workspaceId">Workspace ID.</param>
        public ModelsTrackReminder(string createdAt = default(string), long? frequency = default(long?), List<long?> groupIds = default(List<long?>), long? reminderId = default(long?), long? threshold = default(long?), List<long?> userIds = default(List<long?>), long? workspaceId = default(long?))
        {
            this.CreatedAt = createdAt;
            this.Frequency = frequency;
            this.GroupIds = groupIds;
            this.ReminderId = reminderId;
            this.Threshold = threshold;
            this.UserIds = userIds;
            this.WorkspaceId = workspaceId;
        }
        
        /// <summary>
        /// Reminder creation time
        /// </summary>
        /// <value>Reminder creation time</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Frequency of the reminder in days, should be either 1 or 7
        /// </summary>
        /// <value>Frequency of the reminder in days, should be either 1 or 7</value>
        [DataMember(Name="frequency", EmitDefaultValue=false)]
        public long? Frequency { get; set; }

        /// <summary>
        /// Groups IDs to send the reminder to
        /// </summary>
        /// <value>Groups IDs to send the reminder to</value>
        [DataMember(Name="group_ids", EmitDefaultValue=false)]
        public List<long?> GroupIds { get; set; }

        /// <summary>
        /// Reminder ID
        /// </summary>
        /// <value>Reminder ID</value>
        [DataMember(Name="reminder_id", EmitDefaultValue=false)]
        public long? ReminderId { get; set; }

        /// <summary>
        /// Threshold is the number of hours after which the reminder will be sent
        /// </summary>
        /// <value>Threshold is the number of hours after which the reminder will be sent</value>
        [DataMember(Name="threshold", EmitDefaultValue=false)]
        public long? Threshold { get; set; }

        /// <summary>
        /// User IDs to send the reminder to
        /// </summary>
        /// <value>User IDs to send the reminder to</value>
        [DataMember(Name="user_ids", EmitDefaultValue=false)]
        public List<long?> UserIds { get; set; }

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
            sb.Append("class ModelsTrackReminder {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  GroupIds: ").Append(GroupIds).Append("\n");
            sb.Append("  ReminderId: ").Append(ReminderId).Append("\n");
            sb.Append("  Threshold: ").Append(Threshold).Append("\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
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
            return this.Equals(input as ModelsTrackReminder);
        }

        /// <summary>
        /// Returns true if ModelsTrackReminder instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelsTrackReminder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelsTrackReminder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
                ) && 
                (
                    this.GroupIds == input.GroupIds ||
                    this.GroupIds != null &&
                    this.GroupIds.SequenceEqual(input.GroupIds)
                ) && 
                (
                    this.ReminderId == input.ReminderId ||
                    (this.ReminderId != null &&
                    this.ReminderId.Equals(input.ReminderId))
                ) && 
                (
                    this.Threshold == input.Threshold ||
                    (this.Threshold != null &&
                    this.Threshold.Equals(input.Threshold))
                ) && 
                (
                    this.UserIds == input.UserIds ||
                    this.UserIds != null &&
                    this.UserIds.SequenceEqual(input.UserIds)
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.GroupIds != null)
                    hashCode = hashCode * 59 + this.GroupIds.GetHashCode();
                if (this.ReminderId != null)
                    hashCode = hashCode * 59 + this.ReminderId.GetHashCode();
                if (this.Threshold != null)
                    hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                if (this.UserIds != null)
                    hashCode = hashCode * 59 + this.UserIds.GetHashCode();
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
