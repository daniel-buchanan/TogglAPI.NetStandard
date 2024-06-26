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
    /// ModelsOrganizationUserSimple
    /// </summary>
    [DataContract]
    public partial class ModelsOrganizationUserSimple :  IEquatable<ModelsOrganizationUserSimple>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsOrganizationUserSimple" /> class.
        /// </summary>
        /// <param name="avatarUrl">avatarUrl.</param>
        /// <param name="joined">joined.</param>
        /// <param name="name">name.</param>
        /// <param name="userId">userId.</param>
        public ModelsOrganizationUserSimple(string avatarUrl = default(string), bool? joined = default(bool?), string name = default(string), long? userId = default(long?))
        {
            this.AvatarUrl = avatarUrl;
            this.Joined = joined;
            this.Name = name;
            this.UserId = userId;
        }
        
        /// <summary>
        /// Gets or Sets AvatarUrl
        /// </summary>
        [DataMember(Name="avatar_url", EmitDefaultValue=false)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// Gets or Sets Joined
        /// </summary>
        [DataMember(Name="joined", EmitDefaultValue=false)]
        public bool? Joined { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
            sb.Append("class ModelsOrganizationUserSimple {\n");
            sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
            sb.Append("  Joined: ").Append(Joined).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as ModelsOrganizationUserSimple);
        }

        /// <summary>
        /// Returns true if ModelsOrganizationUserSimple instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelsOrganizationUserSimple to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelsOrganizationUserSimple input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvatarUrl == input.AvatarUrl ||
                    (this.AvatarUrl != null &&
                    this.AvatarUrl.Equals(input.AvatarUrl))
                ) && 
                (
                    this.Joined == input.Joined ||
                    (this.Joined != null &&
                    this.Joined.Equals(input.Joined))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.AvatarUrl != null)
                    hashCode = hashCode * 59 + this.AvatarUrl.GetHashCode();
                if (this.Joined != null)
                    hashCode = hashCode * 59 + this.Joined.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
