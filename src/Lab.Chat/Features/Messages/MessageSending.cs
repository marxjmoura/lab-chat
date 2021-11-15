using System;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DataModel;
using Lab.Chat.Infrastructure.Database.DataModel.Messages;
using NUlid;

namespace Lab.Chat.Features.Messages
{
    public class MessageSending
    {
        private readonly IDynamoDBContext _dbContext;

        public MessageSending(IDynamoDBContext dbContext)
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
