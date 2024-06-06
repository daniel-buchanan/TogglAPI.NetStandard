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
    /// TasksTaskStatus
    /// </summary>
    [DataContract]
    public partial class TasksTaskStatus :  IEquatable<TasksTaskStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TasksTaskStatus" /> class.
        /// </summary>
        /// <param name="billableAmount">billableAmount.</param>
        /// <param name="billableSeconds">billableSeconds.</param>
        /// <param name="currency">currency.</param>
        /// <param name="estimatedSeconds">estimatedSeconds.</param>
        /// <param name="id">id.</param>
        /// <param name="trackedSeconds">trackedSeconds.</param>
        public TasksTaskStatus(long? billableAmount = default(long?), long? billableSeconds = default(long?), string currency = default(string), long? estimatedSeconds = default(long?), long? id = default(long?), long? trackedSeconds = default(long?))
        {
            this.BillableAmount = billableAmount;
            this.BillableSeconds = billableSeconds;
            this.Currency = currency;
            this.EstimatedSeconds = estimatedSeconds;
            this.Id = id;
            this.TrackedSeconds = trackedSeconds;
        }
        
        /// <summary>
        /// Gets or Sets BillableAmount
        /// </summary>
        [DataMember(Name="billable_amount", EmitDefaultValue=false)]
        public long? BillableAmount { get; set; }

        /// <summary>
        /// Gets or Sets BillableSeconds
        /// </summary>
        [DataMember(Name="billable_seconds", EmitDefaultValue=false)]
        public long? BillableSeconds { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedSeconds
        /// </summary>
        [DataMember(Name="estimated_seconds", EmitDefaultValue=false)]
        public long? EstimatedSeconds { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets TrackedSeconds
        /// </summary>
        [DataMember(Name="tracked_seconds", EmitDefaultValue=false)]
        public long? TrackedSeconds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TasksTaskStatus {\n");
            sb.Append("  BillableAmount: ").Append(BillableAmount).Append("\n");
            sb.Append("  BillableSeconds: ").Append(BillableSeconds).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  EstimatedSeconds: ").Append(EstimatedSeconds).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TrackedSeconds: ").Append(TrackedSeconds).Append("\n");
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
            return this.Equals(input as TasksTaskStatus);
        }

        /// <summary>
        /// Returns true if TasksTaskStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of TasksTaskStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TasksTaskStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BillableAmount == input.BillableAmount ||
                    (this.BillableAmount != null &&
                    this.BillableAmount.Equals(input.BillableAmount))
                ) && 
                (
                    this.BillableSeconds == input.BillableSeconds ||
                    (this.BillableSeconds != null &&
                    this.BillableSeconds.Equals(input.BillableSeconds))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.EstimatedSeconds == input.EstimatedSeconds ||
                    (this.EstimatedSeconds != null &&
                    this.EstimatedSeconds.Equals(input.EstimatedSeconds))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.TrackedSeconds == input.TrackedSeconds ||
                    (this.TrackedSeconds != null &&
                    this.TrackedSeconds.Equals(input.TrackedSeconds))
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
                if (this.BillableAmount != null)
                    hashCode = hashCode * 59 + this.BillableAmount.GetHashCode();
                if (this.BillableSeconds != null)
                    hashCode = hashCode * 59 + this.BillableSeconds.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.EstimatedSeconds != null)
                    hashCode = hashCode * 59 + this.EstimatedSeconds.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TrackedSeconds != null)
                    hashCode = hashCode * 59 + this.TrackedSeconds.GetHashCode();
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
