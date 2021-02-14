using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_1___School_Register
{
    class Student
    {
        private string Name;
        private DateTime DateOfBirth;
        private string Gender;
        private Attendance[] Attendances = new Attendance[180];
        private int AttendanceCount = 0;
        private int PresentCount = 0;
        private int LateCount = 0;
        private int AbsentCount = 0;
        private int TotalMinutesLate = 0;
        private string registered = "";
        private DateTime Date;
        private int MinutesLate;


        public Student(string name, DateTime dateOfBirth, string gender)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }

        public void AddAttendance(DateTime date, string registered)
        {

            Attendances[AttendanceCount] = new Attendance(date, registered);
            AttendanceCount++;
            if (registered == "present")
            {
                Attendances[AttendanceCount] = new Attendance(date, registered);
                PresentCount++;
                AttendanceCount++;
                Date = date;
            }
            else if (registered == "absent")
            {

                Attendances[AttendanceCount] = new Attendance(date, registered);
                AbsentCount++;
                AttendanceCount++;
                Date = date;
            }
            else if (registered == "late")
            {

                Attendances[AttendanceCount] = new Attendance(date, registered);
                TotalMinutesLate = TotalMinutesLate + Attendances[AttendanceCount].GetMinutesLate();
                LateCount++;
                AttendanceCount++;
                Date = date;
                
            }

        }

        public int GetAttendanceCount()
        {
            return AttendanceCount;
        }

        public int GetPresentCount()
        {
            return PresentCount;
        }

        public int GetLateCount()
        {
            return LateCount;
        }

        public int GetAbsentCount()
        {
            return AbsentCount;
        }

        public int GetTotalMinutesLate()
        {
            return TotalMinutesLate;
        }

        public string GetName()
        {
            return Name;
        }

        public DateTime GetStatus()
        {
            return Date;
        }
    }
}