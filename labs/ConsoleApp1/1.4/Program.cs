using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 катета: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a, 2.0) + Math.Pow(b, 2.0));
            Console.WriteLine("Периметр: " + (a + b + c));

        }
    }
}
