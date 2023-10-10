/*
 * Semantic Search - Searcher HTTP API
 *
 * The searcher component HTTP API of the semantic search Service.  The service depends on a database backend. If a mere vector store (e.g. [Qdrant](https://qdrant.tech/)), instead of a full fledged search engine (e.g. [Elasticsearch](https://www.elastic.co/)), is configured, some advanced functionalities of the API have no effect. This is noted where appropriate, referring to the former as _simple database_ and the latter as _full database_. 
 *
 * The version of the OpenAPI document: 1.4.0
 * Contact: contact@leftshift.one
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = LSO.SemanticSearch.Client.OpenAPIDateConverter;

namespace LSO.SemanticSearch.Model
{
    /// <summary>
    /// The settings to fine-tune the search behavior.  &gt; **_NOTE:_**  For simple database backends, these settings have no effect at the moment. 
    /// </summary>
    [DataContract(Name = "SearchSettings")]
    public partial class SearchSettings : IEquatable<SearchSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSettings" /> class.
        /// </summary>
        /// <param name="globalSemanticScoreWeight">The multiplicative weight for the semantic part of the score. (default to 1.0M).</param>
        /// <param name="globalFullTextScoreWeight">The multiplicative weight for the full text part of the score. (default to 1.0M).</param>
        /// <param name="fullTextScoreSaturation">The value in x / (value + x), to saturate the unbounded full text part of the score and to squeeze it into the interval [0,1). If the value is 0, no saturation is performed and the score is unbounded. (default to 0M).</param>
        public SearchSettings(decimal globalSemanticScoreWeight = 1.0M, decimal globalFullTextScoreWeight = 1.0M, decimal fullTextScoreSaturation = 0M)
        {
            this.GlobalSemanticScoreWeight = globalSemanticScoreWeight;
            this.GlobalFullTextScoreWeight = globalFullTextScoreWeight;
            this.FullTextScoreSaturation = fullTextScoreSaturation;
        }

        /// <summary>
        /// The multiplicative weight for the semantic part of the score.
        /// </summary>
        /// <value>The multiplicative weight for the semantic part of the score.</value>
        [DataMember(Name = "global_semantic_score_weight", EmitDefaultValue = false)]
        public decimal GlobalSemanticScoreWeight { get; set; }

        /// <summary>
        /// The multiplicative weight for the full text part of the score.
        /// </summary>
        /// <value>The multiplicative weight for the full text part of the score.</value>
        [DataMember(Name = "global_full_text_score_weight", EmitDefaultValue = false)]
        public decimal GlobalFullTextScoreWeight { get; set; }

        /// <summary>
        /// The value in x / (value + x), to saturate the unbounded full text part of the score and to squeeze it into the interval [0,1). If the value is 0, no saturation is performed and the score is unbounded.
        /// </summary>
        /// <value>The value in x / (value + x), to saturate the unbounded full text part of the score and to squeeze it into the interval [0,1). If the value is 0, no saturation is performed and the score is unbounded.</value>
        [DataMember(Name = "full_text_score_saturation", EmitDefaultValue = false)]
        public decimal FullTextScoreSaturation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchSettings {\n");
            sb.Append("  GlobalSemanticScoreWeight: ").Append(GlobalSemanticScoreWeight).Append("\n");
            sb.Append("  GlobalFullTextScoreWeight: ").Append(GlobalFullTextScoreWeight).Append("\n");
            sb.Append("  FullTextScoreSaturation: ").Append(FullTextScoreSaturation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchSettings);
        }

        /// <summary>
        /// Returns true if SearchSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchSettings input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GlobalSemanticScoreWeight == input.GlobalSemanticScoreWeight ||
                    this.GlobalSemanticScoreWeight.Equals(input.GlobalSemanticScoreWeight)
                ) && 
                (
                    this.GlobalFullTextScoreWeight == input.GlobalFullTextScoreWeight ||
                    this.GlobalFullTextScoreWeight.Equals(input.GlobalFullTextScoreWeight)
                ) && 
                (
                    this.FullTextScoreSaturation == input.FullTextScoreSaturation ||
                    this.FullTextScoreSaturation.Equals(input.FullTextScoreSaturation)
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
                hashCode = (hashCode * 59) + this.GlobalSemanticScoreWeight.GetHashCode();
                hashCode = (hashCode * 59) + this.GlobalFullTextScoreWeight.GetHashCode();
                hashCode = (hashCode * 59) + this.FullTextScoreSaturation.GetHashCode();
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
            // GlobalSemanticScoreWeight (decimal) minimum
            if (this.GlobalSemanticScoreWeight < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GlobalSemanticScoreWeight, must be a value greater than or equal to 0.", new [] { "GlobalSemanticScoreWeight" });
            }

            // GlobalFullTextScoreWeight (decimal) minimum
            if (this.GlobalFullTextScoreWeight < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GlobalFullTextScoreWeight, must be a value greater than or equal to 0.", new [] { "GlobalFullTextScoreWeight" });
            }

            // FullTextScoreSaturation (decimal) minimum
            if (this.FullTextScoreSaturation < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FullTextScoreSaturation, must be a value greater than or equal to 0.", new [] { "FullTextScoreSaturation" });
            }

            yield break;
        }
    }

}