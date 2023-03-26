using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class CustomDelegateExample
    {
        public delegate void CustomerDelegate(Customer customer);

        public event CustomerDelegate CustomDelegateEvent;

        public void InvokeCustomDelegate()
        {
            var customer = new Customer("John", "Doe", "johndoe@example.com");
            Console.WriteLine("Invoking custom delegate event");
            CustomDelegateEvent?.Invoke(customer);
        }

    }
}
