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
    /// ModelsSuggestion
    /// </summary>
    [DataContract]
    public partial class ModelsSuggestion :  IEquatable<ModelsSuggestion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsSuggestion" /> class.
        /// </summary>
        /// <param name="accuracy">accuracy.</param>
        /// <param name="billable">billable.</param>
        /// <param name="descriptionMatch">descriptionMatch.</param>
        /// <param name="lastSeen">lastSeen.</param>
        /// <param name="projectId">projectId.</param>
        /// <param name="tagIds">tagIds.</param>
        /// <param name="taskId">taskId.</param>
        /// <param name="workspaceId">workspaceId.</param>
        public ModelsSuggestion(decimal? accuracy = default(decimal?), bool? billable = default(bool?), bool? descriptionMatch = default(bool?), string lastSeen = default(string), long? projectId = default(long?), List<long?> tagIds = default(List<long?>), long? taskId = default(long?), long? workspaceId = default(long?))
        {
            this.Accuracy = accuracy;
            this.Billable = billable;
            this.DescriptionMatch = descriptionMatch;
            this.LastSeen = lastSeen;
            this.ProjectId = projectId;
            this.TagIds = tagIds;
            this.TaskId = taskId;
            this.WorkspaceId = workspaceId;
        }
        
        /// <summary>
        /// Gets or Sets Accuracy
        /// </summary>
        [DataMember(Name="accuracy", EmitDefaultValue=false)]
        public decimal? Accuracy { get; set; }

        /// <summary>
        /// Gets or Sets Billable
        /// </summary>
        [DataMember(Name="billable", EmitDefaultValue=false)]
        public bool? Billable { get; set; }

        /// <summary>
        /// Gets or Sets DescriptionMatch
        /// </summary>
        [DataMember(Name="description_match", EmitDefaultValue=false)]
        public bool? DescriptionMatch { get; set; }

        /// <summary>
        /// Gets or Sets LastSeen
        /// </summary>
        [DataMember(Name="last_seen", EmitDefaultValue=false)]
        public string LastSeen { get; set; }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name="project_id", EmitDefaultValue=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets TagIds
        /// </summary>
        [DataMember(Name="tag_ids", EmitDefaultValue=false)]
        public List<long?> TagIds { get; set; }

        /// <summary>
        /// Gets or Sets TaskId
        /// </summary>
        [DataMember(Name="task_id", EmitDefaultValue=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// Gets or Sets WorkspaceId
        /// </summary>
        [DataMember(Name="workspace_id", EmitDefaultValue=false)]
        public long? WorkspaceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelsSuggestion {\n");
            sb.Append("  Accuracy: ").Append(Accuracy).Append("\n");
            sb.Append("  Billable: ").Append(Billable).Append("\n");
            sb.Append("  DescriptionMatch: ").Append(DescriptionMatch).Append("\n");
            sb.Append("  LastSeen: ").Append(LastSeen).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  TagIds: ").Append(TagIds).Append("\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
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
            return this.Equals(input as ModelsSuggestion);
        }

        /// <summary>
        /// Returns true if ModelsSuggestion instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelsSuggestion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelsSuggestion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Accuracy == input.Accuracy ||
                    (this.Accuracy != null &&
                    this.Accuracy.Equals(input.Accuracy))
                ) && 
                (
                    this.Billable == input.Billable ||
                    (this.Billable != null &&
                    this.Billable.Equals(input.Billable))
                ) && 
                (
                    this.DescriptionMatch == input.DescriptionMatch ||
                    (this.DescriptionMatch != null &&
                    this.DescriptionMatch.Equals(input.DescriptionMatch))
                ) && 
                (
                    this.LastSeen == input.LastSeen ||
                    (this.LastSeen != null &&
                    this.LastSeen.Equals(input.LastSeen))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.TagIds == input.TagIds ||
                    this.TagIds != null &&
                    this.TagIds.SequenceEqual(input.TagIds)
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
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
                if (this.Accuracy != null)
                    hashCode = hashCode * 59 + this.Accuracy.GetHashCode();
                if (this.Billable != null)
                    hashCode = hashCode * 59 + this.Billable.GetHashCode();
                if (this.DescriptionMatch != null)
                    hashCode = hashCode * 59 + this.DescriptionMatch.GetHashCode();
                if (this.LastSeen != null)
                    hashCode = hashCode * 59 + this.LastSeen.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.TagIds != null)
                    hashCode = hashCode * 59 + this.TagIds.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
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
