using System;

namespace _21.TheCleverLili
{
    class Program
    {
        static void Main()
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            double priceToy = double.Parse(Console.ReadLine());
            int money = 1;
            int sumMoney = 0;
            int counter = 0;
            int toyNumber = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    counter++;
                    money = 10 * counter;
                    sumMoney += money;
                }

                else
                {
                    toyNumber++;
                }
            }

            double toyToMoney = priceToy * toyNumber;
            double totalMoney = toyToMoney + sumMoney - counter * 1;

            if (totalMoney >= priceWashingMachine)
            {
                Console.WriteLine($"Yes! {totalMoney - priceWashingMachine:F2}");
            }

            else
            {
                Console.WriteLine($"No! {Math.Abs(totalMoney - priceWashingMachine):F2}");
            }
        }
    }
}
