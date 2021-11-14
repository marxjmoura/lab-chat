using System.Collections.Generic;

namespace Lab.Chat.Models.Messages
{
    public class GetMessagesResponse
    {
        /// <summary>
        /// Message list.
        /// </summary>
        public IEnumerable<MessageResponse> Messages { get; set; }
    }
}
