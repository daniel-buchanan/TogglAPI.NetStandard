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
    /// CalculateResponse
    /// </summary>
    [DataContract]
    public partial class CalculateResponse :  IEquatable<CalculateResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateResponse" /> class.
        /// </summary>
        /// <param name="calculation">calculation.</param>
        /// <param name="currency">currency.</param>
        /// <param name="period">period.</param>
        /// <param name="taxPercentage">taxPercentage.</param>
        /// <param name="totalAmount">totalAmount.</param>
        public CalculateResponse(string calculation = default(string), string currency = default(string), int? period = default(int?), int? taxPercentage = default(int?), int? totalAmount = default(int?))
        {
            this.Calculation = calculation;
            this.Currency = currency;
            this.Period = period;
            this.TaxPercentage = taxPercentage;
            this.TotalAmount = totalAmount;
        }
        
        /// <summary>
        /// Gets or Sets Calculation
        /// </summary>
        [DataMember(Name="calculation", EmitDefaultValue=false)]
        public string Calculation { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public int? Period { get; set; }

        /// <summary>
        /// Gets or Sets TaxPercentage
        /// </summary>
        [DataMember(Name="tax_percentage", EmitDefaultValue=false)]
        public int? TaxPercentage { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmount
        /// </summary>
        [DataMember(Name="total_amount", EmitDefaultValue=false)]
        public int? TotalAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CalculateResponse {\n");
            sb.Append("  Calculation: ").Append(Calculation).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  TaxPercentage: ").Append(TaxPercentage).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
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
            return this.Equals(input as CalculateResponse);
        }

        /// <summary>
        /// Returns true if CalculateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CalculateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CalculateResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Calculation == input.Calculation ||
                    (this.Calculation != null &&
                    this.Calculation.Equals(input.Calculation))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.TaxPercentage == input.TaxPercentage ||
                    (this.TaxPercentage != null &&
                    this.TaxPercentage.Equals(input.TaxPercentage))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
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
                if (this.Calculation != null)
                    hashCode = hashCode * 59 + this.Calculation.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.TaxPercentage != null)
                    hashCode = hashCode * 59 + this.TaxPercentage.GetHashCode();
                if (this.TotalAmount != null)
                    hashCode = hashCode * 59 + this.TotalAmount.GetHashCode();
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
