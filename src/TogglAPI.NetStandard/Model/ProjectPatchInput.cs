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
    /// ProjectPatchInput
    /// </summary>
    [DataContract]
    public partial class ProjectPatchInput :  IEquatable<ProjectPatchInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectPatchInput" /> class.
        /// </summary>
        /// <param name="op">Patch operation to perform, one of \&quot;add\&quot;, \&quot;remove\&quot;, \&quot;replace\&quot;.</param>
        /// <param name="path">Path to the field to patch, example: \&quot;/color\&quot;.</param>
        /// <param name="value">Value to set when operation is \&quot;add\&quot; or \&quot;replace\&quot;, example: \&quot;#000000\&quot;. The value type actually depends on the field being patched..</param>
        public ProjectPatchInput(string op = default(string), string path = default(string), Object value = default(Object))
        {
            this.Op = op;
            this.Path = path;
            this.Value = value;
        }
        
        /// <summary>
        /// Patch operation to perform, one of \&quot;add\&quot;, \&quot;remove\&quot;, \&quot;replace\&quot;
        /// </summary>
        /// <value>Patch operation to perform, one of \&quot;add\&quot;, \&quot;remove\&quot;, \&quot;replace\&quot;</value>
        [DataMember(Name="op", EmitDefaultValue=false)]
        public string Op { get; set; }

        /// <summary>
        /// Path to the field to patch, example: \&quot;/color\&quot;
        /// </summary>
        /// <value>Path to the field to patch, example: \&quot;/color\&quot;</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Value to set when operation is \&quot;add\&quot; or \&quot;replace\&quot;, example: \&quot;#000000\&quot;. The value type actually depends on the field being patched.
        /// </summary>
        /// <value>Value to set when operation is \&quot;add\&quot; or \&quot;replace\&quot;, example: \&quot;#000000\&quot;. The value type actually depends on the field being patched.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Object Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectPatchInput {\n");
            sb.Append("  Op: ").Append(Op).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as ProjectPatchInput);
        }

        /// <summary>
        /// Returns true if ProjectPatchInput instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectPatchInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectPatchInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Op == input.Op ||
                    (this.Op != null &&
                    this.Op.Equals(input.Op))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Op != null)
                    hashCode = hashCode * 59 + this.Op.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
