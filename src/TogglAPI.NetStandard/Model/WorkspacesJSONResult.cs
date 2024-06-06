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
    /// WorkspacesJSONResult
    /// </summary>
    [DataContract]
    public partial class WorkspacesJSONResult :  IEquatable<WorkspacesJSONResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspacesJSONResult" /> class.
        /// </summary>
        /// <param name="wid">wid.</param>
        public WorkspacesJSONResult(long? wid = default(long?))
        {
            this.Wid = wid;
        }
        
        /// <summary>
        /// Gets or Sets Wid
        /// </summary>
        [DataMember(Name="wid", EmitDefaultValue=false)]
        public long? Wid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkspacesJSONResult {\n");
            sb.Append("  Wid: ").Append(Wid).Append("\n");
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
            return this.Equals(input as WorkspacesJSONResult);
        }

        /// <summary>
        /// Returns true if WorkspacesJSONResult instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkspacesJSONResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspacesJSONResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Wid == input.Wid ||
                    (this.Wid != null &&
                    this.Wid.Equals(input.Wid))
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
                if (this.Wid != null)
                    hashCode = hashCode * 59 + this.Wid.GetHashCode();
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