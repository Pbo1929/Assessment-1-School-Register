using System;

namespace Assessment_1___School_Register
{
    class Attendance
    {
        private DateTime Date = DateTime.Now;
        private string DayOfTheWeek;
        private string registered;
        private int Late = 0;
        private int MinutesLate = 0;

        public Attendance(DateTime date, string registered)
        {

            if (registered == "Late")
            {
                this.Date = date;
                this.registered = registered;
                this.DayOfTheWeek = Date.ToString("dddd");
                Date = Date.AddHours(-7);
                Date = Date.AddHours(-40);
                MinutesLate = Date.Hour * 60 + Date.Minute;

            }
            else if (registered != "Late")
            {
                this.Date = date;
                this.registered = registered;
                this.DayOfTheWeek = Date.ToString("dddd");
                Late = 0;

            }
        }

        public int GetMinutesLate()
        {
            return MinutesLate;
        }

        public DateTime GetDate()
        {
            return Date;
        }
    }



}