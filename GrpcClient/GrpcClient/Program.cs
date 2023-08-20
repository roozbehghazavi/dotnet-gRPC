using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcClient;
 // Import your .proto-generated namespace

class Program
{
    static async Task Main(string[] args)
    {
        var channel = GrpcChannel.ForAddress("http://localhost:5016");
        var client = new CustomerService.CustomerServiceClient(channel);

        // Add a few customers
        Random random = new Random();

        int randomId = random.Next(1000, 9999); // Generates a random integer between 1000 and 9999

        await AddCustomerAsync(client, randomId.ToString(), 1990,500,30);

        // List all customers
        await ListCustomersAsync(client);
        await ListCustomerAgesAsync(client);
    }

    static async Task AddCustomerAsync(CustomerService.CustomerServiceClient client, string id, int birthYear ,int walletBalance, int totalCart)
    {
        var customer = new ProtoCustomer
        {
            Id = id,
            BirthYear = birthYear,
            WalletBalance = walletBalance,
            TotalCart = totalCart
        };
        await client.AddCustomerAsync(customer);
        Console.WriteLine($"Added Customer - ID: {id}, Birth Year: {birthYear}, Wallet Balance: {walletBalance}, Total Cart: {totalCart}");
    }

    static async Task ListCustomersAsync(CustomerService.CustomerServiceClient client)
    {
        var customersListRequest = new ProtoEmpty();
        var customersListResponse = await client.GetCustomersListAsync(customersListRequest);

        Console.WriteLine("List of Customers:");
        foreach (var protoCustomer in customersListResponse.Customers)
        {
            Console.WriteLine($"Customer ID: {protoCustomer.Id}, Birth Year: {protoCustomer.BirthYear}, Wallet Balance: {protoCustomer.WalletBalance}, Total Cart: {protoCustomer.TotalCart}");
        }
    }
    static async Task ListCustomerAgesAsync(CustomerService.CustomerServiceClient client)
    {
        var request = new CustomerRequest();
        var response = await client.GetCustomerAgeAsync(request);

        Console.WriteLine("List of Customer Ages:");
        foreach (var age in response.Age)
        {
            Console.WriteLine($"Age: {age}");
        }
    }
}
