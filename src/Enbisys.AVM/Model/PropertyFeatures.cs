/* 
 * AVM
 *
 * This is api for AVM (automated valuation machine)
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@enbisys.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Enbisys.AVM.Client.OpenAPIDateConverter;

namespace Enbisys.AVM.Model
{
    /// <summary>
    /// PropertyFeatures
    /// </summary>
    [DataContract]
    public partial class PropertyFeatures :  IEquatable<PropertyFeatures>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyFeatures" /> class.
        /// </summary>
        [JsonConstructor]
        protected PropertyFeatures() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyFeatures" /> class.
        /// </summary>
        /// <param name="requiredFeatures">requiredFeatures (required).</param>
        /// <param name="additionalFeatures">additionalFeatures.</param>
        public PropertyFeatures(RequiredFeatures requiredFeatures = default(RequiredFeatures), AdditionalFeatures additionalFeatures = default(AdditionalFeatures))
        {
            // to ensure "requiredFeatures" is required (not null)
            if (requiredFeatures == null)
            {
                throw new InvalidDataException("requiredFeatures is a required property for PropertyFeatures and cannot be null");
            }
            else
            {
                this.RequiredFeatures = requiredFeatures;
            }
            
            this.AdditionalFeatures = additionalFeatures;
        }
        
        /// <summary>
        /// Gets or Sets RequiredFeatures
        /// </summary>
        [DataMember(Name="requiredFeatures", EmitDefaultValue=false)]
        public RequiredFeatures RequiredFeatures { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalFeatures
        /// </summary>
        [DataMember(Name="additionalFeatures", EmitDefaultValue=false)]
        public AdditionalFeatures AdditionalFeatures { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertyFeatures {\n");
            sb.Append("  RequiredFeatures: ").Append(RequiredFeatures).Append("\n");
            sb.Append("  AdditionalFeatures: ").Append(AdditionalFeatures).Append("\n");
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
            return this.Equals(input as PropertyFeatures);
        }

        /// <summary>
        /// Returns true if PropertyFeatures instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertyFeatures to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyFeatures input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequiredFeatures == input.RequiredFeatures ||
                    (this.RequiredFeatures != null &&
                    this.RequiredFeatures.Equals(input.RequiredFeatures))
                ) && 
                (
                    this.AdditionalFeatures == input.AdditionalFeatures ||
                    (this.AdditionalFeatures != null &&
                    this.AdditionalFeatures.Equals(input.AdditionalFeatures))
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
                if (this.RequiredFeatures != null)
                    hashCode = hashCode * 59 + this.RequiredFeatures.GetHashCode();
                if (this.AdditionalFeatures != null)
                    hashCode = hashCode * 59 + this.AdditionalFeatures.GetHashCode();
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