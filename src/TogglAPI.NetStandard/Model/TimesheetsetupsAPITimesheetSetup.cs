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
    /// TimesheetsetupsAPITimesheetSetup
    /// </summary>
    [DataContract]
    public partial class TimesheetsetupsAPITimesheetSetup :  IEquatable<TimesheetsetupsAPITimesheetSetup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimesheetsetupsAPITimesheetSetup" /> class.
        /// </summary>
        /// <param name="approverId">approverId.</param>
        /// <param name="approverName">approverName.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="errors">errors.</param>
        /// <param name="id">id.</param>
        /// <param name="memberId">memberId.</param>
        /// <param name="memberName">memberName.</param>
        /// <param name="periodicity">periodicity.</param>
        /// <param name="reminderDay">reminderDay.</param>
        /// <param name="reminderTime">reminderTime.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="workspaceId">workspaceId.</param>
        public TimesheetsetupsAPITimesheetSetup(long? approverId = default(long?), string approverName = default(string), string endDate = default(string), List<ModelsTimesheetSetupError> errors = default(List<ModelsTimesheetSetupError>), long? id = default(long?), long? memberId = default(long?), string memberName = default(string), string periodicity = default(string), string reminderDay = default(string), string reminderTime = default(string), string startDate = default(string), long? workspaceId = default(long?))
        {
            this.ApproverId = approverId;
            this.ApproverName = approverName;
            this.EndDate = endDate;
            this.Errors = errors;
            this.Id = id;
            this.MemberId = memberId;
            this.MemberName = memberName;
            this.Periodicity = periodicity;
            this.ReminderDay = reminderDay;
            this.ReminderTime = reminderTime;
            this.StartDate = startDate;
            this.WorkspaceId = workspaceId;
        }
        
        /// <summary>
        /// Gets or Sets ApproverId
        /// </summary>
        [DataMember(Name="approver_id", EmitDefaultValue=false)]
        public long? ApproverId { get; set; }

        /// <summary>
        /// Gets or Sets ApproverName
        /// </summary>
        [DataMember(Name="approver_name", EmitDefaultValue=false)]
        public string ApproverName { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<ModelsTimesheetSetupError> Errors { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets MemberId
        /// </summary>
        [DataMember(Name="member_id", EmitDefaultValue=false)]
        public long? MemberId { get; set; }

        /// <summary>
        /// Gets or Sets MemberName
        /// </summary>
        [DataMember(Name="member_name", EmitDefaultValue=false)]
        public string MemberName { get; set; }

        /// <summary>
        /// Gets or Sets Periodicity
        /// </summary>
        [DataMember(Name="periodicity", EmitDefaultValue=false)]
        public string Periodicity { get; set; }

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
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or Sets WorkspaceId
        /// </summary>
        [DataMember(Name="workspace_id", EmitDefaultValue=false)]
        public long? WorkspaceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimesheetsetupsAPITimesheetSetup {\n");
            sb.Append("  ApproverId: ").Append(ApproverId).Append("\n");
            sb.Append("  ApproverName: ").Append(ApproverName).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MemberId: ").Append(MemberId).Append("\n");
            sb.Append("  MemberName: ").Append(MemberName).Append("\n");
            sb.Append("  Periodicity: ").Append(Periodicity).Append("\n");
            sb.Append("  ReminderDay: ").Append(ReminderDay).Append("\n");
            sb.Append("  ReminderTime: ").Append(ReminderTime).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
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
            return this.Equals(input as TimesheetsetupsAPITimesheetSetup);
        }

        /// <summary>
        /// Returns true if TimesheetsetupsAPITimesheetSetup instances are equal
        /// </summary>
        /// <param name="input">Instance of TimesheetsetupsAPITimesheetSetup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimesheetsetupsAPITimesheetSetup input)
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
                    this.ApproverName == input.ApproverName ||
                    (this.ApproverName != null &&
                    this.ApproverName.Equals(input.ApproverName))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MemberId == input.MemberId ||
                    (this.MemberId != null &&
                    this.MemberId.Equals(input.MemberId))
                ) && 
                (
                    this.MemberName == input.MemberName ||
                    (this.MemberName != null &&
                    this.MemberName.Equals(input.MemberName))
                ) && 
                (
                    this.Periodicity == input.Periodicity ||
                    (this.Periodicity != null &&
                    this.Periodicity.Equals(input.Periodicity))
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
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.WorkspaceId == input.WorkspaceId ||
                    (this.WorkspaceId != null &&
                    this.WorkspaceId.Equals(input.WorkspaceId))
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
                if (this.ApproverName != null)
                    hashCode = hashCode * 59 + this.ApproverName.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MemberId != null)
                    hashCode = hashCode * 59 + this.MemberId.GetHashCode();
                if (this.MemberName != null)
                    hashCode = hashCode * 59 + this.MemberName.GetHashCode();
                if (this.Periodicity != null)
                    hashCode = hashCode * 59 + this.Periodicity.GetHashCode();
                if (this.ReminderDay != null)
                    hashCode = hashCode * 59 + this.ReminderDay.GetHashCode();
                if (this.ReminderTime != null)
                    hashCode = hashCode * 59 + this.ReminderTime.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.WorkspaceId != null)
                    hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
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