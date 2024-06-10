using CleanArchitectureGRPC.Application.Interfaces;
using CleanArchitectureGRPC.Application.Services;
using System.Threading.Tasks;
using Xunit;

namespace CleanArchitectureGRPC.Tests.UnitTests
{
    public class GreeterUnitTests
    {
        private readonly IGreetingService _greeterService;

        public GreeterUnitTests()
        {
            _greeterService = new GreetingService();
        }

        [Fact]
        public async Task SayHelloAsync_ReturnsGreetingMessage()
        {
            // Arrange
            var name = "World";

            // Act
            var result = await _greeterService.SayHelloAsync(name);

            // Assert
            Assert.Equal("Hello, World!", result);
        }

        [Theory]
        [InlineData("Alice", "Hello, Alice!")]
        [InlineData("Bob", "Hello, Bob!")]
        public async Task SayHelloAsync_ReturnsExpectedGreetingMessage(string name, string expectedMessage)
        {
            // Act
            var result = await _greeterService.SayHelloAsync(name);

            // Assert
            Assert.Equal(expectedMessage, result);
        }

        [Fact]
        public async Task SayHelloAsync_WithEmptyName_ReturnsGreetingMessage()
        {
            // Arrange
            var name = "";

            // Act
            var result = await _greeterService.SayHelloAsync(name);

            // Assert
            Assert.Equal("Hello, !", result);
        }
    }
}
