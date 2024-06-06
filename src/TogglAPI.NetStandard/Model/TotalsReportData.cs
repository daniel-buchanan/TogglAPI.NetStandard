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
    /// TotalsReportData
    /// </summary>
    [DataContract]
    public partial class TotalsReportData :  IEquatable<TotalsReportData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TotalsReportData" /> class.
        /// </summary>
        /// <param name="billableAmountInCents">billableAmountInCents.</param>
        /// <param name="graph">graph.</param>
        /// <param name="labourCostInCents">labourCostInCents.</param>
        /// <param name="rates">rates.</param>
        /// <param name="resolution">resolution.</param>
        /// <param name="seconds">seconds.</param>
        /// <param name="trackedDays">trackedDays.</param>
        public TotalsReportData(long? billableAmountInCents = default(long?), List<TotalsGraph> graph = default(List<TotalsGraph>), long? labourCostInCents = default(long?), List<BaseBillableHourlyRate> rates = default(List<BaseBillableHourlyRate>), string resolution = default(string), long? seconds = default(long?), long? trackedDays = default(long?))
        {
            this.BillableAmountInCents = billableAmountInCents;
            this.Graph = graph;
            this.LabourCostInCents = labourCostInCents;
            this.Rates = rates;
            this.Resolution = resolution;
            this.Seconds = seconds;
            this.TrackedDays = trackedDays;
        }
        
        /// <summary>
        /// Gets or Sets BillableAmountInCents
        /// </summary>
        [DataMember(Name="billable_amount_in_cents", EmitDefaultValue=false)]
        public long? BillableAmountInCents { get; set; }

        /// <summary>
        /// Gets or Sets Graph
        /// </summary>
        [DataMember(Name="graph", EmitDefaultValue=false)]
        public List<TotalsGraph> Graph { get; set; }

        /// <summary>
        /// Gets or Sets LabourCostInCents
        /// </summary>
        [DataMember(Name="labour_cost_in_cents", EmitDefaultValue=false)]
        public long? LabourCostInCents { get; set; }

        /// <summary>
        /// Gets or Sets Rates
        /// </summary>
        [DataMember(Name="rates", EmitDefaultValue=false)]
        public List<BaseBillableHourlyRate> Rates { get; set; }

        /// <summary>
        /// Gets or Sets Resolution
        /// </summary>
        [DataMember(Name="resolution", EmitDefaultValue=false)]
        public string Resolution { get; set; }

        /// <summary>
        /// Gets or Sets Seconds
        /// </summary>
        [DataMember(Name="seconds", EmitDefaultValue=false)]
        public long? Seconds { get; set; }

        /// <summary>
        /// Gets or Sets TrackedDays
        /// </summary>
        [DataMember(Name="tracked_days", EmitDefaultValue=false)]
        public long? TrackedDays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TotalsReportData {\n");
            sb.Append("  BillableAmountInCents: ").Append(BillableAmountInCents).Append("\n");
            sb.Append("  Graph: ").Append(Graph).Append("\n");
            sb.Append("  LabourCostInCents: ").Append(LabourCostInCents).Append("\n");
            sb.Append("  Rates: ").Append(Rates).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  Seconds: ").Append(Seconds).Append("\n");
            sb.Append("  TrackedDays: ").Append(TrackedDays).Append("\n");
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
            return this.Equals(input as TotalsReportData);
        }

        /// <summary>
        /// Returns true if TotalsReportData instances are equal
        /// </summary>
        /// <param name="input">Instance of TotalsReportData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TotalsReportData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BillableAmountInCents == input.BillableAmountInCents ||
                    (this.BillableAmountInCents != null &&
                    this.BillableAmountInCents.Equals(input.BillableAmountInCents))
                ) && 
                (
                    this.Graph == input.Graph ||
                    this.Graph != null &&
                    this.Graph.SequenceEqual(input.Graph)
                ) && 
                (
                    this.LabourCostInCents == input.LabourCostInCents ||
                    (this.LabourCostInCents != null &&
                    this.LabourCostInCents.Equals(input.LabourCostInCents))
                ) && 
                (
                    this.Rates == input.Rates ||
                    this.Rates != null &&
                    this.Rates.SequenceEqual(input.Rates)
                ) && 
                (
                    this.Resolution == input.Resolution ||
                    (this.Resolution != null &&
                    this.Resolution.Equals(input.Resolution))
                ) && 
                (
                    this.Seconds == input.Seconds ||
                    (this.Seconds != null &&
                    this.Seconds.Equals(input.Seconds))
                ) && 
                (
                    this.TrackedDays == input.TrackedDays ||
                    (this.TrackedDays != null &&
                    this.TrackedDays.Equals(input.TrackedDays))
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
                if (this.BillableAmountInCents != null)
                    hashCode = hashCode * 59 + this.BillableAmountInCents.GetHashCode();
                if (this.Graph != null)
                    hashCode = hashCode * 59 + this.Graph.GetHashCode();
                if (this.LabourCostInCents != null)
                    hashCode = hashCode * 59 + this.LabourCostInCents.GetHashCode();
                if (this.Rates != null)
                    hashCode = hashCode * 59 + this.Rates.GetHashCode();
                if (this.Resolution != null)
                    hashCode = hashCode * 59 + this.Resolution.GetHashCode();
                if (this.Seconds != null)
                    hashCode = hashCode * 59 + this.Seconds.GetHashCode();
                if (this.TrackedDays != null)
                    hashCode = hashCode * 59 + this.TrackedDays.GetHashCode();
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
