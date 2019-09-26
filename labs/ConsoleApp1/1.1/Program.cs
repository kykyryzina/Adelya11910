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
            Console.WriteLine("Введите периметр: ");
            int p = Convert.ToInt32(Console.ReadLine());
            p /= 3;
            double S = p * p * Math.Sqrt(3) / 4;
            Console.WriteLine("Площадь: " + (S));
        }
    }
    

}
