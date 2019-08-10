using System;

namespace RaceDirector.Models.ViewModels
{
    public class DriverVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{LastName} {FirstName}";
        public DateTime DateOfBirth { get; set; }
        public int Age => (new DateTime(1, 1, 1) + (DateTime.Now.Date - DateOfBirth)).Year - 1;
        public string AgeString
        {
            get
            {
                string str = "лет";
                if (Age % 10 <= 4)
                    str = "года";
                if (Age % 10 == 1)
                    str = "год";
                return $"{Age} {str}";
            }
        }
    }
}
