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
    /// GroupOrganizationGroupResponse
    /// </summary>
    [DataContract]
    public partial class GroupOrganizationGroupResponse :  IEquatable<GroupOrganizationGroupResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupOrganizationGroupResponse" /> class.
        /// </summary>
        /// <param name="at">at.</param>
        /// <param name="groupId">groupId.</param>
        /// <param name="name">name.</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="users">users.</param>
        /// <param name="workspaces">workspaces.</param>
        public GroupOrganizationGroupResponse(string at = default(string), int? groupId = default(int?), string name = default(string), string permissions = default(string), List<ModelsOrganizationUserSimple> users = default(List<ModelsOrganizationUserSimple>), List<int?> workspaces = default(List<int?>))
        {
            this.At = at;
            this.GroupId = groupId;
            this.Name = name;
            this.Permissions = permissions;
            this.Users = users;
            this.Workspaces = workspaces;
        }
        
        /// <summary>
        /// Gets or Sets At
        /// </summary>
        [DataMember(Name="at", EmitDefaultValue=false)]
        public string At { get; set; }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name="group_id", EmitDefaultValue=false)]
        public int? GroupId { get; set; }

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
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<ModelsOrganizationUserSimple> Users { get; set; }

        /// <summary>
        /// Gets or Sets Workspaces
        /// </summary>
        [DataMember(Name="workspaces", EmitDefaultValue=false)]
        public List<int?> Workspaces { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupOrganizationGroupResponse {\n");
            sb.Append("  At: ").Append(At).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Workspaces: ").Append(Workspaces).Append("\n");
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
            return this.Equals(input as GroupOrganizationGroupResponse);
        }

        /// <summary>
        /// Returns true if GroupOrganizationGroupResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupOrganizationGroupResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupOrganizationGroupResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.At == input.At ||
                    (this.At != null &&
                    this.At.Equals(input.At))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
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
                    this.Users == input.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(input.Users)
                ) && 
                (
                    this.Workspaces == input.Workspaces ||
                    this.Workspaces != null &&
                    this.Workspaces.SequenceEqual(input.Workspaces)
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
                if (this.At != null)
                    hashCode = hashCode * 59 + this.At.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.Workspaces != null)
                    hashCode = hashCode * 59 + this.Workspaces.GetHashCode();
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
