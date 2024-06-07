using CleanArchitectureGRPC.Application.Interfaces;
using Grpc.Core;
using System.Threading.Tasks;

namespace CleanArchitectureGRPC.API.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly IGreetingService _greeterService;

        public GreeterService(IGreetingService greeterService)
        {
            _greeterService = greeterService;
        }

        public override async Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            var message = await _greeterService.SayHelloAsync(request.Name);
            return new HelloReply { Message = message };
        }
    }
}
