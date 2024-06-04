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
    /// ModelsStatistics
    /// </summary>
    [DataContract]
    public partial class ModelsStatistics :  IEquatable<ModelsStatistics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsStatistics" /> class.
        /// </summary>
        /// <param name="admins">admins.</param>
        /// <param name="groupsCount">groupsCount.</param>
        /// <param name="membersCount">membersCount.</param>
        public ModelsStatistics(List<ModelsUserData> admins = default(List<ModelsUserData>), int? groupsCount = default(int?), int? membersCount = default(int?))
        {
            this.Admins = admins;
            this.GroupsCount = groupsCount;
            this.MembersCount = membersCount;
        }
        
        /// <summary>
        /// Gets or Sets Admins
        /// </summary>
        [DataMember(Name="admins", EmitDefaultValue=false)]
        public List<ModelsUserData> Admins { get; set; }

        /// <summary>
        /// Gets or Sets GroupsCount
        /// </summary>
        [DataMember(Name="groups_count", EmitDefaultValue=false)]
        public int? GroupsCount { get; set; }

        /// <summary>
        /// Gets or Sets MembersCount
        /// </summary>
        [DataMember(Name="members_count", EmitDefaultValue=false)]
        public int? MembersCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelsStatistics {\n");
            sb.Append("  Admins: ").Append(Admins).Append("\n");
            sb.Append("  GroupsCount: ").Append(GroupsCount).Append("\n");
            sb.Append("  MembersCount: ").Append(MembersCount).Append("\n");
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
            return this.Equals(input as ModelsStatistics);
        }

        /// <summary>
        /// Returns true if ModelsStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelsStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelsStatistics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Admins == input.Admins ||
                    this.Admins != null &&
                    this.Admins.SequenceEqual(input.Admins)
                ) && 
                (
                    this.GroupsCount == input.GroupsCount ||
                    (this.GroupsCount != null &&
                    this.GroupsCount.Equals(input.GroupsCount))
                ) && 
                (
                    this.MembersCount == input.MembersCount ||
                    (this.MembersCount != null &&
                    this.MembersCount.Equals(input.MembersCount))
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
                if (this.Admins != null)
                    hashCode = hashCode * 59 + this.Admins.GetHashCode();
                if (this.GroupsCount != null)
                    hashCode = hashCode * 59 + this.GroupsCount.GetHashCode();
                if (this.MembersCount != null)
                    hashCode = hashCode * 59 + this.MembersCount.GetHashCode();
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
