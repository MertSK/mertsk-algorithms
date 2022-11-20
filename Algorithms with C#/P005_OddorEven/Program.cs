using System;

namespace P005_OddorEven

{

    /* 
        sayi tek mi cift mi?
    */

    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Please enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            string result;

            if(number % 2 == 0)
            {
                result = "Even";
            }
            else
            {
                result = "Odd";
            }

            Console.WriteLine("Your number is " + result + ".");
        }
    }
}
