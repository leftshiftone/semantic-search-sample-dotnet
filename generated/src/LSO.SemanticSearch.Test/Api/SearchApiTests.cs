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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using LSO.SemanticSearch.Client;
using LSO.SemanticSearch.Api;
// uncomment below to import models
//using LSO.SemanticSearch.Model;

namespace LSO.SemanticSearch.Test.Api
{
    /// <summary>
    ///  Class for testing SearchApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SearchApiTests : IDisposable
    {
        private SearchApi instance;

        public SearchApiTests()
        {
            instance = new SearchApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SearchApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SearchApi
            //Assert.IsType<SearchApi>(instance);
        }

        /// <summary>
        /// Test SearchIndexNamePost
        /// </summary>
        [Fact]
        public void SearchIndexNamePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string indexName = null;
            //SearchQueryRequest? searchQueryRequest = null;
            //var response = instance.SearchIndexNamePost(indexName, searchQueryRequest);
            //Assert.IsType<SearchResultsResponse>(response);
        }
    }
}
