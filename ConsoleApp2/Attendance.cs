using System;

namespace Assessment_1___School_Register
{
    class Attendance
    {
        private DateTime Date = DateTime.Now;
        private string Registered = "";
        private int Late = 0;
        private int MinutesLate = 0;

        public Attendance(DateTime date, DateTime DayOfTheWeek, string registered, int Late)
        {

            if (Registered != "Late")
            {
                this.Date = date;
                this.Registered = registered;
                DateTime DateOfTheWeek = DateTime.Parse(DateTime.Now.ToString("dddd"));
                Late = 0;
            }
            else if (Registered == "Late")
            {
                this.Date = date;
                this.Registered = registered;
                DateTime DateOfTheWeek = DateTime.Parse(DateTime.Now.ToString("dddd"));
                Date = Date.AddHours(-7);
                Date = Date.AddHours(-40);
                MinutesLate = Date.Hour * 60 + Date.Minute;

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

        public string GetRegistered()
        {
            return Registered;


        }
    }



    }