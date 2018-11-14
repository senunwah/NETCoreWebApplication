using DataLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using NETCoreWebApplication.Models;
using System.Threading;

namespace NETCoreWebApplication.Controllers
{
    public class HomeController : Controller
    {
        PersonDataList pdl = new PersonDataList();
        Person p = new Person();
        Shoe s = new Shoe();
        PersonShoe ps = new PersonShoe();
        public List<SelectListItem> AgeList, GenderList;

        public HomeController()
        {
            pdl.GetList();
            AgeList = pdl.AgeList;
            GenderList = pdl.GenderList;
        }

       
        public IActionResult Index()
        {
            return View();
        }
        
        
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(InsertPersonShoeModel model)
        {
            Thread t = new Thread(() => p.InsertPerson(model.Name, model.Age.ToString(), model.Gender));
            t.Start();

            Thread d = new Thread(() => s.InsertShoe(model.ShoeName, model.ShoeBrand));
            d.Start();

            Thread f = new Thread(()=> PersonShoe(model));
            f.Start();

            ModelState.Clear();

            return View(new InsertPersonShoeModel());
        }

        public void PersonShoe(InsertPersonShoeModel model)
        {
            ps.GetPersonID(model.Name);
            ps.GetShoeID(model.ShoeName, model.ShoeBrand);
            ps.InsertID();
        }

    }
}
