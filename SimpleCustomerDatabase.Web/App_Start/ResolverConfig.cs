using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using System.Linq;
using SimpleCustomerDatabase.Web.Controllers;
using SimpleCustomerDatabase.Domain;


namespace SimpleCustomerDatabase.Web.App_Start
{
    public class ResolverConfig
    {
        public static SimpleCustomerDatabase.Domain.Customer instance;

        public static void Register()
        {

            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(ResolverConfig).Assembly);
            builder.Register<SimpleCustomerDatabase.Domain.Customer>(c => instance);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }

        private static void CreateDummyCustomer()
        {

            instance = new Customer()
                {
                    FirstName = "James",
                    LastName = "Bond",
                    Email = "James.Bond@customer.com",
                    PhoneNumber = "214.555.1212",
                    CompanyName = "Company Work",
                    CompanyStreet1 = "2525 Alta Vista Dr.",
                    CompanyStreet2 =  "Suite 400",
                    CompanyCity = "Addison",
                    CompanyState = "TX",
                    CompanyPostalCode = "75087",
                };

        }
        
        
    }
}