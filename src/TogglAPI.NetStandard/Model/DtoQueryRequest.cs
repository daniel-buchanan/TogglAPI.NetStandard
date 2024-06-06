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
    /// DtoQueryRequest
    /// </summary>
    [DataContract]
    public partial class DtoQueryRequest :  IEquatable<DtoQueryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoQueryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DtoQueryRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoQueryRequest" /> class.
        /// </summary>
        /// <param name="aggregationFilters">aggregationFilters.</param>
        /// <param name="aggregations">aggregations.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="filters">filters.</param>
        /// <param name="groupings">groupings.</param>
        /// <param name="limit">limit.</param>
        /// <param name="ordinations">ordinations.</param>
        /// <param name="period">period (required).</param>
        /// <param name="preferences">preferences.</param>
        /// <param name="transformations">transformations.</param>
        /// <param name="v3QueryParams">v3QueryParams.</param>
        public DtoQueryRequest(List<DtoAggFilterRequest> aggregationFilters = default(List<DtoAggFilterRequest>), List<DtoAggregationRequest> aggregations = default(List<DtoAggregationRequest>), List<DtoAttributeRequest> attributes = default(List<DtoAttributeRequest>), List<DtoFilterRequest> filters = default(List<DtoFilterRequest>), List<DtoGroupingRequest> groupings = default(List<DtoGroupingRequest>), long? limit = default(long?), List<DtoOrdinationRequest> ordinations = default(List<DtoOrdinationRequest>), DtoPeriodRequest period = default(DtoPeriodRequest), Dictionary<string, object> preferences = default(Dictionary<string, object>), List<DtoTransformationRequest> transformations = default(List<DtoTransformationRequest>), string v3QueryParams = default(string))
        {
            // to ensure "period" is required (not null)
            if (period == null)
            {
                throw new InvalidDataException("period is a required property for DtoQueryRequest and cannot be null");
            }
            else
            {
                this.Period = period;
            }
            this.AggregationFilters = aggregationFilters;
            this.Aggregations = aggregations;
            this.Attributes = attributes;
            this.Filters = filters;
            this.Groupings = groupings;
            this.Limit = limit;
            this.Ordinations = ordinations;
            this.Preferences = preferences;
            this.Transformations = transformations;
            this.V3QueryParams = v3QueryParams;
        }
        
        /// <summary>
        /// Gets or Sets AggregationFilters
        /// </summary>
        [DataMember(Name="aggregation_filters", EmitDefaultValue=false)]
        public List<DtoAggFilterRequest> AggregationFilters { get; set; }

        /// <summary>
        /// Gets or Sets Aggregations
        /// </summary>
        [DataMember(Name="aggregations", EmitDefaultValue=false)]
        public List<DtoAggregationRequest> Aggregations { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public List<DtoAttributeRequest> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets Filters
        /// </summary>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<DtoFilterRequest> Filters { get; set; }

        /// <summary>
        /// Gets or Sets Groupings
        /// </summary>
        [DataMember(Name="groupings", EmitDefaultValue=false)]
        public List<DtoGroupingRequest> Groupings { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// Gets or Sets Ordinations
        /// </summary>
        [DataMember(Name="ordinations", EmitDefaultValue=false)]
        public List<DtoOrdinationRequest> Ordinations { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public DtoPeriodRequest Period { get; set; }

        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name="preferences", EmitDefaultValue=false)]
        public Dictionary<string, object> Preferences { get; set; }

        /// <summary>
        /// Gets or Sets Transformations
        /// </summary>
        [DataMember(Name="transformations", EmitDefaultValue=false)]
        public List<DtoTransformationRequest> Transformations { get; set; }

        /// <summary>
        /// Gets or Sets V3QueryParams
        /// </summary>
        [DataMember(Name="v3_query_params", EmitDefaultValue=false)]
        public string V3QueryParams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DtoQueryRequest {\n");
            sb.Append("  AggregationFilters: ").Append(AggregationFilters).Append("\n");
            sb.Append("  Aggregations: ").Append(Aggregations).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Groupings: ").Append(Groupings).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Ordinations: ").Append(Ordinations).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  Transformations: ").Append(Transformations).Append("\n");
            sb.Append("  V3QueryParams: ").Append(V3QueryParams).Append("\n");
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
            return this.Equals(input as DtoQueryRequest);
        }

        /// <summary>
        /// Returns true if DtoQueryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DtoQueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DtoQueryRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AggregationFilters == input.AggregationFilters ||
                    this.AggregationFilters != null &&
                    this.AggregationFilters.SequenceEqual(input.AggregationFilters)
                ) && 
                (
                    this.Aggregations == input.Aggregations ||
                    this.Aggregations != null &&
                    this.Aggregations.SequenceEqual(input.Aggregations)
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.Filters == input.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(input.Filters)
                ) && 
                (
                    this.Groupings == input.Groupings ||
                    this.Groupings != null &&
                    this.Groupings.SequenceEqual(input.Groupings)
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Ordinations == input.Ordinations ||
                    this.Ordinations != null &&
                    this.Ordinations.SequenceEqual(input.Ordinations)
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.Preferences == input.Preferences ||
                    this.Preferences != null &&
                    this.Preferences.SequenceEqual(input.Preferences)
                ) && 
                (
                    this.Transformations == input.Transformations ||
                    this.Transformations != null &&
                    this.Transformations.SequenceEqual(input.Transformations)
                ) && 
                (
                    this.V3QueryParams == input.V3QueryParams ||
                    (this.V3QueryParams != null &&
                    this.V3QueryParams.Equals(input.V3QueryParams))
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
                if (this.AggregationFilters != null)
                    hashCode = hashCode * 59 + this.AggregationFilters.GetHashCode();
                if (this.Aggregations != null)
                    hashCode = hashCode * 59 + this.Aggregations.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.Filters != null)
                    hashCode = hashCode * 59 + this.Filters.GetHashCode();
                if (this.Groupings != null)
                    hashCode = hashCode * 59 + this.Groupings.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Ordinations != null)
                    hashCode = hashCode * 59 + this.Ordinations.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.Preferences != null)
                    hashCode = hashCode * 59 + this.Preferences.GetHashCode();
                if (this.Transformations != null)
                    hashCode = hashCode * 59 + this.Transformations.GetHashCode();
                if (this.V3QueryParams != null)
                    hashCode = hashCode * 59 + this.V3QueryParams.GetHashCode();
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