using CleanArchitectureGRPC.Application.Interfaces;
using Grpc.Core;

namespace CleanArchitectureGRPC.API.Services
{
    public class GreeterRemoteProcedure : Greeter.GreeterBase
    {
        private readonly IGreetingService _greeterService;

        public GreeterRemoteProcedure(IGreetingService greeterService)
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
