using System;

namespace P003_FindingBiggerNumber

{

    /* 
        iki sayi arasindan büyük olan sayiyi bulma
    */

    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;

            Console.WriteLine("Please enter number 1: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter number 2: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine(number1 + " is bigger.");
            }
            else
            {
                Console.WriteLine(number2 + " is bigger or they are equal each other.");
            }


        }
    }
}
