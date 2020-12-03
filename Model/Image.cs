using System.Collections.Generic;
using Amazon.DynamoDBv2.DataModel;

namespace Assignment4AWSLambda.Model
{
    [DynamoDBTable("Images")]
    public class Image
    {
        [DynamoDBHashKey]
        public string Id { get; set; }

        [DynamoDBProperty]
        public string BucketName { get; set; }

        [DynamoDBProperty]
        public string KeyName { get; set; }

        [DynamoDBProperty]
        public bool Processed { get; set; }

        [DynamoDBProperty]
        public string Metadatainfo { get; set; }

        [DynamoDBProperty(AttributeName = "Labels")]
        public List<Label> Labels { get; set; }
    }
}
