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
                //Not at all coding related ignore lol ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // ui bank:
                //Console.WriteLine("                                                   |");
                //Console.WriteLine("***************************************************|");                
                //Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX|");
                //Console.WriteLine("---------------------------------------------------|");

                //ui bank 2.0:
                //Console.WriteLine("------------------------------------------------------------------|");

                //Not at all coding related ignore lol ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------|");
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX|");
                Console.WriteLine("---------------------------------------------------|");
                Console.WriteLine("                                                   |");
                Console.WriteLine("Welcome to the School Enrollment System.           |");
                Console.WriteLine("             Term: Summer                          |");
                Console.WriteLine("Please enter a number to make a selection.         |");

                Console.WriteLine("                                                   |");
                Console.WriteLine("---------------------------------------------------|");
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX|");
                Console.WriteLine("---------------------------------------------------|");
                Console.WriteLine("                                                   |");
                Console.WriteLine("                                                   |");


                





                Console.WriteLine("1. Enroll a student                                |");
                Console.WriteLine("2. Unenroll a student                              |");
                Console.WriteLine("3. Print list of enrolled students                 |");
                Console.WriteLine("4. Exit                                            |");
                Console.WriteLine("                                                   |");
                Console.WriteLine("---------------------------------------------------|");

                int menuEnt = Convert.ToInt32(Console.ReadLine());
                if (menuEnt == 1)
                {
                    Enroll();
                }
                else if (menuEnt == 2)
                {
                    Unenroll();
                }
                else if (menuEnt == 3)
                {
                    Print();
                }
                else if (menuEnt == 4)
                {
                    //Quit
                    break;
                }


                else if (menuEnt > 4)
                {

                    Console.WriteLine("---------------------------------------------------|");
                    Console.WriteLine("                                                   |");
                    Console.WriteLine("Invalid entry. Please select on of the options listed by enter in number and pressing >ENTER<");
                    Console.ReadKey();
                    Console.WriteLine("                                                   |");
                    Console.WriteLine("---------------------------------------------------|");
                }
                // not sure how to capture non-integer inputs
                //else
                //{
                //    string strgMenuEnt = Convert.ToString(menuEnt);
                //    strMenuEnt 

                //    Console.WriteLine("---------------------------------------------------|");
                //    Console.WriteLine("                                                   |");
                //    Console.WriteLine("Invalid entry. Please select on of the options listed by enter in number and pressing >ENTER<");
                //    Console.ReadKey();
                //    Console.WriteLine("                                                   |");
                //    Console.WriteLine("---------------------------------------------------|");
                //}






            }


        }


        static void Enroll()
        {
            Console.WriteLine("---------------------------------------------------|");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("What's the name of the student to enroll?");
            Console.WriteLine();
            Console.WriteLine();
            string stu = Console.ReadLine();

            // code to process name and route accoridnigly goes here (have to create corresponding methods):
            //string firstName = splitNames[0];
            //string lastName = splitNames[splitNames.Length - 1];
            //if (lastName.ToLower() == "malfoy")
            // Console.Writeline("No Malfoys....);
            // return;
            //so on...(see github class example)


            //put student in the next available spot in Students
            int spot = GetNextAvialbleSpot();
            // Check if enrollment is full, if so displays message and loops back to menu
            if (spot == -1)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------|");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("School roster at capacity! ENROLLMENT IS CURRENTLY COLSED!");
                Console.WriteLine("Please press <ENTER> to return to the main menu.");
                Console.ReadKey();
            }
            // If not full display enroll confirmation
            else
            {
                Console.WriteLine("------------------------------------------------------------------|");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("You have entered: |> " + stu + " <| Would you like to continue?");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Enter 'Y' to enroll this student or 'N' to return to the menu.");
                Console.WriteLine();
                // check for user confirm
                string enrollconf = Console.ReadLine();
                if (enrollconf.ToLower() == "y")
                {
                    // if confirmed display enrolee and tuition
                    Students[spot] = stu;
                    string tuition = "200";
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("******************************************************************|");
                    Console.WriteLine("******************************************************************|");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(stu + " has been enrolled at a tuition of £" + tuition);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("******************************************************************|");
                    Console.WriteLine("******************************************************************|");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Please press <ENTER> to return to the main menu.");
                    Console.ReadKey();
                    Console.WriteLine();

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

        // Method to Unenroll students. Present list of stus and take user selection, remove corresponding stu, confirm selection
        private static void Unenroll()
        {
            //Print method shows current enrollees
            Print();
            Console.WriteLine("Please select the number of the student you would like to unenroll.");

            //capture user choice
            int stuNum = Convert.ToInt32(Console.ReadLine());
            //convert users # selection to correlating index
            int stuIndex = stuNum - 1;

            // Present selected stu
            Console.WriteLine("You have selected:\n");
            Console.WriteLine("****|>" + Students[stuIndex] + "<|****\n");

            //confirm unenroll
            Console.WriteLine("Are you sure you want to uneroll this student?  Enter: y/n\n");
            string unenrollconf = Console.ReadLine();

            //attempt to preserve stu name after removal for removal display message
            string removedStu = Students[stuIndex];
            // remove if confirmed
            if (unenrollconf.ToLower() == "y")
            {
                //removes student from array index slot
                Students[stuIndex] = null;
                Console.WriteLine(removedStu + " has been unenrolled.\n");
                Print();

                //Console.WriteLine("Press any key to return to the menu.");
                //Console.ReadKey();

            }
        }


        private static void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Enrolled Students");
            Console.WriteLine("-----------------");
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] != null)
                {
                    //Console.WriteLine(Students);    <---- only captured one arg  in array at a time presented weird
                    // Finally figured this out, for ever index i, add 1 and a ".", then the name stored in array Students[] for every i

                    Console.WriteLine(i + 1 + ". " + Students[i] + "   Tuition: £200");
                    // add line to total enrolled students and display # of available spots                    
                }


            }            
            Console.WriteLine("\nPlease press <ENTER> to return to continue.\n\n");
            Console.ReadKey();            
        }
    }
}















