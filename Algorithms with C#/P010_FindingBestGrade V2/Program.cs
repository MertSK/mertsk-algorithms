using System;

namespace P010_FindingBestGradeV2

{

    /* 
        en iyi notu bulma v2
    */

    class Program
    {
        static void Main(string[] args)
        {
            int [] grades = new int[3];
            grades[0] = 80;
            grades[1] = 95;
            grades[2] = 23;
            int maxGrade = 0;

            for(int i = 0; i < 3; i++)
            {
                if(grades[i] > maxGrade)
                {
                    maxGrade = grades[i];
                }
            }

            Console.WriteLine("Best Grade: " + maxGrade);
        }
    }
}
