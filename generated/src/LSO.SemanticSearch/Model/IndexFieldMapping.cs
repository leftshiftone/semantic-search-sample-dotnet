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
    /// IndexFieldMapping
    /// </summary>
    [DataContract(Name = "IndexFieldMapping")]
    public partial class IndexFieldMapping : IEquatable<IndexFieldMapping>, IValidatableObject
    {
        /// <summary>
        /// The data type of the field. Possible values:   * BOOLEAN, INTEGER, FLOAT: The familiar data types.   * TIMESTAMP: Formatted either as yyyy-MM-ddTHH:mm:ss.SSSSSSZ or yyyy-MM-dd   * JSON: A general, structured element.   * GEO_POINT: Latitude and longitude coordinates   * KEYWORD: Text field, which is not analyzed. Suited for filter queries.   * TEXT: Text field, which is analyzed as well as (possibly) semantically embedded. Suited for full text and semantic search. 
        /// </summary>
        /// <value>The data type of the field. Possible values:   * BOOLEAN, INTEGER, FLOAT: The familiar data types.   * TIMESTAMP: Formatted either as yyyy-MM-ddTHH:mm:ss.SSSSSSZ or yyyy-MM-dd   * JSON: A general, structured element.   * GEO_POINT: Latitude and longitude coordinates   * KEYWORD: Text field, which is not analyzed. Suited for filter queries.   * TEXT: Text field, which is analyzed as well as (possibly) semantically embedded. Suited for full text and semantic search. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum BOOLEAN for value: BOOLEAN
            /// </summary>
            [EnumMember(Value = "BOOLEAN")]
            BOOLEAN = 1,

            /// <summary>
            /// Enum INTEGER for value: INTEGER
            /// </summary>
            [EnumMember(Value = "INTEGER")]
            INTEGER = 2,

            /// <summary>
            /// Enum FLOAT for value: FLOAT
            /// </summary>
            [EnumMember(Value = "FLOAT")]
            FLOAT = 3,

            /// <summary>
            /// Enum TIMESTAMP for value: TIMESTAMP
            /// </summary>
            [EnumMember(Value = "TIMESTAMP")]
            TIMESTAMP = 4,

            /// <summary>
            /// Enum KEYWORD for value: KEYWORD
            /// </summary>
            [EnumMember(Value = "KEYWORD")]
            KEYWORD = 5,

            /// <summary>
            /// Enum TEXT for value: TEXT
            /// </summary>
            [EnumMember(Value = "TEXT")]
            TEXT = 6,

            /// <summary>
            /// Enum JSON for value: JSON
            /// </summary>
            [EnumMember(Value = "JSON")]
            JSON = 7,

            /// <summary>
            /// Enum GEOPOINT for value: GEO_POINT
            /// </summary>
            [EnumMember(Value = "GEO_POINT")]
            GEOPOINT = 8
        }


        /// <summary>
        /// The data type of the field. Possible values:   * BOOLEAN, INTEGER, FLOAT: The familiar data types.   * TIMESTAMP: Formatted either as yyyy-MM-ddTHH:mm:ss.SSSSSSZ or yyyy-MM-dd   * JSON: A general, structured element.   * GEO_POINT: Latitude and longitude coordinates   * KEYWORD: Text field, which is not analyzed. Suited for filter queries.   * TEXT: Text field, which is analyzed as well as (possibly) semantically embedded. Suited for full text and semantic search. 
        /// </summary>
        /// <value>The data type of the field. Possible values:   * BOOLEAN, INTEGER, FLOAT: The familiar data types.   * TIMESTAMP: Formatted either as yyyy-MM-ddTHH:mm:ss.SSSSSSZ or yyyy-MM-dd   * JSON: A general, structured element.   * GEO_POINT: Latitude and longitude coordinates   * KEYWORD: Text field, which is not analyzed. Suited for filter queries.   * TEXT: Text field, which is analyzed as well as (possibly) semantically embedded. Suited for full text and semantic search. </value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexFieldMapping" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IndexFieldMapping() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexFieldMapping" /> class.
        /// </summary>
        /// <param name="fieldName">The name of the field. (required).</param>
        /// <param name="type">The data type of the field. Possible values:   * BOOLEAN, INTEGER, FLOAT: The familiar data types.   * TIMESTAMP: Formatted either as yyyy-MM-ddTHH:mm:ss.SSSSSSZ or yyyy-MM-dd   * JSON: A general, structured element.   * GEO_POINT: Latitude and longitude coordinates   * KEYWORD: Text field, which is not analyzed. Suited for filter queries.   * TEXT: Text field, which is analyzed as well as (possibly) semantically embedded. Suited for full text and semantic search.  (required).</param>
        public IndexFieldMapping(string fieldName = default(string), TypeEnum type = default(TypeEnum))
        {
            // to ensure "fieldName" is required (not null)
            if (fieldName == null)
            {
                throw new ArgumentNullException("fieldName is a required property for IndexFieldMapping and cannot be null");
            }
            this.FieldName = fieldName;
            this.Type = type;
        }

        /// <summary>
        /// The name of the field.
        /// </summary>
        /// <value>The name of the field.</value>
        [DataMember(Name = "field_name", IsRequired = true, EmitDefaultValue = true)]
        public string FieldName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IndexFieldMapping {\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as IndexFieldMapping);
        }

        /// <summary>
        /// Returns true if IndexFieldMapping instances are equal
        /// </summary>
        /// <param name="input">Instance of IndexFieldMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndexFieldMapping input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.FieldName != null)
                {
                    hashCode = (hashCode * 59) + this.FieldName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
