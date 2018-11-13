using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NETCoreWebApplication.Models;
using ClassLibrary;
using System.Threading;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.SqlClient;

namespace NETCoreWebApplication.Controllers
{
    public class HomeController : Controller
    {
        
       
        public IActionResult Index()
        {
            return View();
        }
        
        
        public IActionResult InsertPerson()
        {
            
            return View();
        }

        
        public IActionResult InsertShoe()
        {
            
            return View();
        }

        
        public IActionResult InsertPersonShoe()
        {
            
            return View();
        }


    }
}
