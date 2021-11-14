using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using System;
using System.Globalization;

namespace Lab.Chat.Infrastructure.Database.Converters
{
    public sealed class DateTimeOffsetConverter : IPropertyConverter
    {
        public object FromEntry(DynamoDBEntry entry)
        {
            var entryAsIso8601 = entry?.AsString();

            if (entryAsIso8601 == null)
            {
                return null;
            }

            return DateTimeOffset.Parse(entryAsIso8601, null, DateTimeStyles.RoundtripKind);
        }

        public DynamoDBEntry ToEntry(object value)
        {
            return ((DateTimeOffset)value).ToString("o");
        }
    }
}
