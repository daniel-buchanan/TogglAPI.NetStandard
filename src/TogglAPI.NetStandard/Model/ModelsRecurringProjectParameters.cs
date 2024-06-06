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
    /// ModelsRecurringProjectParameters
    /// </summary>
    [DataContract]
    public partial class ModelsRecurringProjectParameters :  IEquatable<ModelsRecurringProjectParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsRecurringProjectParameters" /> class.
        /// </summary>
        /// <param name="customPeriod">Custom period, used when \&quot;period\&quot; field is \&quot;custom\&quot;.</param>
        /// <param name="estimatedSeconds">Estimated seconds.</param>
        /// <param name="parameterEndDate">Recurring end date.</param>
        /// <param name="parameterStartDate">Recurring start date.</param>
        /// <param name="period">Period.</param>
        /// <param name="projectStartDate">Project start date.</param>
        public ModelsRecurringProjectParameters(long? customPeriod = default(long?), long? estimatedSeconds = default(long?), string parameterEndDate = default(string), string parameterStartDate = default(string), string period = default(string), string projectStartDate = default(string))
        {
            this.CustomPeriod = customPeriod;
            this.EstimatedSeconds = estimatedSeconds;
            this.ParameterEndDate = parameterEndDate;
            this.ParameterStartDate = parameterStartDate;
            this.Period = period;
            this.ProjectStartDate = projectStartDate;
        }
        
        /// <summary>
        /// Custom period, used when \&quot;period\&quot; field is \&quot;custom\&quot;
        /// </summary>
        /// <value>Custom period, used when \&quot;period\&quot; field is \&quot;custom\&quot;</value>
        [DataMember(Name="custom_period", EmitDefaultValue=false)]
        public long? CustomPeriod { get; set; }

        /// <summary>
        /// Estimated seconds
        /// </summary>
        /// <value>Estimated seconds</value>
        [DataMember(Name="estimated_seconds", EmitDefaultValue=false)]
        public long? EstimatedSeconds { get; set; }

        /// <summary>
        /// Recurring end date
        /// </summary>
        /// <value>Recurring end date</value>
        [DataMember(Name="parameter_end_date", EmitDefaultValue=false)]
        public string ParameterEndDate { get; set; }

        /// <summary>
        /// Recurring start date
        /// </summary>
        /// <value>Recurring start date</value>
        [DataMember(Name="parameter_start_date", EmitDefaultValue=false)]
        public string ParameterStartDate { get; set; }

        /// <summary>
        /// Period
        /// </summary>
        /// <value>Period</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public string Period { get; set; }

        /// <summary>
        /// Project start date
        /// </summary>
        /// <value>Project start date</value>
        [DataMember(Name="project_start_date", EmitDefaultValue=false)]
        public string ProjectStartDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelsRecurringProjectParameters {\n");
            sb.Append("  CustomPeriod: ").Append(CustomPeriod).Append("\n");
            sb.Append("  EstimatedSeconds: ").Append(EstimatedSeconds).Append("\n");
            sb.Append("  ParameterEndDate: ").Append(ParameterEndDate).Append("\n");
            sb.Append("  ParameterStartDate: ").Append(ParameterStartDate).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  ProjectStartDate: ").Append(ProjectStartDate).Append("\n");
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
            return this.Equals(input as ModelsRecurringProjectParameters);
        }

        /// <summary>
        /// Returns true if ModelsRecurringProjectParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelsRecurringProjectParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelsRecurringProjectParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomPeriod == input.CustomPeriod ||
                    (this.CustomPeriod != null &&
                    this.CustomPeriod.Equals(input.CustomPeriod))
                ) && 
                (
                    this.EstimatedSeconds == input.EstimatedSeconds ||
                    (this.EstimatedSeconds != null &&
                    this.EstimatedSeconds.Equals(input.EstimatedSeconds))
                ) && 
                (
                    this.ParameterEndDate == input.ParameterEndDate ||
                    (this.ParameterEndDate != null &&
                    this.ParameterEndDate.Equals(input.ParameterEndDate))
                ) && 
                (
                    this.ParameterStartDate == input.ParameterStartDate ||
                    (this.ParameterStartDate != null &&
                    this.ParameterStartDate.Equals(input.ParameterStartDate))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.ProjectStartDate == input.ProjectStartDate ||
                    (this.ProjectStartDate != null &&
                    this.ProjectStartDate.Equals(input.ProjectStartDate))
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
                if (this.CustomPeriod != null)
                    hashCode = hashCode * 59 + this.CustomPeriod.GetHashCode();
                if (this.EstimatedSeconds != null)
                    hashCode = hashCode * 59 + this.EstimatedSeconds.GetHashCode();
                if (this.ParameterEndDate != null)
                    hashCode = hashCode * 59 + this.ParameterEndDate.GetHashCode();
                if (this.ParameterStartDate != null)
                    hashCode = hashCode * 59 + this.ParameterStartDate.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.ProjectStartDate != null)
                    hashCode = hashCode * 59 + this.ProjectStartDate.GetHashCode();
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
