using System;
namespace lab4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int a = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                    a *= i;
            }
            Console.WriteLine(a);
        }
    }
}
