using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCoreCustomerProject.Models {

    public class Customer {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Sales { get; set; }
        public bool Active { get; set; }

        public Customer() {

        }

    }
}
