using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int answer = 0;

            Console.WriteLine("Enter a number.");
            string sNum1 = Console.ReadLine();

            Console.WriteLine("Enter another number.");
            string sNum2 = Console.ReadLine();

            Int32.TryParse(sNum1, out num1);
            Int32.TryParse(sNum2, out num2);

            answer = num1 + num2;

            Console.WriteLine("The answer is " + answer); 

            Console.ReadLine();
        }

        static void WriteLine(string value)
        {


        }
    }
}
