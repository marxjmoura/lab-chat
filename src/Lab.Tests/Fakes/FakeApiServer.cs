using Amazon.DynamoDBv2.DataModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;

namespace Lab.Tests.Fakes
{
    public sealed class FakeApiServer : TestServer
    {
        public FakeApiServer() : base(new Program().CreateWebHostBuilder()) { }

        public IDynamoDBContext DynamoDB => Host.Services.GetService<IDynamoDBContext>();
        public IWebHostEnvironment Environment => Host.Services.GetService<IWebHostEnvironment>();
    }
}
