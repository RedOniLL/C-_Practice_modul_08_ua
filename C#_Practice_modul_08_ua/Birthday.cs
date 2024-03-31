using System;


namespace C__Practice_modul_08_ua
{
    public struct Birthday
    {
        public int Day;
        public int Month;
        public int Year;
        public void SetBirthday(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public string GetDayOfWeekOfBirth()
        {
            DateTime birthdayDate = new DateTime(Year, Month, Day);
            return birthdayDate.DayOfWeek.ToString();
        }
        public string GetDayOfWeekOfFutureBirthday(int futureYear)
        {
            DateTime futureBirthdayDate = new DateTime(futureYear, Month, Day);
            return futureBirthdayDate.DayOfWeek.ToString();
        }

        public int GetDaysUntilBirthday()
        {
            DateTime today = DateTime.Today;
            DateTime birthdayThisYear = new DateTime(today.Year, Month, Day);

            if (birthdayThisYear < today)
            {
                birthdayThisYear = birthdayThisYear.AddYears(1); 
            }

            return (birthdayThisYear - today).Days;
        }
    }

}
