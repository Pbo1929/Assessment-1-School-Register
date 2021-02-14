using System;

namespace Assessment_1___School_Register
{
    class Program
    {
        static void Main(string[] args)
        {
            FormGroup Y12FB = new FormGroup("Y12FB", "Faye Blairs");
            Y12FB.AddStudent("Bob", DateTime.Parse("11/11/2004"), "Male");
            Y12FB.AddStudent("Sam", DateTime.Parse("1/6/2003"), "Male");
            Y12FB.AddStudent("Tom", DateTime.Parse("1/1/2003"), "Male");
            Y12FB.AddStudent("Arthur", DateTime.Parse("10/11/2004"), "Male");
            
            RegisterMenu(Y12FB);

            //Y12FB.TakeRegister(DateTime.Parse("2/10/2021"));
            

        }
        static public void RegisterMenu(FormGroup Y12FB)
        {
            bool x = false;
            string input;
            int input2;
            while (x == false)
            {
                Console.WriteLine("Y12FB School Register Menu");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Type 1 to take register.");
                Console.WriteLine("Type 2 to add new student.");
                Console.WriteLine("Type 3 to get register.");
                Console.WriteLine("Type 4 to end.");
                input = Console.ReadLine();
                input2 = Convert.ToInt32(input);
                Console.WriteLine(input2);

                if (input2 == 1)
                {
                    TakeAttendance(Y12FB);
                }

                else if(input2 == 2)
                {
                    AddStudent(Y12FB);
                }

                else if(input2 == 3)
                {
                    GetRegister(Y12FB);
                }

                else if(input2 == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error.");
                }
            }
        }

        static public void TakeAttendance(FormGroup Y12FB)
        {
            
            Y12FB.TakeRegister(DateTime.Today);
            
        }

        static public void AddStudent(FormGroup Y12FB)
        {
            string StudentName;
            string StudentDoB;
            string StudentGender;
            DateTime StudentDoB2;
            Console.WriteLine("Enter Student Name:");
            StudentName = Console.ReadLine();

            Console.WriteLine("Enter Student Date of Birth:");
            StudentDoB = Console.ReadLine();
            StudentDoB2 = Convert.ToDateTime(StudentDoB);

            Console.WriteLine("Enter Student Gender:");
            StudentGender = Console.ReadLine();

            Y12FB.AddStudent(StudentName, StudentDoB2, StudentGender);
        }

        static public void GetRegister(FormGroup Y12FB)
        {
            Y12FB.PrintRegister(DateTime.Today);
            
        }

    }
}
