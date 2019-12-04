using System;

namespace Lab_3___завд._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nYour perfect and amicable numbers:");
            PrintAllAmicableNumbersPairs(num: x);
            PrintAllPerfectNumbers(num: y);

            Console.ReadKey();
        }
        public static int SumOfDivisors(int num)
        {
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        public static void PrintAllPerfectNumbers(int num)
        {
            for (int i = 2; i <= num; i++)
            {
                for (int k = 2; i <= num; k++)
                {
                    if (SumOfDivisors(i) == k)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        public static void PrintAllAmicableNumbersPairs(int num)
        {
            for (int i = 2; i <= num; i++)
            {
                if (SumOfDivisors(SumOfDivisors(i)) == i)
                {
                    Console.WriteLine(i + " and " + SumOfDivisors(i) + "\n");
                }
            }
        }
    }
}
