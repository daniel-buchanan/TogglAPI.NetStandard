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
    /// DtoCreationRequest
    /// </summary>
    [DataContract]
    public partial class DtoCreationRequest :  IEquatable<DtoCreationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoCreationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DtoCreationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoCreationRequest" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="name">name (required).</param>
        /// <param name="organizationId">organizationId (required).</param>
        /// <param name="pinned">pinned.</param>
        /// <param name="preferences">preferences.</param>
        /// <param name="query">query (required).</param>
        /// <param name="source">source.</param>
        /// <param name="type">type (required).</param>
        public DtoCreationRequest(string description = default(string), string name = default(string), long? organizationId = default(long?), bool? pinned = default(bool?), Dictionary<string, object> preferences = default(Dictionary<string, object>), DtoQueryRequest query = default(DtoQueryRequest), string source = default(string), string type = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for DtoCreationRequest and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "organizationId" is required (not null)
            if (organizationId == null)
            {
                throw new InvalidDataException("organizationId is a required property for DtoCreationRequest and cannot be null");
            }
            else
            {
                this.OrganizationId = organizationId;
            }
            // to ensure "query" is required (not null)
            if (query == null)
            {
                throw new InvalidDataException("query is a required property for DtoCreationRequest and cannot be null");
            }
            else
            {
                this.Query = query;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for DtoCreationRequest and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.Description = description;
            this.Pinned = pinned;
            this.Preferences = preferences;
            this.Source = source;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organization_id", EmitDefaultValue=false)]
        public long? OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets Pinned
        /// </summary>
        [DataMember(Name="pinned", EmitDefaultValue=false)]
        public bool? Pinned { get; set; }

        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name="preferences", EmitDefaultValue=false)]
        public Dictionary<string, object> Preferences { get; set; }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public DtoQueryRequest Query { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DtoCreationRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  Pinned: ").Append(Pinned).Append("\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as DtoCreationRequest);
        }

        /// <summary>
        /// Returns true if DtoCreationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DtoCreationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DtoCreationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.Pinned == input.Pinned ||
                    (this.Pinned != null &&
                    this.Pinned.Equals(input.Pinned))
                ) && 
                (
                    this.Preferences == input.Preferences ||
                    this.Preferences != null &&
                    this.Preferences.SequenceEqual(input.Preferences)
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.Pinned != null)
                    hashCode = hashCode * 59 + this.Pinned.GetHashCode();
                if (this.Preferences != null)
                    hashCode = hashCode * 59 + this.Preferences.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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