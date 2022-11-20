using System;

namespace P007_Factorial

{

    /* 
        faktöriyel bulma
    */

    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int factorial = 1;

            Console.WriteLine("Please enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            while(number > 1)
            {
                factorial = factorial * number;
                number = number - 1;
            }
            Console.WriteLine("Your number's factorial is: " + factorial);
        }
    }
}
