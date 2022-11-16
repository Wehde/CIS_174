using Microsoft.AspNetCore.Mvc;
using Xunit;
using Moq;
using Ticket.Repository;
using Ticket.Controllers;
using Ticket.Models;
using Microsoft.EntityFrameworkCore;

namespace Ticket.Tests
{
    public class HomeControllerTests
    {
        /*
         * public IActionResult Index(string id)
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
         */

        [Fact]
        public void Index_Test()
        {
            //Arrange
            var mockRepo = new Mock<ITicketRepository>();
            List<Models.Ticket> tickets = new List<Models.Ticket>()
            {
                new Models.Ticket()
                {
                    Id = 1,
                    Name = "Ticket 1",
                    Description = "Test 1",
                    DueDate = new DateTime(2022, 12, 12),
                    SprintNumber = "1",
                    PointValue = "2",
                    StatusId = "todo",
                    Status = new Models.Status()
                    {
                        StatusId = "todo",
                        Name = "To Do"
                    }
                },
                new Models.Ticket()
                {
                    Id = 2,
                    Name = "Ticket 2",
                    Description = "Test 2",
                    DueDate = new DateTime(2022, 12, 24),
                    SprintNumber = "2",
                    PointValue = "10",
                    StatusId = "progress",
                    Status = new Models.Status()
                    {
                        StatusId = "progress",
                        Name = "In Progress"
                    }
                }
            };
            List<Status> statuses = new List<Status>()
            {
                new Status { StatusId = "todo", Name = "To Do"},
                new Status { StatusId = "progress", Name = "In Progress"},
                new Status { StatusId = "qa", Name = "Quality Assurance" },
                new Status { StatusId = "done", Name = "Done" }
            };
            mockRepo.Setup(r => r.GetAllTickets()).Returns(tickets);
            mockRepo.Setup(r => r.GetAllStatuses()).Returns(statuses);
            mockRepo.Setup(r => r.GetQuery()).Returns(tickets.AsQueryable());
            HomeController controller = new HomeController(mockRepo.Object);

            //Action
            var result = controller.Index("all-all");

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<List<Models.Ticket>>(viewResult.Model);
            Assert.Equal(2, model.Count());
        }
    }
}
