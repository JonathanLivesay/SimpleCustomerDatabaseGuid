using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCustomerDatabase.Domain
{
    interface ICustomerRepository
    {
        void AddCustomer(Customer customer);

        void DeleteCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void ReadCustomer(Customer customer);

    }
}
