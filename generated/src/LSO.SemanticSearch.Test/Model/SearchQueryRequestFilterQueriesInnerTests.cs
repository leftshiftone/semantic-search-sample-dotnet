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
    ///  Class for testing SearchQueryRequestFilterQueriesInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SearchQueryRequestFilterQueriesInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SearchQueryRequestFilterQueriesInner
        //private SearchQueryRequestFilterQueriesInner instance;

        public SearchQueryRequestFilterQueriesInnerTests()
        {
            // TODO uncomment below to create an instance of SearchQueryRequestFilterQueriesInner
            //instance = new SearchQueryRequestFilterQueriesInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SearchQueryRequestFilterQueriesInner
        /// </summary>
        [Fact]
        public void SearchQueryRequestFilterQueriesInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" SearchQueryRequestFilterQueriesInner
            //Assert.IsType<SearchQueryRequestFilterQueriesInner>(instance);
        }

        /// <summary>
        /// Test the property 'FieldName'
        /// </summary>
        [Fact]
        public void FieldNameTest()
        {
            // TODO unit test for the property 'FieldName'
        }

        /// <summary>
        /// Test the property 'Value'
        /// </summary>
        [Fact]
        public void ValueTest()
        {
            // TODO unit test for the property 'Value'
        }

        /// <summary>
        /// Test the property 'ModalType'
        /// </summary>
        [Fact]
        public void ModalTypeTest()
        {
            // TODO unit test for the property 'ModalType'
        }

        /// <summary>
        /// Test the property 'Start'
        /// </summary>
        [Fact]
        public void StartTest()
        {
            // TODO unit test for the property 'Start'
        }

        /// <summary>
        /// Test the property 'End'
        /// </summary>
        [Fact]
        public void EndTest()
        {
            // TODO unit test for the property 'End'
        }
    }
}
