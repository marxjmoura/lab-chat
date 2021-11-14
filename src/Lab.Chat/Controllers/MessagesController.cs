using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Lab.Chat.Infrastructure.Database.DataModel.Messages;
using Lab.Chat.Infrastructure.Serialization.Messages;
using Lab.Chat.Models.Messages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NUlid;

namespace Lab.Chat.Controllers
{
    [Route("messages")]
    public class MessagesController : Controller
    {
        private readonly DynamoDBContext _dbContext;

        public MessagesController(IAmazonDynamoDB dynamoDB)
        {
            _dbContext = new DynamoDBContext(dynamoDB);
        }

        /// <summary>
        /// Get messages
        /// </summary>
        /// <remarks>
        /// Direct message sent from one user to another user or group.
        /// </remarks>
        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(GetMessagesResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> List([FromQuery] GetMessagesQuery queryString)
        {
            var query = new MessageQuery();
            query.UserId = "1A2B3C4D";
            query.BeforeMessage = queryString.Before ?? Ulid.NewUlid();
            query.Length = queryString.Length ?? 30;

            var messages = await _dbContext
                .FromQueryAsync<Message>(query.ToDynamoDBQuery())
                .GetRemainingAsync();

            return Ok(new GetMessagesResponse
            {
                Messages = messages.Select(message => message.MapToResponse())
            });
        }
    }
}
