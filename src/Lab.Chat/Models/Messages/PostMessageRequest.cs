using System.ComponentModel.DataAnnotations;
using Lab.Chat.Infrastructure.Database.DataModel.Messages;

namespace Lab.Chat.Models.Messages
{
    public class PostMessageRequest
    {
        /// <summary>
        /// Message's content that will be read by the user.
        /// </summary>
        [Required, MaxLength(150)]
        public string Content { get; set; }

        public Message ToMessage()
        {
            return new Message
            {
                Content = Content
            };
        }
    }
}
