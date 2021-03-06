﻿using System.Collections.Generic;
using Amazon.DynamoDBv2.DataModel;

namespace Assignment4AWSLambda.Model
{
    [DynamoDBTable("MyImage")]
    public class MyImage
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
        public byte[] Metadata { get; set; }

        [DynamoDBProperty(AttributeName = "Labels")]
        public List<MyLabel> Labels { get; set; }
    }
}
