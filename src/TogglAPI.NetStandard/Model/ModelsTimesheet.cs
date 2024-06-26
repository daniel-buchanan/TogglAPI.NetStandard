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
    /// ModelsTimesheet
    /// </summary>
    [DataContract]
    public partial class ModelsTimesheet :  IEquatable<ModelsTimesheet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsTimesheet" /> class.
        /// </summary>
        /// <param name="approvedOrRejectedAt">approvedOrRejectedAt.</param>
        /// <param name="approvedOrRejectedID">approvedOrRejectedID.</param>
        /// <param name="approvedOrRejectedName">approvedOrRejectedName.</param>
        /// <param name="approverID">approverID.</param>
        /// <param name="approverName">approverName.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="deletedAt">deletedAt.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="memberID">memberID.</param>
        /// <param name="memberName">memberName.</param>
        /// <param name="periodEditable">periodEditable.</param>
        /// <param name="periodEndDate">periodEndDate.</param>
        /// <param name="periodLocked">periodLocked.</param>
        /// <param name="periodStartDate">periodStartDate.</param>
        /// <param name="periodicity">periodicity.</param>
        /// <param name="rejectionComment">rejectionComment.</param>
        /// <param name="reminderDay">reminderDay.</param>
        /// <param name="reminderSentAt">reminderSentAt.</param>
        /// <param name="reminderTime">reminderTime.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="status">status.</param>
        /// <param name="submittedAt">submittedAt.</param>
        /// <param name="timesheetSetupID">timesheetSetupID.</param>
        /// <param name="timezone">timezone.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="workingHoursInMinutes">workingHoursInMinutes.</param>
        /// <param name="workspaceID">workspaceID.</param>
        public ModelsTimesheet(string approvedOrRejectedAt = default(string), long? approvedOrRejectedID = default(long?), string approvedOrRejectedName = default(string), long? approverID = default(long?), string approverName = default(string), string createdAt = default(string), string deletedAt = default(string), string endDate = default(string), long? memberID = default(long?), string memberName = default(string), bool? periodEditable = default(bool?), string periodEndDate = default(string), bool? periodLocked = default(bool?), string periodStartDate = default(string), string periodicity = default(string), string rejectionComment = default(string), string reminderDay = default(string), string reminderSentAt = default(string), string reminderTime = default(string), string startDate = default(string), string status = default(string), string submittedAt = default(string), long? timesheetSetupID = default(long?), string timezone = default(string), string updatedAt = default(string), long? workingHoursInMinutes = default(long?), long? workspaceID = default(long?))
        {
            this.ApprovedOrRejectedAt = approvedOrRejectedAt;
            this.ApprovedOrRejectedID = approvedOrRejectedID;
            this.ApprovedOrRejectedName = approvedOrRejectedName;
            this.ApproverID = approverID;
            this.ApproverName = approverName;
            this.CreatedAt = createdAt;
            this.DeletedAt = deletedAt;
            this.EndDate = endDate;
            this.MemberID = memberID;
            this.MemberName = memberName;
            this.PeriodEditable = periodEditable;
            this.PeriodEndDate = periodEndDate;
            this.PeriodLocked = periodLocked;
            this.PeriodStartDate = periodStartDate;
            this.Periodicity = periodicity;
            this.RejectionComment = rejectionComment;
            this.ReminderDay = reminderDay;
            this.ReminderSentAt = reminderSentAt;
            this.ReminderTime = reminderTime;
            this.StartDate = startDate;
            this.Status = status;
            this.SubmittedAt = submittedAt;
            this.TimesheetSetupID = timesheetSetupID;
            this.Timezone = timezone;
            this.UpdatedAt = updatedAt;
            this.WorkingHoursInMinutes = workingHoursInMinutes;
            this.WorkspaceID = workspaceID;
        }
        
        /// <summary>
        /// Gets or Sets ApprovedOrRejectedAt
        /// </summary>
        [DataMember(Name="approvedOrRejectedAt", EmitDefaultValue=false)]
        public string ApprovedOrRejectedAt { get; set; }

        /// <summary>
        /// Gets or Sets ApprovedOrRejectedID
        /// </summary>
        [DataMember(Name="approvedOrRejectedID", EmitDefaultValue=false)]
        public long? ApprovedOrRejectedID { get; set; }

        /// <summary>
        /// Gets or Sets ApprovedOrRejectedName
        /// </summary>
        [DataMember(Name="approvedOrRejectedName", EmitDefaultValue=false)]
        public string ApprovedOrRejectedName { get; set; }

        /// <summary>
        /// Gets or Sets ApproverID
        /// </summary>
        [DataMember(Name="approverID", EmitDefaultValue=false)]
        public long? ApproverID { get; set; }

        /// <summary>
        /// Gets or Sets ApproverName
        /// </summary>
        [DataMember(Name="approverName", EmitDefaultValue=false)]
        public string ApproverName { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets DeletedAt
        /// </summary>
        [DataMember(Name="deletedAt", EmitDefaultValue=false)]
        public string DeletedAt { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or Sets MemberID
        /// </summary>
        [DataMember(Name="memberID", EmitDefaultValue=false)]
        public long? MemberID { get; set; }

        /// <summary>
        /// Gets or Sets MemberName
        /// </summary>
        [DataMember(Name="memberName", EmitDefaultValue=false)]
        public string MemberName { get; set; }

        /// <summary>
        /// Gets or Sets PeriodEditable
        /// </summary>
        [DataMember(Name="periodEditable", EmitDefaultValue=false)]
        public bool? PeriodEditable { get; set; }

        /// <summary>
        /// Gets or Sets PeriodEndDate
        /// </summary>
        [DataMember(Name="periodEndDate", EmitDefaultValue=false)]
        public string PeriodEndDate { get; set; }

        /// <summary>
        /// Gets or Sets PeriodLocked
        /// </summary>
        [DataMember(Name="periodLocked", EmitDefaultValue=false)]
        public bool? PeriodLocked { get; set; }

        /// <summary>
        /// Gets or Sets PeriodStartDate
        /// </summary>
        [DataMember(Name="periodStartDate", EmitDefaultValue=false)]
        public string PeriodStartDate { get; set; }

        /// <summary>
        /// Gets or Sets Periodicity
        /// </summary>
        [DataMember(Name="periodicity", EmitDefaultValue=false)]
        public string Periodicity { get; set; }

        /// <summary>
        /// Gets or Sets RejectionComment
        /// </summary>
        [DataMember(Name="rejectionComment", EmitDefaultValue=false)]
        public string RejectionComment { get; set; }

        /// <summary>
        /// Gets or Sets ReminderDay
        /// </summary>
        [DataMember(Name="reminderDay", EmitDefaultValue=false)]
        public string ReminderDay { get; set; }

        /// <summary>
        /// Gets or Sets ReminderSentAt
        /// </summary>
        [DataMember(Name="reminderSentAt", EmitDefaultValue=false)]
        public string ReminderSentAt { get; set; }

        /// <summary>
        /// Gets or Sets ReminderTime
        /// </summary>
        [DataMember(Name="reminderTime", EmitDefaultValue=false)]
        public string ReminderTime { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets SubmittedAt
        /// </summary>
        [DataMember(Name="submittedAt", EmitDefaultValue=false)]
        public string SubmittedAt { get; set; }

        /// <summary>
        /// Gets or Sets TimesheetSetupID
        /// </summary>
        [DataMember(Name="timesheetSetupID", EmitDefaultValue=false)]
        public long? TimesheetSetupID { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updatedAt", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets WorkingHoursInMinutes
        /// </summary>
        [DataMember(Name="workingHoursInMinutes", EmitDefaultValue=false)]
        public long? WorkingHoursInMinutes { get; set; }

        /// <summary>
        /// Gets or Sets WorkspaceID
        /// </summary>
        [DataMember(Name="workspaceID", EmitDefaultValue=false)]
        public long? WorkspaceID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelsTimesheet {\n");
            sb.Append("  ApprovedOrRejectedAt: ").Append(ApprovedOrRejectedAt).Append("\n");
            sb.Append("  ApprovedOrRejectedID: ").Append(ApprovedOrRejectedID).Append("\n");
            sb.Append("  ApprovedOrRejectedName: ").Append(ApprovedOrRejectedName).Append("\n");
            sb.Append("  ApproverID: ").Append(ApproverID).Append("\n");
            sb.Append("  ApproverName: ").Append(ApproverName).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  MemberID: ").Append(MemberID).Append("\n");
            sb.Append("  MemberName: ").Append(MemberName).Append("\n");
            sb.Append("  PeriodEditable: ").Append(PeriodEditable).Append("\n");
            sb.Append("  PeriodEndDate: ").Append(PeriodEndDate).Append("\n");
            sb.Append("  PeriodLocked: ").Append(PeriodLocked).Append("\n");
            sb.Append("  PeriodStartDate: ").Append(PeriodStartDate).Append("\n");
            sb.Append("  Periodicity: ").Append(Periodicity).Append("\n");
            sb.Append("  RejectionComment: ").Append(RejectionComment).Append("\n");
            sb.Append("  ReminderDay: ").Append(ReminderDay).Append("\n");
            sb.Append("  ReminderSentAt: ").Append(ReminderSentAt).Append("\n");
            sb.Append("  ReminderTime: ").Append(ReminderTime).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubmittedAt: ").Append(SubmittedAt).Append("\n");
            sb.Append("  TimesheetSetupID: ").Append(TimesheetSetupID).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  WorkingHoursInMinutes: ").Append(WorkingHoursInMinutes).Append("\n");
            sb.Append("  WorkspaceID: ").Append(WorkspaceID).Append("\n");
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
            return this.Equals(input as ModelsTimesheet);
        }

        /// <summary>
        /// Returns true if ModelsTimesheet instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelsTimesheet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelsTimesheet input)
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
                    this.ApprovedOrRejectedID == input.ApprovedOrRejectedID ||
                    (this.ApprovedOrRejectedID != null &&
                    this.ApprovedOrRejectedID.Equals(input.ApprovedOrRejectedID))
                ) && 
                (
                    this.ApprovedOrRejectedName == input.ApprovedOrRejectedName ||
                    (this.ApprovedOrRejectedName != null &&
                    this.ApprovedOrRejectedName.Equals(input.ApprovedOrRejectedName))
                ) && 
                (
                    this.ApproverID == input.ApproverID ||
                    (this.ApproverID != null &&
                    this.ApproverID.Equals(input.ApproverID))
                ) && 
                (
                    this.ApproverName == input.ApproverName ||
                    (this.ApproverName != null &&
                    this.ApproverName.Equals(input.ApproverName))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.DeletedAt == input.DeletedAt ||
                    (this.DeletedAt != null &&
                    this.DeletedAt.Equals(input.DeletedAt))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.MemberID == input.MemberID ||
                    (this.MemberID != null &&
                    this.MemberID.Equals(input.MemberID))
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
                    this.PeriodEndDate == input.PeriodEndDate ||
                    (this.PeriodEndDate != null &&
                    this.PeriodEndDate.Equals(input.PeriodEndDate))
                ) && 
                (
                    this.PeriodLocked == input.PeriodLocked ||
                    (this.PeriodLocked != null &&
                    this.PeriodLocked.Equals(input.PeriodLocked))
                ) && 
                (
                    this.PeriodStartDate == input.PeriodStartDate ||
                    (this.PeriodStartDate != null &&
                    this.PeriodStartDate.Equals(input.PeriodStartDate))
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
                    this.TimesheetSetupID == input.TimesheetSetupID ||
                    (this.TimesheetSetupID != null &&
                    this.TimesheetSetupID.Equals(input.TimesheetSetupID))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.WorkingHoursInMinutes == input.WorkingHoursInMinutes ||
                    (this.WorkingHoursInMinutes != null &&
                    this.WorkingHoursInMinutes.Equals(input.WorkingHoursInMinutes))
                ) && 
                (
                    this.WorkspaceID == input.WorkspaceID ||
                    (this.WorkspaceID != null &&
                    this.WorkspaceID.Equals(input.WorkspaceID))
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
                if (this.ApprovedOrRejectedID != null)
                    hashCode = hashCode * 59 + this.ApprovedOrRejectedID.GetHashCode();
                if (this.ApprovedOrRejectedName != null)
                    hashCode = hashCode * 59 + this.ApprovedOrRejectedName.GetHashCode();
                if (this.ApproverID != null)
                    hashCode = hashCode * 59 + this.ApproverID.GetHashCode();
                if (this.ApproverName != null)
                    hashCode = hashCode * 59 + this.ApproverName.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.DeletedAt != null)
                    hashCode = hashCode * 59 + this.DeletedAt.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.MemberID != null)
                    hashCode = hashCode * 59 + this.MemberID.GetHashCode();
                if (this.MemberName != null)
                    hashCode = hashCode * 59 + this.MemberName.GetHashCode();
                if (this.PeriodEditable != null)
                    hashCode = hashCode * 59 + this.PeriodEditable.GetHashCode();
                if (this.PeriodEndDate != null)
                    hashCode = hashCode * 59 + this.PeriodEndDate.GetHashCode();
                if (this.PeriodLocked != null)
                    hashCode = hashCode * 59 + this.PeriodLocked.GetHashCode();
                if (this.PeriodStartDate != null)
                    hashCode = hashCode * 59 + this.PeriodStartDate.GetHashCode();
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
                if (this.TimesheetSetupID != null)
                    hashCode = hashCode * 59 + this.TimesheetSetupID.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.WorkingHoursInMinutes != null)
                    hashCode = hashCode * 59 + this.WorkingHoursInMinutes.GetHashCode();
                if (this.WorkspaceID != null)
                    hashCode = hashCode * 59 + this.WorkspaceID.GetHashCode();
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
