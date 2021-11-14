using NUlid;

namespace Lab.Chat.Infrastructure.Database.DataModel.Messages
{
    public class MessageKey
    {
        public MessageKey(string userId, Ulid messageId)
        {
            PK = $"User#{userId}#Messages";
            SK = $"Message#{messageId}";
        }

        public string PK { get; }

        public string SK { get; }

        public void AssignTo(Message message)
        {
            message.PK = PK;
            message.SK = SK;
        }
    }
}
