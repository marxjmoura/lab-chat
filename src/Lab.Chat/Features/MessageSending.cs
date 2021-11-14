using System;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DataModel;
using Lab.Chat.Infrastructure.Database.DataModel.Messages;
using NUlid;

namespace Lab.Chat.Features
{
    public class MessageSending
    {
        private readonly DynamoDBContext _dbContext;

        public MessageSending(DynamoDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Send(string userId, Message message)
        {
            message.Id = Ulid.NewUlid();
            message.SentOn = DateTimeOffset.UtcNow;

            var messageKey = new MessageKey(userId, message.Id);
            messageKey.AssignTo(message);

            await _dbContext.SaveAsync(message);
        }
    }
}
