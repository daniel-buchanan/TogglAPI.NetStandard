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
    /// ModelsClient
    /// </summary>
    [DataContract]
    public partial class ModelsClient :  IEquatable<ModelsClient>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsClient" /> class.
        /// </summary>
        /// <param name="archived">IsArchived is true if the client is archived.</param>
        /// <param name="at">When was the last update.</param>
        /// <param name="creatorId">CreatorID is the ID of the user who created the client.</param>
        /// <param name="id">Client ID.</param>
        /// <param name="name">Name of the client.</param>
        /// <param name="notes">notes.</param>
        /// <param name="permissions">List of authorization permissions for this client..</param>
        /// <param name="serverDeletedAt">When was deleted, null if not deleted.</param>
        /// <param name="wid">Workspace ID.</param>
        public ModelsClient(bool? archived = default(bool?), string at = default(string), int? creatorId = default(int?), int? id = default(int?), string name = default(string), string notes = default(string), string permissions = default(string), string serverDeletedAt = default(string), int? wid = default(int?))
        {
            this.Archived = archived;
            this.At = at;
            this.CreatorId = creatorId;
            this.Id = id;
            this.Name = name;
            this.Notes = notes;
            this.Permissions = permissions;
            this.ServerDeletedAt = serverDeletedAt;
            this.Wid = wid;
        }
        
        /// <summary>
        /// IsArchived is true if the client is archived
        /// </summary>
        /// <value>IsArchived is true if the client is archived</value>
        [DataMember(Name="archived", EmitDefaultValue=false)]
        public bool? Archived { get; set; }

        /// <summary>
        /// When was the last update
        /// </summary>
        /// <value>When was the last update</value>
        [DataMember(Name="at", EmitDefaultValue=false)]
        public string At { get; set; }

        /// <summary>
        /// CreatorID is the ID of the user who created the client
        /// </summary>
        /// <value>CreatorID is the ID of the user who created the client</value>
        [DataMember(Name="creator_id", EmitDefaultValue=false)]
        public int? CreatorId { get; set; }

        /// <summary>
        /// Client ID
        /// </summary>
        /// <value>Client ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Name of the client
        /// </summary>
        /// <value>Name of the client</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// List of authorization permissions for this client.
        /// </summary>
        /// <value>List of authorization permissions for this client.</value>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public string Permissions { get; set; }

        /// <summary>
        /// When was deleted, null if not deleted
        /// </summary>
        /// <value>When was deleted, null if not deleted</value>
        [DataMember(Name="server_deleted_at", EmitDefaultValue=false)]
        public string ServerDeletedAt { get; set; }

        /// <summary>
        /// Workspace ID
        /// </summary>
        /// <value>Workspace ID</value>
        [DataMember(Name="wid", EmitDefaultValue=false)]
        public int? Wid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelsClient {\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  At: ").Append(At).Append("\n");
            sb.Append("  CreatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  ServerDeletedAt: ").Append(ServerDeletedAt).Append("\n");
            sb.Append("  Wid: ").Append(Wid).Append("\n");
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
            return this.Equals(input as ModelsClient);
        }

        /// <summary>
        /// Returns true if ModelsClient instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelsClient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelsClient input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Archived == input.Archived ||
                    (this.Archived != null &&
                    this.Archived.Equals(input.Archived))
                ) && 
                (
                    this.At == input.At ||
                    (this.At != null &&
                    this.At.Equals(input.At))
                ) && 
                (
                    this.CreatorId == input.CreatorId ||
                    (this.CreatorId != null &&
                    this.CreatorId.Equals(input.CreatorId))
                ) && 
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
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
                ) && 
                (
                    this.ServerDeletedAt == input.ServerDeletedAt ||
                    (this.ServerDeletedAt != null &&
                    this.ServerDeletedAt.Equals(input.ServerDeletedAt))
                ) && 
                (
                    this.Wid == input.Wid ||
                    (this.Wid != null &&
                    this.Wid.Equals(input.Wid))
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
                if (this.Archived != null)
                    hashCode = hashCode * 59 + this.Archived.GetHashCode();
                if (this.At != null)
                    hashCode = hashCode * 59 + this.At.GetHashCode();
                if (this.CreatorId != null)
                    hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.ServerDeletedAt != null)
                    hashCode = hashCode * 59 + this.ServerDeletedAt.GetHashCode();
                if (this.Wid != null)
                    hashCode = hashCode * 59 + this.Wid.GetHashCode();
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
