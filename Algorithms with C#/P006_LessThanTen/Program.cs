using System;

namespace P006_LessThanTen

{

    /* 
        sayi ondan küçük ve tek mi?
        && -> and
        || -> or
    */

    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Please enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            if(number < 10 && number % 2 == 1)
            {
                Console.WriteLine("Your number is less than 10 and this number is odd.");
            }
            else
            {
                Console.WriteLine("Your number is greater than 10 veya çifttir.");
            }
        }
    }
}
