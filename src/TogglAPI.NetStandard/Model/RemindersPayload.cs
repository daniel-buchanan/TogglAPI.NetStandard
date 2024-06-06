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
    /// RemindersPayload
    /// </summary>
    [DataContract]
    public partial class RemindersPayload :  IEquatable<RemindersPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemindersPayload" /> class.
        /// </summary>
        /// <param name="frequency">Frequency of the reminder in days, should be either 1 or 7.</param>
        /// <param name="groupIds">Group IDs to send the reminder to, can be omitted if user_ids is provided.</param>
        /// <param name="threshold">Threshold is the number of hours after which the reminder will be sent.</param>
        /// <param name="userIds">User IDs to send the reminder to, can be omitted if group_ids is provided.</param>
        public RemindersPayload(long? frequency = default(long?), List<long?> groupIds = default(List<long?>), decimal? threshold = default(decimal?), List<long?> userIds = default(List<long?>))
        {
            this.Frequency = frequency;
            this.GroupIds = groupIds;
            this.Threshold = threshold;
            this.UserIds = userIds;
        }
        
        /// <summary>
        /// Frequency of the reminder in days, should be either 1 or 7
        /// </summary>
        /// <value>Frequency of the reminder in days, should be either 1 or 7</value>
        [DataMember(Name="frequency", EmitDefaultValue=false)]
        public long? Frequency { get; set; }

        /// <summary>
        /// Group IDs to send the reminder to, can be omitted if user_ids is provided
        /// </summary>
        /// <value>Group IDs to send the reminder to, can be omitted if user_ids is provided</value>
        [DataMember(Name="group_ids", EmitDefaultValue=false)]
        public List<long?> GroupIds { get; set; }

        /// <summary>
        /// Threshold is the number of hours after which the reminder will be sent
        /// </summary>
        /// <value>Threshold is the number of hours after which the reminder will be sent</value>
        [DataMember(Name="threshold", EmitDefaultValue=false)]
        public decimal? Threshold { get; set; }

        /// <summary>
        /// User IDs to send the reminder to, can be omitted if group_ids is provided
        /// </summary>
        /// <value>User IDs to send the reminder to, can be omitted if group_ids is provided</value>
        [DataMember(Name="user_ids", EmitDefaultValue=false)]
        public List<long?> UserIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemindersPayload {\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  GroupIds: ").Append(GroupIds).Append("\n");
            sb.Append("  Threshold: ").Append(Threshold).Append("\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
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
            return this.Equals(input as RemindersPayload);
        }

        /// <summary>
        /// Returns true if RemindersPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of RemindersPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemindersPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
                ) && 
                (
                    this.GroupIds == input.GroupIds ||
                    this.GroupIds != null &&
                    this.GroupIds.SequenceEqual(input.GroupIds)
                ) && 
                (
                    this.Threshold == input.Threshold ||
                    (this.Threshold != null &&
                    this.Threshold.Equals(input.Threshold))
                ) && 
                (
                    this.UserIds == input.UserIds ||
                    this.UserIds != null &&
                    this.UserIds.SequenceEqual(input.UserIds)
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
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.GroupIds != null)
                    hashCode = hashCode * 59 + this.GroupIds.GetHashCode();
                if (this.Threshold != null)
                    hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                if (this.UserIds != null)
                    hashCode = hashCode * 59 + this.UserIds.GetHashCode();
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
