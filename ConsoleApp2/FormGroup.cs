using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_1___School_Register
{
    class FormGroup
    {
        private string GroupName;
        private string FormTeacher;
        private DateTime Date = DateTime.Now;
        private Student[] Students = new Student[22];
        private int StudentCount = 0;

        public FormGroup(string GroupName, string FormTeacher)
        {
            this.GroupName = GroupName;
            this.FormTeacher = FormTeacher;
        }

        public void AddStudent(string name, DateTime dateOfBirth, string gender)
        {
            Students[StudentCount] = new Student(name, dateOfBirth, gender);
            StudentCount++;
        }

        public int GetStudentCount()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] == null) return i;
            }

            return Students.Length;
        }

        public void TakeRegister(DateTime Today)
        {
            string x;
            for (int i = 0; i < StudentCount; i++)
            {

                Console.WriteLine("Is " + Students[i].GetName() + " here today.");
                x = Console.ReadLine();
                if (x == "Present")
                {
                    Students[i].AddAttendance(Today, "present");
                }
                else if (x == "Absent")
                {
                    Students[i].AddAttendance(Today, "absent");
                }
                else if (x == "Late")
                {
                    Students[i].AddAttendance(Today, "late");
                }
            }
        }

        public void PrintRegister(DateTime Today)
        {
            for (int i = 0; i < StudentCount; i++)
            {
                Console.WriteLine(Students[i].GetName() + " was " + Students[i].GetStatus());
                Console.WriteLine(Students[i].GetName() + " is " + Students[i].GetTotalMinutesLate() + " minutes late ");
            }
        }

        public void GetStudentStatus()
        {
            for (int i = 0; i < StudentCount; i++)
            {
                Console.WriteLine(Students[i].GetName() + "'s" + " Status");
                Console.WriteLine("Present: " + Students[i].GetPresentCount());
                Console.WriteLine("Absent: " + Students[i].GetAbsentCount());
                Console.WriteLine("Late: " + Students[i].GetLateCount());
            }
        }

        public string GetGroupName()
        {
            return GroupName;
        }

        public string GetFormTeacher()
        {
            return FormTeacher;
        }
    }
}