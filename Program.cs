using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();
            //for (int i = 1; i <= 10; i++)
            //{
            //    int x = random.Next(-40, 40);
            //    Console.WriteLine(x);
            //}
            int count = 0;
            Random random = new Random();
            for (int i = 1; i <= 15; i++)
            {
                Double x = -20 + 50 * random.NextDouble();
                Console.WriteLine(x);
                if (x > 0)
                {
                    { count++; }
                }
            }
            Console.Read();
        }
    }
}
