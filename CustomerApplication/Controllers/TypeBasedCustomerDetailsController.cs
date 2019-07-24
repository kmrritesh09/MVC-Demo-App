using CustomerApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerApplication.Controllers
{
    public class TypeBasedCustomerDetailsController : Controller
    {
        private readonly CustomerEntities _dbContext = new CustomerEntities();

        // GET: TypeBasedCustomerDetails
        public ActionResult Index(int id)
        {
            return View();
        }

        // Display customer type details
        public ActionResult Details(int id)
        {
            var currentCustomers = 
                _dbContext.Customer_CustomerType.Where(x => x.CustomerTypeID == id)
                .Join(_dbContext.Customers, x => x.CustomerID, y => y.ID, (x,y) => new CustomerObject{
                CustomerID = y.ID,
                CustomerName = y.NAME
            }).ToList();
            var currentCustomersIDs = currentCustomers.Select(x => x.CustomerID);
            var availableCustomers = _dbContext.Customers.Where(x => !currentCustomersIDs.Contains(x.ID)).Select(x => new CustomerObject {
                CustomerID = x.ID,
                CustomerName = x.NAME
            }).ToList();
            var customerType = _dbContext.CustomerTypes.First(x => x.ID == id);
            var typeCustomerDetails = new TypeCustomers{
                CustomerTypeID = customerType.ID,
                CustomerTypeDescription = customerType.Type,
                AvailableCustomers = availableCustomers,
                CurrentCustomers = currentCustomers
            };
            return View(typeCustomerDetails);
        }

        // GET: TypeBasedCustomerDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeBasedCustomerDetails/Create
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

        // GET: TypeBasedCustomerDetails/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TypeBasedCustomerDetails/Edit/5
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

        // GET: TypeBasedCustomerDetails/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TypeBasedCustomerDetails/Delete/5
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
