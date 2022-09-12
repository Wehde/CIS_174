

using FirstResponsiveWebAppWehde.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstResponsiveWebAppWehdeTests
{
    public class UnitTest1
    {
        [Fact]
        public void CalculateAgeTest1()
        {
            //Arrange
            GetAgeModel model = new GetAgeModel();
            model.UsersName = "Kilian";
            model.UserBirthday = new DateTime(1995, 03, 22);

            string expected = "Kilian your age is 27 as of today.";
            string? actual;

            //Act
            actual = model.CaclulateAge();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateAgeTest2()
        {
            //Arrange
            GetAgeModel model = new GetAgeModel();
            model.UsersName = "Amanda";
            model.UserBirthday = new DateTime(1993, 04, 07);

            string expected = "Amanda your age is 29 as of today.";
            string? actual;

            //Act
            actual = model.CaclulateAge();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateAgeTest3()
        {
            //Arrange
            GetAgeModel model = new GetAgeModel();
            model.UsersName = "Zero";
            model.UserBirthday = DateTime.Today;

            string expected = "Zero your age is 0 as of today.";
            string? actual;

            //Act
            actual = model.CaclulateAge();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateAgeTest4()
        {
            //Arrange
            GetAgeModel model = new GetAgeModel();
            model.UsersName = "Negative";
            model.UserBirthday = new DateTime(2025, 04, 07);

            string expected = "Negative your age is -3 as of today.";
            string? actual;

            //Act
            actual = model.CaclulateAge();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}