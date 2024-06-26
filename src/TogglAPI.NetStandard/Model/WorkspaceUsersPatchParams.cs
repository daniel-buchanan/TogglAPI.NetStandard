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
    /// WorkspaceUsersPatchParams
    /// </summary>
    [DataContract]
    public partial class WorkspaceUsersPatchParams :  IEquatable<WorkspaceUsersPatchParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceUsersPatchParams" /> class.
        /// </summary>
        /// <param name="delete">Workspace user IDs to be deleted.</param>
        public WorkspaceUsersPatchParams(List<long?> delete = default(List<long?>))
        {
            this.Delete = delete;
        }
        
        /// <summary>
        /// Workspace user IDs to be deleted
        /// </summary>
        /// <value>Workspace user IDs to be deleted</value>
        [DataMember(Name="delete", EmitDefaultValue=false)]
        public List<long?> Delete { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkspaceUsersPatchParams {\n");
            sb.Append("  Delete: ").Append(Delete).Append("\n");
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
            return this.Equals(input as WorkspaceUsersPatchParams);
        }

        /// <summary>
        /// Returns true if WorkspaceUsersPatchParams instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkspaceUsersPatchParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceUsersPatchParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Delete == input.Delete ||
                    this.Delete != null &&
                    this.Delete.SequenceEqual(input.Delete)
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
                if (this.Delete != null)
                    hashCode = hashCode * 59 + this.Delete.GetHashCode();
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
