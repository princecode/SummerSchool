using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please select an option from the menu below by entering the corresponding number.");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Enroll a student");
            Console.WriteLine("2. Unenroll a student");
            Console.WriteLine("3. Print out the list of enrolled students");
            Console.WriteLine("4. Exit");          
            Console.WriteLine();

            Console.WriteLine(">");
            string menuEnt = Console.ReadLine();
            //the below was just a test to make sure the above was capturing user input
            //Need to write code to limit entires to the ones in the menu
            //need to refactor add loops to catch invalid entires and maybe array for menu options
            Console.WriteLine(menuEnt);



            Console.ReadLine(); 
        }
    }
}
