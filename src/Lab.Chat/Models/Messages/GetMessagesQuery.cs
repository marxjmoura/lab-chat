using System.ComponentModel.DataAnnotations;
using NUlid;

namespace Lab.Chat.Models.Messages
{
    public class GetMessagesQuery
    {
        /// <summary>
        /// Message ID used to identify previous messages (used for pagination).
        /// </summary>
        public Ulid? Before { get; set; }

        /// <summary>
        /// Number of messages returned in search.
        /// </summary>
        [MaxLength(100)]
        public int? Length { get; set; }
    }
}
