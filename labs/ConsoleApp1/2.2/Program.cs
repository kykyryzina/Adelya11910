using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Введите делимое и делитель: ");
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            double result = a / b;
            Console.WriteLine(result % 1 == 0 ? "Результат: " + result : a + " на " + b + "нацело не делится");
        }
    }
}
