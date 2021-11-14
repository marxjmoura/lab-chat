using Amazon.DynamoDBv2.DocumentModel;
using NUlid;

namespace Lab.Chat.Infrastructure.Database.DataModel.Messages
{
    public class MessageQuery
    {
        public string UserId { get; set; }

        public Ulid BeforeMessage { get; set; }

        public int Length { get; set; }

        public QueryOperationConfig ToDynamoDBQuery()
        {
            var primaryKey = new MessageKey(UserId, BeforeMessage);

            var filter = new QueryFilter();
            filter.AddCondition(AppDynamoDBTable.PK, QueryOperator.Equal, primaryKey.PK);
            filter.AddCondition(AppDynamoDBTable.SK, QueryOperator.LessThan, primaryKey.SK);

            return new QueryOperationConfig
            {
                Filter = filter,
                Limit = Length,
                BackwardSearch = true
            };
        }
    }
}
