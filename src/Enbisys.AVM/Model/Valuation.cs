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
    /// Valuation
    /// </summary>
    [DataContract]
    public partial class Valuation :  IEquatable<Valuation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Valuation" /> class.
        /// </summary>
        /// <param name="mostProbablePrice">Predicted price, pound.</param>
        /// <param name="priceRangeFrom">Lower price boundary, pound.</param>
        /// <param name="priceRangeTo">Higher price boundary, pound.</param>
        /// <param name="confidence">Probability (in percents) that actual price is within the specified boundaries.</param>
        /// <param name="priceDistribution">Describes the probabilities (in percents) that actual price is within particular subranges.</param>
        public Valuation(int? mostProbablePrice = default(int?), int? priceRangeFrom = default(int?), int? priceRangeTo = default(int?), int? confidence = default(int?), List<ValuationPriceDistribution> priceDistribution = default(List<ValuationPriceDistribution>))
        {
            this.MostProbablePrice = mostProbablePrice;
            this.PriceRangeFrom = priceRangeFrom;
            this.PriceRangeTo = priceRangeTo;
            this.Confidence = confidence;
            this.PriceDistribution = priceDistribution;
        }
        
        /// <summary>
        /// Predicted price, pound
        /// </summary>
        /// <value>Predicted price, pound</value>
        [DataMember(Name="mostProbablePrice", EmitDefaultValue=false)]
        public int? MostProbablePrice { get; set; }

        /// <summary>
        /// Lower price boundary, pound
        /// </summary>
        /// <value>Lower price boundary, pound</value>
        [DataMember(Name="priceRangeFrom", EmitDefaultValue=false)]
        public int? PriceRangeFrom { get; set; }

        /// <summary>
        /// Higher price boundary, pound
        /// </summary>
        /// <value>Higher price boundary, pound</value>
        [DataMember(Name="priceRangeTo", EmitDefaultValue=false)]
        public int? PriceRangeTo { get; set; }

        /// <summary>
        /// Probability (in percents) that actual price is within the specified boundaries
        /// </summary>
        /// <value>Probability (in percents) that actual price is within the specified boundaries</value>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public int? Confidence { get; set; }

        /// <summary>
        /// Describes the probabilities (in percents) that actual price is within particular subranges
        /// </summary>
        /// <value>Describes the probabilities (in percents) that actual price is within particular subranges</value>
        [DataMember(Name="priceDistribution", EmitDefaultValue=false)]
        public List<ValuationPriceDistribution> PriceDistribution { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Valuation {\n");
            sb.Append("  MostProbablePrice: ").Append(MostProbablePrice).Append("\n");
            sb.Append("  PriceRangeFrom: ").Append(PriceRangeFrom).Append("\n");
            sb.Append("  PriceRangeTo: ").Append(PriceRangeTo).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  PriceDistribution: ").Append(PriceDistribution).Append("\n");
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
            return this.Equals(input as Valuation);
        }

        /// <summary>
        /// Returns true if Valuation instances are equal
        /// </summary>
        /// <param name="input">Instance of Valuation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Valuation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MostProbablePrice == input.MostProbablePrice ||
                    (this.MostProbablePrice != null &&
                    this.MostProbablePrice.Equals(input.MostProbablePrice))
                ) && 
                (
                    this.PriceRangeFrom == input.PriceRangeFrom ||
                    (this.PriceRangeFrom != null &&
                    this.PriceRangeFrom.Equals(input.PriceRangeFrom))
                ) && 
                (
                    this.PriceRangeTo == input.PriceRangeTo ||
                    (this.PriceRangeTo != null &&
                    this.PriceRangeTo.Equals(input.PriceRangeTo))
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                ) && 
                (
                    this.PriceDistribution == input.PriceDistribution ||
                    this.PriceDistribution != null &&
                    input.PriceDistribution != null &&
                    this.PriceDistribution.SequenceEqual(input.PriceDistribution)
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
                if (this.MostProbablePrice != null)
                    hashCode = hashCode * 59 + this.MostProbablePrice.GetHashCode();
                if (this.PriceRangeFrom != null)
                    hashCode = hashCode * 59 + this.PriceRangeFrom.GetHashCode();
                if (this.PriceRangeTo != null)
                    hashCode = hashCode * 59 + this.PriceRangeTo.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.PriceDistribution != null)
                    hashCode = hashCode * 59 + this.PriceDistribution.GetHashCode();
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
