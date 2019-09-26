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
            Console.WriteLine("Введите первый член, разность, число членов прогрессии: ");
            int first = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int last = first = (n - 1) * d;
            Console.WriteLine("Сумма членов арифметической прогрессии: " + ((first + last) * n) / 2);

        }
    }
}
