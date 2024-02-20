using System;

namespace Uppgift_6_12
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hur hög vill du att din triangel ska vara?");
            RitaTriangel(int.Parse(Console.ReadLine()));
        }

        static void RitaTriangel(int höjd)
        {
            int bredd = 1;
            int maxBredd = 1 + 2 * höjd;
            maxBredd /= 2 - 1;

            for (int i = 0; i < höjd; i++)
            {
                for (int k = 0; k < maxBredd; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < bredd; j++)
                {
                    Console.Write("*");
                }

                maxBredd -= 1;
                bredd += 2;

                Console.WriteLine();
            }
        } 
    }
}