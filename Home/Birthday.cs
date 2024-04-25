using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    public struct Birthday
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        private DateTime DateOfBirth { get; set; }

        public Birthday(string name, string lastName, DateTime dateOfBirth)
        {
            Name = name;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public DayOfWeek GetBirthDate()
        {
            return DateOfBirth.DayOfWeek;
        }

        public DayOfWeek GetDayOfWeek(int year)
        {
            DateTime birthdayInTargetYear = new DateTime(year, DateOfBirth.Month, DateOfBirth.Day);

            return birthdayInTargetYear.DayOfWeek;
        }

        public int CalculateDaysToBirthday()
        {
            DateTime today = DateTime.Now;

            DateTime nextBirthday;
            if (today.Month < DateOfBirth.Month || (today.Month == DateOfBirth.Month && today.Day < DateOfBirth.Day))
            {
                nextBirthday = new DateTime(today.Year + 1, DateOfBirth.Month, DateOfBirth.Day);
            }
            else
            {
                nextBirthday = new DateTime(today.Year, DateOfBirth.Month, DateOfBirth.Day);
            }

            TimeSpan daysUntilBirthday = nextBirthday - today;
            return (int)daysUntilBirthday.TotalDays;
        }
        public override string ToString()
        {
            return $"{Name} {LastName}, birth date: {DateOfBirth}";
        }
    }

}
