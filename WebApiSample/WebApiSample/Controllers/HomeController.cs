using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApiSample.Models;

namespace WebApiSample.Controllers
{
	public class HomeController :ApiController
	{
		public StudentModel GetStudent()  
        {  
            return new StudentModel  
            {  
                Name = "Sandeep",  
                Age = 27  
            };  
        }  
	}
}
