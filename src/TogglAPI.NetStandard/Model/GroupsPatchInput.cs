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
    /// GroupsPatchInput
    /// </summary>
    [DataContract]
    public partial class GroupsPatchInput :  IEquatable<GroupsPatchInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsPatchInput" /> class.
        /// </summary>
        /// <param name="op">op.</param>
        /// <param name="path">path.</param>
        /// <param name="value">value.</param>
        public GroupsPatchInput(string op = default(string), string path = default(string), List<long?> value = default(List<long?>))
        {
            this.Op = op;
            this.Path = path;
            this.Value = value;
        }
        
        /// <summary>
        /// Gets or Sets Op
        /// </summary>
        [DataMember(Name="op", EmitDefaultValue=false)]
        public string Op { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public List<long?> Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupsPatchInput {\n");
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
            return this.Equals(input as GroupsPatchInput);
        }

        /// <summary>
        /// Returns true if GroupsPatchInput instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupsPatchInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupsPatchInput input)
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
                    this.Value != null &&
                    this.Value.SequenceEqual(input.Value)
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