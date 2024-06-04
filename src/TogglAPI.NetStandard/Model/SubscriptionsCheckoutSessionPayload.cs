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
    /// SubscriptionsCheckoutSessionPayload
    /// </summary>
    [DataContract]
    public partial class SubscriptionsCheckoutSessionPayload :  IEquatable<SubscriptionsCheckoutSessionPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsCheckoutSessionPayload" /> class.
        /// </summary>
        /// <param name="cancelUrl">cancelUrl.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="countryId">countryId.</param>
        /// <param name="priceTag">priceTag.</param>
        /// <param name="referral">referral.</param>
        /// <param name="subdivisionId">subdivisionId.</param>
        /// <param name="successUrl">successUrl.</param>
        /// <param name="tax">tax.</param>
        /// <param name="zip">zip.</param>
        public SubscriptionsCheckoutSessionPayload(string cancelUrl = default(string), string countryCode = default(string), int? countryId = default(int?), string priceTag = default(string), string referral = default(string), int? subdivisionId = default(int?), string successUrl = default(string), string tax = default(string), string zip = default(string))
        {
            this.CancelUrl = cancelUrl;
            this.CountryCode = countryCode;
            this.CountryId = countryId;
            this.PriceTag = priceTag;
            this.Referral = referral;
            this.SubdivisionId = subdivisionId;
            this.SuccessUrl = successUrl;
            this.Tax = tax;
            this.Zip = zip;
        }
        
        /// <summary>
        /// Gets or Sets CancelUrl
        /// </summary>
        [DataMember(Name="cancel_url", EmitDefaultValue=false)]
        public string CancelUrl { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name="country_code", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets CountryId
        /// </summary>
        [DataMember(Name="country_id", EmitDefaultValue=false)]
        public int? CountryId { get; set; }

        /// <summary>
        /// Gets or Sets PriceTag
        /// </summary>
        [DataMember(Name="price_tag", EmitDefaultValue=false)]
        public string PriceTag { get; set; }

        /// <summary>
        /// Gets or Sets Referral
        /// </summary>
        [DataMember(Name="referral", EmitDefaultValue=false)]
        public string Referral { get; set; }

        /// <summary>
        /// Gets or Sets SubdivisionId
        /// </summary>
        [DataMember(Name="subdivision_id", EmitDefaultValue=false)]
        public int? SubdivisionId { get; set; }

        /// <summary>
        /// Gets or Sets SuccessUrl
        /// </summary>
        [DataMember(Name="success_url", EmitDefaultValue=false)]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// Gets or Sets Tax
        /// </summary>
        [DataMember(Name="tax", EmitDefaultValue=false)]
        public string Tax { get; set; }

        /// <summary>
        /// Gets or Sets Zip
        /// </summary>
        [DataMember(Name="zip", EmitDefaultValue=false)]
        public string Zip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionsCheckoutSessionPayload {\n");
            sb.Append("  CancelUrl: ").Append(CancelUrl).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  PriceTag: ").Append(PriceTag).Append("\n");
            sb.Append("  Referral: ").Append(Referral).Append("\n");
            sb.Append("  SubdivisionId: ").Append(SubdivisionId).Append("\n");
            sb.Append("  SuccessUrl: ").Append(SuccessUrl).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
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
            return this.Equals(input as SubscriptionsCheckoutSessionPayload);
        }

        /// <summary>
        /// Returns true if SubscriptionsCheckoutSessionPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionsCheckoutSessionPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionsCheckoutSessionPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CancelUrl == input.CancelUrl ||
                    (this.CancelUrl != null &&
                    this.CancelUrl.Equals(input.CancelUrl))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.CountryId == input.CountryId ||
                    (this.CountryId != null &&
                    this.CountryId.Equals(input.CountryId))
                ) && 
                (
                    this.PriceTag == input.PriceTag ||
                    (this.PriceTag != null &&
                    this.PriceTag.Equals(input.PriceTag))
                ) && 
                (
                    this.Referral == input.Referral ||
                    (this.Referral != null &&
                    this.Referral.Equals(input.Referral))
                ) && 
                (
                    this.SubdivisionId == input.SubdivisionId ||
                    (this.SubdivisionId != null &&
                    this.SubdivisionId.Equals(input.SubdivisionId))
                ) && 
                (
                    this.SuccessUrl == input.SuccessUrl ||
                    (this.SuccessUrl != null &&
                    this.SuccessUrl.Equals(input.SuccessUrl))
                ) && 
                (
                    this.Tax == input.Tax ||
                    (this.Tax != null &&
                    this.Tax.Equals(input.Tax))
                ) && 
                (
                    this.Zip == input.Zip ||
                    (this.Zip != null &&
                    this.Zip.Equals(input.Zip))
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
                if (this.CancelUrl != null)
                    hashCode = hashCode * 59 + this.CancelUrl.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.CountryId != null)
                    hashCode = hashCode * 59 + this.CountryId.GetHashCode();
                if (this.PriceTag != null)
                    hashCode = hashCode * 59 + this.PriceTag.GetHashCode();
                if (this.Referral != null)
                    hashCode = hashCode * 59 + this.Referral.GetHashCode();
                if (this.SubdivisionId != null)
                    hashCode = hashCode * 59 + this.SubdivisionId.GetHashCode();
                if (this.SuccessUrl != null)
                    hashCode = hashCode * 59 + this.SuccessUrl.GetHashCode();
                if (this.Tax != null)
                    hashCode = hashCode * 59 + this.Tax.GetHashCode();
                if (this.Zip != null)
                    hashCode = hashCode * 59 + this.Zip.GetHashCode();
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
