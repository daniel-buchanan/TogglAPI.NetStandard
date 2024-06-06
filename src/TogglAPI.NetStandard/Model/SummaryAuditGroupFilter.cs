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
    /// SummaryAuditGroupFilter
    /// </summary>
    [DataContract]
    public partial class SummaryAuditGroupFilter :  IEquatable<SummaryAuditGroupFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryAuditGroupFilter" /> class.
        /// </summary>
        /// <param name="currency">Audit currency, optional, example \&quot;USD\&quot;, premium feature..</param>
        /// <param name="maxAmountCents">Audit max amount in cents, optional, premium feature..</param>
        /// <param name="maxDurationSeconds">Audit max duration in seconds, optional, premium feature..</param>
        /// <param name="minAmountCents">Audit min amount in cents, optional, premium feature..</param>
        /// <param name="minDurationSeconds">Audit min duration in seconds, optional, premium feature..</param>
        public SummaryAuditGroupFilter(string currency = default(string), long? maxAmountCents = default(long?), long? maxDurationSeconds = default(long?), long? minAmountCents = default(long?), long? minDurationSeconds = default(long?))
        {
            this.Currency = currency;
            this.MaxAmountCents = maxAmountCents;
            this.MaxDurationSeconds = maxDurationSeconds;
            this.MinAmountCents = minAmountCents;
            this.MinDurationSeconds = minDurationSeconds;
        }
        
        /// <summary>
        /// Audit currency, optional, example \&quot;USD\&quot;, premium feature.
        /// </summary>
        /// <value>Audit currency, optional, example \&quot;USD\&quot;, premium feature.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Audit max amount in cents, optional, premium feature.
        /// </summary>
        /// <value>Audit max amount in cents, optional, premium feature.</value>
        [DataMember(Name="max_amount_cents", EmitDefaultValue=false)]
        public long? MaxAmountCents { get; set; }

        /// <summary>
        /// Audit max duration in seconds, optional, premium feature.
        /// </summary>
        /// <value>Audit max duration in seconds, optional, premium feature.</value>
        [DataMember(Name="max_duration_seconds", EmitDefaultValue=false)]
        public long? MaxDurationSeconds { get; set; }

        /// <summary>
        /// Audit min amount in cents, optional, premium feature.
        /// </summary>
        /// <value>Audit min amount in cents, optional, premium feature.</value>
        [DataMember(Name="min_amount_cents", EmitDefaultValue=false)]
        public long? MinAmountCents { get; set; }

        /// <summary>
        /// Audit min duration in seconds, optional, premium feature.
        /// </summary>
        /// <value>Audit min duration in seconds, optional, premium feature.</value>
        [DataMember(Name="min_duration_seconds", EmitDefaultValue=false)]
        public long? MinDurationSeconds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SummaryAuditGroupFilter {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  MaxAmountCents: ").Append(MaxAmountCents).Append("\n");
            sb.Append("  MaxDurationSeconds: ").Append(MaxDurationSeconds).Append("\n");
            sb.Append("  MinAmountCents: ").Append(MinAmountCents).Append("\n");
            sb.Append("  MinDurationSeconds: ").Append(MinDurationSeconds).Append("\n");
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
            return this.Equals(input as SummaryAuditGroupFilter);
        }

        /// <summary>
        /// Returns true if SummaryAuditGroupFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of SummaryAuditGroupFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SummaryAuditGroupFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.MaxAmountCents == input.MaxAmountCents ||
                    (this.MaxAmountCents != null &&
                    this.MaxAmountCents.Equals(input.MaxAmountCents))
                ) && 
                (
                    this.MaxDurationSeconds == input.MaxDurationSeconds ||
                    (this.MaxDurationSeconds != null &&
                    this.MaxDurationSeconds.Equals(input.MaxDurationSeconds))
                ) && 
                (
                    this.MinAmountCents == input.MinAmountCents ||
                    (this.MinAmountCents != null &&
                    this.MinAmountCents.Equals(input.MinAmountCents))
                ) && 
                (
                    this.MinDurationSeconds == input.MinDurationSeconds ||
                    (this.MinDurationSeconds != null &&
                    this.MinDurationSeconds.Equals(input.MinDurationSeconds))
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
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.MaxAmountCents != null)
                    hashCode = hashCode * 59 + this.MaxAmountCents.GetHashCode();
                if (this.MaxDurationSeconds != null)
                    hashCode = hashCode * 59 + this.MaxDurationSeconds.GetHashCode();
                if (this.MinAmountCents != null)
                    hashCode = hashCode * 59 + this.MinAmountCents.GetHashCode();
                if (this.MinDurationSeconds != null)
                    hashCode = hashCode * 59 + this.MinDurationSeconds.GetHashCode();
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