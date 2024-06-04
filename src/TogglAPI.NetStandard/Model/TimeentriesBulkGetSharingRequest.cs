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
    /// TimeentriesBulkGetSharingRequest
    /// </summary>
    [DataContract]
    public partial class TimeentriesBulkGetSharingRequest :  IEquatable<TimeentriesBulkGetSharingRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeentriesBulkGetSharingRequest" /> class.
        /// </summary>
        /// <param name="timeEntryId">timeEntryId.</param>
        /// <param name="workspaceId">workspaceId.</param>
        public TimeentriesBulkGetSharingRequest(int? timeEntryId = default(int?), int? workspaceId = default(int?))
        {
            this.TimeEntryId = timeEntryId;
            this.WorkspaceId = workspaceId;
        }
        
        /// <summary>
        /// Gets or Sets TimeEntryId
        /// </summary>
        [DataMember(Name="time_entry_id", EmitDefaultValue=false)]
        public int? TimeEntryId { get; set; }

        /// <summary>
        /// Gets or Sets WorkspaceId
        /// </summary>
        [DataMember(Name="workspace_id", EmitDefaultValue=false)]
        public int? WorkspaceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeentriesBulkGetSharingRequest {\n");
            sb.Append("  TimeEntryId: ").Append(TimeEntryId).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
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
            return this.Equals(input as TimeentriesBulkGetSharingRequest);
        }

        /// <summary>
        /// Returns true if TimeentriesBulkGetSharingRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeentriesBulkGetSharingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeentriesBulkGetSharingRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimeEntryId == input.TimeEntryId ||
                    (this.TimeEntryId != null &&
                    this.TimeEntryId.Equals(input.TimeEntryId))
                ) && 
                (
                    this.WorkspaceId == input.WorkspaceId ||
                    (this.WorkspaceId != null &&
                    this.WorkspaceId.Equals(input.WorkspaceId))
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
                if (this.TimeEntryId != null)
                    hashCode = hashCode * 59 + this.TimeEntryId.GetHashCode();
                if (this.WorkspaceId != null)
                    hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
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
