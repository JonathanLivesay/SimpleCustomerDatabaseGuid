using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleCustomerDatabase.Domain;
using SimpleCustomerDatabase.Web.Models;
using SimpleCustomerDatabase.Web.Persistence;
using Highway.Data;

namespace SimpleCustomerDatabase.Web.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        private IRepository repo;

        public CustomerController(IRepository repo)
        {
            this.repo = repo;
        }
        
        // GET: Customer

        public ActionResult Index()
        {
            var customerModel = new CustomerModels();
            
            customerModel.Customers = repo.Find(new FindAll<Customer>()).ToList();

            if (customerModel.Customers.Count == 0)
            {
                return RedirectToAction("First");
            } 
 
            repo.Context.Commit();

            customerModel.Customers.OrderBy(c => c.DateCreated);
            
            return View(customerModel);
        }

        // GET: Customer/Details/5
        [HttpGet]
        public ActionResult Details(Guid id)
        {
            Customer customer = repo.Find(new FindById(id));

            return View("Details", customer);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {


            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
        {

            customer.DateCreated = DateTime.Now;
            customer.DateUpdated = DateTime.Now;
            repo.Context.Add<Customer>(customer);

            repo.Context.Commit();

            return RedirectToAction("Index", "Customer");
        }

        // GET: Customer/Edit/5
        [HttpGet]
        public ActionResult EditGet(Guid id)
        {
            Customer customer = repo.Find(new FindById(id));

            return View("Edit", customer);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, Customer customer)
        {

            Customer originalCustomer = repo.Find(new FindById(id));

            originalCustomer.FirstName = customer.FirstName;
            originalCustomer.LastName = customer.LastName;
            originalCustomer.CompanyName = customer.CompanyName;
            originalCustomer.Email = customer.Email;
            originalCustomer.PhoneNumber = customer.PhoneNumber;
            originalCustomer.CompanyStreet1 = customer.CompanyStreet1;
            originalCustomer.CompanyStreet2 = customer.CompanyStreet2;
            originalCustomer.CompanyCity = customer.CompanyCity;
            originalCustomer.CompanyState = customer.CompanyState;
            originalCustomer.CompanyPostalCode = customer.CompanyPostalCode;
            originalCustomer.DateUpdated = DateTime.Now;

            repo.Context.Commit();

            return RedirectToAction("Details", originalCustomer);

            //try
            //{
            //    // TODO: Add update logic here

            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
        }

        // GET: Customer/Delete/5
        [HttpGet]
        public ActionResult DeleteConfirm(Guid id)
        {
            var customer = repo.Find(new FindById(id));

            return View("Delete", customer);
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id)
        {
            var customer = repo.Find(new FindById(id));

            repo.Context.Remove(customer);
            
            repo.Context.Commit();

            return RedirectToAction("Index");
            
            //}
        }

        public ActionResult First()
        {
            return View();
        }
    }

}
