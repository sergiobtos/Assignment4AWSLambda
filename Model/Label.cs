using Amazon.DynamoDBv2.DataModel;

namespace Assignment4AWSLambda.Model
{
    public class Label
    {
        [DynamoDBProperty]
        public string TagName { get; set; }
        [DynamoDBProperty]
        public int Value { get; set; }
    }
}
