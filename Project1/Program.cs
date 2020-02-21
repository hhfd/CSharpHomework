using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer number");
            var s = Console.ReadLine();
            int a = int.Parse(s);
            Console.WriteLine("Please input another integer number");
            var t = Console.ReadLine();
            int b = int.Parse(t);
            Console.WriteLine("Please input an operator");
            var u = Console.ReadLine();
            int c = 0;
            if (u == "+")
                c = a + b;
            if (u == "-")
                c = a - b;
            if (u == "*")
                c = a * b;
            if (u == "/")
                c = a / b;
            Console.WriteLine("{0}", c);
        }
    }
}
