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
    /// HandlergoalsCreatePayload
    /// </summary>
    [DataContract]
    public partial class HandlergoalsCreatePayload :  IEquatable<HandlergoalsCreatePayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HandlergoalsCreatePayload" /> class.
        /// </summary>
        /// <param name="billable">billable.</param>
        /// <param name="comparison">comparison.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="icon">icon.</param>
        /// <param name="name">name.</param>
        /// <param name="plannedTaskIds">plannedTaskIds.</param>
        /// <param name="projectIds">projectIds.</param>
        /// <param name="recurrence">recurrence.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="tagIds">tagIds.</param>
        /// <param name="targetSeconds">targetSeconds.</param>
        /// <param name="userId">userId.</param>
        public HandlergoalsCreatePayload(bool? billable = default(bool?), string comparison = default(string), string endDate = default(string), long? icon = default(long?), string name = default(string), List<long?> plannedTaskIds = default(List<long?>), List<long?> projectIds = default(List<long?>), string recurrence = default(string), string startDate = default(string), List<long?> tagIds = default(List<long?>), long? targetSeconds = default(long?), long? userId = default(long?))
        {
            this.Billable = billable;
            this.Comparison = comparison;
            this.EndDate = endDate;
            this.Icon = icon;
            this.Name = name;
            this.PlannedTaskIds = plannedTaskIds;
            this.ProjectIds = projectIds;
            this.Recurrence = recurrence;
            this.StartDate = startDate;
            this.TagIds = tagIds;
            this.TargetSeconds = targetSeconds;
            this.UserId = userId;
        }
        
        /// <summary>
        /// Gets or Sets Billable
        /// </summary>
        [DataMember(Name="billable", EmitDefaultValue=false)]
        public bool? Billable { get; set; }

        /// <summary>
        /// Gets or Sets Comparison
        /// </summary>
        [DataMember(Name="comparison", EmitDefaultValue=false)]
        public string Comparison { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Icon
        /// </summary>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        public long? Icon { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PlannedTaskIds
        /// </summary>
        [DataMember(Name="planned_task_ids", EmitDefaultValue=false)]
        public List<long?> PlannedTaskIds { get; set; }

        /// <summary>
        /// Gets or Sets ProjectIds
        /// </summary>
        [DataMember(Name="project_ids", EmitDefaultValue=false)]
        public List<long?> ProjectIds { get; set; }

        /// <summary>
        /// Gets or Sets Recurrence
        /// </summary>
        [DataMember(Name="recurrence", EmitDefaultValue=false)]
        public string Recurrence { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or Sets TagIds
        /// </summary>
        [DataMember(Name="tag_ids", EmitDefaultValue=false)]
        public List<long?> TagIds { get; set; }

        /// <summary>
        /// Gets or Sets TargetSeconds
        /// </summary>
        [DataMember(Name="target_seconds", EmitDefaultValue=false)]
        public long? TargetSeconds { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HandlergoalsCreatePayload {\n");
            sb.Append("  Billable: ").Append(Billable).Append("\n");
            sb.Append("  Comparison: ").Append(Comparison).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PlannedTaskIds: ").Append(PlannedTaskIds).Append("\n");
            sb.Append("  ProjectIds: ").Append(ProjectIds).Append("\n");
            sb.Append("  Recurrence: ").Append(Recurrence).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  TagIds: ").Append(TagIds).Append("\n");
            sb.Append("  TargetSeconds: ").Append(TargetSeconds).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as HandlergoalsCreatePayload);
        }

        /// <summary>
        /// Returns true if HandlergoalsCreatePayload instances are equal
        /// </summary>
        /// <param name="input">Instance of HandlergoalsCreatePayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HandlergoalsCreatePayload input)
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
                    this.Comparison == input.Comparison ||
                    (this.Comparison != null &&
                    this.Comparison.Equals(input.Comparison))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PlannedTaskIds == input.PlannedTaskIds ||
                    this.PlannedTaskIds != null &&
                    this.PlannedTaskIds.SequenceEqual(input.PlannedTaskIds)
                ) && 
                (
                    this.ProjectIds == input.ProjectIds ||
                    this.ProjectIds != null &&
                    this.ProjectIds.SequenceEqual(input.ProjectIds)
                ) && 
                (
                    this.Recurrence == input.Recurrence ||
                    (this.Recurrence != null &&
                    this.Recurrence.Equals(input.Recurrence))
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
                    this.TargetSeconds == input.TargetSeconds ||
                    (this.TargetSeconds != null &&
                    this.TargetSeconds.Equals(input.TargetSeconds))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.Comparison != null)
                    hashCode = hashCode * 59 + this.Comparison.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PlannedTaskIds != null)
                    hashCode = hashCode * 59 + this.PlannedTaskIds.GetHashCode();
                if (this.ProjectIds != null)
                    hashCode = hashCode * 59 + this.ProjectIds.GetHashCode();
                if (this.Recurrence != null)
                    hashCode = hashCode * 59 + this.Recurrence.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.TagIds != null)
                    hashCode = hashCode * 59 + this.TagIds.GetHashCode();
                if (this.TargetSeconds != null)
                    hashCode = hashCode * 59 + this.TargetSeconds.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
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
