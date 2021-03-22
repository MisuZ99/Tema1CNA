using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace PersonPrinterClient
{
    class Program
    {

        static async Task Main(string[] args)
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter CNP: ");
            string cnp = Console.ReadLine();

            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:7580");
            var client = new Printer.PrinterClient(channel);
            var reply =  client.PrintPerson(
                          new PrintRequest { Name = name, CNP = cnp });
            if (reply.MAge == "")
            {
                Console.WriteLine("Wrong input!");
            }
            else
            {
                Console.WriteLine(reply.MName + " , " + reply.MGender + " , " + reply.MAge + " years old.");
            }

            await Task.Delay(1000);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

}
