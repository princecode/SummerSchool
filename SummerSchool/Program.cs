using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool
{
    class Program
    {
        static string[] Students = new string[15];

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Welcome to the School Enrollment System.");
                Console.WriteLine("Term: Summer");
                Console.WriteLine("Please enter a number to make a selection.");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1. Enroll a student");
                Console.WriteLine("2. Unenroll a student");
                Console.WriteLine("3. Print list of enrolled students");
                Console.WriteLine("4. Exit");
                Console.WriteLine();

                int menuEnt = Convert.ToInt32(Console.ReadLine());
                if (menuEnt == 1)
                {
                    Enroll();
                }
                else if (menuEnt == 2)
                {
                    //Unenroll();
                }
                else if (menuEnt == 3)
                {
                    //Print();
                }
                else if (menuEnt == 4)
                {
                    //Quit
                    break;
                }
                else
                {
                    Console.ReadLine();
                    // not sure what all is suposed to be here. or if I have/am missing {'s....
                }
            }

        }

        static void Enroll()
        {
            Console.WriteLine("What's the name of the student to enroll?");
            string stu = Console.ReadLine();

            //put student in the next available spot in Students
            int spot = GetNextAvialbleSpot();

            Students[spot] = stu;
            //method to find next available spot in students

        }

        static int GetNextAvialbleSpot()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] == null)
                {
                    //we found one!
                    return i;
                }

            }
            // if we get through the whole 
            return -1;
        }
        //static void Unenroll()
        //{
        //    for (int = 0; i < 15; int++)
        //    {
        //        //?
        //    }
        //}

        //private static void Print()
        //{
        //    for (int i = 0; i < Students.Length; i++)
        //    {
        //        if
        //    }
        //}

    }


}



