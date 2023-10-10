/*
 * Semantic Search - Searcher HTTP API
 *
 * The searcher component HTTP API of the semantic search Service.  The service depends on a database backend. If a mere vector store (e.g. [Qdrant](https://qdrant.tech/)), instead of a full fledged search engine (e.g. [Elasticsearch](https://www.elastic.co/)), is configured, some advanced functionalities of the API have no effect. This is noted where appropriate, referring to the former as _simple database_ and the latter as _full database_. 
 *
 * The version of the OpenAPI document: 1.4.0
 * Contact: contact@leftshift.one
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using LSO.SemanticSearch.Model;
using LSO.SemanticSearch.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace LSO.SemanticSearch.Test.Model
{
    /// <summary>
    ///  Class for testing SearchQueryRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SearchQueryRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SearchQueryRequest
        //private SearchQueryRequest instance;

        public SearchQueryRequestTests()
        {
            // TODO uncomment below to create an instance of SearchQueryRequest
            //instance = new SearchQueryRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SearchQueryRequest
        /// </summary>
        [Fact]
        public void SearchQueryRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" SearchQueryRequest
            //Assert.IsType<SearchQueryRequest>(instance);
        }

        /// <summary>
        /// Test the property 'TextQueries'
        /// </summary>
        [Fact]
        public void TextQueriesTest()
        {
            // TODO unit test for the property 'TextQueries'
        }

        /// <summary>
        /// Test the property 'FilterQueries'
        /// </summary>
        [Fact]
        public void FilterQueriesTest()
        {
            // TODO unit test for the property 'FilterQueries'
        }

        /// <summary>
        /// Test the property 'FilterQuery'
        /// </summary>
        [Fact]
        public void FilterQueryTest()
        {
            // TODO unit test for the property 'FilterQuery'
        }

        /// <summary>
        /// Test the property 'Offset'
        /// </summary>
        [Fact]
        public void OffsetTest()
        {
            // TODO unit test for the property 'Offset'
        }

        /// <summary>
        /// Test the property 'Limit'
        /// </summary>
        [Fact]
        public void LimitTest()
        {
            // TODO unit test for the property 'Limit'
        }

        /// <summary>
        /// Test the property 'MinScore'
        /// </summary>
        [Fact]
        public void MinScoreTest()
        {
            // TODO unit test for the property 'MinScore'
        }

        /// <summary>
        /// Test the property 'IsDistinct'
        /// </summary>
        [Fact]
        public void IsDistinctTest()
        {
            // TODO unit test for the property 'IsDistinct'
        }

        /// <summary>
        /// Test the property 'SearchSettings'
        /// </summary>
        [Fact]
        public void SearchSettingsTest()
        {
            // TODO unit test for the property 'SearchSettings'
        }

        /// <summary>
        /// Test the property 'PreprocessorSettings'
        /// </summary>
        [Fact]
        public void PreprocessorSettingsTest()
        {
            // TODO unit test for the property 'PreprocessorSettings'
        }

        /// <summary>
        /// Test the property 'PostprocessorSettings'
        /// </summary>
        [Fact]
        public void PostprocessorSettingsTest()
        {
            // TODO unit test for the property 'PostprocessorSettings'
        }
    }
}