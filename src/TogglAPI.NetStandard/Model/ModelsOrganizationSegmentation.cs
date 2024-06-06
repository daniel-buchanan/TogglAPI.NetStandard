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
    /// ModelsOrganizationSegmentation
    /// </summary>
    [DataContract]
    public partial class ModelsOrganizationSegmentation :  IEquatable<ModelsOrganizationSegmentation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsOrganizationSegmentation" /> class.
        /// </summary>
        /// <param name="demoRequested">demoRequested.</param>
        /// <param name="fullName">fullName.</param>
        /// <param name="heard">heard.</param>
        /// <param name="industries">industries.</param>
        /// <param name="membersRange">membersRange.</param>
        /// <param name="organizationId">organizationId.</param>
        /// <param name="reasons">reasons.</param>
        /// <param name="skippedStep">skippedStep.</param>
        /// <param name="userId">userId.</param>
        public ModelsOrganizationSegmentation(bool? demoRequested = default(bool?), string fullName = default(string), string heard = default(string), string industries = default(string), string membersRange = default(string), long? organizationId = default(long?), string reasons = default(string), string skippedStep = default(string), long? userId = default(long?))
        {
            this.DemoRequested = demoRequested;
            this.FullName = fullName;
            this.Heard = heard;
            this.Industries = industries;
            this.MembersRange = membersRange;
            this.OrganizationId = organizationId;
            this.Reasons = reasons;
            this.SkippedStep = skippedStep;
            this.UserId = userId;
        }
        
        /// <summary>
        /// Gets or Sets DemoRequested
        /// </summary>
        [DataMember(Name="demo_requested", EmitDefaultValue=false)]
        public bool? DemoRequested { get; set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name="full_name", EmitDefaultValue=false)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets Heard
        /// </summary>
        [DataMember(Name="heard", EmitDefaultValue=false)]
        public string Heard { get; set; }

        /// <summary>
        /// Gets or Sets Industries
        /// </summary>
        [DataMember(Name="industries", EmitDefaultValue=false)]
        public string Industries { get; set; }

        /// <summary>
        /// Gets or Sets MembersRange
        /// </summary>
        [DataMember(Name="members_range", EmitDefaultValue=false)]
        public string MembersRange { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organization_id", EmitDefaultValue=false)]
        public long? OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets Reasons
        /// </summary>
        [DataMember(Name="reasons", EmitDefaultValue=false)]
        public string Reasons { get; set; }

        /// <summary>
        /// Gets or Sets SkippedStep
        /// </summary>
        [DataMember(Name="skipped_step", EmitDefaultValue=false)]
        public string SkippedStep { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelsOrganizationSegmentation {\n");
            sb.Append("  DemoRequested: ").Append(DemoRequested).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Heard: ").Append(Heard).Append("\n");
            sb.Append("  Industries: ").Append(Industries).Append("\n");
            sb.Append("  MembersRange: ").Append(MembersRange).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  Reasons: ").Append(Reasons).Append("\n");
            sb.Append("  SkippedStep: ").Append(SkippedStep).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as ModelsOrganizationSegmentation);
        }

        /// <summary>
        /// Returns true if ModelsOrganizationSegmentation instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelsOrganizationSegmentation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelsOrganizationSegmentation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DemoRequested == input.DemoRequested ||
                    (this.DemoRequested != null &&
                    this.DemoRequested.Equals(input.DemoRequested))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.Heard == input.Heard ||
                    (this.Heard != null &&
                    this.Heard.Equals(input.Heard))
                ) && 
                (
                    this.Industries == input.Industries ||
                    (this.Industries != null &&
                    this.Industries.Equals(input.Industries))
                ) && 
                (
                    this.MembersRange == input.MembersRange ||
                    (this.MembersRange != null &&
                    this.MembersRange.Equals(input.MembersRange))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.Reasons == input.Reasons ||
                    (this.Reasons != null &&
                    this.Reasons.Equals(input.Reasons))
                ) && 
                (
                    this.SkippedStep == input.SkippedStep ||
                    (this.SkippedStep != null &&
                    this.SkippedStep.Equals(input.SkippedStep))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.DemoRequested != null)
                    hashCode = hashCode * 59 + this.DemoRequested.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.Heard != null)
                    hashCode = hashCode * 59 + this.Heard.GetHashCode();
                if (this.Industries != null)
                    hashCode = hashCode * 59 + this.Industries.GetHashCode();
                if (this.MembersRange != null)
                    hashCode = hashCode * 59 + this.MembersRange.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.Reasons != null)
                    hashCode = hashCode * 59 + this.Reasons.GetHashCode();
                if (this.SkippedStep != null)
                    hashCode = hashCode * 59 + this.SkippedStep.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
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
