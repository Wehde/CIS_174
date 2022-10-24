namespace Ticket.Models
{
    public class Filters
    {
        public string FilterString { get; }
        public string StatusId { get; }
        public string Due { get; }

        public Filters(string filterstring)
        {
            FilterString = filterstring ?? "all-all";
            string[] filters = FilterString.Split('-');
            StatusId = filters[0];
            Due = filters[1];
        }
        public bool HasStatus => StatusId.ToLower() != "all";
        public bool HasDue => Due.ToLower() != "all";

        public static Dictionary<string, string> DueFilterValues =>
            new Dictionary<string, string> {
                { "future", "Future" },
                { "past", "Past" },
                { "today", "Today" }
            };
        public bool IsPast => Due.ToLower() == "past";
        public bool IsFuture => Due.ToLower() == "future";
        public bool IsToday => Due.ToLower() == "today";
    }
}
