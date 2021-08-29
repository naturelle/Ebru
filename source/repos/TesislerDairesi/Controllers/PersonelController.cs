using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesislerDairesi.Models;

namespace TesislerDairesi.Controllers
{
    public class PersonelController : Controller
    {
        static List<PersonelModel> personels = new List<PersonelModel>();
        public IActionResult Index()
        {
            return View(personels);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Details(PersonelModel personel)
        {
            personels.Add(personel);
            return View("Details", personel);
        }
    }
}
