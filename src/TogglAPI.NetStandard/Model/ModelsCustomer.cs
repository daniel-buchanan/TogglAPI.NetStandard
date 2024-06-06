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
    /// ModelsCustomer
    /// </summary>
    [DataContract]
    public partial class ModelsCustomer :  IEquatable<ModelsCustomer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsCustomer" /> class.
        /// </summary>
        /// <param name="balanceInCents">DEPRECATED.</param>
        /// <param name="balanceUpdatedAt">DEPRECATED.</param>
        /// <param name="company">company.</param>
        /// <param name="companyId">companyId.</param>
        /// <param name="contactDetail">contactDetail.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="currencyId">currencyId.</param>
        /// <param name="customerId">customerId.</param>
        /// <param name="deletedAt">deletedAt.</param>
        /// <param name="organizationId">organizationId.</param>
        /// <param name="paymentDetail">paymentDetail.</param>
        /// <param name="purchaseOrderEnabled">purchaseOrderEnabled.</param>
        public ModelsCustomer(long? balanceInCents = default(long?), string balanceUpdatedAt = default(string), ModelsCompany company = default(ModelsCompany), long? companyId = default(long?), ModelsContactDetail contactDetail = default(ModelsContactDetail), string createdAt = default(string), long? currencyId = default(long?), long? customerId = default(long?), string deletedAt = default(string), long? organizationId = default(long?), ModelsPaymentDetail paymentDetail = default(ModelsPaymentDetail), bool? purchaseOrderEnabled = default(bool?))
        {
            this.BalanceInCents = balanceInCents;
            this.BalanceUpdatedAt = balanceUpdatedAt;
            this.Company = company;
            this.CompanyId = companyId;
            this.ContactDetail = contactDetail;
            this.CreatedAt = createdAt;
            this.CurrencyId = currencyId;
            this.CustomerId = customerId;
            this.DeletedAt = deletedAt;
            this.OrganizationId = organizationId;
            this.PaymentDetail = paymentDetail;
            this.PurchaseOrderEnabled = purchaseOrderEnabled;
        }
        
        /// <summary>
        /// DEPRECATED
        /// </summary>
        /// <value>DEPRECATED</value>
        [DataMember(Name="balance_in_cents", EmitDefaultValue=false)]
        public long? BalanceInCents { get; set; }

        /// <summary>
        /// DEPRECATED
        /// </summary>
        /// <value>DEPRECATED</value>
        [DataMember(Name="balance_updated_at", EmitDefaultValue=false)]
        public string BalanceUpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public ModelsCompany Company { get; set; }

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
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        [DataMember(Name="currency_id", EmitDefaultValue=false)]
        public long? CurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        [DataMember(Name="customer_id", EmitDefaultValue=false)]
        public long? CustomerId { get; set; }

        /// <summary>
        /// Gets or Sets DeletedAt
        /// </summary>
        [DataMember(Name="deleted_at", EmitDefaultValue=false)]
        public string DeletedAt { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organization_id", EmitDefaultValue=false)]
        public long? OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets PaymentDetail
        /// </summary>
        [DataMember(Name="payment_detail", EmitDefaultValue=false)]
        public ModelsPaymentDetail PaymentDetail { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseOrderEnabled
        /// </summary>
        [DataMember(Name="purchase_order_enabled", EmitDefaultValue=false)]
        public bool? PurchaseOrderEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelsCustomer {\n");
            sb.Append("  BalanceInCents: ").Append(BalanceInCents).Append("\n");
            sb.Append("  BalanceUpdatedAt: ").Append(BalanceUpdatedAt).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  ContactDetail: ").Append(ContactDetail).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  PaymentDetail: ").Append(PaymentDetail).Append("\n");
            sb.Append("  PurchaseOrderEnabled: ").Append(PurchaseOrderEnabled).Append("\n");
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
            return this.Equals(input as ModelsCustomer);
        }

        /// <summary>
        /// Returns true if ModelsCustomer instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelsCustomer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelsCustomer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BalanceInCents == input.BalanceInCents ||
                    (this.BalanceInCents != null &&
                    this.BalanceInCents.Equals(input.BalanceInCents))
                ) && 
                (
                    this.BalanceUpdatedAt == input.BalanceUpdatedAt ||
                    (this.BalanceUpdatedAt != null &&
                    this.BalanceUpdatedAt.Equals(input.BalanceUpdatedAt))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
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
                    this.CurrencyId == input.CurrencyId ||
                    (this.CurrencyId != null &&
                    this.CurrencyId.Equals(input.CurrencyId))
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
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.PaymentDetail == input.PaymentDetail ||
                    (this.PaymentDetail != null &&
                    this.PaymentDetail.Equals(input.PaymentDetail))
                ) && 
                (
                    this.PurchaseOrderEnabled == input.PurchaseOrderEnabled ||
                    (this.PurchaseOrderEnabled != null &&
                    this.PurchaseOrderEnabled.Equals(input.PurchaseOrderEnabled))
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
                if (this.BalanceInCents != null)
                    hashCode = hashCode * 59 + this.BalanceInCents.GetHashCode();
                if (this.BalanceUpdatedAt != null)
                    hashCode = hashCode * 59 + this.BalanceUpdatedAt.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.CompanyId != null)
                    hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.ContactDetail != null)
                    hashCode = hashCode * 59 + this.ContactDetail.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CurrencyId != null)
                    hashCode = hashCode * 59 + this.CurrencyId.GetHashCode();
                if (this.CustomerId != null)
                    hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.DeletedAt != null)
                    hashCode = hashCode * 59 + this.DeletedAt.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.PaymentDetail != null)
                    hashCode = hashCode * 59 + this.PaymentDetail.GetHashCode();
                if (this.PurchaseOrderEnabled != null)
                    hashCode = hashCode * 59 + this.PurchaseOrderEnabled.GetHashCode();
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
