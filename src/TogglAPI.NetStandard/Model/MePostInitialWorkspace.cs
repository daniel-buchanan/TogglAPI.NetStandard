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
    /// MePostInitialWorkspace
    /// </summary>
    [DataContract]
    public partial class MePostInitialWorkspace :  IEquatable<MePostInitialWorkspace>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MePostInitialWorkspace" /> class.
        /// </summary>
        /// <param name="initialPricingPlan">Plan ID for the new workspace.</param>
        /// <param name="name">Workspace name, if not provided it will be based on the user&#39;s full name.</param>
        public MePostInitialWorkspace(int? initialPricingPlan = default(int?), string name = default(string))
        {
            this.InitialPricingPlan = initialPricingPlan;
            this.Name = name;
        }
        
        /// <summary>
        /// Plan ID for the new workspace
        /// </summary>
        /// <value>Plan ID for the new workspace</value>
        [DataMember(Name="initial_pricing_plan", EmitDefaultValue=false)]
        public int? InitialPricingPlan { get; set; }

        /// <summary>
        /// Workspace name, if not provided it will be based on the user&#39;s full name
        /// </summary>
        /// <value>Workspace name, if not provided it will be based on the user&#39;s full name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MePostInitialWorkspace {\n");
            sb.Append("  InitialPricingPlan: ").Append(InitialPricingPlan).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as MePostInitialWorkspace);
        }

        /// <summary>
        /// Returns true if MePostInitialWorkspace instances are equal
        /// </summary>
        /// <param name="input">Instance of MePostInitialWorkspace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MePostInitialWorkspace input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InitialPricingPlan == input.InitialPricingPlan ||
                    (this.InitialPricingPlan != null &&
                    this.InitialPricingPlan.Equals(input.InitialPricingPlan))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.InitialPricingPlan != null)
                    hashCode = hashCode * 59 + this.InitialPricingPlan.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
