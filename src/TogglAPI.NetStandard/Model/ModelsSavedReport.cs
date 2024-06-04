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
    /// ModelsSavedReport
    /// </summary>
    [DataContract]
    public partial class ModelsSavedReport :  IEquatable<ModelsSavedReport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsSavedReport" /> class.
        /// </summary>
        /// <param name="deletedAt">deletedAt.</param>
        /// <param name="fixedDaterange">fixedDaterange.</param>
        /// <param name="id">id.</param>
        /// <param name="isNAResource">isNAResource.</param>
        /// <param name="name">name.</param>
        /// <param name="_params">_params.</param>
        /// <param name="_public">_public.</param>
        /// <param name="scheduledEmailGids">scheduledEmailGids.</param>
        /// <param name="scheduledEmailUids">scheduledEmailUids.</param>
        /// <param name="token">token.</param>
        /// <param name="uid">uid.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="updatedBy">updatedBy.</param>
        public ModelsSavedReport(string deletedAt = default(string), bool? fixedDaterange = default(bool?), int? id = default(int?), bool? isNAResource = default(bool?), string name = default(string), string _params = default(string), bool? _public = default(bool?), UtilsInt64Slice scheduledEmailGids = default(UtilsInt64Slice), UtilsInt64Slice scheduledEmailUids = default(UtilsInt64Slice), string token = default(string), int? uid = default(int?), string updatedAt = default(string), int? updatedBy = default(int?))
        {
            this.DeletedAt = deletedAt;
            this.FixedDaterange = fixedDaterange;
            this.Id = id;
            this.IsNAResource = isNAResource;
            this.Name = name;
            this.Params = _params;
            this.Public = _public;
            this.ScheduledEmailGids = scheduledEmailGids;
            this.ScheduledEmailUids = scheduledEmailUids;
            this.Token = token;
            this.Uid = uid;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
        }
        
        /// <summary>
        /// Gets or Sets DeletedAt
        /// </summary>
        [DataMember(Name="deleted_at", EmitDefaultValue=false)]
        public string DeletedAt { get; set; }

        /// <summary>
        /// Gets or Sets FixedDaterange
        /// </summary>
        [DataMember(Name="fixed_daterange", EmitDefaultValue=false)]
        public bool? FixedDaterange { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets IsNAResource
        /// </summary>
        [DataMember(Name="isNAResource", EmitDefaultValue=false)]
        public bool? IsNAResource { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Params
        /// </summary>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public string Params { get; set; }

        /// <summary>
        /// Gets or Sets Public
        /// </summary>
        [DataMember(Name="public", EmitDefaultValue=false)]
        public bool? Public { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledEmailGids
        /// </summary>
        [DataMember(Name="scheduled_email_gids", EmitDefaultValue=false)]
        public UtilsInt64Slice ScheduledEmailGids { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledEmailUids
        /// </summary>
        [DataMember(Name="scheduled_email_uids", EmitDefaultValue=false)]
        public UtilsInt64Slice ScheduledEmailUids { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// Gets or Sets Uid
        /// </summary>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public int? Uid { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedBy
        /// </summary>
        [DataMember(Name="updated_by", EmitDefaultValue=false)]
        public int? UpdatedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelsSavedReport {\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  FixedDaterange: ").Append(FixedDaterange).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsNAResource: ").Append(IsNAResource).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("  ScheduledEmailGids: ").Append(ScheduledEmailGids).Append("\n");
            sb.Append("  ScheduledEmailUids: ").Append(ScheduledEmailUids).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
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
            return this.Equals(input as ModelsSavedReport);
        }

        /// <summary>
        /// Returns true if ModelsSavedReport instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelsSavedReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelsSavedReport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeletedAt == input.DeletedAt ||
                    (this.DeletedAt != null &&
                    this.DeletedAt.Equals(input.DeletedAt))
                ) && 
                (
                    this.FixedDaterange == input.FixedDaterange ||
                    (this.FixedDaterange != null &&
                    this.FixedDaterange.Equals(input.FixedDaterange))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsNAResource == input.IsNAResource ||
                    (this.IsNAResource != null &&
                    this.IsNAResource.Equals(input.IsNAResource))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Params == input.Params ||
                    (this.Params != null &&
                    this.Params.Equals(input.Params))
                ) && 
                (
                    this.Public == input.Public ||
                    (this.Public != null &&
                    this.Public.Equals(input.Public))
                ) && 
                (
                    this.ScheduledEmailGids == input.ScheduledEmailGids ||
                    (this.ScheduledEmailGids != null &&
                    this.ScheduledEmailGids.Equals(input.ScheduledEmailGids))
                ) && 
                (
                    this.ScheduledEmailUids == input.ScheduledEmailUids ||
                    (this.ScheduledEmailUids != null &&
                    this.ScheduledEmailUids.Equals(input.ScheduledEmailUids))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.Uid == input.Uid ||
                    (this.Uid != null &&
                    this.Uid.Equals(input.Uid))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
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
                if (this.DeletedAt != null)
                    hashCode = hashCode * 59 + this.DeletedAt.GetHashCode();
                if (this.FixedDaterange != null)
                    hashCode = hashCode * 59 + this.FixedDaterange.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsNAResource != null)
                    hashCode = hashCode * 59 + this.IsNAResource.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Params != null)
                    hashCode = hashCode * 59 + this.Params.GetHashCode();
                if (this.Public != null)
                    hashCode = hashCode * 59 + this.Public.GetHashCode();
                if (this.ScheduledEmailGids != null)
                    hashCode = hashCode * 59 + this.ScheduledEmailGids.GetHashCode();
                if (this.ScheduledEmailUids != null)
                    hashCode = hashCode * 59 + this.ScheduledEmailUids.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.Uid != null)
                    hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.UpdatedBy != null)
                    hashCode = hashCode * 59 + this.UpdatedBy.GetHashCode();
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
