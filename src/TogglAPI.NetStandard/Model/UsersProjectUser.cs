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
    /// UsersProjectUser
    /// </summary>
    [DataContract]
    public partial class UsersProjectUser :  IEquatable<UsersProjectUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersProjectUser" /> class.
        /// </summary>
        /// <param name="groupId">groupId.</param>
        /// <param name="hourlyRate">hourlyRate.</param>
        /// <param name="id">id.</param>
        /// <param name="labourCost">labourCost.</param>
        /// <param name="manager">manager.</param>
        /// <param name="projectId">projectId.</param>
        /// <param name="userId">userId.</param>
        public UsersProjectUser(int? groupId = default(int?), decimal? hourlyRate = default(decimal?), int? id = default(int?), int? labourCost = default(int?), bool? manager = default(bool?), int? projectId = default(int?), int? userId = default(int?))
        {
            this.GroupId = groupId;
            this.HourlyRate = hourlyRate;
            this.Id = id;
            this.LabourCost = labourCost;
            this.Manager = manager;
            this.ProjectId = projectId;
            this.UserId = userId;
        }
        
        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name="group_id", EmitDefaultValue=false)]
        public int? GroupId { get; set; }

        /// <summary>
        /// Gets or Sets HourlyRate
        /// </summary>
        [DataMember(Name="hourly_rate", EmitDefaultValue=false)]
        public decimal? HourlyRate { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets LabourCost
        /// </summary>
        [DataMember(Name="labour_cost", EmitDefaultValue=false)]
        public int? LabourCost { get; set; }

        /// <summary>
        /// Gets or Sets Manager
        /// </summary>
        [DataMember(Name="manager", EmitDefaultValue=false)]
        public bool? Manager { get; set; }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name="project_id", EmitDefaultValue=false)]
        public int? ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsersProjectUser {\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  HourlyRate: ").Append(HourlyRate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LabourCost: ").Append(LabourCost).Append("\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
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
            return this.Equals(input as UsersProjectUser);
        }

        /// <summary>
        /// Returns true if UsersProjectUser instances are equal
        /// </summary>
        /// <param name="input">Instance of UsersProjectUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsersProjectUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.HourlyRate == input.HourlyRate ||
                    (this.HourlyRate != null &&
                    this.HourlyRate.Equals(input.HourlyRate))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LabourCost == input.LabourCost ||
                    (this.LabourCost != null &&
                    this.LabourCost.Equals(input.LabourCost))
                ) && 
                (
                    this.Manager == input.Manager ||
                    (this.Manager != null &&
                    this.Manager.Equals(input.Manager))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
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
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.HourlyRate != null)
                    hashCode = hashCode * 59 + this.HourlyRate.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LabourCost != null)
                    hashCode = hashCode * 59 + this.LabourCost.GetHashCode();
                if (this.Manager != null)
                    hashCode = hashCode * 59 + this.Manager.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
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
