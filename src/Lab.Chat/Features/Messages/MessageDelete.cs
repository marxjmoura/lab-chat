using System.Threading.Tasks;
using Amazon.DynamoDBv2.DataModel;
using Lab.Chat.Infrastructure.Database.DataModel.Messages;

namespace Lab.Chat.Features.Messages
{
    public class MessageDelete
    {
        private readonly IDynamoDBContext _dbContext;

        public MessageDelete(IDynamoDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Delete(Message message)
        {
            await _dbContext.DeleteAsync(message);
        }
    }
}
