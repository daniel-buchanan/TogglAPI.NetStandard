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
    /// TotalsGraph
    /// </summary>
    [DataContract]
    public partial class TotalsGraph :  IEquatable<TotalsGraph>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TotalsGraph" /> class.
        /// </summary>
        /// <param name="billableAmountInCents">billableAmountInCents.</param>
        /// <param name="byRate">byRate.</param>
        /// <param name="labourCostInCents">labourCostInCents.</param>
        /// <param name="seconds">seconds.</param>
        public TotalsGraph(long? billableAmountInCents = default(long?), Dictionary<string, long?> byRate = default(Dictionary<string, long?>), long? labourCostInCents = default(long?), long? seconds = default(long?))
        {
            this.BillableAmountInCents = billableAmountInCents;
            this.ByRate = byRate;
            this.LabourCostInCents = labourCostInCents;
            this.Seconds = seconds;
        }
        
        /// <summary>
        /// Gets or Sets BillableAmountInCents
        /// </summary>
        [DataMember(Name="billable_amount_in_cents", EmitDefaultValue=false)]
        public long? BillableAmountInCents { get; set; }

        /// <summary>
        /// Gets or Sets ByRate
        /// </summary>
        [DataMember(Name="by_rate", EmitDefaultValue=false)]
        public Dictionary<string, long?> ByRate { get; set; }

        /// <summary>
        /// Gets or Sets LabourCostInCents
        /// </summary>
        [DataMember(Name="labour_cost_in_cents", EmitDefaultValue=false)]
        public long? LabourCostInCents { get; set; }

        /// <summary>
        /// Gets or Sets Seconds
        /// </summary>
        [DataMember(Name="seconds", EmitDefaultValue=false)]
        public long? Seconds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TotalsGraph {\n");
            sb.Append("  BillableAmountInCents: ").Append(BillableAmountInCents).Append("\n");
            sb.Append("  ByRate: ").Append(ByRate).Append("\n");
            sb.Append("  LabourCostInCents: ").Append(LabourCostInCents).Append("\n");
            sb.Append("  Seconds: ").Append(Seconds).Append("\n");
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
            return this.Equals(input as TotalsGraph);
        }

        /// <summary>
        /// Returns true if TotalsGraph instances are equal
        /// </summary>
        /// <param name="input">Instance of TotalsGraph to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TotalsGraph input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BillableAmountInCents == input.BillableAmountInCents ||
                    (this.BillableAmountInCents != null &&
                    this.BillableAmountInCents.Equals(input.BillableAmountInCents))
                ) && 
                (
                    this.ByRate == input.ByRate ||
                    this.ByRate != null &&
                    this.ByRate.SequenceEqual(input.ByRate)
                ) && 
                (
                    this.LabourCostInCents == input.LabourCostInCents ||
                    (this.LabourCostInCents != null &&
                    this.LabourCostInCents.Equals(input.LabourCostInCents))
                ) && 
                (
                    this.Seconds == input.Seconds ||
                    (this.Seconds != null &&
                    this.Seconds.Equals(input.Seconds))
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
                if (this.BillableAmountInCents != null)
                    hashCode = hashCode * 59 + this.BillableAmountInCents.GetHashCode();
                if (this.ByRate != null)
                    hashCode = hashCode * 59 + this.ByRate.GetHashCode();
                if (this.LabourCostInCents != null)
                    hashCode = hashCode * 59 + this.LabourCostInCents.GetHashCode();
                if (this.Seconds != null)
                    hashCode = hashCode * 59 + this.Seconds.GetHashCode();
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
