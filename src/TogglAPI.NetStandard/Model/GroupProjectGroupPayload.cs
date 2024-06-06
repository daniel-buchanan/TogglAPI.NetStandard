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
    /// GroupProjectGroupPayload
    /// </summary>
    [DataContract]
    public partial class GroupProjectGroupPayload :  IEquatable<GroupProjectGroupPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupProjectGroupPayload" /> class.
        /// </summary>
        /// <param name="groupId">Group ID.</param>
        /// <param name="projectId">Project ID.</param>
        public GroupProjectGroupPayload(long? groupId = default(long?), long? projectId = default(long?))
        {
            this.GroupId = groupId;
            this.ProjectId = projectId;
        }
        
        /// <summary>
        /// Group ID
        /// </summary>
        /// <value>Group ID</value>
        [DataMember(Name="group_id", EmitDefaultValue=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        /// <value>Project ID</value>
        [DataMember(Name="project_id", EmitDefaultValue=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupProjectGroupPayload {\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
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
            return this.Equals(input as GroupProjectGroupPayload);
        }

        /// <summary>
        /// Returns true if GroupProjectGroupPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupProjectGroupPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupProjectGroupPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
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
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
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