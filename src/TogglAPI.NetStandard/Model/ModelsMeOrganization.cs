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
    /// ModelsMeOrganization
    /// </summary>
    [DataContract]
    public partial class ModelsMeOrganization :  IEquatable<ModelsMeOrganization>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsMeOrganization" /> class.
        /// </summary>
        /// <param name="admin">Whether the requester is an admin of the organization.</param>
        /// <param name="at">Organization&#39;s last modification date.</param>
        /// <param name="createdAt">Organization&#39;s creation date.</param>
        /// <param name="id">Organization ID.</param>
        /// <param name="isMultiWorkspaceEnabled">Is true when the organization option is_multi_workspace_enabled is set.</param>
        /// <param name="isUnified">isUnified.</param>
        /// <param name="maxDataRetentionDays">How far back free workspaces in this org can access data..</param>
        /// <param name="maxWorkspaces">Maximum number of workspaces allowed for the organization.</param>
        /// <param name="name">Organization Name.</param>
        /// <param name="owner">Whether the requester is a the owner of the organization.</param>
        /// <param name="paymentMethods">Organization&#39;s subscription payment methods. Omitted if empty..</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="pricingPlanEnterprise">The subscription plan is an enterprise plan.</param>
        /// <param name="pricingPlanId">Organization plan ID.</param>
        /// <param name="pricingPlanName">The subscription plan name the org is currently on. Free or any plan name coming from payment provider.</param>
        /// <param name="serverDeletedAt">Organization&#39;s delete date.</param>
        /// <param name="suspendedAt">Whether the organization is currently suspended.</param>
        /// <param name="trialInfo">trialInfo.</param>
        /// <param name="userCount">Number of organization users.</param>
        public ModelsMeOrganization(bool? admin = default(bool?), DateTime? at = default(DateTime?), DateTime? createdAt = default(DateTime?), long? id = default(long?), bool? isMultiWorkspaceEnabled = default(bool?), bool? isUnified = default(bool?), long? maxDataRetentionDays = default(long?), long? maxWorkspaces = default(long?), string name = default(string), bool? owner = default(bool?), string paymentMethods = default(string), string permissions = default(string), bool? pricingPlanEnterprise = default(bool?), long? pricingPlanId = default(long?), string pricingPlanName = default(string), DateTime? serverDeletedAt = default(DateTime?), string suspendedAt = default(string), ModelsTrialInfo trialInfo = default(ModelsTrialInfo), long? userCount = default(long?))
        {
            this.Admin = admin;
            this.At = at;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.IsMultiWorkspaceEnabled = isMultiWorkspaceEnabled;
            this.IsUnified = isUnified;
            this.MaxDataRetentionDays = maxDataRetentionDays;
            this.MaxWorkspaces = maxWorkspaces;
            this.Name = name;
            this.Owner = owner;
            this.PaymentMethods = paymentMethods;
            this.Permissions = permissions;
            this.PricingPlanEnterprise = pricingPlanEnterprise;
            this.PricingPlanId = pricingPlanId;
            this.PricingPlanName = pricingPlanName;
            this.ServerDeletedAt = serverDeletedAt;
            this.SuspendedAt = suspendedAt;
            this.TrialInfo = trialInfo;
            this.UserCount = userCount;
        }
        
        /// <summary>
        /// Whether the requester is an admin of the organization
        /// </summary>
        /// <value>Whether the requester is an admin of the organization</value>
        [DataMember(Name="admin", EmitDefaultValue=false)]
        public bool? Admin { get; set; }

        /// <summary>
        /// Organization&#39;s last modification date
        /// </summary>
        /// <value>Organization&#39;s last modification date</value>
        [DataMember(Name="at", EmitDefaultValue=false)]
        public DateTime? At { get; set; }

        /// <summary>
        /// Organization&#39;s creation date
        /// </summary>
        /// <value>Organization&#39;s creation date</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Organization ID
        /// </summary>
        /// <value>Organization ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Is true when the organization option is_multi_workspace_enabled is set
        /// </summary>
        /// <value>Is true when the organization option is_multi_workspace_enabled is set</value>
        [DataMember(Name="is_multi_workspace_enabled", EmitDefaultValue=false)]
        public bool? IsMultiWorkspaceEnabled { get; set; }

        /// <summary>
        /// Gets or Sets IsUnified
        /// </summary>
        [DataMember(Name="is_unified", EmitDefaultValue=false)]
        public bool? IsUnified { get; set; }

        /// <summary>
        /// How far back free workspaces in this org can access data.
        /// </summary>
        /// <value>How far back free workspaces in this org can access data.</value>
        [DataMember(Name="max_data_retention_days", EmitDefaultValue=false)]
        public long? MaxDataRetentionDays { get; set; }

        /// <summary>
        /// Maximum number of workspaces allowed for the organization
        /// </summary>
        /// <value>Maximum number of workspaces allowed for the organization</value>
        [DataMember(Name="max_workspaces", EmitDefaultValue=false)]
        public long? MaxWorkspaces { get; set; }

        /// <summary>
        /// Organization Name
        /// </summary>
        /// <value>Organization Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Whether the requester is a the owner of the organization
        /// </summary>
        /// <value>Whether the requester is a the owner of the organization</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public bool? Owner { get; set; }

        /// <summary>
        /// Organization&#39;s subscription payment methods. Omitted if empty.
        /// </summary>
        /// <value>Organization&#39;s subscription payment methods. Omitted if empty.</value>
        [DataMember(Name="payment_methods", EmitDefaultValue=false)]
        public string PaymentMethods { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public string Permissions { get; set; }

        /// <summary>
        /// The subscription plan is an enterprise plan
        /// </summary>
        /// <value>The subscription plan is an enterprise plan</value>
        [DataMember(Name="pricing_plan_enterprise", EmitDefaultValue=false)]
        public bool? PricingPlanEnterprise { get; set; }

        /// <summary>
        /// Organization plan ID
        /// </summary>
        /// <value>Organization plan ID</value>
        [DataMember(Name="pricing_plan_id", EmitDefaultValue=false)]
        public long? PricingPlanId { get; set; }

        /// <summary>
        /// The subscription plan name the org is currently on. Free or any plan name coming from payment provider
        /// </summary>
        /// <value>The subscription plan name the org is currently on. Free or any plan name coming from payment provider</value>
        [DataMember(Name="pricing_plan_name", EmitDefaultValue=false)]
        public string PricingPlanName { get; set; }

        /// <summary>
        /// Organization&#39;s delete date
        /// </summary>
        /// <value>Organization&#39;s delete date</value>
        [DataMember(Name="server_deleted_at", EmitDefaultValue=false)]
        public DateTime? ServerDeletedAt { get; set; }

        /// <summary>
        /// Whether the organization is currently suspended
        /// </summary>
        /// <value>Whether the organization is currently suspended</value>
        [DataMember(Name="suspended_at", EmitDefaultValue=false)]
        public string SuspendedAt { get; set; }

        /// <summary>
        /// Gets or Sets TrialInfo
        /// </summary>
        [DataMember(Name="trial_info", EmitDefaultValue=false)]
        public ModelsTrialInfo TrialInfo { get; set; }

        /// <summary>
        /// Number of organization users
        /// </summary>
        /// <value>Number of organization users</value>
        [DataMember(Name="user_count", EmitDefaultValue=false)]
        public long? UserCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelsMeOrganization {\n");
            sb.Append("  Admin: ").Append(Admin).Append("\n");
            sb.Append("  At: ").Append(At).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsMultiWorkspaceEnabled: ").Append(IsMultiWorkspaceEnabled).Append("\n");
            sb.Append("  IsUnified: ").Append(IsUnified).Append("\n");
            sb.Append("  MaxDataRetentionDays: ").Append(MaxDataRetentionDays).Append("\n");
            sb.Append("  MaxWorkspaces: ").Append(MaxWorkspaces).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  PaymentMethods: ").Append(PaymentMethods).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  PricingPlanEnterprise: ").Append(PricingPlanEnterprise).Append("\n");
            sb.Append("  PricingPlanId: ").Append(PricingPlanId).Append("\n");
            sb.Append("  PricingPlanName: ").Append(PricingPlanName).Append("\n");
            sb.Append("  ServerDeletedAt: ").Append(ServerDeletedAt).Append("\n");
            sb.Append("  SuspendedAt: ").Append(SuspendedAt).Append("\n");
            sb.Append("  TrialInfo: ").Append(TrialInfo).Append("\n");
            sb.Append("  UserCount: ").Append(UserCount).Append("\n");
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
            return this.Equals(input as ModelsMeOrganization);
        }

        /// <summary>
        /// Returns true if ModelsMeOrganization instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelsMeOrganization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelsMeOrganization input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Admin == input.Admin ||
                    (this.Admin != null &&
                    this.Admin.Equals(input.Admin))
                ) && 
                (
                    this.At == input.At ||
                    (this.At != null &&
                    this.At.Equals(input.At))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsMultiWorkspaceEnabled == input.IsMultiWorkspaceEnabled ||
                    (this.IsMultiWorkspaceEnabled != null &&
                    this.IsMultiWorkspaceEnabled.Equals(input.IsMultiWorkspaceEnabled))
                ) && 
                (
                    this.IsUnified == input.IsUnified ||
                    (this.IsUnified != null &&
                    this.IsUnified.Equals(input.IsUnified))
                ) && 
                (
                    this.MaxDataRetentionDays == input.MaxDataRetentionDays ||
                    (this.MaxDataRetentionDays != null &&
                    this.MaxDataRetentionDays.Equals(input.MaxDataRetentionDays))
                ) && 
                (
                    this.MaxWorkspaces == input.MaxWorkspaces ||
                    (this.MaxWorkspaces != null &&
                    this.MaxWorkspaces.Equals(input.MaxWorkspaces))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.PaymentMethods == input.PaymentMethods ||
                    (this.PaymentMethods != null &&
                    this.PaymentMethods.Equals(input.PaymentMethods))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
                ) && 
                (
                    this.PricingPlanEnterprise == input.PricingPlanEnterprise ||
                    (this.PricingPlanEnterprise != null &&
                    this.PricingPlanEnterprise.Equals(input.PricingPlanEnterprise))
                ) && 
                (
                    this.PricingPlanId == input.PricingPlanId ||
                    (this.PricingPlanId != null &&
                    this.PricingPlanId.Equals(input.PricingPlanId))
                ) && 
                (
                    this.PricingPlanName == input.PricingPlanName ||
                    (this.PricingPlanName != null &&
                    this.PricingPlanName.Equals(input.PricingPlanName))
                ) && 
                (
                    this.ServerDeletedAt == input.ServerDeletedAt ||
                    (this.ServerDeletedAt != null &&
                    this.ServerDeletedAt.Equals(input.ServerDeletedAt))
                ) && 
                (
                    this.SuspendedAt == input.SuspendedAt ||
                    (this.SuspendedAt != null &&
                    this.SuspendedAt.Equals(input.SuspendedAt))
                ) && 
                (
                    this.TrialInfo == input.TrialInfo ||
                    (this.TrialInfo != null &&
                    this.TrialInfo.Equals(input.TrialInfo))
                ) && 
                (
                    this.UserCount == input.UserCount ||
                    (this.UserCount != null &&
                    this.UserCount.Equals(input.UserCount))
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
                if (this.Admin != null)
                    hashCode = hashCode * 59 + this.Admin.GetHashCode();
                if (this.At != null)
                    hashCode = hashCode * 59 + this.At.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsMultiWorkspaceEnabled != null)
                    hashCode = hashCode * 59 + this.IsMultiWorkspaceEnabled.GetHashCode();
                if (this.IsUnified != null)
                    hashCode = hashCode * 59 + this.IsUnified.GetHashCode();
                if (this.MaxDataRetentionDays != null)
                    hashCode = hashCode * 59 + this.MaxDataRetentionDays.GetHashCode();
                if (this.MaxWorkspaces != null)
                    hashCode = hashCode * 59 + this.MaxWorkspaces.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.PaymentMethods != null)
                    hashCode = hashCode * 59 + this.PaymentMethods.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.PricingPlanEnterprise != null)
                    hashCode = hashCode * 59 + this.PricingPlanEnterprise.GetHashCode();
                if (this.PricingPlanId != null)
                    hashCode = hashCode * 59 + this.PricingPlanId.GetHashCode();
                if (this.PricingPlanName != null)
                    hashCode = hashCode * 59 + this.PricingPlanName.GetHashCode();
                if (this.ServerDeletedAt != null)
                    hashCode = hashCode * 59 + this.ServerDeletedAt.GetHashCode();
                if (this.SuspendedAt != null)
                    hashCode = hashCode * 59 + this.SuspendedAt.GetHashCode();
                if (this.TrialInfo != null)
                    hashCode = hashCode * 59 + this.TrialInfo.GetHashCode();
                if (this.UserCount != null)
                    hashCode = hashCode * 59 + this.UserCount.GetHashCode();
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