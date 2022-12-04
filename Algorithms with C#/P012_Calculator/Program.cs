using System;

namespace P012_Calculator

{

    /* 
        calculator
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number 1: ");
            float number1= Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter number 2: ");
            float number2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your operation code: ");
            Console.WriteLine("Addition = 1, Substraction = 2, Multiplication = 3, Division = 4");
            int operation = Int32.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1: 
                    Console.WriteLine(number1 + number2); break;
                case 2: 
                    Console.WriteLine(number1 - number2); break;
                case 3: 
                    Console.WriteLine(number1 * number2); break;
                case 4: 
                    Console.WriteLine(number1 / number2); break;

                default: 
                    Console.WriteLine("We couldn't find a operation like that."); 
                    break;
            }
        }
    }
}
