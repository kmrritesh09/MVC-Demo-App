using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerApplication.Models
{
    public class TypeCustomers
    {
        public int CustomerTypeID { get; set; }
        public string CustomerTypeDescription { get; set; }
        public List<CustomerObject> CurrentCustomers { get; set; }
        public List<CustomerObject> AvailableCustomers { get; set; }
    }
}