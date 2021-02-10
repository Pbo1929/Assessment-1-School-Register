using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_1___School_Register
{
    class FormGroup
    {
        private string GroupName;
        private string FormTeacher;
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

        public bool TakeRegister(Student StudentToRegister)
        {
            int StudentCount = GetStudentCount();
            if (StudentCount < Students.Length)
            {
                Students[StudentCount] = StudentToRegister;
                return true;
            }
            return false;
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