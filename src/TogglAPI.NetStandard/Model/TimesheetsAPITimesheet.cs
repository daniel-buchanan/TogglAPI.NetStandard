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
    /// TimesheetsAPITimesheet
    /// </summary>
    [DataContract]
    public partial class TimesheetsAPITimesheet :  IEquatable<TimesheetsAPITimesheet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimesheetsAPITimesheet" /> class.
        /// </summary>
        /// <param name="approvedOrRejectedAt">approvedOrRejectedAt.</param>
        /// <param name="approvedOrRejectedId">approvedOrRejectedId.</param>
        /// <param name="approvedOrRejectedName">approvedOrRejectedName.</param>
        /// <param name="approverId">approverId.</param>
        /// <param name="approverName">approverName.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="memberId">memberId.</param>
        /// <param name="memberName">memberName.</param>
        /// <param name="periodEditable">periodEditable.</param>
        /// <param name="periodEnd">periodEnd.</param>
        /// <param name="periodLocked">periodLocked.</param>
        /// <param name="periodStart">periodStart.</param>
        /// <param name="periodicity">periodicity.</param>
        /// <param name="rejectionComment">rejectionComment.</param>
        /// <param name="reminderDay">reminderDay.</param>
        /// <param name="reminderSentAt">reminderSentAt.</param>
        /// <param name="reminderTime">reminderTime.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="status">status.</param>
        /// <param name="submittedAt">submittedAt.</param>
        /// <param name="timesheetSetupId">timesheetSetupId.</param>
        /// <param name="workingHoursInMinutes">workingHoursInMinutes.</param>
        /// <param name="workspaceId">workspaceId.</param>
        public TimesheetsAPITimesheet(string approvedOrRejectedAt = default(string), long? approvedOrRejectedId = default(long?), string approvedOrRejectedName = default(string), long? approverId = default(long?), string approverName = default(string), string endDate = default(string), long? memberId = default(long?), string memberName = default(string), bool? periodEditable = default(bool?), string periodEnd = default(string), bool? periodLocked = default(bool?), string periodStart = default(string), string periodicity = default(string), string rejectionComment = default(string), string reminderDay = default(string), string reminderSentAt = default(string), string reminderTime = default(string), string startDate = default(string), string status = default(string), string submittedAt = default(string), long? timesheetSetupId = default(long?), long? workingHoursInMinutes = default(long?), long? workspaceId = default(long?))
        {
            this.ApprovedOrRejectedAt = approvedOrRejectedAt;
            this.ApprovedOrRejectedId = approvedOrRejectedId;
            this.ApprovedOrRejectedName = approvedOrRejectedName;
            this.ApproverId = approverId;
            this.ApproverName = approverName;
            this.EndDate = endDate;
            this.MemberId = memberId;
            this.MemberName = memberName;
            this.PeriodEditable = periodEditable;
            this.PeriodEnd = periodEnd;
            this.PeriodLocked = periodLocked;
            this.PeriodStart = periodStart;
            this.Periodicity = periodicity;
            this.RejectionComment = rejectionComment;
            this.ReminderDay = reminderDay;
            this.ReminderSentAt = reminderSentAt;
            this.ReminderTime = reminderTime;
            this.StartDate = startDate;
            this.Status = status;
            this.SubmittedAt = submittedAt;
            this.TimesheetSetupId = timesheetSetupId;
            this.WorkingHoursInMinutes = workingHoursInMinutes;
            this.WorkspaceId = workspaceId;
        }
        
        /// <summary>
        /// Gets or Sets ApprovedOrRejectedAt
        /// </summary>
        [DataMember(Name="approved_or_rejected_at", EmitDefaultValue=false)]
        public string ApprovedOrRejectedAt { get; set; }

        /// <summary>
        /// Gets or Sets ApprovedOrRejectedId
        /// </summary>
        [DataMember(Name="approved_or_rejected_id", EmitDefaultValue=false)]
        public long? ApprovedOrRejectedId { get; set; }

        /// <summary>
        /// Gets or Sets ApprovedOrRejectedName
        /// </summary>
        [DataMember(Name="approved_or_rejected_name", EmitDefaultValue=false)]
        public string ApprovedOrRejectedName { get; set; }

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
        /// Gets or Sets PeriodEditable
        /// </summary>
        [DataMember(Name="period_editable", EmitDefaultValue=false)]
        public bool? PeriodEditable { get; set; }

        /// <summary>
        /// Gets or Sets PeriodEnd
        /// </summary>
        [DataMember(Name="period_end", EmitDefaultValue=false)]
        public string PeriodEnd { get; set; }

        /// <summary>
        /// Gets or Sets PeriodLocked
        /// </summary>
        [DataMember(Name="period_locked", EmitDefaultValue=false)]
        public bool? PeriodLocked { get; set; }

        /// <summary>
        /// Gets or Sets PeriodStart
        /// </summary>
        [DataMember(Name="period_start", EmitDefaultValue=false)]
        public string PeriodStart { get; set; }

        /// <summary>
        /// Gets or Sets Periodicity
        /// </summary>
        [DataMember(Name="periodicity", EmitDefaultValue=false)]
        public string Periodicity { get; set; }

        /// <summary>
        /// Gets or Sets RejectionComment
        /// </summary>
        [DataMember(Name="rejection_comment", EmitDefaultValue=false)]
        public string RejectionComment { get; set; }

        /// <summary>
        /// Gets or Sets ReminderDay
        /// </summary>
        [DataMember(Name="reminder_day", EmitDefaultValue=false)]
        public string ReminderDay { get; set; }

        /// <summary>
        /// Gets or Sets ReminderSentAt
        /// </summary>
        [DataMember(Name="reminder_sent_at", EmitDefaultValue=false)]
        public string ReminderSentAt { get; set; }

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
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets SubmittedAt
        /// </summary>
        [DataMember(Name="submitted_at", EmitDefaultValue=false)]
        public string SubmittedAt { get; set; }

        /// <summary>
        /// Gets or Sets TimesheetSetupId
        /// </summary>
        [DataMember(Name="timesheet_setup_id", EmitDefaultValue=false)]
        public long? TimesheetSetupId { get; set; }

        /// <summary>
        /// Gets or Sets WorkingHoursInMinutes
        /// </summary>
        [DataMember(Name="working_hours_in_minutes", EmitDefaultValue=false)]
        public long? WorkingHoursInMinutes { get; set; }

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
            sb.Append("class TimesheetsAPITimesheet {\n");
            sb.Append("  ApprovedOrRejectedAt: ").Append(ApprovedOrRejectedAt).Append("\n");
            sb.Append("  ApprovedOrRejectedId: ").Append(ApprovedOrRejectedId).Append("\n");
            sb.Append("  ApprovedOrRejectedName: ").Append(ApprovedOrRejectedName).Append("\n");
            sb.Append("  ApproverId: ").Append(ApproverId).Append("\n");
            sb.Append("  ApproverName: ").Append(ApproverName).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  MemberId: ").Append(MemberId).Append("\n");
            sb.Append("  MemberName: ").Append(MemberName).Append("\n");
            sb.Append("  PeriodEditable: ").Append(PeriodEditable).Append("\n");
            sb.Append("  PeriodEnd: ").Append(PeriodEnd).Append("\n");
            sb.Append("  PeriodLocked: ").Append(PeriodLocked).Append("\n");
            sb.Append("  PeriodStart: ").Append(PeriodStart).Append("\n");
            sb.Append("  Periodicity: ").Append(Periodicity).Append("\n");
            sb.Append("  RejectionComment: ").Append(RejectionComment).Append("\n");
            sb.Append("  ReminderDay: ").Append(ReminderDay).Append("\n");
            sb.Append("  ReminderSentAt: ").Append(ReminderSentAt).Append("\n");
            sb.Append("  ReminderTime: ").Append(ReminderTime).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubmittedAt: ").Append(SubmittedAt).Append("\n");
            sb.Append("  TimesheetSetupId: ").Append(TimesheetSetupId).Append("\n");
            sb.Append("  WorkingHoursInMinutes: ").Append(WorkingHoursInMinutes).Append("\n");
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
            return this.Equals(input as TimesheetsAPITimesheet);
        }

        /// <summary>
        /// Returns true if TimesheetsAPITimesheet instances are equal
        /// </summary>
        /// <param name="input">Instance of TimesheetsAPITimesheet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimesheetsAPITimesheet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApprovedOrRejectedAt == input.ApprovedOrRejectedAt ||
                    (this.ApprovedOrRejectedAt != null &&
                    this.ApprovedOrRejectedAt.Equals(input.ApprovedOrRejectedAt))
                ) && 
                (
                    this.ApprovedOrRejectedId == input.ApprovedOrRejectedId ||
                    (this.ApprovedOrRejectedId != null &&
                    this.ApprovedOrRejectedId.Equals(input.ApprovedOrRejectedId))
                ) && 
                (
                    this.ApprovedOrRejectedName == input.ApprovedOrRejectedName ||
                    (this.ApprovedOrRejectedName != null &&
                    this.ApprovedOrRejectedName.Equals(input.ApprovedOrRejectedName))
                ) && 
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
                    this.PeriodEditable == input.PeriodEditable ||
                    (this.PeriodEditable != null &&
                    this.PeriodEditable.Equals(input.PeriodEditable))
                ) && 
                (
                    this.PeriodEnd == input.PeriodEnd ||
                    (this.PeriodEnd != null &&
                    this.PeriodEnd.Equals(input.PeriodEnd))
                ) && 
                (
                    this.PeriodLocked == input.PeriodLocked ||
                    (this.PeriodLocked != null &&
                    this.PeriodLocked.Equals(input.PeriodLocked))
                ) && 
                (
                    this.PeriodStart == input.PeriodStart ||
                    (this.PeriodStart != null &&
                    this.PeriodStart.Equals(input.PeriodStart))
                ) && 
                (
                    this.Periodicity == input.Periodicity ||
                    (this.Periodicity != null &&
                    this.Periodicity.Equals(input.Periodicity))
                ) && 
                (
                    this.RejectionComment == input.RejectionComment ||
                    (this.RejectionComment != null &&
                    this.RejectionComment.Equals(input.RejectionComment))
                ) && 
                (
                    this.ReminderDay == input.ReminderDay ||
                    (this.ReminderDay != null &&
                    this.ReminderDay.Equals(input.ReminderDay))
                ) && 
                (
                    this.ReminderSentAt == input.ReminderSentAt ||
                    (this.ReminderSentAt != null &&
                    this.ReminderSentAt.Equals(input.ReminderSentAt))
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SubmittedAt == input.SubmittedAt ||
                    (this.SubmittedAt != null &&
                    this.SubmittedAt.Equals(input.SubmittedAt))
                ) && 
                (
                    this.TimesheetSetupId == input.TimesheetSetupId ||
                    (this.TimesheetSetupId != null &&
                    this.TimesheetSetupId.Equals(input.TimesheetSetupId))
                ) && 
                (
                    this.WorkingHoursInMinutes == input.WorkingHoursInMinutes ||
                    (this.WorkingHoursInMinutes != null &&
                    this.WorkingHoursInMinutes.Equals(input.WorkingHoursInMinutes))
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
                if (this.ApprovedOrRejectedAt != null)
                    hashCode = hashCode * 59 + this.ApprovedOrRejectedAt.GetHashCode();
                if (this.ApprovedOrRejectedId != null)
                    hashCode = hashCode * 59 + this.ApprovedOrRejectedId.GetHashCode();
                if (this.ApprovedOrRejectedName != null)
                    hashCode = hashCode * 59 + this.ApprovedOrRejectedName.GetHashCode();
                if (this.ApproverId != null)
                    hashCode = hashCode * 59 + this.ApproverId.GetHashCode();
                if (this.ApproverName != null)
                    hashCode = hashCode * 59 + this.ApproverName.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.MemberId != null)
                    hashCode = hashCode * 59 + this.MemberId.GetHashCode();
                if (this.MemberName != null)
                    hashCode = hashCode * 59 + this.MemberName.GetHashCode();
                if (this.PeriodEditable != null)
                    hashCode = hashCode * 59 + this.PeriodEditable.GetHashCode();
                if (this.PeriodEnd != null)
                    hashCode = hashCode * 59 + this.PeriodEnd.GetHashCode();
                if (this.PeriodLocked != null)
                    hashCode = hashCode * 59 + this.PeriodLocked.GetHashCode();
                if (this.PeriodStart != null)
                    hashCode = hashCode * 59 + this.PeriodStart.GetHashCode();
                if (this.Periodicity != null)
                    hashCode = hashCode * 59 + this.Periodicity.GetHashCode();
                if (this.RejectionComment != null)
                    hashCode = hashCode * 59 + this.RejectionComment.GetHashCode();
                if (this.ReminderDay != null)
                    hashCode = hashCode * 59 + this.ReminderDay.GetHashCode();
                if (this.ReminderSentAt != null)
                    hashCode = hashCode * 59 + this.ReminderSentAt.GetHashCode();
                if (this.ReminderTime != null)
                    hashCode = hashCode * 59 + this.ReminderTime.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SubmittedAt != null)
                    hashCode = hashCode * 59 + this.SubmittedAt.GetHashCode();
                if (this.TimesheetSetupId != null)
                    hashCode = hashCode * 59 + this.TimesheetSetupId.GetHashCode();
                if (this.WorkingHoursInMinutes != null)
                    hashCode = hashCode * 59 + this.WorkingHoursInMinutes.GetHashCode();
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
