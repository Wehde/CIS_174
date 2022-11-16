using Microsoft.EntityFrameworkCore;
using Ticket.Models;

namespace Ticket.Repository
{
    public class TicketRepository : ITicketRepository
    {
        private TicketContext context;

        public TicketRepository(TicketContext context)
        {
            this.context = context;
        }

        public List<Models.Ticket> GetAllTickets()
        {
            return context.Tickets.ToList();
        }

        public List<Models.Ticket> GetOpenTickets()
        {
            return context.Tickets.Where(t => t.StatusId != "done").ToList();
        }

        public List<Status> GetAllStatuses()
        {
            return context.Statuses.ToList();
        }

        public IQueryable<Models.Ticket> GetQuery()
        {
            return context.Tickets.Include(t => t.Status);
        }

        public Models.Ticket Find(int id)
        {
            return context.Tickets.Find(id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void InsertTicket(Models.Ticket ticket)
        {
            context.Tickets.Add(ticket);
        }

        public void UpdateTicket(Models.Ticket ticket)
        {
            context.Tickets.Update(ticket);
        }
        public void DeleteTicket(Models.Ticket ticket)
        {
            context.Tickets.Remove(ticket);
            context.SaveChanges();
        }



    }
}
