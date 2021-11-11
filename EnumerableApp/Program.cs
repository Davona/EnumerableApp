using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 25, 26, 85, 96, 12, 1, 5, 8 };
            int value = numbers._FirstOrDefault(x => x > 26);
            Console.WriteLine(value);
            int lastvalue = numbers._LastOrDefault(x => x < 7);
            Console.WriteLine(lastvalue);
            bool anyvalue = numbers._Any(x => x > 97);
            Console.WriteLine(anyvalue);
            int count = numbers._Count(x => x < 100);
            Console.WriteLine(count);
            bool allcount = numbers._All(x => x < 100);
            Console.WriteLine(allcount);
            int sum = numbers._Sum(x => x);
            Console.WriteLine(sum);
            int min = numbers._Min(x => x);
            Console.WriteLine(min);
            int max = numbers._Max(x => x);
            Console.WriteLine(max);
            double average = numbers._Average(x => x);
            Console.WriteLine(average);
        }
    }
}
