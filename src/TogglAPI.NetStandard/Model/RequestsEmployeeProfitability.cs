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
    /// RequestsEmployeeProfitability
    /// </summary>
    [DataContract]
    public partial class RequestsEmployeeProfitability :  IEquatable<RequestsEmployeeProfitability>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestsEmployeeProfitability" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestsEmployeeProfitability() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestsEmployeeProfitability" /> class.
        /// </summary>
        /// <param name="currency">currency (required).</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="groupIds">groupIds.</param>
        /// <param name="resolution">resolution.</param>
        /// <param name="rounding">rounding.</param>
        /// <param name="roundingMinutes">roundingMinutes.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="userIds">userIds.</param>
        public RequestsEmployeeProfitability(string currency = default(string), string endDate = default(string), UtilsInt64Slice groupIds = default(UtilsInt64Slice), string resolution = default(string), long? rounding = default(long?), long? roundingMinutes = default(long?), string startDate = default(string), UtilsInt64Slice userIds = default(UtilsInt64Slice))
        {
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for RequestsEmployeeProfitability and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }
            this.EndDate = endDate;
            this.GroupIds = groupIds;
            this.Resolution = resolution;
            this.Rounding = rounding;
            this.RoundingMinutes = roundingMinutes;
            this.StartDate = startDate;
            this.UserIds = userIds;
        }
        
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or Sets GroupIds
        /// </summary>
        [DataMember(Name="group_ids", EmitDefaultValue=false)]
        public UtilsInt64Slice GroupIds { get; set; }

        /// <summary>
        /// Gets or Sets Resolution
        /// </summary>
        [DataMember(Name="resolution", EmitDefaultValue=false)]
        public string Resolution { get; set; }

        /// <summary>
        /// Gets or Sets Rounding
        /// </summary>
        [DataMember(Name="rounding", EmitDefaultValue=false)]
        public long? Rounding { get; set; }

        /// <summary>
        /// Gets or Sets RoundingMinutes
        /// </summary>
        [DataMember(Name="rounding_minutes", EmitDefaultValue=false)]
        public long? RoundingMinutes { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or Sets UserIds
        /// </summary>
        [DataMember(Name="user_ids", EmitDefaultValue=false)]
        public UtilsInt64Slice UserIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestsEmployeeProfitability {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  GroupIds: ").Append(GroupIds).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  Rounding: ").Append(Rounding).Append("\n");
            sb.Append("  RoundingMinutes: ").Append(RoundingMinutes).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
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
            return this.Equals(input as RequestsEmployeeProfitability);
        }

        /// <summary>
        /// Returns true if RequestsEmployeeProfitability instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestsEmployeeProfitability to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestsEmployeeProfitability input)
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
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.GroupIds == input.GroupIds ||
                    (this.GroupIds != null &&
                    this.GroupIds.Equals(input.GroupIds))
                ) && 
                (
                    this.Resolution == input.Resolution ||
                    (this.Resolution != null &&
                    this.Resolution.Equals(input.Resolution))
                ) && 
                (
                    this.Rounding == input.Rounding ||
                    (this.Rounding != null &&
                    this.Rounding.Equals(input.Rounding))
                ) && 
                (
                    this.RoundingMinutes == input.RoundingMinutes ||
                    (this.RoundingMinutes != null &&
                    this.RoundingMinutes.Equals(input.RoundingMinutes))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.UserIds == input.UserIds ||
                    (this.UserIds != null &&
                    this.UserIds.Equals(input.UserIds))
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
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.GroupIds != null)
                    hashCode = hashCode * 59 + this.GroupIds.GetHashCode();
                if (this.Resolution != null)
                    hashCode = hashCode * 59 + this.Resolution.GetHashCode();
                if (this.Rounding != null)
                    hashCode = hashCode * 59 + this.Rounding.GetHashCode();
                if (this.RoundingMinutes != null)
                    hashCode = hashCode * 59 + this.RoundingMinutes.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.UserIds != null)
                    hashCode = hashCode * 59 + this.UserIds.GetHashCode();
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