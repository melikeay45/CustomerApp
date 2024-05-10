using CustomerApp.Domain.Dtos;
using CustomerApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Domain.Services
{
    public class InMemoryCustomerService : ICustomerService
    {
        static List<Customer> customers = new();

        public void Add(CustomerAddDto customerAddDto)
        {
            Customer customer = new()
            {
                Id = Guid.NewGuid(),
                Name = customerAddDto.Name,
                Surname = customerAddDto.Surname,
            };
            customers.Add(customer);
        }

        public List<CustomerListDto> List()
        {
            return customers.Select(x => new CustomerListDto()
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();
        }
    }
}
