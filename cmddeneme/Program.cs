using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmddeneme
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("a");
            ConsoleKeyInfo a = Console.ReadKey();
            if (a.Key != ConsoleKey.A) while (true) Console.Write("b");

        }
    }
}
