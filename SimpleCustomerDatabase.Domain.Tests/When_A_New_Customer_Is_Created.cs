using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCustomerDatabase.Domain.Tests
{
    [TestFixture]
    class When_A_New_Customer_Is_Created
    {
        
        private Customer customer;

        [SetUp]
        public void SetUp()
        {
            customer = new Customer()
            {
                FirstName = "James",
                LastName = "Bond",
                CompanyName = "Improving",
                Email = "james.bond@improving.com",
                PhoneNumber = "888.555.1212",
                CompanyStreet1 = "224 History Way",
                CompanyStreet2 = "",
                CompanyCity = "Addison",
                CompanyState = "TX",
                CompanyPostalCode = "75001",
            };
        }

        [Test]
        public void FirstName_Should_Not_Be_Blank()
        {
            Assert.IsNotNullOrEmpty(customer.FirstName);
        }

        [Test]
        public void LastName_Should_Not_Be_Blank()
        {
            Assert.IsNotNullOrEmpty(customer.LastName);
        }
        [Test]
        public void CompanyName_Should_Not_Be_Blank()
        {
            Assert.IsNotNullOrEmpty(customer.CompanyName);
        }
        [Test]
        public void Email_Should_Not_Be_Blank()
        {
            Assert.IsNotNullOrEmpty(customer.Email);
        }
        [Test]
        public void PhoneNumber_Should_Not_Be_Blank()
        {
            Assert.IsNotNullOrEmpty(customer.PhoneNumber);
        }






    }
}
