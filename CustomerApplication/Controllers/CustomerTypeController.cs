using CustomerApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerApplication.Controllers
{
    public class CustomerTypeController : Controller
    {
        private readonly CustomerEntities _dbContext = new CustomerEntities();
        // GET: CustomerType
        public ActionResult Index()
        {
            var customerTypeAndCount = _dbContext.Customer_CustomerType.GroupBy(x => x.CustomerTypeID).Select(x => new CustomerTypeCount
            {
                customerTypeID = x.Key.Value,
                CustomerType = x.FirstOrDefault().CustomerType.Type,
                Count = x.Count()
            }).ToList();
            return View(customerTypeAndCount.ToList());
        }

        public ActionResult Edit(int id)
        {
            return RedirectToAction("Details", "TypeBasedCustomerDetails", new { id = id});
        }
    }
}
