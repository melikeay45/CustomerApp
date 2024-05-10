using CustomerApp.Domain.Dtos;
using CustomerApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Domain.Services
{
    public class NotepadDbCustomerServices : ICustomerService
    {
        private readonly string _filePath;


        public NotepadDbCustomerServices()
        {
            _filePath = "C:\\Users\\Melike Aydın\\Desktop\\UNDPBootcamp\\BootcampBenimProjelerim\\CustomerApp\\CustomerApp.Domain\\TextDb.txt";
        }

        public void Add(CustomerAddDto customerAddDto)
        {
            string saveData=$"{Guid.NewGuid()},{customerAddDto.Name},{customerAddDto.Surname}";

            File.AppendAllText(_filePath, saveData);
        }

        public List<CustomerListDto> List()
        {
             List<CustomerListDto> customers = new();

            string allText = File.ReadAllText(_filePath);

            string[] lines = allText.Split("\r\n");

            foreach(string line in lines)
            {
                var data = line.Split(",");

                CustomerListDto customerListDto = new()
                {
                    Id = Guid.Parse(data[0]),
                    Name = data[1]
                };
                customers.Add(customerListDto);
            }
            return customers;

        }
    }
}
