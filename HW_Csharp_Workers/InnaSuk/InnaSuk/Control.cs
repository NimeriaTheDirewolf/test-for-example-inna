using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace InnaSuk
{
    class Control
    {


        public static int OnlyInteger2(string integer)
        {
            int numberNotZero;
            while (!Int32.TryParse(integer, out numberNotZero) || numberNotZero < 0)
            {
                Console.WriteLine("Sorry, but this symbol is incorrect, please enter the positive number (not 0): ");
                integer = Console.ReadLine();
            }
            return numberNotZero;
        }

        public static int OnlyInteger(string integer_or_null)
        {
            int numberOrZero;
            while (!Int32.TryParse(integer_or_null, out numberOrZero) || numberOrZero <= 0)
            {
                Console.WriteLine("Sorry, but this symbol is incorrect, please enter the inreger numer or 0: ");
                integer_or_null = Console.ReadLine();
            }
            return numberOrZero;
        }

        public static int number_control(string control_string)
        {
            int number;
            while (!int.TryParse(control_string, out number))
            {

                Console.WriteLine(" Sorry, but you wrote incorrect on previouse line, you need write it again.");
                control_string = Console.ReadLine();
            }
            return number;
        }

    }
}
