using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleCustomerDatabase.Domain;
using SimpleCustomerDatabase.Web.Models;
using Highway.Data;

namespace SimpleCustomerDatabase.Web.Controllers
{
    public class CustomerController : Controller
    {

        public CustomerController(Customer customer)
        {
            this.Customer = customer;
        }

        public Customer Customer { get; set; }


        // GET: Customer
        public ActionResult Index()
        {
            var customerModel = new CustomerModels();
            
            string connectionString = "Server=.;Database=SimpleCustomerDatabase_db;Integrated Security=true";
            MappingConfig mappingConfig = new MappingConfig();
            DataContext context = new DataContext(connectionString, mappingConfig);
            Repository repo = new Repository(context);

            customerModel.Customers.Add(Customer);

            foreach (var customer in customerModel.Customers)
                repo.Context.Add<Customer>(customer);

            repo.Context.Commit();
            
            return View(customerModel);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
