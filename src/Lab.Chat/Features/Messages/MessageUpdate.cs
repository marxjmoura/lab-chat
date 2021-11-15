using System;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DataModel;
using Lab.Chat.Infrastructure.Database.DataModel.Messages;

namespace Lab.Chat.Features.Messages
{
    public class MessageUpdate
    {
        private readonly IDynamoDBContext _dbContext;

        public MessageUpdate(IDynamoDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Update(Message message)
        {
            message.UpdatedOn = DateTimeOffset.UtcNow;

            await _dbContext.SaveAsync(message);
        }
    }
}
