using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularGetStarted.UI.Helpers
{
    public sealed class MongoDBHelper
    {
        // TODO: create domains, services and repos
        private IMongoDatabase MongoDb { get; set; }

        public MongoDBHelper()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            MongoDb = client.GetDatabase("CustomerApi");
        }

    }
}