using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class MyDbContext
    {
        private readonly List<Customer> _customers;

        public MyDbContext()
        {
            _customers = new List<Customer>();
        }

        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
            Console.WriteLine("Customer added: " + customer.ToString());
        }

        public List<Customer> GetAllCustomers()
        {
            return _customers;
        }
    }
}

