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
    /// UserAssignmentsPayload
    /// </summary>
    [DataContract]
    public partial class UserAssignmentsPayload :  IEquatable<UserAssignmentsPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAssignmentsPayload" /> class.
        /// </summary>
        /// <param name="groupId">groupId.</param>
        /// <param name="joined">joined.</param>
        /// <param name="operation">operation.</param>
        /// <param name="userId">userId.</param>
        public UserAssignmentsPayload(long? groupId = default(long?), bool? joined = default(bool?), string operation = default(string), long? userId = default(long?))
        {
            this.GroupId = groupId;
            this.Joined = joined;
            this.Operation = operation;
            this.UserId = userId;
        }
        
        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name="group_id", EmitDefaultValue=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// Gets or Sets Joined
        /// </summary>
        [DataMember(Name="joined", EmitDefaultValue=false)]
        public bool? Joined { get; set; }

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public string Operation { get; set; }

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
            sb.Append("class UserAssignmentsPayload {\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  Joined: ").Append(Joined).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
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
            return this.Equals(input as UserAssignmentsPayload);
        }

        /// <summary>
        /// Returns true if UserAssignmentsPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAssignmentsPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAssignmentsPayload input)
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
                    this.Joined == input.Joined ||
                    (this.Joined != null &&
                    this.Joined.Equals(input.Joined))
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
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
                if (this.Joined != null)
                    hashCode = hashCode * 59 + this.Joined.GetHashCode();
                if (this.Operation != null)
                    hashCode = hashCode * 59 + this.Operation.GetHashCode();
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