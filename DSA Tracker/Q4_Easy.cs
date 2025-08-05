using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Tracker
{
    public class Q4_Easy
    {
        //Given the integer day denoting the day number, print on the screen which day of the week it is. Week starts from Monday
        //and for values greater than 7 or less than 1, print Invalid.Ensure only the 1st letter of the answer is capitalised.

        public static void GetDay()
        {
            Console.Write("Enter the number for which you want to know the day: ");
             string userInpur = Console.ReadLine();
            bool isInteger = int.TryParse(userInpur, out int value);
            if (!isInteger)
            {
                Console.WriteLine("Kindly enter Integer value");
            }
            switch (value)
            {

                    case 1: Console.WriteLine("Day: Monday"); break;
                    case 2: Console.WriteLine("Day: Tuesday");break;
                    case 3: Console.WriteLine("Day: Wednesday");break;
                    case 4: Console.WriteLine("Day: Thursday");break;
                    case 5: Console.WriteLine("Day: Friday");break;
                    case 6: Console.WriteLine("Day: Saturday");break;
                    case 7: Console.WriteLine("Day: Sunday");break;
                    default: Console.WriteLine("Invalid");break;
            }

        }
    }
}
