using System.Collections.Generic;

namespace Lab.Chat.Models.Messages
{
    public class ListMessageResponse
    {
        /// <summary>
        /// Message list.
        /// </summary>
        public ICollection<MessageResponse> Messages { get; set; }
    }
}
