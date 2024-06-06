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
    /// HandlercalendarPatchCalendar
    /// </summary>
    [DataContract]
    public partial class HandlercalendarPatchCalendar :  IEquatable<HandlercalendarPatchCalendar>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HandlercalendarPatchCalendar" /> class.
        /// </summary>
        /// <param name="defaultPlannedTaskId">defaultPlannedTaskId.</param>
        /// <param name="defaultProjectId">defaultProjectId.</param>
        /// <param name="defaultWorkspaceId">defaultWorkspaceId.</param>
        /// <param name="remindTracking">The following fields are deprecated but we need to keep them for backward compatibility with previous versions of mobile apps.</param>
        /// <param name="selected">selected.</param>
        public HandlercalendarPatchCalendar(long? defaultPlannedTaskId = default(long?), long? defaultProjectId = default(long?), long? defaultWorkspaceId = default(long?), bool? remindTracking = default(bool?), bool? selected = default(bool?))
        {
            this.DefaultPlannedTaskId = defaultPlannedTaskId;
            this.DefaultProjectId = defaultProjectId;
            this.DefaultWorkspaceId = defaultWorkspaceId;
            this.RemindTracking = remindTracking;
            this.Selected = selected;
        }
        
        /// <summary>
        /// Gets or Sets DefaultPlannedTaskId
        /// </summary>
        [DataMember(Name="default_planned_task_id", EmitDefaultValue=false)]
        public long? DefaultPlannedTaskId { get; set; }

        /// <summary>
        /// Gets or Sets DefaultProjectId
        /// </summary>
        [DataMember(Name="default_project_id", EmitDefaultValue=false)]
        public long? DefaultProjectId { get; set; }

        /// <summary>
        /// Gets or Sets DefaultWorkspaceId
        /// </summary>
        [DataMember(Name="default_workspace_id", EmitDefaultValue=false)]
        public long? DefaultWorkspaceId { get; set; }

        /// <summary>
        /// The following fields are deprecated but we need to keep them for backward compatibility with previous versions of mobile apps
        /// </summary>
        /// <value>The following fields are deprecated but we need to keep them for backward compatibility with previous versions of mobile apps</value>
        [DataMember(Name="remind_tracking", EmitDefaultValue=false)]
        public bool? RemindTracking { get; set; }

        /// <summary>
        /// Gets or Sets Selected
        /// </summary>
        [DataMember(Name="selected", EmitDefaultValue=false)]
        public bool? Selected { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HandlercalendarPatchCalendar {\n");
            sb.Append("  DefaultPlannedTaskId: ").Append(DefaultPlannedTaskId).Append("\n");
            sb.Append("  DefaultProjectId: ").Append(DefaultProjectId).Append("\n");
            sb.Append("  DefaultWorkspaceId: ").Append(DefaultWorkspaceId).Append("\n");
            sb.Append("  RemindTracking: ").Append(RemindTracking).Append("\n");
            sb.Append("  Selected: ").Append(Selected).Append("\n");
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
            return this.Equals(input as HandlercalendarPatchCalendar);
        }

        /// <summary>
        /// Returns true if HandlercalendarPatchCalendar instances are equal
        /// </summary>
        /// <param name="input">Instance of HandlercalendarPatchCalendar to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HandlercalendarPatchCalendar input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultPlannedTaskId == input.DefaultPlannedTaskId ||
                    (this.DefaultPlannedTaskId != null &&
                    this.DefaultPlannedTaskId.Equals(input.DefaultPlannedTaskId))
                ) && 
                (
                    this.DefaultProjectId == input.DefaultProjectId ||
                    (this.DefaultProjectId != null &&
                    this.DefaultProjectId.Equals(input.DefaultProjectId))
                ) && 
                (
                    this.DefaultWorkspaceId == input.DefaultWorkspaceId ||
                    (this.DefaultWorkspaceId != null &&
                    this.DefaultWorkspaceId.Equals(input.DefaultWorkspaceId))
                ) && 
                (
                    this.RemindTracking == input.RemindTracking ||
                    (this.RemindTracking != null &&
                    this.RemindTracking.Equals(input.RemindTracking))
                ) && 
                (
                    this.Selected == input.Selected ||
                    (this.Selected != null &&
                    this.Selected.Equals(input.Selected))
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
                if (this.DefaultPlannedTaskId != null)
                    hashCode = hashCode * 59 + this.DefaultPlannedTaskId.GetHashCode();
                if (this.DefaultProjectId != null)
                    hashCode = hashCode * 59 + this.DefaultProjectId.GetHashCode();
                if (this.DefaultWorkspaceId != null)
                    hashCode = hashCode * 59 + this.DefaultWorkspaceId.GetHashCode();
                if (this.RemindTracking != null)
                    hashCode = hashCode * 59 + this.RemindTracking.GetHashCode();
                if (this.Selected != null)
                    hashCode = hashCode * 59 + this.Selected.GetHashCode();
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
