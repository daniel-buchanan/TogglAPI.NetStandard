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
    /// ModelsTimeEntryConstraints
    /// </summary>
    [DataContract]
    public partial class ModelsTimeEntryConstraints :  IEquatable<ModelsTimeEntryConstraints>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsTimeEntryConstraints" /> class.
        /// </summary>
        /// <param name="descriptionPresent">descriptionPresent.</param>
        /// <param name="projectPresent">projectPresent.</param>
        /// <param name="tagPresent">tagPresent.</param>
        /// <param name="taskPresent">taskPresent.</param>
        /// <param name="timeEntryConstraintsEnabled">timeEntryConstraintsEnabled.</param>
        public ModelsTimeEntryConstraints(bool? descriptionPresent = default(bool?), bool? projectPresent = default(bool?), bool? tagPresent = default(bool?), bool? taskPresent = default(bool?), bool? timeEntryConstraintsEnabled = default(bool?))
        {
            this.DescriptionPresent = descriptionPresent;
            this.ProjectPresent = projectPresent;
            this.TagPresent = tagPresent;
            this.TaskPresent = taskPresent;
            this.TimeEntryConstraintsEnabled = timeEntryConstraintsEnabled;
        }
        
        /// <summary>
        /// Gets or Sets DescriptionPresent
        /// </summary>
        [DataMember(Name="description_present", EmitDefaultValue=false)]
        public bool? DescriptionPresent { get; set; }

        /// <summary>
        /// Gets or Sets ProjectPresent
        /// </summary>
        [DataMember(Name="project_present", EmitDefaultValue=false)]
        public bool? ProjectPresent { get; set; }

        /// <summary>
        /// Gets or Sets TagPresent
        /// </summary>
        [DataMember(Name="tag_present", EmitDefaultValue=false)]
        public bool? TagPresent { get; set; }

        /// <summary>
        /// Gets or Sets TaskPresent
        /// </summary>
        [DataMember(Name="task_present", EmitDefaultValue=false)]
        public bool? TaskPresent { get; set; }

        /// <summary>
        /// Gets or Sets TimeEntryConstraintsEnabled
        /// </summary>
        [DataMember(Name="time_entry_constraints_enabled", EmitDefaultValue=false)]
        public bool? TimeEntryConstraintsEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelsTimeEntryConstraints {\n");
            sb.Append("  DescriptionPresent: ").Append(DescriptionPresent).Append("\n");
            sb.Append("  ProjectPresent: ").Append(ProjectPresent).Append("\n");
            sb.Append("  TagPresent: ").Append(TagPresent).Append("\n");
            sb.Append("  TaskPresent: ").Append(TaskPresent).Append("\n");
            sb.Append("  TimeEntryConstraintsEnabled: ").Append(TimeEntryConstraintsEnabled).Append("\n");
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
            return this.Equals(input as ModelsTimeEntryConstraints);
        }

        /// <summary>
        /// Returns true if ModelsTimeEntryConstraints instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelsTimeEntryConstraints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelsTimeEntryConstraints input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DescriptionPresent == input.DescriptionPresent ||
                    (this.DescriptionPresent != null &&
                    this.DescriptionPresent.Equals(input.DescriptionPresent))
                ) && 
                (
                    this.ProjectPresent == input.ProjectPresent ||
                    (this.ProjectPresent != null &&
                    this.ProjectPresent.Equals(input.ProjectPresent))
                ) && 
                (
                    this.TagPresent == input.TagPresent ||
                    (this.TagPresent != null &&
                    this.TagPresent.Equals(input.TagPresent))
                ) && 
                (
                    this.TaskPresent == input.TaskPresent ||
                    (this.TaskPresent != null &&
                    this.TaskPresent.Equals(input.TaskPresent))
                ) && 
                (
                    this.TimeEntryConstraintsEnabled == input.TimeEntryConstraintsEnabled ||
                    (this.TimeEntryConstraintsEnabled != null &&
                    this.TimeEntryConstraintsEnabled.Equals(input.TimeEntryConstraintsEnabled))
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
                if (this.DescriptionPresent != null)
                    hashCode = hashCode * 59 + this.DescriptionPresent.GetHashCode();
                if (this.ProjectPresent != null)
                    hashCode = hashCode * 59 + this.ProjectPresent.GetHashCode();
                if (this.TagPresent != null)
                    hashCode = hashCode * 59 + this.TagPresent.GetHashCode();
                if (this.TaskPresent != null)
                    hashCode = hashCode * 59 + this.TaskPresent.GetHashCode();
                if (this.TimeEntryConstraintsEnabled != null)
                    hashCode = hashCode * 59 + this.TimeEntryConstraintsEnabled.GetHashCode();
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
