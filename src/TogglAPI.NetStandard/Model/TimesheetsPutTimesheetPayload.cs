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
    /// TimesheetsPutTimesheetPayload
    /// </summary>
    [DataContract]
    public partial class TimesheetsPutTimesheetPayload :  IEquatable<TimesheetsPutTimesheetPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimesheetsPutTimesheetPayload" /> class.
        /// </summary>
        /// <param name="rejectionComment">rejectionComment.</param>
        /// <param name="status">status.</param>
        public TimesheetsPutTimesheetPayload(string rejectionComment = default(string), string status = default(string))
        {
            this.RejectionComment = rejectionComment;
            this.Status = status;
        }
        
        /// <summary>
        /// Gets or Sets RejectionComment
        /// </summary>
        [DataMember(Name="rejection_comment", EmitDefaultValue=false)]
        public string RejectionComment { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimesheetsPutTimesheetPayload {\n");
            sb.Append("  RejectionComment: ").Append(RejectionComment).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as TimesheetsPutTimesheetPayload);
        }

        /// <summary>
        /// Returns true if TimesheetsPutTimesheetPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of TimesheetsPutTimesheetPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimesheetsPutTimesheetPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RejectionComment == input.RejectionComment ||
                    (this.RejectionComment != null &&
                    this.RejectionComment.Equals(input.RejectionComment))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.RejectionComment != null)
                    hashCode = hashCode * 59 + this.RejectionComment.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
