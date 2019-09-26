using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number % 10 == 7 ? "Оканчивается на цифру 7 " : "Не оканчивается на цифру 7 ");

        }
    }
}
