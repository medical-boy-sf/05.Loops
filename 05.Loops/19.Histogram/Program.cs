using System;

namespace Demos
{
    class Program
    {
        static void Main()
        {
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >= 800)
                {
                    p5++;
                }

                else if (number > 599)
                {
                    p4++;
                }

                else if (number > 399)
                {
                    p3++;
                }

                else if (number >= 200)
                {
                    p2++;
                }

                else
                {
                    p1++;
                }


            }
            double sum = p1 + p2 + p3 + p4 + p5;
            p1 = p1 / sum * 100;
            p2 = p2 / sum * 100;
            p3 = p3 / sum * 100;
            p4 = p4 / sum * 100;
            p5 = p5 / sum * 100;
            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
        }
    }
}
