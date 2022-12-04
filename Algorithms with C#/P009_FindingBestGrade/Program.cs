using System;

namespace P009_FindingBestGrade

{

    /* 
        en iyi notu bulma
    */

    class Program
    {
        static void Main(string[] args)
        {
            int grade1 = 60;
            int grade2 = 75;
            int grade3 = 50;

            if(grade1 > grade2)
            {
                if(grade1 > grade3)
                {
                    Console.WriteLine("Best Grade: " + grade1);
                }
                else
                {
                    Console.WriteLine("Best Grade: " + grade3);
                }
            }
            else
            {
                if(grade2 > grade3)
                {
                    Console.WriteLine("Best Grade: " + grade2);
                }
                else
                {
                    Console.WriteLine("Best Grade: " + grade3);
                }
            }
        }
    }
}
