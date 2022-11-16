using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Moq;
using Ticket.Models;
using Ticket.Repository;

namespace TicketTest
{
    public class TicketRepositoryTests
    {
        DbContextOptions<TicketContext> options = new DbContextOptionsBuilder<TicketContext>()
                .UseInMemoryDatabase("Filename=test.db")
                .ConfigureWarnings(x => x.Ignore(InMemoryEventId.TransactionIgnoredWarning))
                .Options;

        [Fact]
        public void GetAllTickets_Test()
        {
            //Arrange
            TicketContext context = new TicketContext(options);
            context.Tickets.Add(new Ticket.Models.Ticket()
            {
                Id = 1,
                Name = "Ticket 1",
                Description = "Test 1",
                DueDate = new DateTime(2022, 12, 12),
                SprintNumber = "1",
                PointValue = "2",
                StatusId = "todo",
                Status = new Status()
                {
                    StatusId = "todo",
                    Name = "To Do"
                }
            });
            context.Tickets.Add(new Ticket.Models.Ticket()
            {
                Id = 2,
                Name = "Ticket 2",
                Description = "Test 2",
                DueDate = new DateTime(2022, 12, 24),
                SprintNumber = "2",
                PointValue = "10",
                StatusId = "progress",
                Status = new Status()
                {
                    StatusId = "progress",
                    Name = "In Progress"
                }
            });
            context.SaveChanges();

            //Action
            TicketRepository repo = new TicketRepository(context);
            var tickets = repo.GetAllTickets();

            //Assert
            Assert.Equal(2, tickets.Count);
        }
    }
}
