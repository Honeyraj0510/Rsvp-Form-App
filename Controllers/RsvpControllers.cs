using Microsoft.AspNetCore.Mvc;
using RsvpApp.Models;

namespace RsvpApp.Controllers
{
    public class RsvpController : Controller
    {
        private readonly RsvpContext _context;

        public RsvpController(RsvpContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Rsvp model)
        {
            if (ModelState.IsValid)
            {
                _context.Rsvps.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Thanks");
            }
            return View(model);
        }

        public IActionResult Thanks()
        {
            return View();
        }

        public IActionResult List()
        {
            var responses = _context.Rsvps.ToList();
            return View(responses);
        }
    }
}
