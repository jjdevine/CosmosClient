﻿using System;
using Microsoft.Azure.Cosmos;

namespace TestCosmosClient
{
    class Program
    {
        private string EndpointUrl = "https://jd-cosmos.documents.azure.com:443/";

        private string PrimaryKey = "EfoKRkQYFgYZRXG6DDwkgrB4yMVFU1ngGo4OgguKAZEecIB3OsMzQ2sCYuHsKBuSfIjGBBKVhzI30kLqBOfAQQ==";


        static void Main(string[] args)
        {
            CosmosClient cosmosClient = new CosmosClient(
                "AccountEndpoint=https://jd-cosmos.documents.azure.com:443/;AccountKey=EfoKRkQYFgYZRXG6DDwkgrB4yMVFU1ngGo4OgguKAZEecIB3OsMzQ2sCYuHsKBuSfIjGBBKVhzI30kLqBOfAQQ==;",
                new CosmosClientOptions()
                {       
                }
            );

            Database db = cosmosClient.GetDatabase("cosmos1");
            Container container = db.GetContainer("container1");

            var sqlQueryText = "SELECT * FROM c WHERE c.val = 'a'";

            QueryDefinition queryDefinition = new QueryDefinition(sqlQueryText);
            FeedIterator feedIterator = container.GetItemQueryIterator(queryDefinition);



        }
    }
}
