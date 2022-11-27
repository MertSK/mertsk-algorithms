using System;

namespace P008_SumofNumbers

{

    /* 
        girilen sayilarin toplamini bulma
    */

    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;

            do
            {
                Console.WriteLine("Please enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number != -1)
                {
                    sum += number;
                }
            }
            while(number != -1);

            Console.WriteLine("Sum of numbers that you entered: " + sum);

        }
    }
}
