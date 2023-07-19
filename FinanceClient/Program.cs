using System;
using FinanceService;
using Grpc.Net.Client;

namespace GrpcClient
{
    class Program
    {
        static async Task Main()
        {
            try
            {
                var channel = GrpcChannel.ForAddress("http://localhost:5258");
                var client = new Finances.FinancesClient(channel);
                var ModelPriceRequest = new PriceRequest { ModelId = "123" };
                var reply = await client.GetModelPriceAsync(ModelPriceRequest);
                Console.WriteLine($"Model Price: {reply.Price}");
                Console.ReadLine();

            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}