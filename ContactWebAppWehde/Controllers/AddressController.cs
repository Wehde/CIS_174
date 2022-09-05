using ContactWebAppWehde.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactWebAppWehde.Controllers
{
    public class AddressController : Controller
    {
        private ContactContext context { get; set; }

        public AddressController(ContactContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Address());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var address = context.Addresses.Find(id);
            return View(address);
        }

        [HttpPost]
        public IActionResult Edit(Address address)
        {
            if (ModelState.IsValid)
            {
                if (address.AddressID == 0)
                    context.Addresses.Add(address);
                else
                    context.Addresses.Update(address);
                context.SaveChanges();
                return RedirectToAction("Address", "Home");
            }
            else
            {
                ViewBag.Action = (address.AddressID == 0) ? "Add" : "Edit";
                return View(address);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var address = context.Addresses.Find(id);
            return View(address);
        }

        [HttpPost]
        public IActionResult Delete(Address address)
        {
            context.Addresses.Remove(address);
            context.SaveChanges();
            return RedirectToAction("Address", "Home");
        }
    }
}
