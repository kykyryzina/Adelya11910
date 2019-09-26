using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите объём куба: ");
            Console.WriteLine("Ребро: " + Math.Pow(Convert.ToInt32(Console.ReadLine()), 1.0 / 3.0));
        }
    }
}
