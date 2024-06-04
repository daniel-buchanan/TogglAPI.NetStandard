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
    /// ModelsProjectStatistics
    /// </summary>
    [DataContract]
    public partial class ModelsProjectStatistics :  IEquatable<ModelsProjectStatistics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsProjectStatistics" /> class.
        /// </summary>
        /// <param name="earliestTimeEntry">earliestTimeEntry.</param>
        /// <param name="latestTimeEntry">latestTimeEntry.</param>
        public ModelsProjectStatistics(string earliestTimeEntry = default(string), string latestTimeEntry = default(string))
        {
            this.EarliestTimeEntry = earliestTimeEntry;
            this.LatestTimeEntry = latestTimeEntry;
        }
        
        /// <summary>
        /// Gets or Sets EarliestTimeEntry
        /// </summary>
        [DataMember(Name="earliest_time_entry", EmitDefaultValue=false)]
        public string EarliestTimeEntry { get; set; }

        /// <summary>
        /// Gets or Sets LatestTimeEntry
        /// </summary>
        [DataMember(Name="latest_time_entry", EmitDefaultValue=false)]
        public string LatestTimeEntry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelsProjectStatistics {\n");
            sb.Append("  EarliestTimeEntry: ").Append(EarliestTimeEntry).Append("\n");
            sb.Append("  LatestTimeEntry: ").Append(LatestTimeEntry).Append("\n");
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
            return this.Equals(input as ModelsProjectStatistics);
        }

        /// <summary>
        /// Returns true if ModelsProjectStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelsProjectStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelsProjectStatistics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EarliestTimeEntry == input.EarliestTimeEntry ||
                    (this.EarliestTimeEntry != null &&
                    this.EarliestTimeEntry.Equals(input.EarliestTimeEntry))
                ) && 
                (
                    this.LatestTimeEntry == input.LatestTimeEntry ||
                    (this.LatestTimeEntry != null &&
                    this.LatestTimeEntry.Equals(input.LatestTimeEntry))
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
                if (this.EarliestTimeEntry != null)
                    hashCode = hashCode * 59 + this.EarliestTimeEntry.GetHashCode();
                if (this.LatestTimeEntry != null)
                    hashCode = hashCode * 59 + this.LatestTimeEntry.GetHashCode();
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
