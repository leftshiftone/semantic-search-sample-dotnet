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
    /// SearchResultResponse
    /// </summary>
    [DataContract(Name = "SearchResultResponse")]
    public partial class SearchResultResponse : IEquatable<SearchResultResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchResultResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultResponse" /> class.
        /// </summary>
        /// <param name="id">The identifier of the indexed document. (required).</param>
        /// <param name="rawId">The identifier of the underlying indexed object. (required).</param>
        /// <param name="score">The relevance score of the search result. (required).</param>
        /// <param name="data">data (required).</param>
        public SearchResultResponse(string id = default(string), string rawId = default(string), decimal score = default(decimal), Dictionary<string, Object> data = default(Dictionary<string, Object>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for SearchResultResponse and cannot be null");
            }
            this.Id = id;
            // to ensure "rawId" is required (not null)
            if (rawId == null)
            {
                throw new ArgumentNullException("rawId is a required property for SearchResultResponse and cannot be null");
            }
            this.RawId = rawId;
            this.Score = score;
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for SearchResultResponse and cannot be null");
            }
            this.Data = data;
        }

        /// <summary>
        /// The identifier of the indexed document.
        /// </summary>
        /// <value>The identifier of the indexed document.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The identifier of the underlying indexed object.
        /// </summary>
        /// <value>The identifier of the underlying indexed object.</value>
        [DataMember(Name = "raw_id", IsRequired = true, EmitDefaultValue = true)]
        public string RawId { get; set; }

        /// <summary>
        /// The relevance score of the search result.
        /// </summary>
        /// <value>The relevance score of the search result.</value>
        [DataMember(Name = "score", IsRequired = true, EmitDefaultValue = true)]
        public decimal Score { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchResultResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RawId: ").Append(RawId).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as SearchResultResponse);
        }

        /// <summary>
        /// Returns true if SearchResultResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchResultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchResultResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RawId == input.RawId ||
                    (this.RawId != null &&
                    this.RawId.Equals(input.RawId))
                ) && 
                (
                    this.Score == input.Score ||
                    this.Score.Equals(input.Score)
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.RawId != null)
                {
                    hashCode = (hashCode * 59) + this.RawId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Score.GetHashCode();
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
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
