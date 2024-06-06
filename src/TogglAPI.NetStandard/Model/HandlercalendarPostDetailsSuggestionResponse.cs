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
    /// HandlercalendarPostDetailsSuggestionResponse
    /// </summary>
    [DataContract]
    public partial class HandlercalendarPostDetailsSuggestionResponse :  IEquatable<HandlercalendarPostDetailsSuggestionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HandlercalendarPostDetailsSuggestionResponse" /> class.
        /// </summary>
        /// <param name="suggestions">suggestions.</param>
        public HandlercalendarPostDetailsSuggestionResponse(List<HandlercalendarPostDetailsSuggestionResponseItem> suggestions = default(List<HandlercalendarPostDetailsSuggestionResponseItem>))
        {
            this.Suggestions = suggestions;
        }
        
        /// <summary>
        /// Gets or Sets Suggestions
        /// </summary>
        [DataMember(Name="suggestions", EmitDefaultValue=false)]
        public List<HandlercalendarPostDetailsSuggestionResponseItem> Suggestions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HandlercalendarPostDetailsSuggestionResponse {\n");
            sb.Append("  Suggestions: ").Append(Suggestions).Append("\n");
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
            return this.Equals(input as HandlercalendarPostDetailsSuggestionResponse);
        }

        /// <summary>
        /// Returns true if HandlercalendarPostDetailsSuggestionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of HandlercalendarPostDetailsSuggestionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HandlercalendarPostDetailsSuggestionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Suggestions == input.Suggestions ||
                    this.Suggestions != null &&
                    this.Suggestions.SequenceEqual(input.Suggestions)
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
                if (this.Suggestions != null)
                    hashCode = hashCode * 59 + this.Suggestions.GetHashCode();
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