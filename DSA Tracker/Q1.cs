using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Tracker
{
    public static class Q1
    {
        //Q1.Complete the function printNumber which takes an integer input from the user and prints it on the screen.

        public static void Question1()
        {
            Console.WriteLine("Enter a number");
            string UserInput = Console.ReadLine();
            bool IsInteger = int.TryParse(UserInput, out int value);
            if (IsInteger)
            {
                Console.WriteLine("Entered Value is: " + value);
            }
            else {
                Console.WriteLine("Kindly enter Integer Value");
            }

            Console.ReadLine();
        }

    }
    
}
