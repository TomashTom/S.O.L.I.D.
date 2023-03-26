using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class MulticastDelegateExample
    {
        public delegate void MulticastDelegate(Customer customer);

        public event MulticastDelegate MulticastDelegateEvent;

        public void InvokeMulticastDelegate()
        {
            var customer = new Customer("John", "Doe", "john.doe@example.com");

            Console.WriteLine("Invoking Multicast Delegate Example");

            if (MulticastDelegateEvent != null)
            {
                MulticastDelegateEvent(customer);
            }
        }
    }
}
