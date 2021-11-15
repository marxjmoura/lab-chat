using System.Net;
using System.Threading.Tasks;
using Lab.Tests.Fakes;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NSubstitute;
using Xunit;

namespace Lab.Tests.Functional.Messages
{
    public class ListMessagesTest
    {
        private readonly FakeApiServer _server;
        private readonly FakeApiClient _client;

        public ListMessagesTest()
        {
            _server = new FakeApiServer();
            _client = new FakeApiClient(_server);
        }

        // [Fact]
        // public async Task ShouldList()
        // {
        //     _server.DynamoDB.LoadAsync<Message>("abc").Returns(new Message());

        //     var route = "/messages";
        //     var response = await _client.Get(route, jsonRequest);
        //     var jsonResponse = await _client.ReadAsJsonAsync<GetMessagesResponse>(response);

        //     Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        //     Assert.Equal(_token.AccountId, shop.AccountId);
        //     Assert.Equal(jsonRequest.Name, shop.Name);
        //     Assert.Equal(jsonRequest.Active, shop.Active);
        //     Assert.NotEqual(DateTime.MinValue, shop.CreatedAt);
        // }
    }
}
