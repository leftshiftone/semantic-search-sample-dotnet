#!/bin/sh

openapi-generator generate \
-i schema/indexer.yaml \
-g csharp \
--additional-properties=packageName=LSO.SemanticSearch,apiName=IndexerApi \
-o generated

openapi-generator generate \
-i schema/searcher.yaml \
-g csharp \
--additional-properties=packageName=LSO.SemanticSearch,apiName=SearcherApi\
-o generated
