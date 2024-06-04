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
    /// ModelsMobileFeedback
    /// </summary>
    [DataContract]
    public partial class ModelsMobileFeedback :  IEquatable<ModelsMobileFeedback>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsMobileFeedback" /> class.
        /// </summary>
        /// <param name="attachment">attachment.</param>
        /// <param name="attachmentName">attachmentName.</param>
        /// <param name="data">data.</param>
        /// <param name="email">email.</param>
        /// <param name="intercomEnabled">intercomEnabled.</param>
        /// <param name="message">message.</param>
        /// <param name="userID">userID.</param>
        public ModelsMobileFeedback(List<int?> attachment = default(List<int?>), string attachmentName = default(string), List<ModelsMobileFeedbackData> data = default(List<ModelsMobileFeedbackData>), string email = default(string), bool? intercomEnabled = default(bool?), string message = default(string), int? userID = default(int?))
        {
            this.Attachment = attachment;
            this.AttachmentName = attachmentName;
            this.Data = data;
            this.Email = email;
            this.IntercomEnabled = intercomEnabled;
            this.Message = message;
            this.UserID = userID;
        }
        
        /// <summary>
        /// Gets or Sets Attachment
        /// </summary>
        [DataMember(Name="attachment", EmitDefaultValue=false)]
        public List<int?> Attachment { get; set; }

        /// <summary>
        /// Gets or Sets AttachmentName
        /// </summary>
        [DataMember(Name="attachment_name", EmitDefaultValue=false)]
        public string AttachmentName { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<ModelsMobileFeedbackData> Data { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets IntercomEnabled
        /// </summary>
        [DataMember(Name="intercomEnabled", EmitDefaultValue=false)]
        public bool? IntercomEnabled { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets UserID
        /// </summary>
        [DataMember(Name="userID", EmitDefaultValue=false)]
        public int? UserID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelsMobileFeedback {\n");
            sb.Append("  Attachment: ").Append(Attachment).Append("\n");
            sb.Append("  AttachmentName: ").Append(AttachmentName).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  IntercomEnabled: ").Append(IntercomEnabled).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  UserID: ").Append(UserID).Append("\n");
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
            return this.Equals(input as ModelsMobileFeedback);
        }

        /// <summary>
        /// Returns true if ModelsMobileFeedback instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelsMobileFeedback to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelsMobileFeedback input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Attachment == input.Attachment ||
                    this.Attachment != null &&
                    this.Attachment.SequenceEqual(input.Attachment)
                ) && 
                (
                    this.AttachmentName == input.AttachmentName ||
                    (this.AttachmentName != null &&
                    this.AttachmentName.Equals(input.AttachmentName))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.IntercomEnabled == input.IntercomEnabled ||
                    (this.IntercomEnabled != null &&
                    this.IntercomEnabled.Equals(input.IntercomEnabled))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.UserID == input.UserID ||
                    (this.UserID != null &&
                    this.UserID.Equals(input.UserID))
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
                if (this.Attachment != null)
                    hashCode = hashCode * 59 + this.Attachment.GetHashCode();
                if (this.AttachmentName != null)
                    hashCode = hashCode * 59 + this.AttachmentName.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.IntercomEnabled != null)
                    hashCode = hashCode * 59 + this.IntercomEnabled.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.UserID != null)
                    hashCode = hashCode * 59 + this.UserID.GetHashCode();
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
