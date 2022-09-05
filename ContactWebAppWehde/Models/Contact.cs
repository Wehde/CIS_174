using System.ComponentModel.DataAnnotations;

namespace ContactWebAppWehde.Models
{
    public class Contact
    {
        public int ContactID { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter a phone number")]
        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter an email.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter an address")]
        public int AddressID { get; set; }
        public Address? Address { get; set; }

        [Required(ErrorMessage = "Please enter a note")]
        public string? Note { get; set; }

        public string Slug => Name?.Replace(' ', '-').ToLower() + "?";
    }
}
