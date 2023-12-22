using System;
using System.IO;
using System.Linq;
namespace ConsoleApplication1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string path = "../../../numsTask3.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string numbers = reader.ReadToEnd();
                int[] nums = numbers.Split(',').Select(int.Parse).ToArray();

                int min = nums[0];
                int max = nums[0];

                foreach (int num in nums)
                {
                    if (num == 0)
                        break;

                    if (num > max)
                        max = num;
                    else if (num < min)
                        min = num;
                }
                Console.WriteLine(max - min);
            }
        }
    }
}