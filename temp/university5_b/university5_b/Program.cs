using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fact_dll;

namespace university5_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Class1 obj = new Class1();
            int res = obj.Fact(n);
            Console.WriteLine("Fact = " + res);
            Console.ReadKey();
        }
    }
}
