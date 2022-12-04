using System;

namespace P011_FindingBestGradeV3

{

    /* 
        en iyi notu bulma v3
    */

    class Program
    {
        static void Main(string[] args)
        {
            int [] grades = new int[3];
            int maxGrade = 0;

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter 3 grades: ");
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int j = 0; j < 3; j++)
            {
                if(grades[j] > maxGrade)
                {
                    maxGrade = grades[j];
                }
            }

            Console.WriteLine("Best Grade: " + maxGrade);
        }
    }
}
