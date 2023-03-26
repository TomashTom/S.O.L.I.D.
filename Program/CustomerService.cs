using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class CustomerService
    {
        private readonly IDataAccess _dataAccess;
        public CustomerService(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void SaveCustomer(Customer customer)
        {
            _dataAccess.Save(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            _dataAccess.Update(customer);
        }

    }
}
