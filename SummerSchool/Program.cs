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
                //blank "Console.WriteLine();'s" are to create spacing/padding to help with visual presentation on ui
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("___________________________________________________");
                Console.WriteLine();
                Console.WriteLine("Welcome to the School Enrollment System.");
                Console.WriteLine("Term: Summer");
                Console.WriteLine("Please enter a number to make a selection.");

                Console.WriteLine();
                Console.WriteLine();
                //if (spot)
                {
                }


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

            //---------------------------------------------------------------------------


            //static string Tuition()
            //{
            //    Console.WriteLine("200");
            //}

           static void Enroll()
        {
                Console.WriteLine("_________________________________________________");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("What's the name of the student to enroll?");
                string stu = Console.ReadLine();

                //put student in the next available spot in Students
                int spot = GetNextAvialbleSpot();
            // Check if enrollment is full, if so displays message and loops back to menu
                if (spot == -1)
                {
                    Console.WriteLine();
                    Console.WriteLine("_________________________________________________");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("School roster at capacity! ENROLLMENT IS CURRENTLY COLSED!");
                    Console.WriteLine("Please press <ENTER> to return to the main menu.");
                    Console.ReadKey();
                }
                // If not full display enroll confirmation
                else
            {
                Console.WriteLine("You have entered: " + stu + ". Would you like to continue?");
                Console.WriteLine("Please type 'Y' for 'Yes' to enroll this student or N' for 'no' to return to the menu?");
                // check for user confirm
                string enrollconf = Console.ReadLine();
                if (enrollconf.ToLower() == "y" )
                {
                    // if confirmed display enrolee and tuition
                    Students[spot] = stu;
                    string tuition = "200";
                    Console.WriteLine("_________________________________________________");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(stu + " has been enrolled at a tuition of £" + tuition);

                }

            }              
          
                  
            }
            //method to find next available spot in students
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
            //    for (int = 0; i < Students.Length; i++)
            //    {
            //        if
            //    }
            //}
            //private static void Print()
            //{
            //    for (int i = 0; i < Students.Length; i++)
            //    {
            //        Console.WriteLine(i + 1 + ". " + Students[i]);
            //    }
            //}

        }

    }








