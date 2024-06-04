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
    /// CustomerUnifiedCustomerResponse
    /// </summary>
    [DataContract]
    public partial class CustomerUnifiedCustomerResponse :  IEquatable<CustomerUnifiedCustomerResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerUnifiedCustomerResponse" /> class.
        /// </summary>
        /// <param name="addressLine">addressLine.</param>
        /// <param name="countryId">countryId.</param>
        /// <param name="currency">currency.</param>
        /// <param name="customerName">customerName.</param>
        /// <param name="defaultPaymentMethod">defaultPaymentMethod.</param>
        /// <param name="discount">discount.</param>
        /// <param name="id">id.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="site">site.</param>
        /// <param name="state">state.</param>
        /// <param name="taxNumber">taxNumber.</param>
        /// <param name="togglUserEmail">togglUserEmail.</param>
        /// <param name="togglUserId">togglUserId.</param>
        public CustomerUnifiedCustomerResponse(string addressLine = default(string), string countryId = default(string), string currency = default(string), string customerName = default(string), CustomerPaymentMethod defaultPaymentMethod = default(CustomerPaymentMethod), CustomerDiscountResponse discount = default(CustomerDiscountResponse), string id = default(string), string postalCode = default(string), string site = default(string), string state = default(string), string taxNumber = default(string), string togglUserEmail = default(string), int? togglUserId = default(int?))
        {
            this.AddressLine = addressLine;
            this.CountryId = countryId;
            this.Currency = currency;
            this.CustomerName = customerName;
            this.DefaultPaymentMethod = defaultPaymentMethod;
            this.Discount = discount;
            this.Id = id;
            this.PostalCode = postalCode;
            this.Site = site;
            this.State = state;
            this.TaxNumber = taxNumber;
            this.TogglUserEmail = togglUserEmail;
            this.TogglUserId = togglUserId;
        }
        
        /// <summary>
        /// Gets or Sets AddressLine
        /// </summary>
        [DataMember(Name="address_line", EmitDefaultValue=false)]
        public string AddressLine { get; set; }

        /// <summary>
        /// Gets or Sets CountryId
        /// </summary>
        [DataMember(Name="country_id", EmitDefaultValue=false)]
        public string CountryId { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets CustomerName
        /// </summary>
        [DataMember(Name="customer_name", EmitDefaultValue=false)]
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPaymentMethod
        /// </summary>
        [DataMember(Name="default_payment_method", EmitDefaultValue=false)]
        public CustomerPaymentMethod DefaultPaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name="discount", EmitDefaultValue=false)]
        public CustomerDiscountResponse Discount { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets Site
        /// </summary>
        [DataMember(Name="site", EmitDefaultValue=false)]
        public string Site { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets TaxNumber
        /// </summary>
        [DataMember(Name="tax_number", EmitDefaultValue=false)]
        public string TaxNumber { get; set; }

        /// <summary>
        /// Gets or Sets TogglUserEmail
        /// </summary>
        [DataMember(Name="toggl_user_email", EmitDefaultValue=false)]
        public string TogglUserEmail { get; set; }

        /// <summary>
        /// Gets or Sets TogglUserId
        /// </summary>
        [DataMember(Name="toggl_user_id", EmitDefaultValue=false)]
        public int? TogglUserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerUnifiedCustomerResponse {\n");
            sb.Append("  AddressLine: ").Append(AddressLine).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  DefaultPaymentMethod: ").Append(DefaultPaymentMethod).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Site: ").Append(Site).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TaxNumber: ").Append(TaxNumber).Append("\n");
            sb.Append("  TogglUserEmail: ").Append(TogglUserEmail).Append("\n");
            sb.Append("  TogglUserId: ").Append(TogglUserId).Append("\n");
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
            return this.Equals(input as CustomerUnifiedCustomerResponse);
        }

        /// <summary>
        /// Returns true if CustomerUnifiedCustomerResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerUnifiedCustomerResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerUnifiedCustomerResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressLine == input.AddressLine ||
                    (this.AddressLine != null &&
                    this.AddressLine.Equals(input.AddressLine))
                ) && 
                (
                    this.CountryId == input.CountryId ||
                    (this.CountryId != null &&
                    this.CountryId.Equals(input.CountryId))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.CustomerName == input.CustomerName ||
                    (this.CustomerName != null &&
                    this.CustomerName.Equals(input.CustomerName))
                ) && 
                (
                    this.DefaultPaymentMethod == input.DefaultPaymentMethod ||
                    (this.DefaultPaymentMethod != null &&
                    this.DefaultPaymentMethod.Equals(input.DefaultPaymentMethod))
                ) && 
                (
                    this.Discount == input.Discount ||
                    (this.Discount != null &&
                    this.Discount.Equals(input.Discount))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Site == input.Site ||
                    (this.Site != null &&
                    this.Site.Equals(input.Site))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.TaxNumber == input.TaxNumber ||
                    (this.TaxNumber != null &&
                    this.TaxNumber.Equals(input.TaxNumber))
                ) && 
                (
                    this.TogglUserEmail == input.TogglUserEmail ||
                    (this.TogglUserEmail != null &&
                    this.TogglUserEmail.Equals(input.TogglUserEmail))
                ) && 
                (
                    this.TogglUserId == input.TogglUserId ||
                    (this.TogglUserId != null &&
                    this.TogglUserId.Equals(input.TogglUserId))
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
                if (this.AddressLine != null)
                    hashCode = hashCode * 59 + this.AddressLine.GetHashCode();
                if (this.CountryId != null)
                    hashCode = hashCode * 59 + this.CountryId.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.CustomerName != null)
                    hashCode = hashCode * 59 + this.CustomerName.GetHashCode();
                if (this.DefaultPaymentMethod != null)
                    hashCode = hashCode * 59 + this.DefaultPaymentMethod.GetHashCode();
                if (this.Discount != null)
                    hashCode = hashCode * 59 + this.Discount.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.Site != null)
                    hashCode = hashCode * 59 + this.Site.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.TaxNumber != null)
                    hashCode = hashCode * 59 + this.TaxNumber.GetHashCode();
                if (this.TogglUserEmail != null)
                    hashCode = hashCode * 59 + this.TogglUserEmail.GetHashCode();
                if (this.TogglUserId != null)
                    hashCode = hashCode * 59 + this.TogglUserId.GetHashCode();
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
