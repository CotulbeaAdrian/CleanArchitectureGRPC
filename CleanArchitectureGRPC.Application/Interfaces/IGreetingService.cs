namespace CleanArchitectureGRPC.Application.Interfaces
{
    public interface IGreetingService
    {
        Task<string> SayHelloAsync(string name);
    }
}