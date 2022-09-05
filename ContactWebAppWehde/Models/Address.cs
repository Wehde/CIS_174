using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ContactWebAppWehde.Models
{
    public class Address
    {
        public readonly string[] STATES = {
            "AK", "AL", "AR", "AS", "AZ", "CA", "CO", "CT", "DC", "DE", 
            "FL", "GA", "GU", "HI", "IA", "ID", "IL", "IN", "KS", "KY", 
            "LA", "MA", "MD", "ME", "MI", "MN", "MO", "MP", "MS", "MT", 
            "NC", "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", 
            "OR", "PA", "PR", "RI", "SC", "SD", "TN", "TX", "UM", "UT", 
            "VA", "VI", "VT", "WA", "WI", "WV", "WY"};

        public int AddressID { get; set; }

        [Required(ErrorMessage = "Please enter a street address.")]
        public string? StreetAddress { get; set; }

        [Required(ErrorMessage = "Please enter a city.")]
        public string? City { get; set; }

        [Required(ErrorMessage = "Please enter a state.")]
        [StringLength(2, ErrorMessage = "Please use the 2 character abbreviation.")]
        public string? State { get; set; }

        [Required(ErrorMessage = "Please enter a zip code.")]
        [MinLength(5, ErrorMessage = "Zip Code should be at least 5 characters.")]
        public string? Zip { get; set; }

        public string Slug => StreetAddress?.Replace(' ', '-').ToLower() + City?.Replace(' ', '-').ToLower() + State?.Replace(' ', '-') + Zip?.Replace(' ', '-');
    }
}
