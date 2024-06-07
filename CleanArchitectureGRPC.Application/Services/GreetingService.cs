using CleanArchitectureGRPC.Application.Interfaces;

namespace CleanArchitectureGRPC.Application.Services
{
    public class GreetingService : IGreetingService
    {
        public async Task<string> SayHelloAsync(string name)
        {
            return await Task.FromResult($"Hello, {name}!");
        }
    }
}
