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
    /// GoalsInsightResponse
    /// </summary>
    [DataContract]
    public partial class GoalsInsightResponse :  IEquatable<GoalsInsightResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoalsInsightResponse" /> class.
        /// </summary>
        /// <param name="cadences">cadences.</param>
        /// <param name="value">value.</param>
        public GoalsInsightResponse(long? cadences = default(long?), long? value = default(long?))
        {
            this.Cadences = cadences;
            this.Value = value;
        }
        
        /// <summary>
        /// Gets or Sets Cadences
        /// </summary>
        [DataMember(Name="cadences", EmitDefaultValue=false)]
        public long? Cadences { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public long? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GoalsInsightResponse {\n");
            sb.Append("  Cadences: ").Append(Cadences).Append("\n");
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
            return this.Equals(input as GoalsInsightResponse);
        }

        /// <summary>
        /// Returns true if GoalsInsightResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GoalsInsightResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoalsInsightResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cadences == input.Cadences ||
                    (this.Cadences != null &&
                    this.Cadences.Equals(input.Cadences))
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
                if (this.Cadences != null)
                    hashCode = hashCode * 59 + this.Cadences.GetHashCode();
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