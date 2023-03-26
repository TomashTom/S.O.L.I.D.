using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public interface IDataAccess
    {
        void Save(Customer customer);
        void Update(Customer customer);


    }
}
