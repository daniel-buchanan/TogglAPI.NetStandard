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
    /// SummaryAudit
    /// </summary>
    [DataContract]
    public partial class SummaryAudit :  IEquatable<SummaryAudit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryAudit" /> class.
        /// </summary>
        /// <param name="groupFilter">groupFilter.</param>
        /// <param name="showEmptyGroups">Whether empty groups should be displayed, default false, premium feature..</param>
        /// <param name="showTrackedGroups">Whether tacked groups should be displayed, default true, premium feature..</param>
        public SummaryAudit(SummaryAuditGroupFilter groupFilter = default(SummaryAuditGroupFilter), bool? showEmptyGroups = default(bool?), bool? showTrackedGroups = default(bool?))
        {
            this.GroupFilter = groupFilter;
            this.ShowEmptyGroups = showEmptyGroups;
            this.ShowTrackedGroups = showTrackedGroups;
        }
        
        /// <summary>
        /// Gets or Sets GroupFilter
        /// </summary>
        [DataMember(Name="group_filter", EmitDefaultValue=false)]
        public SummaryAuditGroupFilter GroupFilter { get; set; }

        /// <summary>
        /// Whether empty groups should be displayed, default false, premium feature.
        /// </summary>
        /// <value>Whether empty groups should be displayed, default false, premium feature.</value>
        [DataMember(Name="show_empty_groups", EmitDefaultValue=false)]
        public bool? ShowEmptyGroups { get; set; }

        /// <summary>
        /// Whether tacked groups should be displayed, default true, premium feature.
        /// </summary>
        /// <value>Whether tacked groups should be displayed, default true, premium feature.</value>
        [DataMember(Name="show_tracked_groups", EmitDefaultValue=false)]
        public bool? ShowTrackedGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SummaryAudit {\n");
            sb.Append("  GroupFilter: ").Append(GroupFilter).Append("\n");
            sb.Append("  ShowEmptyGroups: ").Append(ShowEmptyGroups).Append("\n");
            sb.Append("  ShowTrackedGroups: ").Append(ShowTrackedGroups).Append("\n");
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
            return this.Equals(input as SummaryAudit);
        }

        /// <summary>
        /// Returns true if SummaryAudit instances are equal
        /// </summary>
        /// <param name="input">Instance of SummaryAudit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SummaryAudit input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupFilter == input.GroupFilter ||
                    (this.GroupFilter != null &&
                    this.GroupFilter.Equals(input.GroupFilter))
                ) && 
                (
                    this.ShowEmptyGroups == input.ShowEmptyGroups ||
                    (this.ShowEmptyGroups != null &&
                    this.ShowEmptyGroups.Equals(input.ShowEmptyGroups))
                ) && 
                (
                    this.ShowTrackedGroups == input.ShowTrackedGroups ||
                    (this.ShowTrackedGroups != null &&
                    this.ShowTrackedGroups.Equals(input.ShowTrackedGroups))
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
                if (this.GroupFilter != null)
                    hashCode = hashCode * 59 + this.GroupFilter.GetHashCode();
                if (this.ShowEmptyGroups != null)
                    hashCode = hashCode * 59 + this.ShowEmptyGroups.GetHashCode();
                if (this.ShowTrackedGroups != null)
                    hashCode = hashCode * 59 + this.ShowTrackedGroups.GetHashCode();
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
