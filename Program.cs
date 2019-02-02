git modification 1(second try)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.WriteLine("enter even number");
                    var n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        break;
                    }
                    Console.WriteLine("thenumber is not even");
                }
                catch
                {
                    Console.WriteLine("invalid number");
                }
            }
            while (true);
        }
    }
}
