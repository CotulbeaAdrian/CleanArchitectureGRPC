# CleanArchitectureGRPC

## Project Structure

- **CleanArchitectureGRPC.API**: Contains the gRPC service definitions and implementations.
  - `Protos/greet.proto`: The Protocol Buffers file defining the gRPC service and messages.
  - `RemoteProcedures/GreeterRemoteProcedure.cs`: Implementation of the gRPC service.
  - `Program.cs` and `Startup.cs`: Entry point and configuration for the gRPC server.

- **CleanArchitectureGRPC.Application**: Contains application logic.
  - `Interfaces/IGreetingService.cs`: Interface for the greeting service.
  - `Services/GreetingService.cs`: Implementation of the greeting service.

- **CleanArchitectureGRPC.Client**: gRPC client setup for testing the service.

- **CleanArchitectureGRPC.Domain**: Contains domain entities and logic.

- **CleanArchitectureGRPC.Infrastructure**: Contains infrastructure-related code.

- **CleanArchitectureGRPC.Tests**: Contains unit and integration tests.
  - `IntegrationTests/GreeterIntegrationTests.cs`: Integration tests for the gRPC service.
  - `UnitTests/GreeterServiceTests.cs`: Unit tests for the application services.

## Running the Project

1. **Build the Project**: Open the solution in Visual Studio and build the entire solution.
2. **Run the API**: Set `CleanArchitectureGRPC.API` as the startup project and run it.
3. **Test the API**: Use a gRPC client (like `grpcurl` or a gRPC client library) to send requests to the service.

## Example gRPC Request

Using `grpcurl`:

```sh
grpcurl -plaintext -proto greet.proto -d '{"name":"Andrew"}' localhost:5073 greet.Greeter/SayHello
