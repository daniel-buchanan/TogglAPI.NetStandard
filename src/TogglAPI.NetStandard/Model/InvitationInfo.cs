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
    /// InvitationInfo
    /// </summary>
    [DataContract]
    public partial class InvitationInfo :  IEquatable<InvitationInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationInfo" /> class.
        /// </summary>
        /// <param name="email">email.</param>
        /// <param name="invitationId">invitationId.</param>
        /// <param name="inviteUrl">inviteUrl.</param>
        /// <param name="organizationId">organizationId.</param>
        /// <param name="recipientId">recipientId.</param>
        /// <param name="senderId">senderId.</param>
        public InvitationInfo(string email = default(string), long? invitationId = default(long?), string inviteUrl = default(string), long? organizationId = default(long?), long? recipientId = default(long?), long? senderId = default(long?))
        {
            this.Email = email;
            this.InvitationId = invitationId;
            this.InviteUrl = inviteUrl;
            this.OrganizationId = organizationId;
            this.RecipientId = recipientId;
            this.SenderId = senderId;
        }
        
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets InvitationId
        /// </summary>
        [DataMember(Name="invitation_id", EmitDefaultValue=false)]
        public long? InvitationId { get; set; }

        /// <summary>
        /// Gets or Sets InviteUrl
        /// </summary>
        [DataMember(Name="invite_url", EmitDefaultValue=false)]
        public string InviteUrl { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organization_id", EmitDefaultValue=false)]
        public long? OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets RecipientId
        /// </summary>
        [DataMember(Name="recipient_id", EmitDefaultValue=false)]
        public long? RecipientId { get; set; }

        /// <summary>
        /// Gets or Sets SenderId
        /// </summary>
        [DataMember(Name="sender_id", EmitDefaultValue=false)]
        public long? SenderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvitationInfo {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  InvitationId: ").Append(InvitationId).Append("\n");
            sb.Append("  InviteUrl: ").Append(InviteUrl).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  RecipientId: ").Append(RecipientId).Append("\n");
            sb.Append("  SenderId: ").Append(SenderId).Append("\n");
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
            return this.Equals(input as InvitationInfo);
        }

        /// <summary>
        /// Returns true if InvitationInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of InvitationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvitationInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.InvitationId == input.InvitationId ||
                    (this.InvitationId != null &&
                    this.InvitationId.Equals(input.InvitationId))
                ) && 
                (
                    this.InviteUrl == input.InviteUrl ||
                    (this.InviteUrl != null &&
                    this.InviteUrl.Equals(input.InviteUrl))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.RecipientId == input.RecipientId ||
                    (this.RecipientId != null &&
                    this.RecipientId.Equals(input.RecipientId))
                ) && 
                (
                    this.SenderId == input.SenderId ||
                    (this.SenderId != null &&
                    this.SenderId.Equals(input.SenderId))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.InvitationId != null)
                    hashCode = hashCode * 59 + this.InvitationId.GetHashCode();
                if (this.InviteUrl != null)
                    hashCode = hashCode * 59 + this.InviteUrl.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.RecipientId != null)
                    hashCode = hashCode * 59 + this.RecipientId.GetHashCode();
                if (this.SenderId != null)
                    hashCode = hashCode * 59 + this.SenderId.GetHashCode();
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
