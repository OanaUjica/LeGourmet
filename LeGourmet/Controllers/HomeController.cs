using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeGourmet.Models;
using LeGourmet.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LeGourmet.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactRepository _contactRepository;

        public HomeController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactComplete(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _contactRepository.AddContact(contact);
                return View();
            }
            return RedirectToAction("Index",contact);
        }
    }
}