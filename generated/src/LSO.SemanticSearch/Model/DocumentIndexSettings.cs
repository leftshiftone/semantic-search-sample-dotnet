/*
 * Semantic Search - Indexer HTTP API
 *
 * The indexer component HTTP API of the semantic search service.  The service depends on a database backend. If a mere vector store (e.g. [Qdrant](https://qdrant.tech/)), instead of a full fledged search engine (e.g. [Elasticsearch](https://www.elastic.co/)), is configured, some advanced functionalities of the API have no effect. This is noted where appropriate, referring to the former as _simple database_ and the latter as _full database_. 
 *
 * The version of the OpenAPI document: 1.5.0
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
    /// DocumentIndexSettings
    /// </summary>
    [DataContract(Name = "DocumentIndexSettings")]
    public partial class DocumentIndexSettings : IEquatable<DocumentIndexSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentIndexSettings" /> class.
        /// </summary>
        /// <param name="splitSentences">Whether to split the document into sentences. (default to true).</param>
        /// <param name="sentenceCount">The number of sentences to group and index together. (default to 3).</param>
        /// <param name="sentenceOverlap">The number of sentences consecutive sentence groups overlap. (default to 1).</param>
        /// <param name="minChars">The minimum number of characters a sentence group must contain. If the length of a sentence group is below this value, additional sentences are added until this requirement is fulfilled. (default to 1).</param>
        /// <param name="semanticFields">The names of text fields, which should be semantically embedded. The default value &#39;content_text_&#39; refers to the raw document text content.  &gt; **_NOTE:_**  For simple database backends, only the default content_text_ is semantically embedded at the moment. .</param>
        /// <param name="deleteSource">Delete the source files belonging to that document. (default to true).</param>
        public DocumentIndexSettings(bool splitSentences = true, int sentenceCount = 3, int sentenceOverlap = 1, int minChars = 1, List<string> semanticFields = default(List<string>), bool deleteSource = true)
        {
            this.SplitSentences = splitSentences;
            this.SentenceCount = sentenceCount;
            this.SentenceOverlap = sentenceOverlap;
            this.MinChars = minChars;
            this.SemanticFields = semanticFields;
            this.DeleteSource = deleteSource;
        }

        /// <summary>
        /// Whether to split the document into sentences.
        /// </summary>
        /// <value>Whether to split the document into sentences.</value>
        [DataMember(Name = "split_sentences", EmitDefaultValue = true)]
        public bool SplitSentences { get; set; }

        /// <summary>
        /// The number of sentences to group and index together.
        /// </summary>
        /// <value>The number of sentences to group and index together.</value>
        [DataMember(Name = "sentence_count", EmitDefaultValue = false)]
        public int SentenceCount { get; set; }

        /// <summary>
        /// The number of sentences consecutive sentence groups overlap.
        /// </summary>
        /// <value>The number of sentences consecutive sentence groups overlap.</value>
        [DataMember(Name = "sentence_overlap", EmitDefaultValue = false)]
        public int SentenceOverlap { get; set; }

        /// <summary>
        /// The minimum number of characters a sentence group must contain. If the length of a sentence group is below this value, additional sentences are added until this requirement is fulfilled.
        /// </summary>
        /// <value>The minimum number of characters a sentence group must contain. If the length of a sentence group is below this value, additional sentences are added until this requirement is fulfilled.</value>
        [DataMember(Name = "min_chars", EmitDefaultValue = false)]
        public int MinChars { get; set; }

        /// <summary>
        /// The names of text fields, which should be semantically embedded. The default value &#39;content_text_&#39; refers to the raw document text content.  &gt; **_NOTE:_**  For simple database backends, only the default content_text_ is semantically embedded at the moment. 
        /// </summary>
        /// <value>The names of text fields, which should be semantically embedded. The default value &#39;content_text_&#39; refers to the raw document text content.  &gt; **_NOTE:_**  For simple database backends, only the default content_text_ is semantically embedded at the moment. </value>
        [DataMember(Name = "semantic_fields", EmitDefaultValue = false)]
        public List<string> SemanticFields { get; set; }

        /// <summary>
        /// Delete the source files belonging to that document.
        /// </summary>
        /// <value>Delete the source files belonging to that document.</value>
        [DataMember(Name = "delete_source", EmitDefaultValue = true)]
        public bool DeleteSource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentIndexSettings {\n");
            sb.Append("  SplitSentences: ").Append(SplitSentences).Append("\n");
            sb.Append("  SentenceCount: ").Append(SentenceCount).Append("\n");
            sb.Append("  SentenceOverlap: ").Append(SentenceOverlap).Append("\n");
            sb.Append("  MinChars: ").Append(MinChars).Append("\n");
            sb.Append("  SemanticFields: ").Append(SemanticFields).Append("\n");
            sb.Append("  DeleteSource: ").Append(DeleteSource).Append("\n");
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
            return this.Equals(input as DocumentIndexSettings);
        }

        /// <summary>
        /// Returns true if DocumentIndexSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentIndexSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentIndexSettings input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SplitSentences == input.SplitSentences ||
                    this.SplitSentences.Equals(input.SplitSentences)
                ) && 
                (
                    this.SentenceCount == input.SentenceCount ||
                    this.SentenceCount.Equals(input.SentenceCount)
                ) && 
                (
                    this.SentenceOverlap == input.SentenceOverlap ||
                    this.SentenceOverlap.Equals(input.SentenceOverlap)
                ) && 
                (
                    this.MinChars == input.MinChars ||
                    this.MinChars.Equals(input.MinChars)
                ) && 
                (
                    this.SemanticFields == input.SemanticFields ||
                    this.SemanticFields != null &&
                    input.SemanticFields != null &&
                    this.SemanticFields.SequenceEqual(input.SemanticFields)
                ) && 
                (
                    this.DeleteSource == input.DeleteSource ||
                    this.DeleteSource.Equals(input.DeleteSource)
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
                hashCode = (hashCode * 59) + this.SplitSentences.GetHashCode();
                hashCode = (hashCode * 59) + this.SentenceCount.GetHashCode();
                hashCode = (hashCode * 59) + this.SentenceOverlap.GetHashCode();
                hashCode = (hashCode * 59) + this.MinChars.GetHashCode();
                if (this.SemanticFields != null)
                {
                    hashCode = (hashCode * 59) + this.SemanticFields.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DeleteSource.GetHashCode();
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
            // SentenceCount (int) minimum
            if (this.SentenceCount < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SentenceCount, must be a value greater than or equal to 1.", new [] { "SentenceCount" });
            }

            // SentenceOverlap (int) minimum
            if (this.SentenceOverlap < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SentenceOverlap, must be a value greater than or equal to 0.", new [] { "SentenceOverlap" });
            }

            // MinChars (int) minimum
            if (this.MinChars < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinChars, must be a value greater than or equal to 0.", new [] { "MinChars" });
            }

            yield break;
        }
    }

}
