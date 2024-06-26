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
    /// MePostUser
    /// </summary>
    [DataContract]
    public partial class MePostUser :  IEquatable<MePostUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MePostUser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MePostUser() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MePostUser" /> class.
        /// </summary>
        /// <param name="countryId">User&#39;s country ID, if not provided will be United States.</param>
        /// <param name="createdWith">Should describe the application/service that is using the API.</param>
        /// <param name="email">Email for new user account (required).</param>
        /// <param name="fullName">User&#39;s full name, if not provided will be derived from the email address.</param>
        /// <param name="invitationCode">Optional, used when creating account through an invitation.</param>
        /// <param name="password">Password for new user account (required).</param>
        /// <param name="timezone">User&#39;s timezone, if not provided will be UTC.</param>
        /// <param name="tosAccepted">Whether the Terms of Service have been accepted (required).</param>
        /// <param name="workspace">Optional workspace settings, used when creating account not through an invitation.</param>
        public MePostUser(long? countryId = default(long?), string createdWith = default(string), string email = default(string), string fullName = default(string), string invitationCode = default(string), string password = default(string), string timezone = default(string), bool? tosAccepted = default(bool?), MePostInitialWorkspace workspace = default(MePostInitialWorkspace))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for MePostUser and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new InvalidDataException("password is a required property for MePostUser and cannot be null");
            }
            else
            {
                this.Password = password;
            }
            // to ensure "tosAccepted" is required (not null)
            if (tosAccepted == null)
            {
                throw new InvalidDataException("tosAccepted is a required property for MePostUser and cannot be null");
            }
            else
            {
                this.TosAccepted = tosAccepted;
            }
            this.CountryId = countryId;
            this.CreatedWith = createdWith;
            this.FullName = fullName;
            this.InvitationCode = invitationCode;
            this.Timezone = timezone;
            this.Workspace = workspace;
        }
        
        /// <summary>
        /// User&#39;s country ID, if not provided will be United States
        /// </summary>
        /// <value>User&#39;s country ID, if not provided will be United States</value>
        [DataMember(Name="country_id", EmitDefaultValue=false)]
        public long? CountryId { get; set; }

        /// <summary>
        /// Should describe the application/service that is using the API
        /// </summary>
        /// <value>Should describe the application/service that is using the API</value>
        [DataMember(Name="created_with", EmitDefaultValue=false)]
        public string CreatedWith { get; set; }

        /// <summary>
        /// Email for new user account
        /// </summary>
        /// <value>Email for new user account</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// User&#39;s full name, if not provided will be derived from the email address
        /// </summary>
        /// <value>User&#39;s full name, if not provided will be derived from the email address</value>
        [DataMember(Name="full_name", EmitDefaultValue=false)]
        public string FullName { get; set; }

        /// <summary>
        /// Optional, used when creating account through an invitation
        /// </summary>
        /// <value>Optional, used when creating account through an invitation</value>
        [DataMember(Name="invitation_code", EmitDefaultValue=false)]
        public string InvitationCode { get; set; }

        /// <summary>
        /// Password for new user account
        /// </summary>
        /// <value>Password for new user account</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// User&#39;s timezone, if not provided will be UTC
        /// </summary>
        /// <value>User&#39;s timezone, if not provided will be UTC</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Whether the Terms of Service have been accepted
        /// </summary>
        /// <value>Whether the Terms of Service have been accepted</value>
        [DataMember(Name="tos_accepted", EmitDefaultValue=false)]
        public bool? TosAccepted { get; set; }

        /// <summary>
        /// Optional workspace settings, used when creating account not through an invitation
        /// </summary>
        /// <value>Optional workspace settings, used when creating account not through an invitation</value>
        [DataMember(Name="workspace", EmitDefaultValue=false)]
        public MePostInitialWorkspace Workspace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MePostUser {\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  CreatedWith: ").Append(CreatedWith).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  InvitationCode: ").Append(InvitationCode).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  TosAccepted: ").Append(TosAccepted).Append("\n");
            sb.Append("  Workspace: ").Append(Workspace).Append("\n");
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
            return this.Equals(input as MePostUser);
        }

        /// <summary>
        /// Returns true if MePostUser instances are equal
        /// </summary>
        /// <param name="input">Instance of MePostUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MePostUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CountryId == input.CountryId ||
                    (this.CountryId != null &&
                    this.CountryId.Equals(input.CountryId))
                ) && 
                (
                    this.CreatedWith == input.CreatedWith ||
                    (this.CreatedWith != null &&
                    this.CreatedWith.Equals(input.CreatedWith))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.InvitationCode == input.InvitationCode ||
                    (this.InvitationCode != null &&
                    this.InvitationCode.Equals(input.InvitationCode))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.TosAccepted == input.TosAccepted ||
                    (this.TosAccepted != null &&
                    this.TosAccepted.Equals(input.TosAccepted))
                ) && 
                (
                    this.Workspace == input.Workspace ||
                    (this.Workspace != null &&
                    this.Workspace.Equals(input.Workspace))
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
                if (this.CountryId != null)
                    hashCode = hashCode * 59 + this.CountryId.GetHashCode();
                if (this.CreatedWith != null)
                    hashCode = hashCode * 59 + this.CreatedWith.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.InvitationCode != null)
                    hashCode = hashCode * 59 + this.InvitationCode.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.TosAccepted != null)
                    hashCode = hashCode * 59 + this.TosAccepted.GetHashCode();
                if (this.Workspace != null)
                    hashCode = hashCode * 59 + this.Workspace.GetHashCode();
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
            // Password (string) minLength
            if(this.Password != null && this.Password.Length < 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be greater than 6.", new [] { "Password" });
            }

            yield break;
        }
    }

}
