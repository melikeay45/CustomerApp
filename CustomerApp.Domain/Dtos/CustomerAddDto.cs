﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Domain.Dtos
{
    public class CustomerAddDto
    {
        public string Name { get; set; }    
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
    }
}
