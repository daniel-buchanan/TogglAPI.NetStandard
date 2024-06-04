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
    /// SubscriptionContactDetailRequest
    /// </summary>
    [DataContract]
    public partial class SubscriptionContactDetailRequest :  IEquatable<SubscriptionContactDetailRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionContactDetailRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionContactDetailRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionContactDetailRequest" /> class.
        /// </summary>
        /// <param name="companyAddress">companyAddress (required).</param>
        /// <param name="companyCity">companyCity.</param>
        /// <param name="companyName">companyName (required).</param>
        /// <param name="contactEmail">contactEmail (required).</param>
        /// <param name="contactPerson">contactPerson.</param>
        /// <param name="countryId">countryId (required).</param>
        /// <param name="countrySubdivisionId">CountrySubdivisionID is the ID of the country subdivision (state in USA) This field is required if country_id &#x3D;&#x3D; 235 (United states).</param>
        /// <param name="subDivision">subDivision.</param>
        /// <param name="taxNumber">taxNumber.</param>
        /// <param name="zipCode">ZIPCode field is required if country_id &#x3D;&#x3D; 235 (United states).</param>
        public SubscriptionContactDetailRequest(string companyAddress = default(string), string companyCity = default(string), string companyName = default(string), string contactEmail = default(string), string contactPerson = default(string), int? countryId = default(int?), int? countrySubdivisionId = default(int?), ModelsSubdivision subDivision = default(ModelsSubdivision), string taxNumber = default(string), string zipCode = default(string))
        {
            // to ensure "companyAddress" is required (not null)
            if (companyAddress == null)
            {
                throw new InvalidDataException("companyAddress is a required property for SubscriptionContactDetailRequest and cannot be null");
            }
            else
            {
                this.CompanyAddress = companyAddress;
            }
            // to ensure "companyName" is required (not null)
            if (companyName == null)
            {
                throw new InvalidDataException("companyName is a required property for SubscriptionContactDetailRequest and cannot be null");
            }
            else
            {
                this.CompanyName = companyName;
            }
            // to ensure "contactEmail" is required (not null)
            if (contactEmail == null)
            {
                throw new InvalidDataException("contactEmail is a required property for SubscriptionContactDetailRequest and cannot be null");
            }
            else
            {
                this.ContactEmail = contactEmail;
            }
            // to ensure "countryId" is required (not null)
            if (countryId == null)
            {
                throw new InvalidDataException("countryId is a required property for SubscriptionContactDetailRequest and cannot be null");
            }
            else
            {
                this.CountryId = countryId;
            }
            this.CompanyCity = companyCity;
            this.ContactPerson = contactPerson;
            this.CountrySubdivisionId = countrySubdivisionId;
            this.SubDivision = subDivision;
            this.TaxNumber = taxNumber;
            this.ZipCode = zipCode;
        }
        
        /// <summary>
        /// Gets or Sets CompanyAddress
        /// </summary>
        [DataMember(Name="company_address", EmitDefaultValue=false)]
        public string CompanyAddress { get; set; }

        /// <summary>
        /// Gets or Sets CompanyCity
        /// </summary>
        [DataMember(Name="company_city", EmitDefaultValue=false)]
        public string CompanyCity { get; set; }

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="company_name", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets ContactEmail
        /// </summary>
        [DataMember(Name="contact_email", EmitDefaultValue=false)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// Gets or Sets ContactPerson
        /// </summary>
        [DataMember(Name="contact_person", EmitDefaultValue=false)]
        public string ContactPerson { get; set; }

        /// <summary>
        /// Gets or Sets CountryId
        /// </summary>
        [DataMember(Name="country_id", EmitDefaultValue=false)]
        public int? CountryId { get; set; }

        /// <summary>
        /// CountrySubdivisionID is the ID of the country subdivision (state in USA) This field is required if country_id &#x3D;&#x3D; 235 (United states)
        /// </summary>
        /// <value>CountrySubdivisionID is the ID of the country subdivision (state in USA) This field is required if country_id &#x3D;&#x3D; 235 (United states)</value>
        [DataMember(Name="country_subdivision_id", EmitDefaultValue=false)]
        public int? CountrySubdivisionId { get; set; }

        /// <summary>
        /// Gets or Sets SubDivision
        /// </summary>
        [DataMember(Name="subDivision", EmitDefaultValue=false)]
        public ModelsSubdivision SubDivision { get; set; }

        /// <summary>
        /// Gets or Sets TaxNumber
        /// </summary>
        [DataMember(Name="tax_number", EmitDefaultValue=false)]
        public string TaxNumber { get; set; }

        /// <summary>
        /// ZIPCode field is required if country_id &#x3D;&#x3D; 235 (United states)
        /// </summary>
        /// <value>ZIPCode field is required if country_id &#x3D;&#x3D; 235 (United states)</value>
        [DataMember(Name="zip_code", EmitDefaultValue=false)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionContactDetailRequest {\n");
            sb.Append("  CompanyAddress: ").Append(CompanyAddress).Append("\n");
            sb.Append("  CompanyCity: ").Append(CompanyCity).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
            sb.Append("  ContactPerson: ").Append(ContactPerson).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  CountrySubdivisionId: ").Append(CountrySubdivisionId).Append("\n");
            sb.Append("  SubDivision: ").Append(SubDivision).Append("\n");
            sb.Append("  TaxNumber: ").Append(TaxNumber).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
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
            return this.Equals(input as SubscriptionContactDetailRequest);
        }

        /// <summary>
        /// Returns true if SubscriptionContactDetailRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionContactDetailRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionContactDetailRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompanyAddress == input.CompanyAddress ||
                    (this.CompanyAddress != null &&
                    this.CompanyAddress.Equals(input.CompanyAddress))
                ) && 
                (
                    this.CompanyCity == input.CompanyCity ||
                    (this.CompanyCity != null &&
                    this.CompanyCity.Equals(input.CompanyCity))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.ContactEmail == input.ContactEmail ||
                    (this.ContactEmail != null &&
                    this.ContactEmail.Equals(input.ContactEmail))
                ) && 
                (
                    this.ContactPerson == input.ContactPerson ||
                    (this.ContactPerson != null &&
                    this.ContactPerson.Equals(input.ContactPerson))
                ) && 
                (
                    this.CountryId == input.CountryId ||
                    (this.CountryId != null &&
                    this.CountryId.Equals(input.CountryId))
                ) && 
                (
                    this.CountrySubdivisionId == input.CountrySubdivisionId ||
                    (this.CountrySubdivisionId != null &&
                    this.CountrySubdivisionId.Equals(input.CountrySubdivisionId))
                ) && 
                (
                    this.SubDivision == input.SubDivision ||
                    (this.SubDivision != null &&
                    this.SubDivision.Equals(input.SubDivision))
                ) && 
                (
                    this.TaxNumber == input.TaxNumber ||
                    (this.TaxNumber != null &&
                    this.TaxNumber.Equals(input.TaxNumber))
                ) && 
                (
                    this.ZipCode == input.ZipCode ||
                    (this.ZipCode != null &&
                    this.ZipCode.Equals(input.ZipCode))
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
                if (this.CompanyAddress != null)
                    hashCode = hashCode * 59 + this.CompanyAddress.GetHashCode();
                if (this.CompanyCity != null)
                    hashCode = hashCode * 59 + this.CompanyCity.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.ContactEmail != null)
                    hashCode = hashCode * 59 + this.ContactEmail.GetHashCode();
                if (this.ContactPerson != null)
                    hashCode = hashCode * 59 + this.ContactPerson.GetHashCode();
                if (this.CountryId != null)
                    hashCode = hashCode * 59 + this.CountryId.GetHashCode();
                if (this.CountrySubdivisionId != null)
                    hashCode = hashCode * 59 + this.CountrySubdivisionId.GetHashCode();
                if (this.SubDivision != null)
                    hashCode = hashCode * 59 + this.SubDivision.GetHashCode();
                if (this.TaxNumber != null)
                    hashCode = hashCode * 59 + this.TaxNumber.GetHashCode();
                if (this.ZipCode != null)
                    hashCode = hashCode * 59 + this.ZipCode.GetHashCode();
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
