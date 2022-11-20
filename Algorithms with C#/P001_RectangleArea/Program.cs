using System;

namespace P001_RectangleArea
{

    /* dikdörtgenin yüzey alanını bulma */

    class Program
    {
        static void Main(string[] args)
        {
            int width;
            int height;

            /* width = 5;
            height = 3; */

            /* üstteki datalar önceden seçilmiş, bunları kullanıcıdan da alabiliriz. */

            Console.WriteLine("Please enter your rectangle's width: ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your rectangle's height: ");
            height = Convert.ToInt32(Console.ReadLine());

            int area = width * height;

            Console.WriteLine("Area of the rectangle: " + area);

        }
    }
}
