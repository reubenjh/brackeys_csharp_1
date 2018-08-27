using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace brackeys1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01;
            int num02;

            Console.Write("Type a number to be multiplied: ");
            num01 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Type another number: ");
            num02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The result is " + num01 * num02);
            Console.ReadKey();
        }
    }
}
