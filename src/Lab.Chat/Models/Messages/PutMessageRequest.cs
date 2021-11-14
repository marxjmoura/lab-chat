using System.ComponentModel.DataAnnotations;
using Lab.Chat.Infrastructure.Database.DataModel.Messages;

namespace Lab.Chat.Models.Messages
{
    public class PutMessageRequest
    {
        /// <summary>
        /// Message's content that will be updated.
        /// </summary>
        [Required, MaxLength(150)]
        public string Content { get; set; }

        public void MapTo(Message message)
        {
            message.Content = Content;
        }
    }
}
