using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppWehde.Models
{
    public class GetAgeModel
    {
        public DateTime TODAY = DateTime.Now;

        [Required(ErrorMessage = "Please enter your name")]
        public string? UsersName { get; set; }

        [Required(ErrorMessage = "Please enter your birthday")]
        public DateTime? UserBirthday { get; set; }

        public string? CaclulateAge()
        {
            int age = 0;
            if(UserBirthday != null)
            {
                age += TODAY.Year - UserBirthday.Value.Year;
                if (TODAY < UserBirthday.Value.AddYears(age))
                {
                    age--;
                }
            }
            return UsersName + " your age is " + age + " as of today.";
        }
    }
}
