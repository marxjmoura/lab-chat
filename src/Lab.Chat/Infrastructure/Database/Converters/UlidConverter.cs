using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using NUlid;

namespace Lab.Chat.Infrastructure.Database.Converters
{
    public sealed class UlidConverter : IPropertyConverter
    {
        public object FromEntry(DynamoDBEntry entry)
        {
            var entryAsString = entry?.AsString();

            if (entryAsString == null)
            {
                return null;
            }

            return Ulid.Parse(entryAsString);
        }

        public DynamoDBEntry ToEntry(object value)
        {
            return value.ToString();
        }
    }
}
