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
    /// ModelsGoalStats
    /// </summary>
    [DataContract]
    public partial class ModelsGoalStats :  IEquatable<ModelsGoalStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsGoalStats" /> class.
        /// </summary>
        /// <param name="longestStreak">longestStreak.</param>
        /// <param name="status">open, finished or archived.</param>
        /// <param name="successfulCadences">successfulCadences.</param>
        /// <param name="totalCadences">totalCadences.</param>
        public ModelsGoalStats(long? longestStreak = default(long?), string status = default(string), long? successfulCadences = default(long?), long? totalCadences = default(long?))
        {
            this.LongestStreak = longestStreak;
            this.Status = status;
            this.SuccessfulCadences = successfulCadences;
            this.TotalCadences = totalCadences;
        }
        
        /// <summary>
        /// Gets or Sets LongestStreak
        /// </summary>
        [DataMember(Name="longest_streak", EmitDefaultValue=false)]
        public long? LongestStreak { get; set; }

        /// <summary>
        /// open, finished or archived
        /// </summary>
        /// <value>open, finished or archived</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets SuccessfulCadences
        /// </summary>
        [DataMember(Name="successful_cadences", EmitDefaultValue=false)]
        public long? SuccessfulCadences { get; set; }

        /// <summary>
        /// Gets or Sets TotalCadences
        /// </summary>
        [DataMember(Name="total_cadences", EmitDefaultValue=false)]
        public long? TotalCadences { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelsGoalStats {\n");
            sb.Append("  LongestStreak: ").Append(LongestStreak).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SuccessfulCadences: ").Append(SuccessfulCadences).Append("\n");
            sb.Append("  TotalCadences: ").Append(TotalCadences).Append("\n");
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
            return this.Equals(input as ModelsGoalStats);
        }

        /// <summary>
        /// Returns true if ModelsGoalStats instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelsGoalStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelsGoalStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LongestStreak == input.LongestStreak ||
                    (this.LongestStreak != null &&
                    this.LongestStreak.Equals(input.LongestStreak))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SuccessfulCadences == input.SuccessfulCadences ||
                    (this.SuccessfulCadences != null &&
                    this.SuccessfulCadences.Equals(input.SuccessfulCadences))
                ) && 
                (
                    this.TotalCadences == input.TotalCadences ||
                    (this.TotalCadences != null &&
                    this.TotalCadences.Equals(input.TotalCadences))
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
                if (this.LongestStreak != null)
                    hashCode = hashCode * 59 + this.LongestStreak.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SuccessfulCadences != null)
                    hashCode = hashCode * 59 + this.SuccessfulCadences.GetHashCode();
                if (this.TotalCadences != null)
                    hashCode = hashCode * 59 + this.TotalCadences.GetHashCode();
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
