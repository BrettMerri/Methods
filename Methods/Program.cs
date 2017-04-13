using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = getValidInteger();
            printNumbers(i);
        }

        public static int getValidInteger()
        {
            int input;

            Console.Write("Please enter and integer: ");

            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("The input is not an integer! Please enter an integer");
            }

            return input;
        }
        public static void printNumbers(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
