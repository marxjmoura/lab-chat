using System;
using System.Net.Mime;
using Lab.Chat.Models.Messages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NUlid;

namespace Lab.Chat.Controllers
{
    [Route("messages")]
    public class MessagesController : Controller
    {
        /// <summary>
        /// Get messages
        /// </summary>
        /// <remarks>
        /// Direct message sent from one user to another user or group.
        /// </remarks>
        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ListMessageResponse), StatusCodes.Status200OK)]
        public IActionResult List()
        {
            return Ok(new ListMessageResponse
            {
                Messages = new[]
                {
                    new MessageResponse
                    {
                        Id = Ulid.NewUlid().ToString(),
                        Content = "Bla bla bla",
                        SentOn = DateTime.UtcNow
                    }
                }
            });
        }
    }
}
