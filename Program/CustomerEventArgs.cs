using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class CustomerEventArgs : EventArgs
    {

        public Customer Customer { get; set; }
        public CustomerEventArgs(Customer customer)
        {
            Customer = customer;
        }

    }
}
