using Microsoft.EntityFrameworkCore;

namespace ContactWebAppWehde.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext (DbContextOptions<ContactContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactID = 1,
                    Name = "John Doe",
                    Phone = "712-792-1234",
                    Email = "jdoe@gmail.com",
                    AddressID = 1,
                    Note = "Example 1"
                },
                new Contact
                {
                    ContactID = 2,
                    Name = "Jane Doe",
                    Phone = "712-792-1235",
                    Email = "janedoe@gmail.com",
                    AddressID = 1,
                    Note = "Example 2"
                });

            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    AddressID = 1,
                    StreetAddress = "123 Main St.",
                    City = "Carroll",
                    State = "IA",
                    Zip = "51401"
                });
        }
    }
}
