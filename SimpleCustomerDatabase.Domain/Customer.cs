using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCustomerDatabase.Domain
{
    public class Customer
    {

        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string CompanyName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [PhoneNumber]
        public string PhoneNumber { get; set; }

        public string CompanyStreet1 { get; set; }

        public string CompanyStreet2 { get; set; }

        public string CompanyCity { get; set; }

        public string CompanyState { get; set; }

        public string CompanyPostalCode { get; set; }
    }
}
