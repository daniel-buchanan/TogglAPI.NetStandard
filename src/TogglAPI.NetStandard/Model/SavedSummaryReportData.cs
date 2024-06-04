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
    /// SavedSummaryReportData
    /// </summary>
    [DataContract]
    public partial class SavedSummaryReportData :  IEquatable<SavedSummaryReportData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SavedSummaryReportData" /> class.
        /// </summary>
        /// <param name="report">report.</param>
        /// <param name="totals">totals.</param>
        public SavedSummaryReportData(SummaryReportData report = default(SummaryReportData), TotalsReportData totals = default(TotalsReportData))
        {
            this.Report = report;
            this.Totals = totals;
        }
        
        /// <summary>
        /// Gets or Sets Report
        /// </summary>
        [DataMember(Name="report", EmitDefaultValue=false)]
        public SummaryReportData Report { get; set; }

        /// <summary>
        /// Gets or Sets Totals
        /// </summary>
        [DataMember(Name="totals", EmitDefaultValue=false)]
        public TotalsReportData Totals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SavedSummaryReportData {\n");
            sb.Append("  Report: ").Append(Report).Append("\n");
            sb.Append("  Totals: ").Append(Totals).Append("\n");
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
            return this.Equals(input as SavedSummaryReportData);
        }

        /// <summary>
        /// Returns true if SavedSummaryReportData instances are equal
        /// </summary>
        /// <param name="input">Instance of SavedSummaryReportData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SavedSummaryReportData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Report == input.Report ||
                    (this.Report != null &&
                    this.Report.Equals(input.Report))
                ) && 
                (
                    this.Totals == input.Totals ||
                    (this.Totals != null &&
                    this.Totals.Equals(input.Totals))
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
                if (this.Report != null)
                    hashCode = hashCode * 59 + this.Report.GetHashCode();
                if (this.Totals != null)
                    hashCode = hashCode * 59 + this.Totals.GetHashCode();
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
