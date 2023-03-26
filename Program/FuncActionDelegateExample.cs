using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class FuncActionDelegateExample
    {
        public void FuncDelegateExample()
        {
            Func<Customer, bool> funcDelegate = customer => customer.Email.Contains("@");

            var customer1 = new Customer("John", "Doe", "john.doe@example.com");
            var customer2 = new Customer("Jane", "Doe", "jane.doe");

            Console.WriteLine("Func Delegate Example:");
            Console.WriteLine("Does customer1 email contain @? {0}", funcDelegate(customer1));
            Console.WriteLine("Does customer2 email contain @? {0}", funcDelegate(customer2));
        }

        public void ActionDelegateExample()
        {
            Action<Customer> actionDelegate = customer => Console.WriteLine("Action Delegate Example: Saving customer {0} {1}", customer.FirstName, customer.LastName);

            var customer = new Customer("John", "Doe", "john.doe@example.com");

            Console.WriteLine("Action Delegate Example:");
            actionDelegate(customer);
        }
    }
}
