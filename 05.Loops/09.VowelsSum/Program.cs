using System;

namespace _09.VowelsSum
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            int sum = 0;
            int val = 0;
           
            


            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'a':
                        val = 1;
                        break;
                    case 'o':
                        val = 4;
                        break;

                    case 'u':
                        val = 5;
                        break;

                    case 'i':
                        val = 3;
                        break;

                    case 'e':
                        val = 2;
                        break;
                    default:
                        val = 0;
                        break;
                }
                if (str[i] == 'a' || str[i] == 'o' || str[i] == 'e' || str[i] == 'i' || str[i] == 'u')
                {
                    sum += val;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
