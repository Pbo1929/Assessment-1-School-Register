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


        public Student(string name, DateTime dateOfBirth, string gender)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }

        public void AddAttendance(DateTime date, DateTime dayOfTheWeek, string registered, int LateCount)
        {
            Attendances[AttendanceCount] = new Attendance(date, dayOfTheWeek, registered, LateCount);
            AttendanceCount++;
            if (registered == "present")
            {
                Attendances[AttendanceCount] = new Attendance(date, dayOfTheWeek, registered, LateCount);
                PresentCount++;
                AttendanceCount++;
            }
            else if (registered == "absent")
            {

                Attendances[AttendanceCount] = new Attendance(date, dayOfTheWeek, registered, LateCount);
                AbsentCount++;
                AttendanceCount++;
            }
            else if (registered == "late")
            {

                Attendances[AttendanceCount] = new Attendance(date, dayOfTheWeek, registered, LateCount);
                TotalMinutesLate = TotalMinutesLate + Attendances[AttendanceCount].GetMinutesLate();
                LateCount++;
                AttendanceCount++;
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

    }
}