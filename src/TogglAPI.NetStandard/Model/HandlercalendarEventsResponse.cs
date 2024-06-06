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
    /// HandlercalendarEventsResponse
    /// </summary>
    [DataContract]
    public partial class HandlercalendarEventsResponse :  IEquatable<HandlercalendarEventsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HandlercalendarEventsResponse" /> class.
        /// </summary>
        /// <param name="events">events.</param>
        /// <param name="nextPageToken">nextPageToken.</param>
        public HandlercalendarEventsResponse(List<ModelsEvent> events = default(List<ModelsEvent>), string nextPageToken = default(string))
        {
            this.Events = events;
            this.NextPageToken = nextPageToken;
        }
        
        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<ModelsEvent> Events { get; set; }

        /// <summary>
        /// Gets or Sets NextPageToken
        /// </summary>
        [DataMember(Name="next_page_token", EmitDefaultValue=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HandlercalendarEventsResponse {\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  NextPageToken: ").Append(NextPageToken).Append("\n");
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
            return this.Equals(input as HandlercalendarEventsResponse);
        }

        /// <summary>
        /// Returns true if HandlercalendarEventsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of HandlercalendarEventsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HandlercalendarEventsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.NextPageToken == input.NextPageToken ||
                    (this.NextPageToken != null &&
                    this.NextPageToken.Equals(input.NextPageToken))
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
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.NextPageToken != null)
                    hashCode = hashCode * 59 + this.NextPageToken.GetHashCode();
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