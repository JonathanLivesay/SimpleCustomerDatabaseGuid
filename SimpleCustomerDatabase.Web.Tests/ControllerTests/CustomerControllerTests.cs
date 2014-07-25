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
    public class CustomerControllerTests
    {

        private ViewResult viewResult;
        private Customer customer1;
        private Customer customer2;
        private CustomerController customerController;
        private List<Customer> customers;

        [SetUp]
        public void SetUp()
        {


            viewResult = customerController.Index() as ViewResult;
        }

        [Test]
        public void When_A_Customer_Logs_In_They_Should_Go_To_The_Index_View()
        {
            ViewResult result = customerController.Index() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("", result.ViewName);
        }

        [Test]
        public void When_No_Customer_Is_In_The_Model_Then_View_Result_Should_Be_The_First_Page()
        {
            Customer customer = null;

        }


    }
}
