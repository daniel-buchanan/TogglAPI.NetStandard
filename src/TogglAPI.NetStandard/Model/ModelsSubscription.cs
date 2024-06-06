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
    /// ModelsSubscription
    /// </summary>
    [DataContract]
    public partial class ModelsSubscription :  IEquatable<ModelsSubscription>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsSubscription" /> class.
        /// </summary>
        /// <param name="autoRenew">autoRenew.</param>
        /// <param name="cardDetails">cardDetails.</param>
        /// <param name="companyId">companyId.</param>
        /// <param name="contactDetail">contactDetail.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="currency">currency.</param>
        /// <param name="customerId">customerId.</param>
        /// <param name="deletedAt">deletedAt.</param>
        /// <param name="lastPricingPlanId">lastPricingPlanId.</param>
        /// <param name="organizationId">organizationId.</param>
        /// <param name="paymentDetails">paymentDetails.</param>
        /// <param name="pricingPlanId">pricingPlanId.</param>
        /// <param name="renewalAt">renewalAt.</param>
        /// <param name="subscriptionId">subscriptionId.</param>
        /// <param name="subscriptionPeriod">subscriptionPeriod.</param>
        /// <param name="workspaceId">workspaceId.</param>
        public ModelsSubscription(bool? autoRenew = default(bool?), ModelsCardDetails cardDetails = default(ModelsCardDetails), long? companyId = default(long?), ModelsContactDetail contactDetail = default(ModelsContactDetail), DateTime? createdAt = default(DateTime?), string currency = default(string), long? customerId = default(long?), DateTime? deletedAt = default(DateTime?), long? lastPricingPlanId = default(long?), long? organizationId = default(long?), ModelsPaymentDetail paymentDetails = default(ModelsPaymentDetail), long? pricingPlanId = default(long?), DateTime? renewalAt = default(DateTime?), long? subscriptionId = default(long?), ModelsPeriod subscriptionPeriod = default(ModelsPeriod), long? workspaceId = default(long?))
        {
            this.AutoRenew = autoRenew;
            this.CardDetails = cardDetails;
            this.CompanyId = companyId;
            this.ContactDetail = contactDetail;
            this.CreatedAt = createdAt;
            this.Currency = currency;
            this.CustomerId = customerId;
            this.DeletedAt = deletedAt;
            this.LastPricingPlanId = lastPricingPlanId;
            this.OrganizationId = organizationId;
            this.PaymentDetails = paymentDetails;
            this.PricingPlanId = pricingPlanId;
            this.RenewalAt = renewalAt;
            this.SubscriptionId = subscriptionId;
            this.SubscriptionPeriod = subscriptionPeriod;
            this.WorkspaceId = workspaceId;
        }
        
        /// <summary>
        /// Gets or Sets AutoRenew
        /// </summary>
        [DataMember(Name="auto_renew", EmitDefaultValue=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// Gets or Sets CardDetails
        /// </summary>
        [DataMember(Name="card_details", EmitDefaultValue=false)]
        public ModelsCardDetails CardDetails { get; set; }

        /// <summary>
        /// Gets or Sets CompanyId
        /// </summary>
        [DataMember(Name="company_id", EmitDefaultValue=false)]
        public long? CompanyId { get; set; }

        /// <summary>
        /// Gets or Sets ContactDetail
        /// </summary>
        [DataMember(Name="contact_detail", EmitDefaultValue=false)]
        public ModelsContactDetail ContactDetail { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        [DataMember(Name="customer_id", EmitDefaultValue=false)]
        public long? CustomerId { get; set; }

        /// <summary>
        /// Gets or Sets DeletedAt
        /// </summary>
        [DataMember(Name="deleted_at", EmitDefaultValue=false)]
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Gets or Sets LastPricingPlanId
        /// </summary>
        [DataMember(Name="last_pricing_plan_id", EmitDefaultValue=false)]
        public long? LastPricingPlanId { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organization_id", EmitDefaultValue=false)]
        public long? OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets PaymentDetails
        /// </summary>
        [DataMember(Name="payment_details", EmitDefaultValue=false)]
        public ModelsPaymentDetail PaymentDetails { get; set; }

        /// <summary>
        /// Gets or Sets PricingPlanId
        /// </summary>
        [DataMember(Name="pricing_plan_id", EmitDefaultValue=false)]
        public long? PricingPlanId { get; set; }

        /// <summary>
        /// Gets or Sets RenewalAt
        /// </summary>
        [DataMember(Name="renewal_at", EmitDefaultValue=false)]
        public DateTime? RenewalAt { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionId
        /// </summary>
        [DataMember(Name="subscription_id", EmitDefaultValue=false)]
        public long? SubscriptionId { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionPeriod
        /// </summary>
        [DataMember(Name="subscription_period", EmitDefaultValue=false)]
        public ModelsPeriod SubscriptionPeriod { get; set; }

        /// <summary>
        /// Gets or Sets WorkspaceId
        /// </summary>
        [DataMember(Name="workspace_id", EmitDefaultValue=false)]
        public long? WorkspaceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelsSubscription {\n");
            sb.Append("  AutoRenew: ").Append(AutoRenew).Append("\n");
            sb.Append("  CardDetails: ").Append(CardDetails).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  ContactDetail: ").Append(ContactDetail).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  LastPricingPlanId: ").Append(LastPricingPlanId).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  PaymentDetails: ").Append(PaymentDetails).Append("\n");
            sb.Append("  PricingPlanId: ").Append(PricingPlanId).Append("\n");
            sb.Append("  RenewalAt: ").Append(RenewalAt).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  SubscriptionPeriod: ").Append(SubscriptionPeriod).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
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
            return this.Equals(input as ModelsSubscription);
        }

        /// <summary>
        /// Returns true if ModelsSubscription instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelsSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelsSubscription input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoRenew == input.AutoRenew ||
                    (this.AutoRenew != null &&
                    this.AutoRenew.Equals(input.AutoRenew))
                ) && 
                (
                    this.CardDetails == input.CardDetails ||
                    (this.CardDetails != null &&
                    this.CardDetails.Equals(input.CardDetails))
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.ContactDetail == input.ContactDetail ||
                    (this.ContactDetail != null &&
                    this.ContactDetail.Equals(input.ContactDetail))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.DeletedAt == input.DeletedAt ||
                    (this.DeletedAt != null &&
                    this.DeletedAt.Equals(input.DeletedAt))
                ) && 
                (
                    this.LastPricingPlanId == input.LastPricingPlanId ||
                    (this.LastPricingPlanId != null &&
                    this.LastPricingPlanId.Equals(input.LastPricingPlanId))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.PaymentDetails == input.PaymentDetails ||
                    (this.PaymentDetails != null &&
                    this.PaymentDetails.Equals(input.PaymentDetails))
                ) && 
                (
                    this.PricingPlanId == input.PricingPlanId ||
                    (this.PricingPlanId != null &&
                    this.PricingPlanId.Equals(input.PricingPlanId))
                ) && 
                (
                    this.RenewalAt == input.RenewalAt ||
                    (this.RenewalAt != null &&
                    this.RenewalAt.Equals(input.RenewalAt))
                ) && 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
                ) && 
                (
                    this.SubscriptionPeriod == input.SubscriptionPeriod ||
                    (this.SubscriptionPeriod != null &&
                    this.SubscriptionPeriod.Equals(input.SubscriptionPeriod))
                ) && 
                (
                    this.WorkspaceId == input.WorkspaceId ||
                    (this.WorkspaceId != null &&
                    this.WorkspaceId.Equals(input.WorkspaceId))
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
                if (this.AutoRenew != null)
                    hashCode = hashCode * 59 + this.AutoRenew.GetHashCode();
                if (this.CardDetails != null)
                    hashCode = hashCode * 59 + this.CardDetails.GetHashCode();
                if (this.CompanyId != null)
                    hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.ContactDetail != null)
                    hashCode = hashCode * 59 + this.ContactDetail.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.CustomerId != null)
                    hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.DeletedAt != null)
                    hashCode = hashCode * 59 + this.DeletedAt.GetHashCode();
                if (this.LastPricingPlanId != null)
                    hashCode = hashCode * 59 + this.LastPricingPlanId.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.PaymentDetails != null)
                    hashCode = hashCode * 59 + this.PaymentDetails.GetHashCode();
                if (this.PricingPlanId != null)
                    hashCode = hashCode * 59 + this.PricingPlanId.GetHashCode();
                if (this.RenewalAt != null)
                    hashCode = hashCode * 59 + this.RenewalAt.GetHashCode();
                if (this.SubscriptionId != null)
                    hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                if (this.SubscriptionPeriod != null)
                    hashCode = hashCode * 59 + this.SubscriptionPeriod.GetHashCode();
                if (this.WorkspaceId != null)
                    hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
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
