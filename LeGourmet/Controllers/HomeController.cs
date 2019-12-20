using LeGourmet.Models;
using LeGourmet.Services;
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
            if (ModelState.IsValid && contact != null)
            {
                _contactRepository.AddContact(contact);
                return View();
            }
            return RedirectToAction(nameof(Index),contact);
        }
    }
}