using Lab.Chat.Infrastructure.Database.DataModel.Messages;
using Lab.Chat.Models.Messages;

namespace Lab.Chat.Infrastructure.Serialization.Messages
{
    public static class MessageMap
    {
        public static MessageResponse MapToResponse(this Message message)
        {
            return new MessageResponse
            {
                Id = message.Id.ToString(),
                Content = message.Content,
                SentOn = message.SentOn,
                UpdatedOn = message.UpdatedOn
            };
        }
    }
}
