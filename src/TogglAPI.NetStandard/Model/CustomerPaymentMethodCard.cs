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
    /// CustomerPaymentMethodCard
    /// </summary>
    [DataContract]
    public partial class CustomerPaymentMethodCard :  IEquatable<CustomerPaymentMethodCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerPaymentMethodCard" /> class.
        /// </summary>
        /// <param name="brand">brand.</param>
        /// <param name="country">country.</param>
        /// <param name="expMonth">expMonth.</param>
        /// <param name="expYear">expYear.</param>
        /// <param name="last4">last4.</param>
        public CustomerPaymentMethodCard(string brand = default(string), string country = default(string), long? expMonth = default(long?), long? expYear = default(long?), string last4 = default(string))
        {
            this.Brand = brand;
            this.Country = country;
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
            this.Last4 = last4;
        }
        
        /// <summary>
        /// Gets or Sets Brand
        /// </summary>
        [DataMember(Name="brand", EmitDefaultValue=false)]
        public string Brand { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets ExpMonth
        /// </summary>
        [DataMember(Name="exp_month", EmitDefaultValue=false)]
        public long? ExpMonth { get; set; }

        /// <summary>
        /// Gets or Sets ExpYear
        /// </summary>
        [DataMember(Name="exp_year", EmitDefaultValue=false)]
        public long? ExpYear { get; set; }

        /// <summary>
        /// Gets or Sets Last4
        /// </summary>
        [DataMember(Name="last4", EmitDefaultValue=false)]
        public string Last4 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerPaymentMethodCard {\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  ExpMonth: ").Append(ExpMonth).Append("\n");
            sb.Append("  ExpYear: ").Append(ExpYear).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
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
            return this.Equals(input as CustomerPaymentMethodCard);
        }

        /// <summary>
        /// Returns true if CustomerPaymentMethodCard instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerPaymentMethodCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerPaymentMethodCard input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.ExpMonth == input.ExpMonth ||
                    (this.ExpMonth != null &&
                    this.ExpMonth.Equals(input.ExpMonth))
                ) && 
                (
                    this.ExpYear == input.ExpYear ||
                    (this.ExpYear != null &&
                    this.ExpYear.Equals(input.ExpYear))
                ) && 
                (
                    this.Last4 == input.Last4 ||
                    (this.Last4 != null &&
                    this.Last4.Equals(input.Last4))
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
                if (this.Brand != null)
                    hashCode = hashCode * 59 + this.Brand.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.ExpMonth != null)
                    hashCode = hashCode * 59 + this.ExpMonth.GetHashCode();
                if (this.ExpYear != null)
                    hashCode = hashCode * 59 + this.ExpYear.GetHashCode();
                if (this.Last4 != null)
                    hashCode = hashCode * 59 + this.Last4.GetHashCode();
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