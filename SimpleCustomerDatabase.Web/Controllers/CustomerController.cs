﻿using System;
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
    public class CustomerController : Controller
    {

        // private CustomerModels customerModel;
        private Repository repo;
        private string connectionString;

        private bool serverConnection = true;

        public CustomerController(Customer customer)
        {
            this.Customer = customer;

            if (serverConnection == true)
                connectionString = "Data Source=tcp:vsv9sujxvr.database.windows.net,1433;Initial Catalog=simplecustomerdatabase_db;User ID=DatabaseUser135@vsv9sujxvr;Password=13579CustomerDatabase!";
            else 
                connectionString = "Server=.;Database=SimpleCustomerDatabase_db;Integrated Security=true";
            
            MappingConfig mappingConfig = new MappingConfig();
            DataContext context = new DataContext(connectionString, mappingConfig);
            repo = new Repository(context);
        }

        public Customer Customer { get; set; }


        // GET: Customer
        public ActionResult Index()
        {
            var customerModel = new CustomerModels();
            
            customerModel.Customers = repo.Find(new FindAll<Customer>()).ToList();

            if (customerModel.Customers.Count == 0)
            {
                customerModel.Customers.Add(Customer);
                
                foreach (var customer in customerModel.Customers)
                    repo.Context.Add<Customer>(customer);
            } 
               
            repo.Context.Commit();
            
            return View(customerModel);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            Customer customer = repo.Find(new FindById(id));

            //return RedirectToAction("Edit", "Customer", customer);

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

            repo.Context.Add<Customer>(customer);

            repo.Context.Commit();

            return RedirectToAction("Index","Customer");

            //try
            //{
            //    // TODO: Add insert logic here

            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            Customer customer = repo.Find(new FindById(id));

            return View("Edit", customer);


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
        public ActionResult Delete(Customer customer)
        {



            return RedirectToAction("Index", "Customer");
            

            //try
            //{
            //    // TODO: Add delete logic here

            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
        }
    }
}
