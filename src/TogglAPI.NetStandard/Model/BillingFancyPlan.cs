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
    /// BillingFancyPlan
    /// </summary>
    [DataContract]
    public partial class BillingFancyPlan :  IEquatable<BillingFancyPlan>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingFancyPlan" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="planId">planId.</param>
        /// <param name="pricingPlans">pricingPlans.</param>
        public BillingFancyPlan(string name = default(string), int? planId = default(int?), List<BillingFancyPricingPlan> pricingPlans = default(List<BillingFancyPricingPlan>))
        {
            this.Name = name;
            this.PlanId = planId;
            this.PricingPlans = pricingPlans;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PlanId
        /// </summary>
        [DataMember(Name="plan_id", EmitDefaultValue=false)]
        public int? PlanId { get; set; }

        /// <summary>
        /// Gets or Sets PricingPlans
        /// </summary>
        [DataMember(Name="pricing_plans", EmitDefaultValue=false)]
        public List<BillingFancyPricingPlan> PricingPlans { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingFancyPlan {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  PricingPlans: ").Append(PricingPlans).Append("\n");
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
            return this.Equals(input as BillingFancyPlan);
        }

        /// <summary>
        /// Returns true if BillingFancyPlan instances are equal
        /// </summary>
        /// <param name="input">Instance of BillingFancyPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingFancyPlan input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PlanId == input.PlanId ||
                    (this.PlanId != null &&
                    this.PlanId.Equals(input.PlanId))
                ) && 
                (
                    this.PricingPlans == input.PricingPlans ||
                    this.PricingPlans != null &&
                    this.PricingPlans.SequenceEqual(input.PricingPlans)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PlanId != null)
                    hashCode = hashCode * 59 + this.PlanId.GetHashCode();
                if (this.PricingPlans != null)
                    hashCode = hashCode * 59 + this.PricingPlans.GetHashCode();
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
