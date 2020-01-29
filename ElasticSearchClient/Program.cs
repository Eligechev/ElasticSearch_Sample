using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;
using Elasticsearch.Net;

namespace ElasticSearchClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings = new ConnectionSettings(new Uri("http://localhost:9200"))
                .DefaultIndex("response_log");

            var client = new ElasticClient(settings);
            LogModel log = new LogModel();
            var createIndexResponse = client.Indices.Create("response_log1", c => c
                .Map<LogModel>(m => m
                    .AutoMap()
                )
            );

            var indexResponse = client.IndexDocument(log);
        }
    }
}
