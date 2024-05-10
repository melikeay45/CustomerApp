using CustomerApp.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Domain.Services
{
    public interface ICustomerService
    {
        void Add(CustomerAddDto customerCreateDto);
        List<CustomerListDto> List();
        
    }
}
