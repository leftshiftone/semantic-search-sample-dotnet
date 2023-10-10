/*
 * Semantic Search - Indexer HTTP API
 *
 * The indexer component HTTP API of the semantic search service.  The service depends on a database backend. If a mere vector store (e.g. [Qdrant](https://qdrant.tech/)), instead of a full fledged search engine (e.g. [Elasticsearch](https://www.elastic.co/)), is configured, some advanced functionalities of the API have no effect. This is noted where appropriate, referring to the former as _simple database_ and the latter as _full database_. 
 *
 * The version of the OpenAPI document: 1.5.0
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
    ///  Class for testing ErrorResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ErrorResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ErrorResponse
        //private ErrorResponse instance;

        public ErrorResponseTests()
        {
            // TODO uncomment below to create an instance of ErrorResponse
            //instance = new ErrorResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ErrorResponse
        /// </summary>
        [Fact]
        public void ErrorResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" ErrorResponse
            //Assert.IsType<ErrorResponse>(instance);
        }

        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Fact]
        public void MessageTest()
        {
            // TODO unit test for the property 'Message'
        }

        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
    }
}
