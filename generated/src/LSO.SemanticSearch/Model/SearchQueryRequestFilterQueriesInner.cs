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
using System.Reflection;

namespace LSO.SemanticSearch.Model
{
    /// <summary>
    /// SearchQueryRequestFilterQueriesInner
    /// </summary>
    [JsonConverter(typeof(SearchQueryRequestFilterQueriesInnerJsonConverter))]
    [DataContract(Name = "SearchQueryRequest_filter_queries_inner")]
    public partial class SearchQueryRequestFilterQueriesInner : AbstractOpenAPISchema, IEquatable<SearchQueryRequestFilterQueriesInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchQueryRequestFilterQueriesInner" /> class
        /// with the <see cref="KeyValueFilter" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KeyValueFilter.</param>
        public SearchQueryRequestFilterQueriesInner(KeyValueFilter actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchQueryRequestFilterQueriesInner" /> class
        /// with the <see cref="DateFilter" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DateFilter.</param>
        public SearchQueryRequestFilterQueriesInner(DateFilter actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(DateFilter))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KeyValueFilter))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: DateFilter, KeyValueFilter");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `KeyValueFilter`. If the actual instance is not `KeyValueFilter`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KeyValueFilter</returns>
        public KeyValueFilter GetKeyValueFilter()
        {
            return (KeyValueFilter)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DateFilter`. If the actual instance is not `DateFilter`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DateFilter</returns>
        public DateFilter GetDateFilter()
        {
            return (DateFilter)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchQueryRequestFilterQueriesInner {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, SearchQueryRequestFilterQueriesInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of SearchQueryRequestFilterQueriesInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of SearchQueryRequestFilterQueriesInner</returns>
        public static SearchQueryRequestFilterQueriesInner FromJson(string jsonString)
        {
            SearchQueryRequestFilterQueriesInner newSearchQueryRequestFilterQueriesInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newSearchQueryRequestFilterQueriesInner;
            }

            try
            {
                newSearchQueryRequestFilterQueriesInner = new SearchQueryRequestFilterQueriesInner(JsonConvert.DeserializeObject<DateFilter>(jsonString, SearchQueryRequestFilterQueriesInner.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newSearchQueryRequestFilterQueriesInner;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DateFilter: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newSearchQueryRequestFilterQueriesInner = new SearchQueryRequestFilterQueriesInner(JsonConvert.DeserializeObject<KeyValueFilter>(jsonString, SearchQueryRequestFilterQueriesInner.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newSearchQueryRequestFilterQueriesInner;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KeyValueFilter: {1}", jsonString, exception.ToString()));
            }

            // no match found, throw an exception
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchQueryRequestFilterQueriesInner);
        }

        /// <summary>
        /// Returns true if SearchQueryRequestFilterQueriesInner instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchQueryRequestFilterQueriesInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchQueryRequestFilterQueriesInner input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for SearchQueryRequestFilterQueriesInner
    /// </summary>
    public class SearchQueryRequestFilterQueriesInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(SearchQueryRequestFilterQueriesInner).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return SearchQueryRequestFilterQueriesInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
