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
    /// Index a document with given external id according to the specified settings.
    /// </summary>
    [DataContract(Name = "CreateDocumentRequest")]
    public partial class CreateDocumentRequest : IEquatable<CreateDocumentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDocumentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateDocumentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDocumentRequest" /> class.
        /// </summary>
        /// <param name="documentId">The id of the document to be indexed. (required).</param>
        /// <param name="documentIndexSettings">documentIndexSettings.</param>
        public CreateDocumentRequest(string documentId = default(string), DocumentIndexSettings documentIndexSettings = default(DocumentIndexSettings))
        {
            // to ensure "documentId" is required (not null)
            if (documentId == null)
            {
                throw new ArgumentNullException("documentId is a required property for CreateDocumentRequest and cannot be null");
            }
            this.DocumentId = documentId;
            this.DocumentIndexSettings = documentIndexSettings;
        }

        /// <summary>
        /// The id of the document to be indexed.
        /// </summary>
        /// <value>The id of the document to be indexed.</value>
        [DataMember(Name = "document_id", IsRequired = true, EmitDefaultValue = true)]
        public string DocumentId { get; set; }

        /// <summary>
        /// Gets or Sets DocumentIndexSettings
        /// </summary>
        [DataMember(Name = "document_index_settings", EmitDefaultValue = false)]
        public DocumentIndexSettings DocumentIndexSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateDocumentRequest {\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  DocumentIndexSettings: ").Append(DocumentIndexSettings).Append("\n");
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
            return this.Equals(input as CreateDocumentRequest);
        }

        /// <summary>
        /// Returns true if CreateDocumentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateDocumentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDocumentRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DocumentId == input.DocumentId ||
                    (this.DocumentId != null &&
                    this.DocumentId.Equals(input.DocumentId))
                ) && 
                (
                    this.DocumentIndexSettings == input.DocumentIndexSettings ||
                    (this.DocumentIndexSettings != null &&
                    this.DocumentIndexSettings.Equals(input.DocumentIndexSettings))
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
                if (this.DocumentId != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentId.GetHashCode();
                }
                if (this.DocumentIndexSettings != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentIndexSettings.GetHashCode();
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