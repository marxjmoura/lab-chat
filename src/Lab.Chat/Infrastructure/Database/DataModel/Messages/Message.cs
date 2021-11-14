using System;
using Amazon.DynamoDBv2.DataModel;
using Lab.Chat.Infrastructure.Database.Converters;
using NUlid;

namespace Lab.Chat.Infrastructure.Database.DataModel.Messages
{
    [DynamoDBTable(AppDynamoDBTable.Name)]
    public class Message
    {
        [DynamoDBHashKey]
        public string PK { get; set; }

        [DynamoDBRangeKey]
        public string SK { get; set; }

        [DynamoDBProperty(typeof(UlidConverter))]
        public Ulid Id { get; set; }

        [DynamoDBProperty]
        public string Content { get; set; }

        [DynamoDBProperty(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset SentOn { get; set; }
    }
}
