using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите основания a и b и угол a");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int angle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Площадь: " + (a * b) / Math.Sin(angle));

        }
    }
}
