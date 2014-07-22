using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCustomerDatabase.Domain
{
    public class Customer
    {
        private Guid id;
        public Guid Id
        {
            get
            {
                if (id != null)
                    return id;
                else
                    id = Guid.NewGuid();

                return id;
            }
            set 
            {
                id = value;
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string CompanyName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string CompanyStreet1 { get; set; }

        public string CompanyStreet2 { get; set; }

        public string CompanyCity { get; set; }

        public string CompanyState { get; set; }

        public string CompanyPostalCode { get; set; }
    }
}
