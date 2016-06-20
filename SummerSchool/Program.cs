using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool
{
    class Program
    {
        static string[] Roster = new string[15];

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
                   // Unenroll();
                }
                else if ( menuEnt == 3)
                {
                   // Print();
                }
                else if (menuEnt == 4)
                {
                   // Exit();


                    Console.ReadLine();

                }
            }   
         
        }
        private static void Enroll()
        {
            string stu = Console.ReadLine();

            for (int i = 0; i < 15; i++ )
            {
                if (Roster[i] == null)              
                    {
                        Roster[i] = stu;
                        break;
                    }
                }
            }

        }

    }

