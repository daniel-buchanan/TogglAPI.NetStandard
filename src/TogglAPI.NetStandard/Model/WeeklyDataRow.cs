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
    /// WeeklyDataRow
    /// </summary>
    [DataContract]
    public partial class WeeklyDataRow :  IEquatable<WeeklyDataRow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeeklyDataRow" /> class.
        /// </summary>
        /// <param name="billableAmountsInCents">billableAmountsInCents.</param>
        /// <param name="billableSeconds">billableSeconds.</param>
        /// <param name="clientName">clientName.</param>
        /// <param name="currency">currency.</param>
        /// <param name="hourlyRateInCents">In cents.</param>
        /// <param name="plannedTaskId">plannedTaskId.</param>
        /// <param name="projectColor">projectColor.</param>
        /// <param name="projectHexColor">projectHexColor.</param>
        /// <param name="projectId">projectId.</param>
        /// <param name="projectName">projectName.</param>
        /// <param name="seconds">seconds.</param>
        /// <param name="userId">userId.</param>
        /// <param name="userName">userName.</param>
        public WeeklyDataRow(UtilsInt64Slice billableAmountsInCents = default(UtilsInt64Slice), UtilsInt64Slice billableSeconds = default(UtilsInt64Slice), string clientName = default(string), string currency = default(string), int? hourlyRateInCents = default(int?), int? plannedTaskId = default(int?), string projectColor = default(string), string projectHexColor = default(string), int? projectId = default(int?), string projectName = default(string), UtilsInt64Slice seconds = default(UtilsInt64Slice), int? userId = default(int?), string userName = default(string))
        {
            this.BillableAmountsInCents = billableAmountsInCents;
            this.BillableSeconds = billableSeconds;
            this.ClientName = clientName;
            this.Currency = currency;
            this.HourlyRateInCents = hourlyRateInCents;
            this.PlannedTaskId = plannedTaskId;
            this.ProjectColor = projectColor;
            this.ProjectHexColor = projectHexColor;
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.Seconds = seconds;
            this.UserId = userId;
            this.UserName = userName;
        }
        
        /// <summary>
        /// Gets or Sets BillableAmountsInCents
        /// </summary>
        [DataMember(Name="billable_amounts_in_cents", EmitDefaultValue=false)]
        public UtilsInt64Slice BillableAmountsInCents { get; set; }

        /// <summary>
        /// Gets or Sets BillableSeconds
        /// </summary>
        [DataMember(Name="billable_seconds", EmitDefaultValue=false)]
        public UtilsInt64Slice BillableSeconds { get; set; }

        /// <summary>
        /// Gets or Sets ClientName
        /// </summary>
        [DataMember(Name="client_name", EmitDefaultValue=false)]
        public string ClientName { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// In cents
        /// </summary>
        /// <value>In cents</value>
        [DataMember(Name="hourly_rate_in_cents", EmitDefaultValue=false)]
        public int? HourlyRateInCents { get; set; }

        /// <summary>
        /// Gets or Sets PlannedTaskId
        /// </summary>
        [DataMember(Name="planned_task_id", EmitDefaultValue=false)]
        public int? PlannedTaskId { get; set; }

        /// <summary>
        /// Gets or Sets ProjectColor
        /// </summary>
        [DataMember(Name="project_color", EmitDefaultValue=false)]
        public string ProjectColor { get; set; }

        /// <summary>
        /// Gets or Sets ProjectHexColor
        /// </summary>
        [DataMember(Name="project_hex_color", EmitDefaultValue=false)]
        public string ProjectHexColor { get; set; }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name="project_id", EmitDefaultValue=false)]
        public int? ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets ProjectName
        /// </summary>
        [DataMember(Name="project_name", EmitDefaultValue=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Gets or Sets Seconds
        /// </summary>
        [DataMember(Name="seconds", EmitDefaultValue=false)]
        public UtilsInt64Slice Seconds { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="user_name", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeeklyDataRow {\n");
            sb.Append("  BillableAmountsInCents: ").Append(BillableAmountsInCents).Append("\n");
            sb.Append("  BillableSeconds: ").Append(BillableSeconds).Append("\n");
            sb.Append("  ClientName: ").Append(ClientName).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  HourlyRateInCents: ").Append(HourlyRateInCents).Append("\n");
            sb.Append("  PlannedTaskId: ").Append(PlannedTaskId).Append("\n");
            sb.Append("  ProjectColor: ").Append(ProjectColor).Append("\n");
            sb.Append("  ProjectHexColor: ").Append(ProjectHexColor).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
            sb.Append("  Seconds: ").Append(Seconds).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
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
            return this.Equals(input as WeeklyDataRow);
        }

        /// <summary>
        /// Returns true if WeeklyDataRow instances are equal
        /// </summary>
        /// <param name="input">Instance of WeeklyDataRow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WeeklyDataRow input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BillableAmountsInCents == input.BillableAmountsInCents ||
                    (this.BillableAmountsInCents != null &&
                    this.BillableAmountsInCents.Equals(input.BillableAmountsInCents))
                ) && 
                (
                    this.BillableSeconds == input.BillableSeconds ||
                    (this.BillableSeconds != null &&
                    this.BillableSeconds.Equals(input.BillableSeconds))
                ) && 
                (
                    this.ClientName == input.ClientName ||
                    (this.ClientName != null &&
                    this.ClientName.Equals(input.ClientName))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.HourlyRateInCents == input.HourlyRateInCents ||
                    (this.HourlyRateInCents != null &&
                    this.HourlyRateInCents.Equals(input.HourlyRateInCents))
                ) && 
                (
                    this.PlannedTaskId == input.PlannedTaskId ||
                    (this.PlannedTaskId != null &&
                    this.PlannedTaskId.Equals(input.PlannedTaskId))
                ) && 
                (
                    this.ProjectColor == input.ProjectColor ||
                    (this.ProjectColor != null &&
                    this.ProjectColor.Equals(input.ProjectColor))
                ) && 
                (
                    this.ProjectHexColor == input.ProjectHexColor ||
                    (this.ProjectHexColor != null &&
                    this.ProjectHexColor.Equals(input.ProjectHexColor))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
                ) && 
                (
                    this.Seconds == input.Seconds ||
                    (this.Seconds != null &&
                    this.Seconds.Equals(input.Seconds))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
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
                if (this.BillableAmountsInCents != null)
                    hashCode = hashCode * 59 + this.BillableAmountsInCents.GetHashCode();
                if (this.BillableSeconds != null)
                    hashCode = hashCode * 59 + this.BillableSeconds.GetHashCode();
                if (this.ClientName != null)
                    hashCode = hashCode * 59 + this.ClientName.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.HourlyRateInCents != null)
                    hashCode = hashCode * 59 + this.HourlyRateInCents.GetHashCode();
                if (this.PlannedTaskId != null)
                    hashCode = hashCode * 59 + this.PlannedTaskId.GetHashCode();
                if (this.ProjectColor != null)
                    hashCode = hashCode * 59 + this.ProjectColor.GetHashCode();
                if (this.ProjectHexColor != null)
                    hashCode = hashCode * 59 + this.ProjectHexColor.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null)
                    hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.Seconds != null)
                    hashCode = hashCode * 59 + this.Seconds.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
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
