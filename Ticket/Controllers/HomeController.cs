using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ticket.Models;
using Ticket.Repository;

namespace Ticket.Controllers
{
    public class HomeController : Controller
    {
        private ITicketRepository ticketRepository;
        public HomeController(ITicketRepository repo)
        {
            ticketRepository = repo;
        }

        public IActionResult Index(string id)
        {
            var filters = new Filters(id);
            ViewBag.Filters = filters;
            ViewBag.Statuses = ticketRepository.GetAllStatuses();
            ViewBag.DueFilters = Filters.DueFilterValues;

            IQueryable<Models.Ticket> query = ticketRepository.GetQuery();
            if (filters.HasStatus)
            {
                query = query.Where(t => t.StatusId == filters.StatusId);
            }
            if (filters.HasDue)
            {
                var today = DateTime.Today;
                if (filters.IsPast)
                    query = query.Where(t => t.DueDate < today);
                else if (filters.IsFuture)
                    query = query.Where(t => t.DueDate > today);
                else if (filters.IsToday)
                    query = query.Where(t => t.DueDate == today);
            }

            var tickets = query.OrderBy(t => t.DueDate).ToList();
            return View(tickets);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Statuses = ticketRepository.GetAllStatuses();
            return View();
        }

        [HttpPost]
        public IActionResult Add(Models.Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                ticketRepository.InsertTicket(ticket);
                ticketRepository.Save();
                return RedirectToAction("Index");
            } 
            else
            {
                ViewBag.Statuses = ticketRepository.GetAllStatuses();
                return View(ticket);
            }
        }

        [HttpPost]
        public IActionResult Filter(string[] filter)
        {
            string id = string.Join('-', filter);
            return RedirectToAction("Index", new { ID = id });
        }

        [HttpPost]
        public IActionResult Edit([FromRoute] string id, Models.Ticket selected)
        {
            if (selected.StatusId == null)
            {
                ticketRepository.DeleteTicket(selected);
            }
            else
            {
                string newStatusId = selected.StatusId;
                selected = ticketRepository.Find(selected.Id);
                selected.StatusId = newStatusId;
                ticketRepository.UpdateTicket(selected);
            }
            ticketRepository.Save();
            return RedirectToAction("Index", new { ID = id });
        }
    }
}