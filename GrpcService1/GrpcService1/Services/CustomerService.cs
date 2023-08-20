using Grpc.Core;
using GrpcService1;
using GrpcService1.Models;
using Google.Protobuf.WellKnownTypes;
using System.Linq;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace GrpcService1.Services
{
    public class Customerservice : CustomerService.CustomerServiceBase

    {
        private readonly MongoDbContext _mongoDbContext;
        private static readonly Dictionary<string, Customer> _customerDatabase = new Dictionary<string, Customer>();
        public Customerservice(IConfiguration configuration)
        {
            _mongoDbContext = new MongoDbContext(configuration);
        }
        public override async Task<ProtoEmpty> AddCustomer(ProtoCustomer request, ServerCallContext context)
        {
            //var customerModel = new Customer
            //{
            //    Id = request.Id,
            //    BirthYear = request.BirthYear,
            //    WalletBalance = request.WalletBalance,
            //    TotalCart = request.TotalCart
            //};

            //_customerDatabase.Add(customerModel.Id, customerModel);

            var mongoCustomer = new MongoCustomer
            {
                CustomerId = request.Id,
                BirthYear = request.BirthYear,
                WalletBalance = request.WalletBalance,
                TotalCart = request.TotalCart
            };

            await _mongoDbContext.Customers.InsertOneAsync(mongoCustomer);
            return await Task.FromResult(new ProtoEmpty());
        }
        public override async Task<CustomerAgeResponse> GetCustomerAge(CustomerRequest request, ServerCallContext context)
        {

            var mongoCustomers = await _mongoDbContext.Customers.Find(_ => true).ToListAsync();

            var response = new CustomerAgeResponse();
            foreach (var mongoCustomer in mongoCustomers)
            {
                int age = DateTime.UtcNow.Year - mongoCustomer.BirthYear;
                response.Ages.Add(age);
            }

            return response;
        }
        public async override Task<CustomersListResponse> GetCustomersList(ProtoEmpty request, ServerCallContext context)
        {
            var mongoCustomers = await _mongoDbContext.Customers.Find(_ => true).ToListAsync();

            var response = new CustomersListResponse();
            foreach (var mongoCustomer in mongoCustomers)
            {
                var protoCustomer = new ProtoCustomer
                {
                    Id = mongoCustomer.CustomerId,
                    BirthYear = mongoCustomer.BirthYear,
                    WalletBalance = mongoCustomer.WalletBalance,
                    TotalCart = mongoCustomer.TotalCart
                };
                response.Customers.Add(protoCustomer);
            }

            return response;
        }
    }
}