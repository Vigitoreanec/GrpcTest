using Grpc.Net.Client;
using GrpcTest;


using var channel = GrpcChannel.ForAddress("https://localhost:7244");
var client = new Greeter.GreeterClient(channel);

Console.WriteLine("Hello!!! \n Введите Имя!");
string? name = Console.ReadLine();

var helloReply = await client.SayHelloAsync(new HelloRequest
{
    Name = name
});

Console.WriteLine($"Ответ сервера: {helloReply.Message}");
Console.ReadKey();