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
    /// ModelsKeyboardShortcut
    /// </summary>
    [DataContract]
    public partial class ModelsKeyboardShortcut :  IEquatable<ModelsKeyboardShortcut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsKeyboardShortcut" /> class.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="modifiers">modifiers.</param>
        public ModelsKeyboardShortcut(long? key = default(long?), long? modifiers = default(long?))
        {
            this.Key = key;
            this.Modifiers = modifiers;
        }
        
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public long? Key { get; set; }

        /// <summary>
        /// Gets or Sets Modifiers
        /// </summary>
        [DataMember(Name="modifiers", EmitDefaultValue=false)]
        public long? Modifiers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelsKeyboardShortcut {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Modifiers: ").Append(Modifiers).Append("\n");
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
            return this.Equals(input as ModelsKeyboardShortcut);
        }

        /// <summary>
        /// Returns true if ModelsKeyboardShortcut instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelsKeyboardShortcut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelsKeyboardShortcut input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Modifiers == input.Modifiers ||
                    (this.Modifiers != null &&
                    this.Modifiers.Equals(input.Modifiers))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Modifiers != null)
                    hashCode = hashCode * 59 + this.Modifiers.GetHashCode();
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
