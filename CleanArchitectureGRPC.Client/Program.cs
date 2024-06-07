using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using CleanArchitectureGRPC.API;

namespace CleanArchitectureGRPC.Client;

class Program
{
    static async Task Main(string[] args)
    {
        // Define the endpoint of the gRPC service
        var endpoint = "https://localhost:5001";

        // Create a gRPC channel
        using var channel = GrpcChannel.ForAddress(endpoint);

        // Create a client for the Greeter service
        var client = new Greeter.GreeterClient(channel);

        // Call a method on the service
        var reply = await client.SayHelloAsync(new HelloRequest { Name = "World" });

        // Output the response
        Console.WriteLine("Greeting: " + reply.Message);
    }
}
