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
            string operation;

            Start:
            // Ask what calc
            Console.WriteLine("What calc would you like to do?");
            Console.WriteLine("Press + for add");
            Console.WriteLine("Press - for subtract");
            Console.WriteLine("Press * for multiply");
            Console.WriteLine("Press / for divide");
            operation = Convert.ToString(Console.ReadLine());
            switch (operation)
            {
                case "*":
                    multiply(out num01, out num02);
                    break;
                default:
                    Console.WriteLine("You pressed a dumb key...");
                    Console.WriteLine();
                    break;
            }

            goto Start;
        }

        private static void multiply(out int num01, out int num02)
        {
            Console.Write("Type a number to be multiplied: ");
            num01 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Type another number to multiply by: ");
            num02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The result is " + num01 * num02);
            Console.WriteLine("press <any key> to go again");

            // wait for user to press key to continue
            Console.ReadKey();
            Console.WriteLine();
            
        }
    }
}
