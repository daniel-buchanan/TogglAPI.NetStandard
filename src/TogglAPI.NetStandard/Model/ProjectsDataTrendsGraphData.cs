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
    /// ProjectsDataTrendsGraphData
    /// </summary>
    [DataContract]
    public partial class ProjectsDataTrendsGraphData :  IEquatable<ProjectsDataTrendsGraphData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsDataTrendsGraphData" /> class.
        /// </summary>
        /// <param name="date">date.</param>
        /// <param name="projects">projects.</param>
        public ProjectsDataTrendsGraphData(string date = default(string), List<ProjectsDataTrendsProject> projects = default(List<ProjectsDataTrendsProject>))
        {
            this.Date = date;
            this.Projects = projects;
        }
        
        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }

        /// <summary>
        /// Gets or Sets Projects
        /// </summary>
        [DataMember(Name="projects", EmitDefaultValue=false)]
        public List<ProjectsDataTrendsProject> Projects { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectsDataTrendsGraphData {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Projects: ").Append(Projects).Append("\n");
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
            return this.Equals(input as ProjectsDataTrendsGraphData);
        }

        /// <summary>
        /// Returns true if ProjectsDataTrendsGraphData instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectsDataTrendsGraphData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectsDataTrendsGraphData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Projects == input.Projects ||
                    this.Projects != null &&
                    this.Projects.SequenceEqual(input.Projects)
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Projects != null)
                    hashCode = hashCode * 59 + this.Projects.GetHashCode();
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
