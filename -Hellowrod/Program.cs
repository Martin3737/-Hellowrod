using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulačka1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(num1));
            Console.ReadKey();
        }
    }
}
