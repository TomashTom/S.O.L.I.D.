using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class FileDataAccess : IDataAccess
    {
        private readonly string _filePath;

        public FileDataAccess(string filePath)
        {
            _filePath = filePath;
        }

        public void Save(Customer customer)
        {
            // Code to save customer to file
            using (StreamWriter writer = File.AppendText("C:\\Users\\smols\\source\\repos\\Program\\file.txt"))
            {
                writer.WriteLine($"{customer.FirstName}, {customer.LastName}, {customer.Email}");
            }
            Console.WriteLine("Saving customer to file: {0} {1}", customer.FirstName, customer.LastName);
        }

        public void Update(Customer customer)
        {
            // Code to update customer in file
            string[] lines = File.ReadAllLines("C:\\Users\\smols\\source\\repos\\Program\\file.txt");
            using (StreamWriter writer = new StreamWriter("C:\\Users\\smols\\source\\repos\\Program\\file.txt"))
            {
                foreach (string line in lines)
                {
                    string[] fields = line.Split(',');
                    if (fields[0].Trim().Equals(customer.FirstName) && fields[1].Trim().Equals(customer.LastName))
                    {
                        writer.WriteLine($"{customer.FirstName}, {customer.LastName}, {customer.Email}");
                    }
                    else
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            Console.WriteLine("Updating customer in file: {0} {1}", customer.FirstName, customer.LastName);
        }
    }
}
