using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Введите число: ");
            bool a = (Convert.ToInt32(Console.ReadLine()) % 2) == 0;
            Console.WriteLine(a ? "Четное" : "Нечетное");

        }
    }
}
