using System.Threading.Tasks;
using Grpc.Net.Client;
using Xunit;
using CleanArchitectureGRPC.API;

namespace CleanArchitectureGRPC.Tests.IntegrationTests
{
    public class GreeterIntegrationTests
    {
        private readonly GrpcChannel _channel;
        private readonly Greeter.GreeterClient _client;

        public GreeterIntegrationTests()
        {
            // Adjust the address to match your gRPC server's address and port
            _channel = GrpcChannel.ForAddress("http://localhost:5073"); // Use http if SSL/TLS is not configured
            _client = new Greeter.GreeterClient(_channel);
        }

        [Fact]
        public async Task SayHello_ReturnsExpectedMessage()
        {
            var request = new HelloRequest { Name = "World" };
            var response = await _client.SayHelloAsync(request);
            Assert.Equal("Hello, World!", response.Message);
        }
    }
}
