using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class GenericDelegateExample
    {
        public delegate void GenericDelegate<T>(T value);

        public event GenericDelegate<Customer> GenericDelegateEvent;

        public void InvokeGenericDelegate()
        {
            var customer = new Customer("John", "Doe", "john.doe@example.com");

            Console.WriteLine("Invoking Generic Delegate Example");

            if (GenericDelegateEvent != null)
            {
                GenericDelegateEvent(customer);
            }
        }
    }
}
