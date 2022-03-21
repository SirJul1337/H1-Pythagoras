using System;

namespace Pythagoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put it number 1: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Put in number 2: ");
            double number2 = double.Parse(Console.ReadLine());
            double raised1 = Math.Pow(number1, 2);
            double raised2 = Math.Pow(number2, 2);
            double c = (double)raised1 + raised2;
            double csqrt = Math.Sqrt(c);
            Console.WriteLine("C is: "+csqrt);

            if (number1 > number2)
            {
                Console.WriteLine("Number 1 is bigger than number 2");
            }
            else if (number1 < number2)
            {
                Console.WriteLine("Number 2 is bigger than number 1");
            }
            else
            {
                Console.WriteLine("They are equally big");
            }
        }
    }
}
