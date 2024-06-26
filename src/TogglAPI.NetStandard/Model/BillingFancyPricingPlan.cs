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
    /// BillingFancyPricingPlan
    /// </summary>
    [DataContract]
    public partial class BillingFancyPricingPlan :  IEquatable<BillingFancyPricingPlan>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingFancyPricingPlan" /> class.
        /// </summary>
        /// <param name="actualPriceInUsdCents">actualPriceInUsdCents.</param>
        /// <param name="campaign">campaign.</param>
        /// <param name="listPriceInUsdCents">listPriceInUsdCents.</param>
        /// <param name="name">name.</param>
        /// <param name="period">period.</param>
        /// <param name="pricePointHandle">pricePointHandle.</param>
        /// <param name="pricesMonth">pricesMonth.</param>
        /// <param name="pricesPeriod">pricesPeriod.</param>
        /// <param name="pricingPlanId">pricingPlanId.</param>
        public BillingFancyPricingPlan(long? actualPriceInUsdCents = default(long?), ModelsCampaign campaign = default(ModelsCampaign), long? listPriceInUsdCents = default(long?), string name = default(string), long? period = default(long?), string pricePointHandle = default(string), BillingPricesStruct pricesMonth = default(BillingPricesStruct), BillingPricesStruct pricesPeriod = default(BillingPricesStruct), long? pricingPlanId = default(long?))
        {
            this.ActualPriceInUsdCents = actualPriceInUsdCents;
            this.Campaign = campaign;
            this.ListPriceInUsdCents = listPriceInUsdCents;
            this.Name = name;
            this.Period = period;
            this.PricePointHandle = pricePointHandle;
            this.PricesMonth = pricesMonth;
            this.PricesPeriod = pricesPeriod;
            this.PricingPlanId = pricingPlanId;
        }
        
        /// <summary>
        /// Gets or Sets ActualPriceInUsdCents
        /// </summary>
        [DataMember(Name="actual_price_in_usd_cents", EmitDefaultValue=false)]
        public long? ActualPriceInUsdCents { get; set; }

        /// <summary>
        /// Gets or Sets Campaign
        /// </summary>
        [DataMember(Name="campaign", EmitDefaultValue=false)]
        public ModelsCampaign Campaign { get; set; }

        /// <summary>
        /// Gets or Sets ListPriceInUsdCents
        /// </summary>
        [DataMember(Name="list_price_in_usd_cents", EmitDefaultValue=false)]
        public long? ListPriceInUsdCents { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public long? Period { get; set; }

        /// <summary>
        /// Gets or Sets PricePointHandle
        /// </summary>
        [DataMember(Name="price_point_handle", EmitDefaultValue=false)]
        public string PricePointHandle { get; set; }

        /// <summary>
        /// Gets or Sets PricesMonth
        /// </summary>
        [DataMember(Name="prices_month", EmitDefaultValue=false)]
        public BillingPricesStruct PricesMonth { get; set; }

        /// <summary>
        /// Gets or Sets PricesPeriod
        /// </summary>
        [DataMember(Name="prices_period", EmitDefaultValue=false)]
        public BillingPricesStruct PricesPeriod { get; set; }

        /// <summary>
        /// Gets or Sets PricingPlanId
        /// </summary>
        [DataMember(Name="pricing_plan_id", EmitDefaultValue=false)]
        public long? PricingPlanId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingFancyPricingPlan {\n");
            sb.Append("  ActualPriceInUsdCents: ").Append(ActualPriceInUsdCents).Append("\n");
            sb.Append("  Campaign: ").Append(Campaign).Append("\n");
            sb.Append("  ListPriceInUsdCents: ").Append(ListPriceInUsdCents).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  PricePointHandle: ").Append(PricePointHandle).Append("\n");
            sb.Append("  PricesMonth: ").Append(PricesMonth).Append("\n");
            sb.Append("  PricesPeriod: ").Append(PricesPeriod).Append("\n");
            sb.Append("  PricingPlanId: ").Append(PricingPlanId).Append("\n");
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
            return this.Equals(input as BillingFancyPricingPlan);
        }

        /// <summary>
        /// Returns true if BillingFancyPricingPlan instances are equal
        /// </summary>
        /// <param name="input">Instance of BillingFancyPricingPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingFancyPricingPlan input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActualPriceInUsdCents == input.ActualPriceInUsdCents ||
                    (this.ActualPriceInUsdCents != null &&
                    this.ActualPriceInUsdCents.Equals(input.ActualPriceInUsdCents))
                ) && 
                (
                    this.Campaign == input.Campaign ||
                    (this.Campaign != null &&
                    this.Campaign.Equals(input.Campaign))
                ) && 
                (
                    this.ListPriceInUsdCents == input.ListPriceInUsdCents ||
                    (this.ListPriceInUsdCents != null &&
                    this.ListPriceInUsdCents.Equals(input.ListPriceInUsdCents))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.PricePointHandle == input.PricePointHandle ||
                    (this.PricePointHandle != null &&
                    this.PricePointHandle.Equals(input.PricePointHandle))
                ) && 
                (
                    this.PricesMonth == input.PricesMonth ||
                    (this.PricesMonth != null &&
                    this.PricesMonth.Equals(input.PricesMonth))
                ) && 
                (
                    this.PricesPeriod == input.PricesPeriod ||
                    (this.PricesPeriod != null &&
                    this.PricesPeriod.Equals(input.PricesPeriod))
                ) && 
                (
                    this.PricingPlanId == input.PricingPlanId ||
                    (this.PricingPlanId != null &&
                    this.PricingPlanId.Equals(input.PricingPlanId))
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
                if (this.ActualPriceInUsdCents != null)
                    hashCode = hashCode * 59 + this.ActualPriceInUsdCents.GetHashCode();
                if (this.Campaign != null)
                    hashCode = hashCode * 59 + this.Campaign.GetHashCode();
                if (this.ListPriceInUsdCents != null)
                    hashCode = hashCode * 59 + this.ListPriceInUsdCents.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.PricePointHandle != null)
                    hashCode = hashCode * 59 + this.PricePointHandle.GetHashCode();
                if (this.PricesMonth != null)
                    hashCode = hashCode * 59 + this.PricesMonth.GetHashCode();
                if (this.PricesPeriod != null)
                    hashCode = hashCode * 59 + this.PricesPeriod.GetHashCode();
                if (this.PricingPlanId != null)
                    hashCode = hashCode * 59 + this.PricingPlanId.GetHashCode();
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
