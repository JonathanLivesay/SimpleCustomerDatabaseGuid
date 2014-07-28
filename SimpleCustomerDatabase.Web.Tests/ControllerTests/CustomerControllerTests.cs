using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using SimpleCustomerDatabase.Web.Controllers;
using SimpleCustomerDatabase.Domain;
using NUnit.Framework;
using Highway.Data.Contexts;
using Highway.Data;


namespace SimpleCustomerDatabase.Web.Tests.ControllerTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        private InMemoryDataContext context;
        private IRepository repo;
        private ViewResult viewResult;
        private Customer customer1;
        private Customer customer2;
        private CustomerController customerController;
        private List<Customer> customers;

        [SetUp]
        public void SetUp()
        {
            context = new InMemoryActiveDataContext();
            repo = new Repository(context);
            customerController = new CustomerController(repo);
        }

        [Test][Ignore]
        public void If_There_Are_No_Customers_In_The_Database_Then_The_First_View_Will_Come_Up()
        {
            ViewResult result = customerController.First() as ViewResult;

            Assert.IsNotNull(result);
        }

        [Test][Ignore]
        public void If_There_Is_A_Customer_In_The_Database_Then_We_Should_Get_The_Index_Of_the_Customer_Controller()
        {
            

        }


    }
}
