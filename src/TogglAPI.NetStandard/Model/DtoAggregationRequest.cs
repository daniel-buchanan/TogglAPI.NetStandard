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
    /// DtoAggregationRequest
    /// </summary>
    [DataContract]
    public partial class DtoAggregationRequest :  IEquatable<DtoAggregationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoAggregationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DtoAggregationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoAggregationRequest" /> class.
        /// </summary>
        /// <param name="alias">alias.</param>
        /// <param name="function">function (required).</param>
        /// <param name="property">property (required).</param>
        public DtoAggregationRequest(string alias = default(string), string function = default(string), string property = default(string))
        {
            // to ensure "function" is required (not null)
            if (function == null)
            {
                throw new InvalidDataException("function is a required property for DtoAggregationRequest and cannot be null");
            }
            else
            {
                this.Function = function;
            }
            // to ensure "property" is required (not null)
            if (property == null)
            {
                throw new InvalidDataException("property is a required property for DtoAggregationRequest and cannot be null");
            }
            else
            {
                this.Property = property;
            }
            this.Alias = alias;
        }
        
        /// <summary>
        /// Gets or Sets Alias
        /// </summary>
        [DataMember(Name="alias", EmitDefaultValue=false)]
        public string Alias { get; set; }

        /// <summary>
        /// Gets or Sets Function
        /// </summary>
        [DataMember(Name="function", EmitDefaultValue=false)]
        public string Function { get; set; }

        /// <summary>
        /// Gets or Sets Property
        /// </summary>
        [DataMember(Name="property", EmitDefaultValue=false)]
        public string Property { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DtoAggregationRequest {\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Function: ").Append(Function).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
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
            return this.Equals(input as DtoAggregationRequest);
        }

        /// <summary>
        /// Returns true if DtoAggregationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DtoAggregationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DtoAggregationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.Function == input.Function ||
                    (this.Function != null &&
                    this.Function.Equals(input.Function))
                ) && 
                (
                    this.Property == input.Property ||
                    (this.Property != null &&
                    this.Property.Equals(input.Property))
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
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.Function != null)
                    hashCode = hashCode * 59 + this.Function.GetHashCode();
                if (this.Property != null)
                    hashCode = hashCode * 59 + this.Property.GetHashCode();
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
