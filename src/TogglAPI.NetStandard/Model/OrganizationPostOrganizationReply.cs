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
    /// OrganizationPostOrganizationReply
    /// </summary>
    [DataContract]
    public partial class OrganizationPostOrganizationReply :  IEquatable<OrganizationPostOrganizationReply>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationPostOrganizationReply" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="workspaceId">workspaceId.</param>
        /// <param name="workspaceName">workspaceName.</param>
        public OrganizationPostOrganizationReply(long? id = default(long?), string name = default(string), string permissions = default(string), long? workspaceId = default(long?), string workspaceName = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Permissions = permissions;
            this.WorkspaceId = workspaceId;
            this.WorkspaceName = workspaceName;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public string Permissions { get; set; }

        /// <summary>
        /// Gets or Sets WorkspaceId
        /// </summary>
        [DataMember(Name="workspace_id", EmitDefaultValue=false)]
        public long? WorkspaceId { get; set; }

        /// <summary>
        /// Gets or Sets WorkspaceName
        /// </summary>
        [DataMember(Name="workspace_name", EmitDefaultValue=false)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationPostOrganizationReply {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  WorkspaceName: ").Append(WorkspaceName).Append("\n");
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
            return this.Equals(input as OrganizationPostOrganizationReply);
        }

        /// <summary>
        /// Returns true if OrganizationPostOrganizationReply instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationPostOrganizationReply to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationPostOrganizationReply input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
                ) && 
                (
                    this.WorkspaceId == input.WorkspaceId ||
                    (this.WorkspaceId != null &&
                    this.WorkspaceId.Equals(input.WorkspaceId))
                ) && 
                (
                    this.WorkspaceName == input.WorkspaceName ||
                    (this.WorkspaceName != null &&
                    this.WorkspaceName.Equals(input.WorkspaceName))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.WorkspaceId != null)
                    hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.WorkspaceName != null)
                    hashCode = hashCode * 59 + this.WorkspaceName.GetHashCode();
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
