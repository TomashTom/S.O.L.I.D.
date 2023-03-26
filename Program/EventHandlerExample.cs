using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class EventHandlerExample
    {
        public event EventHandler<CustomerEventArgs> EventHandlerEvent;

        public void InvokeEventHandler()
        {
            var customer = new Customer("John", "Doe", "john.doe@example.com");

            Console.WriteLine("Invoking Event Handler Example");

            if (EventHandlerEvent != null)
            {
                EventHandlerEvent(this, new CustomerEventArgs(customer));
            }
        }
    }
}
