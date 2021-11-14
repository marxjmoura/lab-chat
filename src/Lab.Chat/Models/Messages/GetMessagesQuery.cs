using System.ComponentModel.DataAnnotations;
using NUlid;

namespace Lab.Chat.Models.Messages
{
    public class GetMessagesQuery
    {
        public Ulid? Before { get; set; }

        [MaxLength(100)]
        public int? Length { get; set; }
    }
}
