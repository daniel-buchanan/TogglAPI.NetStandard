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
    /// TimesheetsetupsUpdatePayload
    /// </summary>
    [DataContract]
    public partial class TimesheetsetupsUpdatePayload :  IEquatable<TimesheetsetupsUpdatePayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimesheetsetupsUpdatePayload" /> class.
        /// </summary>
        /// <param name="approverId">approverId.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="reminderDay">reminderDay.</param>
        /// <param name="reminderTime">reminderTime.</param>
        public TimesheetsetupsUpdatePayload(long? approverId = default(long?), string endDate = default(string), string reminderDay = default(string), string reminderTime = default(string))
        {
            this.ApproverId = approverId;
            this.EndDate = endDate;
            this.ReminderDay = reminderDay;
            this.ReminderTime = reminderTime;
        }
        
        /// <summary>
        /// Gets or Sets ApproverId
        /// </summary>
        [DataMember(Name="approver_id", EmitDefaultValue=false)]
        public long? ApproverId { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or Sets ReminderDay
        /// </summary>
        [DataMember(Name="reminder_day", EmitDefaultValue=false)]
        public string ReminderDay { get; set; }

        /// <summary>
        /// Gets or Sets ReminderTime
        /// </summary>
        [DataMember(Name="reminder_time", EmitDefaultValue=false)]
        public string ReminderTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimesheetsetupsUpdatePayload {\n");
            sb.Append("  ApproverId: ").Append(ApproverId).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ReminderDay: ").Append(ReminderDay).Append("\n");
            sb.Append("  ReminderTime: ").Append(ReminderTime).Append("\n");
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
            return this.Equals(input as TimesheetsetupsUpdatePayload);
        }

        /// <summary>
        /// Returns true if TimesheetsetupsUpdatePayload instances are equal
        /// </summary>
        /// <param name="input">Instance of TimesheetsetupsUpdatePayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimesheetsetupsUpdatePayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApproverId == input.ApproverId ||
                    (this.ApproverId != null &&
                    this.ApproverId.Equals(input.ApproverId))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.ReminderDay == input.ReminderDay ||
                    (this.ReminderDay != null &&
                    this.ReminderDay.Equals(input.ReminderDay))
                ) && 
                (
                    this.ReminderTime == input.ReminderTime ||
                    (this.ReminderTime != null &&
                    this.ReminderTime.Equals(input.ReminderTime))
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
                if (this.ApproverId != null)
                    hashCode = hashCode * 59 + this.ApproverId.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.ReminderDay != null)
                    hashCode = hashCode * 59 + this.ReminderDay.GetHashCode();
                if (this.ReminderTime != null)
                    hashCode = hashCode * 59 + this.ReminderTime.GetHashCode();
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