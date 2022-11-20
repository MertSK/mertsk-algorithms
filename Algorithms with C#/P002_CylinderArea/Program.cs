using System;

namespace P002_CylinderArea

{

    /* 
        silindirin alanını bulma 
        hacim = pi sayısı * yaricapin karesi * yükseklik
    */

    class Program
    {
        static void Main(string[] args)
        {
            double numberPi = 3.14;
            int radius;
            int height;

            Console.WriteLine("Please enter your cylinder's radius: ");
            radius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your cylinder's height: ");
            height = Convert.ToInt32(Console.ReadLine());

            double cylinderArea = numberPi * radius * radius * height;

            Console.WriteLine("Your cylinder's area is " + cylinderArea);

        }
    }
}
