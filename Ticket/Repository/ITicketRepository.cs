using Ticket.Models;

namespace Ticket.Repository
{
    public interface ITicketRepository
    {
        List<Models.Ticket> GetAllTickets();
        List<Models.Ticket> GetOpenTickets();
        List<Status> GetAllStatuses();
        IQueryable<Models.Ticket> GetQuery();
        Models.Ticket Find(int id);
        void Save();
        void InsertTicket(Models.Ticket ticket);
        void UpdateTicket(Models.Ticket ticket);
        void DeleteTicket(Models.Ticket ticket);
    }
}
