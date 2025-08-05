using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Tracker
{
    public static class Q2_Easy
    {
        //Given marks of a student, print on the screen:
        //Grade A if marks >= 90
        //Grade B if marks >= 70
        //Grade C if marks >= 50
        //Grade D if marks >= 35
        //Fail, otherwise.

        public static int CheckGrade() 
        {
            Console.WriteLine("Enter Marks:");
            string UserInput = Console.ReadLine();
            bool IsInteger = int.TryParse(UserInput, out int value);
            if (!IsInteger)
            {
                Console.WriteLine("Kindly enter integer value");
                return 0;
            }
            if (value >= 90)
            {
                Console.WriteLine("Grade A");
                return 0;
            }
            if (value >= 70)
            {
                Console.WriteLine("Grade B");
                return 0;
            }
            if (value >= 50)
            {
                Console.WriteLine("Grade C");
                return 0;
            }
            if (value >= 30)
            {
                Console.WriteLine("Grade D");
                return 0;
            }
            else {
                Console.WriteLine("Fail");
                return 0;
            }

        }

    }
}
