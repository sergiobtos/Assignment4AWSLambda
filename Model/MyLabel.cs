using Amazon.DynamoDBv2.DataModel;

namespace Assignment4AWSLambda.Model
{
    public class MyLabel
    {
        [DynamoDBProperty]
        public string Key { get; set; }
        [DynamoDBProperty]
        public string Value { get; set; }
    }
}
