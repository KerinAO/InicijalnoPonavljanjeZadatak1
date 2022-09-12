using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 100.00;
            double b = 3.00;
            double y = Math.Truncate(a/b);
            double x = (a / b) - y;


            Console.WriteLine(a + " dijeljeno s " + b + " je " + y + " i ostatak " + x);

            Console.ReadKey();
        }
    }
}
