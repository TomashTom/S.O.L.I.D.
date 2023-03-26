using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDataAccess dataAccess = new FileDataAccess("C:\\Users\\smols\\source\\repos\\Program\\file.txt");
            var customerService = new CustomerService(dataAccess);

            Console.WriteLine("Welcome to the Customer Management System!");
            Console.WriteLine("Please select an option:");

            while (true)
            {
                Console.WriteLine("\n1. Add a customer");
                Console.WriteLine("2. Update a customer");
                Console.WriteLine("3. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("\nEnter customer details:");

                        Console.Write("First name: ");
                        string firstName = Console.ReadLine();

                        Console.Write("Last name: ");
                        string lastName = Console.ReadLine();

                        Console.Write("Email: ");
                        string email = Console.ReadLine();

                        var customer = new Customer(firstName, lastName, email);

                        customerService.SaveCustomer(customer);

                        Console.WriteLine("Customer saved successfully!");
                        break;

                    case "2":
                        Console.WriteLine("\nEnter customer details:");

                        Console.Write("First name: ");
                        string firstNameToUpdate = Console.ReadLine();

                        Console.Write("Last name: ");
                        string lastNameToUpdate = Console.ReadLine();

                        Console.Write("Email: ");
                        string emailToUpdate = Console.ReadLine();

                        var customerToUpdate = new Customer(firstNameToUpdate, lastNameToUpdate, emailToUpdate);

                        customerService.UpdateCustomer(customerToUpdate);

                        Console.WriteLine("Customer updated successfully!");
                        break;

                    case "3":
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }
    }
}
