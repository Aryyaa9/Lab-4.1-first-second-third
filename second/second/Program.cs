using System;
using System.IO;
using System.Linq;
namespace ConsoleApplication1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string path = "../../../numsTask2.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string str = reader.ReadToEnd();
                string[] strs = str.Split(';');

                double[] nums = Array.ConvertAll(strs, double.Parse);

                double sum = 0;
                
                int i = 0;
                while (nums[i] != 0)
                {
                    if (nums[i] > 0)
                        sum += nums[i];
                    i++;
                }
                Console.WriteLine(sum);
            }
        }
    }
}