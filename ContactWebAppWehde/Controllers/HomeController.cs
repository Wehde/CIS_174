using ContactWebAppWehde.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ContactWebAppWehde.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }

        public HomeController(ContactContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var contacts = context.Contacts.Include(c => c.Address).OrderBy(c => c.Name).ToList();
            return View(contacts);
        }

        public IActionResult Address()
        {
            var addresses = context.Addresses.OrderBy(a => a.State).ToList();
            return View(addresses);
        }
    }
}