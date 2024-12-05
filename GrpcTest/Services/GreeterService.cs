using Grpc.Core;
using GrpcTest;

namespace GrpcTest.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = $"Server {DateTime.UtcNow.ToShortTimeString()} => Hello " + request.Name
            });
        }
    }
}
