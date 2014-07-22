using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleCustomerDatabase.Domain;
namespace SimpleCustomerDatabase.Web.Models
{
    public class CustomerModels
    {

        private List<Customer> customers;

        public List<Customer> Customers
        {
            get
            {
                if (customers != null)
                    return customers;
                else
                    customers = new List<Customer>();

                return customers;
            }
            set
            {
            	customers = value;
            }
        }

    }
}