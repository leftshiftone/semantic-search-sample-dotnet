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
    ///  Class for testing DocumentIndexSettings
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DocumentIndexSettingsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DocumentIndexSettings
        //private DocumentIndexSettings instance;

        public DocumentIndexSettingsTests()
        {
            // TODO uncomment below to create an instance of DocumentIndexSettings
            //instance = new DocumentIndexSettings();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DocumentIndexSettings
        /// </summary>
        [Fact]
        public void DocumentIndexSettingsInstanceTest()
        {
            // TODO uncomment below to test "IsType" DocumentIndexSettings
            //Assert.IsType<DocumentIndexSettings>(instance);
        }

        /// <summary>
        /// Test the property 'SplitSentences'
        /// </summary>
        [Fact]
        public void SplitSentencesTest()
        {
            // TODO unit test for the property 'SplitSentences'
        }

        /// <summary>
        /// Test the property 'SentenceCount'
        /// </summary>
        [Fact]
        public void SentenceCountTest()
        {
            // TODO unit test for the property 'SentenceCount'
        }

        /// <summary>
        /// Test the property 'SentenceOverlap'
        /// </summary>
        [Fact]
        public void SentenceOverlapTest()
        {
            // TODO unit test for the property 'SentenceOverlap'
        }

        /// <summary>
        /// Test the property 'MinChars'
        /// </summary>
        [Fact]
        public void MinCharsTest()
        {
            // TODO unit test for the property 'MinChars'
        }

        /// <summary>
        /// Test the property 'SemanticFields'
        /// </summary>
        [Fact]
        public void SemanticFieldsTest()
        {
            // TODO unit test for the property 'SemanticFields'
        }

        /// <summary>
        /// Test the property 'DeleteSource'
        /// </summary>
        [Fact]
        public void DeleteSourceTest()
        {
            // TODO unit test for the property 'DeleteSource'
        }
    }
}
