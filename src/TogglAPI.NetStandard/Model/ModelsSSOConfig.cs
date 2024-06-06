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
    /// ModelsSSOConfig
    /// </summary>
    [DataContract]
    public partial class ModelsSSOConfig :  IEquatable<ModelsSSOConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsSSOConfig" /> class.
        /// </summary>
        /// <param name="certificate">certificate.</param>
        /// <param name="domain">domain.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="entityId">entityId.</param>
        /// <param name="metadataUrl">metadataUrl.</param>
        /// <param name="name">name.</param>
        /// <param name="sharedSsoProfileId">sharedSsoProfileId.</param>
        /// <param name="ssoUrl">ssoUrl.</param>
        public ModelsSSOConfig(string certificate = default(string), string domain = default(string), bool? enabled = default(bool?), string entityId = default(string), string metadataUrl = default(string), string name = default(string), long? sharedSsoProfileId = default(long?), string ssoUrl = default(string))
        {
            this.Certificate = certificate;
            this.Domain = domain;
            this.Enabled = enabled;
            this.EntityId = entityId;
            this.MetadataUrl = metadataUrl;
            this.Name = name;
            this.SharedSsoProfileId = sharedSsoProfileId;
            this.SsoUrl = ssoUrl;
        }
        
        /// <summary>
        /// Gets or Sets Certificate
        /// </summary>
        [DataMember(Name="certificate", EmitDefaultValue=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets EntityId
        /// </summary>
        [DataMember(Name="entity_id", EmitDefaultValue=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// Gets or Sets MetadataUrl
        /// </summary>
        [DataMember(Name="metadata_url", EmitDefaultValue=false)]
        public string MetadataUrl { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SharedSsoProfileId
        /// </summary>
        [DataMember(Name="shared_sso_profile_id", EmitDefaultValue=false)]
        public long? SharedSsoProfileId { get; set; }

        /// <summary>
        /// Gets or Sets SsoUrl
        /// </summary>
        [DataMember(Name="sso_url", EmitDefaultValue=false)]
        public string SsoUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelsSSOConfig {\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  MetadataUrl: ").Append(MetadataUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SharedSsoProfileId: ").Append(SharedSsoProfileId).Append("\n");
            sb.Append("  SsoUrl: ").Append(SsoUrl).Append("\n");
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
            return this.Equals(input as ModelsSSOConfig);
        }

        /// <summary>
        /// Returns true if ModelsSSOConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelsSSOConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelsSSOConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.MetadataUrl == input.MetadataUrl ||
                    (this.MetadataUrl != null &&
                    this.MetadataUrl.Equals(input.MetadataUrl))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SharedSsoProfileId == input.SharedSsoProfileId ||
                    (this.SharedSsoProfileId != null &&
                    this.SharedSsoProfileId.Equals(input.SharedSsoProfileId))
                ) && 
                (
                    this.SsoUrl == input.SsoUrl ||
                    (this.SsoUrl != null &&
                    this.SsoUrl.Equals(input.SsoUrl))
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
                if (this.Certificate != null)
                    hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.MetadataUrl != null)
                    hashCode = hashCode * 59 + this.MetadataUrl.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SharedSsoProfileId != null)
                    hashCode = hashCode * 59 + this.SharedSsoProfileId.GetHashCode();
                if (this.SsoUrl != null)
                    hashCode = hashCode * 59 + this.SsoUrl.GetHashCode();
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