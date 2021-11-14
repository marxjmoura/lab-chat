using System.Threading.Tasks;
using Amazon.DynamoDBv2.DataModel;
using Lab.Chat.Infrastructure.Database.DataModel.Messages;

namespace Lab.Chat.Features
{
    public class MessageDelete
    {
        private readonly DynamoDBContext _dbContext;

        public MessageDelete(DynamoDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Delete(Message message)
        {
            await _dbContext.DeleteAsync(message);
        }
    }
}
