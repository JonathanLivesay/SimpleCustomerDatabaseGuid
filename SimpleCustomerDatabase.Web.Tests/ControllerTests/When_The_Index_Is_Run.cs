using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using SimpleCustomerDatabase.Web.Controllers;
using SimpleCustomerDatabase.Domain;
using NUnit.Framework;


namespace SimpleCustomerDatabase.Web.Tests.ControllerTests
{


    [TestFixture]
    public class When_The_Index_Is_Run
    {


        private Customer customer1;
        private Customer customer2;
        private CustomerController customerController;
        private List<Customer> customers;

        [SetUp]
        public void SetUp()
        {


        }

        [Test]
        public void When_A_Customer_Logs_In_They_Should_Go_To_The_Index_View()
        {

        }
    }
}
