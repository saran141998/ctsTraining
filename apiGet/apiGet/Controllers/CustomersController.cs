using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace apiGet.Controllers
{
    
    public class CustomersController : ApiController
    {
        eticketingEntities e = new eticketingEntities();


        [HttpGet]
        public IEnumerable<Customer> Get()
        { 
           
            return e.Customers;
        }
        public IEnumerable<Customer> Get(string id)
        {
            int customerId = Convert.ToInt32(id);
            return e.Customers.ToList().Where(s=>s.CustomerID==customerId);
        }
    }
    
}
