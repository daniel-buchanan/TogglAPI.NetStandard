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
    /// GoalsParamsInsight
    /// </summary>
    [DataContract]
    public partial class GoalsParamsInsight :  IEquatable<GoalsParamsInsight>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoalsParamsInsight" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GoalsParamsInsight() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GoalsParamsInsight" /> class.
        /// </summary>
        /// <param name="cadencePeriod">cadencePeriod (required).</param>
        /// <param name="goalType">goalType (required).</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="workspaceId">workspaceId (required).</param>
        public GoalsParamsInsight(string cadencePeriod = default(string), ModelsGoalType goalType = default(ModelsGoalType), int? userId = default(int?), int? workspaceId = default(int?))
        {
            // to ensure "cadencePeriod" is required (not null)
            if (cadencePeriod == null)
            {
                throw new InvalidDataException("cadencePeriod is a required property for GoalsParamsInsight and cannot be null");
            }
            else
            {
                this.CadencePeriod = cadencePeriod;
            }
            // to ensure "goalType" is required (not null)
            if (goalType == null)
            {
                throw new InvalidDataException("goalType is a required property for GoalsParamsInsight and cannot be null");
            }
            else
            {
                this.GoalType = goalType;
            }
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for GoalsParamsInsight and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }
            // to ensure "workspaceId" is required (not null)
            if (workspaceId == null)
            {
                throw new InvalidDataException("workspaceId is a required property for GoalsParamsInsight and cannot be null");
            }
            else
            {
                this.WorkspaceId = workspaceId;
            }
        }
        
        /// <summary>
        /// Gets or Sets CadencePeriod
        /// </summary>
        [DataMember(Name="cadence_period", EmitDefaultValue=false)]
        public string CadencePeriod { get; set; }

        /// <summary>
        /// Gets or Sets GoalType
        /// </summary>
        [DataMember(Name="goal_type", EmitDefaultValue=false)]
        public ModelsGoalType GoalType { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets WorkspaceId
        /// </summary>
        [DataMember(Name="workspace_id", EmitDefaultValue=false)]
        public int? WorkspaceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GoalsParamsInsight {\n");
            sb.Append("  CadencePeriod: ").Append(CadencePeriod).Append("\n");
            sb.Append("  GoalType: ").Append(GoalType).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as GoalsParamsInsight);
        }

        /// <summary>
        /// Returns true if GoalsParamsInsight instances are equal
        /// </summary>
        /// <param name="input">Instance of GoalsParamsInsight to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoalsParamsInsight input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CadencePeriod == input.CadencePeriod ||
                    (this.CadencePeriod != null &&
                    this.CadencePeriod.Equals(input.CadencePeriod))
                ) && 
                (
                    this.GoalType == input.GoalType ||
                    (this.GoalType != null &&
                    this.GoalType.Equals(input.GoalType))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.CadencePeriod != null)
                    hashCode = hashCode * 59 + this.CadencePeriod.GetHashCode();
                if (this.GoalType != null)
                    hashCode = hashCode * 59 + this.GoalType.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
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
